using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EServisRacunara
{
    public class Klijent
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumUnosa { get; set; }

        public override string ToString() => $"{Ime} {Prezime} — {Telefon}";
    }

    public class Uredjaj
    {
        public int Id { get; set; }
        public int KlijentId { get; set; }
        public string KlijentIme { get; set; }
        public string Telefon { get; set; }
        public string TipUredjaja { get; set; }
        public string Model { get; set; }
        public string OpisKvara { get; set; }
        public DateTime DatumPrijema { get; set; }
        public string Status { get; set; }
        public decimal CenaPopravke { get; set; }
        public string Napomena { get; set; }
        public DateTime DatumIzmene { get; set; }
    }
    internal class BazaPodataka
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["EServisRacunara"].ConnectionString;

        private static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // ==============================================
        //  KLIJENTI
        // ==============================================

        public static List<Klijent> GetSviKlijenti()
        {
            var lista = new List<Klijent>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT id, ime, prezime, telefon, adresa, datum_unosa " +
                "FROM klijenti ORDER BY prezime, ime;", conn))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    lista.Add(MapKlijent(rdr));
            }
            return lista;
        }

        public static List<Klijent> PretragaKlijenata(string tekst)
        {
            var lista = new List<Klijent>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT id, ime, prezime, telefon, adresa, datum_unosa " +
                "FROM klijenti " +
                "WHERE (ime + ' ' + prezime) LIKE @t OR telefon LIKE @t OR adresa LIKE @t " +
                "ORDER BY prezime, ime;", conn))
            {
                cmd.Parameters.AddWithValue("@t", $"%{tekst}%");
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                        lista.Add(MapKlijent(rdr));
                }
            }
            return lista;
        }

        public static int DodajKlijenta(Klijent k)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "INSERT INTO klijenti (ime, prezime, telefon, adresa) " +
                "OUTPUT INSERTED.id " +
                "VALUES (@ime, @prezime, @telefon, @adresa);", conn))
            {
                cmd.Parameters.AddWithValue("@ime", k.Ime);
                cmd.Parameters.AddWithValue("@prezime", k.Prezime);
                cmd.Parameters.AddWithValue("@telefon", k.Telefon);
                cmd.Parameters.AddWithValue("@adresa", k.Adresa);
                return (int)cmd.ExecuteScalar();
            }
        }

        public static Uredjaj GetAktivnaPopravkaKlijenta(int klijentId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
        SELECT TOP 1
               u.id                        AS uredjaj_id,
               u.klijent_id,
               k.ime + ' ' + k.prezime     AS klijent_ime,
               k.telefon,
               k.adresa                    AS adresa,
               u.tip_uredjaja,
               u.model,
               u.opis_kvara,
               u.datum_prijema,
               u.status,
               u.cena_popravke,
               u.napomena,
               u.datum_izmene
        FROM uredjaji u
        INNER JOIN klijenti k ON k.id = u.klijent_id
        WHERE u.klijent_id = @kid
          AND u.status <> 'preuzeto'
        ORDER BY u.datum_prijema DESC;", conn))
            {
                cmd.Parameters.AddWithValue("@kid", klijentId);
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                        return MapUredjaj(rdr);
                    return null; 
                }
            }
        }

        public static void AzurirajKlijenta(Klijent k)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "UPDATE klijenti SET ime=@ime, prezime=@prezime, " +
                "telefon=@telefon, adresa=@adresa WHERE id=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@ime", k.Ime);
                cmd.Parameters.AddWithValue("@prezime", k.Prezime);
                cmd.Parameters.AddWithValue("@telefon", k.Telefon);
                cmd.Parameters.AddWithValue("@adresa", k.Adresa);
                cmd.Parameters.AddWithValue("@id", k.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ObrisiKlijenta(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "DELETE FROM klijenti WHERE id=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ==============================================
        //  UREĐAJI
        // ==============================================

        public static List<Uredjaj> GetSviUredjaji()
        {
            var lista = new List<Uredjaj>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                SELECT u.id                        AS uredjaj_id,
                       u.klijent_id,
                       k.ime + ' ' + k.prezime     AS klijent_ime,
                       k.telefon,
                       u.tip_uredjaja,
                       u.model,
                       u.opis_kvara,
                       u.datum_prijema,
                       u.status,
                       u.cena_popravke,
                       u.napomena,
                       u.datum_izmene
                FROM uredjaji u
                INNER JOIN klijenti k ON k.id = u.klijent_id
                ORDER BY u.datum_prijema DESC;", conn))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    lista.Add(MapUredjaj(rdr));
            }
            return lista;
        }

        public static List<Uredjaj> GetNepreuzetiUredjaji()
        {
            var lista = new List<Uredjaj>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                SELECT u.id                        AS uredjaj_id,
                       u.klijent_id,
                       k.ime + ' ' + k.prezime     AS klijent_ime,
                       k.telefon,
                       u.tip_uredjaja,
                       u.model,
                       u.opis_kvara,
                       u.datum_prijema,
                       u.status,
                       u.cena_popravke,
                       u.napomena,
                       u.datum_izmene
                FROM uredjaji u
                INNER JOIN klijenti k ON k.id = u.klijent_id
                WHERE u.status <> 'preuzeto'
                ORDER BY u.datum_prijema ASC;", conn))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    lista.Add(MapUredjaj(rdr));
            }
            return lista;
        }

        public static List<Uredjaj> GetUredjajiKlijenta(int klijentId)
        {
            var lista = new List<Uredjaj>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                SELECT u.id                        AS uredjaj_id,
                       u.klijent_id,
                       k.ime + ' ' + k.prezime     AS klijent_ime,
                       k.telefon,
                       u.tip_uredjaja,
                       u.model,
                       u.opis_kvara,
                       u.datum_prijema,
                       u.status,
                       u.cena_popravke,
                       u.napomena,
                       u.datum_izmene
                FROM uredjaji u
                INNER JOIN klijenti k ON k.id = u.klijent_id
                WHERE u.klijent_id = @kid
                ORDER BY u.datum_prijema DESC;", conn))
            {
                cmd.Parameters.AddWithValue("@kid", klijentId);
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                        lista.Add(MapUredjaj(rdr));
                }
            }
            return lista;
        }

        public static int DodajUredjaj(Uredjaj u)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                INSERT INTO uredjaji 
                    (klijent_id, tip_uredjaja, model, opis_kvara, datum_prijema, napomena)
                OUTPUT INSERTED.id
                VALUES (@kid, @tip, @model, @opis, @datum, @napomena);", conn))
            {
                cmd.Parameters.AddWithValue("@kid", u.KlijentId);
                cmd.Parameters.AddWithValue("@tip", u.TipUredjaja);
                cmd.Parameters.AddWithValue("@model", u.Model);
                cmd.Parameters.AddWithValue("@opis", u.OpisKvara);
                cmd.Parameters.AddWithValue("@datum", u.DatumPrijema.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@napomena", u.Napomena ?? "");
                return (int)cmd.ExecuteScalar();
            }
        }

        public static void ObrisiUredjaj(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM uredjaji WHERE id=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void AzurirajUredjaj(Uredjaj u)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                UPDATE uredjaji SET
                    klijent_id    = @kid,
                    tip_uredjaja  = @tip,
                    model         = @model,
                    opis_kvara    = @opis,
                    datum_prijema = @datum,
                    cena_popravke = @cena,
                    napomena      = @napomena
                WHERE id = @id;", conn))
            {
                cmd.Parameters.AddWithValue("@kid", u.KlijentId);
                cmd.Parameters.AddWithValue("@tip", u.TipUredjaja);
                cmd.Parameters.AddWithValue("@model", u.Model);
                cmd.Parameters.AddWithValue("@opis", u.OpisKvara);
                cmd.Parameters.AddWithValue("@datum", u.DatumPrijema.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@cena", u.CenaPopravke);
                cmd.Parameters.AddWithValue("@napomena", u.Napomena ?? "");
                cmd.Parameters.AddWithValue("@id", u.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Uredjaj> PretraziUredjaje(string tekst, string sortKolona = "datum_prijema", string sortSmer = "DESC")
        {
            var dozvoljeneKolone = new[] { "datum_prijema", "model", "status", "klijent_ime" };
            if (!dozvoljeneKolone.Contains(sortKolona))
                sortKolona = "datum_prijema";

            var lista = new List<Uredjaj>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand($@"
        SELECT u.id AS uredjaj_id, u.klijent_id,
               k.ime + ' ' + k.prezime AS klijent_ime,
               k.telefon, u.tip_uredjaja, u.model,
               u.opis_kvara, u.datum_prijema, u.status,
               u.cena_popravke, u.napomena, u.datum_izmene
        FROM uredjaji u
        INNER JOIN klijenti k ON k.id = u.klijent_id
        WHERE u.model        LIKE @t
           OR k.ime + ' ' + k.prezime LIKE @t
           OR u.status       LIKE @t
           OR u.tip_uredjaja LIKE @t
        ORDER BY {sortKolona} {sortSmer};", conn))
            {
                cmd.Parameters.AddWithValue("@t", $"%{tekst}%");
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        lista.Add(MapUredjaj(rdr));
            }
            return lista;
        }

        public static void PromeniStatus(int uredjajId, string noviStatus, string napomena = "")
        {
            using (var conn = GetConnection())
            {
                string stariStatus = "";
                using (var cmdGet = new SqlCommand(
                    "SELECT status FROM uredjaji WHERE id=@id;", conn))
                {
                    cmdGet.Parameters.AddWithValue("@id", uredjajId);
                    stariStatus = cmdGet.ExecuteScalar()?.ToString() ?? "";
                }
                using (var cmdUpd = new SqlCommand(
                    "UPDATE uredjaji SET status=@status WHERE id=@id;", conn))
                {
                    cmdUpd.Parameters.AddWithValue("@status", noviStatus);
                    cmdUpd.Parameters.AddWithValue("@id", uredjajId);
                    cmdUpd.ExecuteNonQuery();
                }

                using (var cmdLog = new SqlCommand(@"
                    INSERT INTO istorija_statusa (uredjaj_id, stari_status, novi_status, napomena)
                    VALUES (@uid, @stari, @novi, @nap);", conn))
                {
                    cmdLog.Parameters.AddWithValue("@uid", uredjajId);
                    cmdLog.Parameters.AddWithValue("@stari", stariStatus);
                    cmdLog.Parameters.AddWithValue("@novi", noviStatus);
                    cmdLog.Parameters.AddWithValue("@nap", napomena);
                    cmdLog.ExecuteNonQuery();
                }
            }
        }

        public static void ZakljuciServis(int uredjajId, decimal cena, string napomena = "")
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new SqlCommand(@"
                    UPDATE uredjaji SET cena_popravke=@cena, status='zavrseno'
                    WHERE id=@id;", conn))
                {
                    cmd.Parameters.AddWithValue("@cena", cena);
                    cmd.Parameters.AddWithValue("@id", uredjajId);
                    cmd.ExecuteNonQuery();
                }

                using (var cmdLog = new SqlCommand(@"
                    INSERT INTO istorija_statusa (uredjaj_id, stari_status, novi_status, napomena)
                    VALUES (@uid, 'u toku', 'zavrseno', @nap);", conn))
                {
                    cmdLog.Parameters.AddWithValue("@uid", uredjajId);
                    cmdLog.Parameters.AddWithValue("@nap", napomena);
                    cmdLog.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetIstorijuStatusa(int uredjajId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                SELECT 
                    datum_izmene  AS [Datum],
                    stari_status  AS [Stari status],
                    novi_status   AS [Novi status],
                    napomena      AS [Napomena]
                FROM istorija_statusa
                WHERE uredjaj_id = @uid
                ORDER BY datum_izmene;", conn))
            {
                cmd.Parameters.AddWithValue("@uid", uredjajId);
                var dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }

        // ==============================================
        //  STATISTIKA
        // ==============================================

        public static DataTable GetStatistika()
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                SELECT 
                    status              AS [Status],
                    COUNT(*)            AS [Broj uređaja],
                    SUM(cena_popravke)  AS [Ukupna cena (RSD)]
                FROM uredjaji
                GROUP BY status;", conn))
            {
                var dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }

        private static Klijent MapKlijent(SqlDataReader r)
        {
            return new Klijent
            {
                Id = r.GetInt32(r.GetOrdinal("id")),
                Ime = r.GetString(r.GetOrdinal("ime")),
                Prezime = r.GetString(r.GetOrdinal("prezime")),
                Telefon = r.GetString(r.GetOrdinal("telefon")),
                Adresa = r.GetString(r.GetOrdinal("adresa")),
                DatumUnosa = r.GetDateTime(r.GetOrdinal("datum_unosa"))
            };
        }

        private static Uredjaj MapUredjaj(SqlDataReader r)
        {
            return new Uredjaj
            {
                Id = r.GetInt32(r.GetOrdinal("uredjaj_id")),
                KlijentId = r.GetInt32(r.GetOrdinal("klijent_id")),
                KlijentIme = r.IsDBNull(r.GetOrdinal("klijent_ime")) ? "" : r.GetString(r.GetOrdinal("klijent_ime")),
                Telefon = r.IsDBNull(r.GetOrdinal("telefon")) ? "" : r.GetString(r.GetOrdinal("telefon")),
                TipUredjaja = r.GetString(r.GetOrdinal("tip_uredjaja")),
                Model = r.GetString(r.GetOrdinal("model")),
                OpisKvara = r.GetString(r.GetOrdinal("opis_kvara")),
                DatumPrijema = r.GetDateTime(r.GetOrdinal("datum_prijema")),
                Status = r.GetString(r.GetOrdinal("status")),
                CenaPopravke = r.IsDBNull(r.GetOrdinal("cena_popravke")) ? 0 : r.GetDecimal(r.GetOrdinal("cena_popravke")),
                Napomena = r.IsDBNull(r.GetOrdinal("napomena")) ? "" : r.GetString(r.GetOrdinal("napomena")),
                DatumIzmene = r.GetDateTime(r.GetOrdinal("datum_izmene"))
            };
        }
    }
}
