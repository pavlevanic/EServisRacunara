# 🖥️ E-Servis Računara

Desktop aplikacija za upravljanje servisom računara i laptopova, razvijena u **C# WinForms** sa **SQL Server** bazom podataka.

---

##  Funkcionalnosti

- **Prijem uređaja** — unos podataka o klijentu i uređaju u jednoj formi
- **Pretraga klijenta** po broju telefona — automatsko popunjavanje podataka
- **Praćenje statusa** poravke — primljeno → u toku → završeno → preuzeto
- **Promena statusa** direktno u tabeli sa unosom cene i napomene
- **Pregled klijenta** — svi uređaji, detalji i promena statusa u jednom prozoru
- **Pretraga** uređaja i klijenata u realnom vremenu
- **Statistika** na početnoj stranici — broj uređaja po statusu

---

##  Tehnologije

| Tehnologija | Verzija |
|-------------|---------|
| C# / .NET Framework | 4.7.2 |
| Windows Forms | - |
| SQL Server | Express |
| Visual Studio | 2022 |

---

##  Baza podataka

Aplikacija koristi tri tabele:
- **klijenti** — podaci o vlasnicima uređaja
- **uredjaji** — uređaji na servisu sa statusom i cenom
- **istorija_statusa** — log svih promena statusa

SQL skripta za kreiranje baze nalazi se u fajlu `eservis_database.sql`.

---

##  Pokretanje

1. Kloniraj repozitorijum
```bash
git clone https://github.com/pavlevanic/EServisRacunara.git
```

2. Kreiraj bazu podataka pokretanjem `eservis_database.sql` u SQL Server Management Studio

3. Kreiraj fajl `App.config` na osnovu `App.config.template` i upiši svoje podatke:
```csharp
public static string ConnStr =
    @"Server=localhost\SQLEXPRESS;Database=eservis;Integrated Security=True;";
```

4. Pokreni projekat u Visual Studio

---

##  Struktura projekta

```
EServisRacunara/
├── Form1.cs                  # Glavna forma (navigacija, tabele)
├── FormPrijem.cs             # Prijem i izmena uređaja
├── FormPregledKlijenta.cs    # Pregled uređaja po klijentu
├── BazaPodataka.cs           # Svi upiti prema SQL Serveru
├── App.config                # Primer konfiguracije (bez lozinke)
└── eservis_database.sql      # SQL skripta za kreiranje baze
```

---

## ⚠️ Napomena

Fajl `App.config` sa connection stringom **nije uključen** u repozitorijum iz bezbednosnih razloga. Kreiraj ga lokalno prema uputstvu iznad.