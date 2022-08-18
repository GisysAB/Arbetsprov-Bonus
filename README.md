# Arbetsprov-Bonus

## Introduktion
Detta är ett arbetsprov som Gisys använder vid rekrytering av ny personal. När du slutfört uppgiften så kan du skicka länken till dit GitHub repo alternativt zippa ihop lösningen och skicka den till rekrytering@gisys.se, vi återkopplar så snart som möjligt för att bekräfta att vi mottagit din lösning. Vi försöker rätta provet under nästakommande arbetsdagar. 
Vid en eventuell efterföljande intervju kommer vi att gå igenom din lösning. 
Arbetsprovet ska vara inskickat till oss på Gisys inom en vecka från utskicksdatum, provet beräknas dock inte ta längre tid än en dag att genomföra.

En grund till arbetsprovet finns i detta repository. 

## Förutsättningar
- .NET 6.0
- Nodejs, version över 16 (Behöver kunna köra Angular 13)

## Uppgift
Du ska bygga en	liten webbapplikation för att beräkna bonus för ett litet konsultbolag. Bonusen baseras på bolagets nettoresultat och beräknas individuellt per konsult baserat på hur stor del av den totala debiteringen som konsulten bidragit till. Dessutom belönas de som varit anställda en längre tid med en viss lojalitetsfaktor.	

Applikation ska bestå av tre vyer;
1. Konsulter
   - Vy för att lista, lägga till, ta bort och redigera konsulter.
2. Bonusberäkning
   - Vy med funkionalitet för att generera bonusunderlag.
3. Startsida med navigering till de två ovanstående vyerna.

## Vy 1: Konsulter
Denna sida ska innehålla funktionalitet för att lista, lägga till, redigera samt ta bort konsulter ur systemet. Konsultens namn samt anställningsdatum skall sparas.

## Vy 2: Bonusberäkning
Denna sida ska innehålla funktionalitet för att producera ett bonusunderlag. För varje konsult som finns registrerad i systemet så ska användaren kunna ange antal debiterade timmar. Användaren behöver även kunna ange bolagets nettoresultat. Därefter ska bonus beräknas enligt formeln beskriven nedan. 

## Beräkning av bonus
Varje konsult får en lojalitetsfaktor Lk, baserat på antal hela anställda år enligt tabellen nedan: 

| Antal år som anställd | Lojalitetsfaktor (Lk) |
| :---                  |         :---:         |
| Mindre än 1 år        | 1                     |
| 1 år                  | 1,1                   |
| 2 år                  | 1,2                   |
| 3 år                  | 1,3                   |
| 4 år                  | 1,4                   |
| 5 år och mer          | 1,5                   |

Varje konsult får också en debiteringspoäng Dk, som räknas ut genom Dk = Tk * Lk där Tk är antal debiterade timmar för konsulten, och Lk är lojalitetsfaktorn.

Låt summan av alla debiteringspoäng Dk vara Dt

5% av bolagets nettoresultat läggs i en bonuspott.

Konsultens andel av bonuspotten Bk = Dk / Dt

### Exempelberäkning med 2 konsulter
| | |
| --------------------------------------- | -------------------------------------- |
| Bolaget har 100 000 SEK i nettoresultat | Bonuspott = 100 000 * 0,05 = 5 000 SEK |
| Konsult 1 har varit anställd i 3 år     | Lk1 = 1,3                              |
| Han har debiterat 150 timmar            | Dk1 = Lk1 * 150 = 195                  |
| Konsult 2 har varit anställd i 1 år     | Lk2 = 1,1                              |
| Hon har debiterat 160 timmar            | Dk2 = Lk2 * 160 = 176                  |
| Summan av alla debiteringspoäng         | Dt = Dk1 + Dk2 = 371                   |
| Konsult 1 andel av bonuspotten          | Bk1 = Dk1 / Dt = 195 / 371 ≈ 52,6%     |
| Konsult 2 andel av bonuspotten          | Bk2 = Dk2 / Dt = 176 / 371 ≈ 47,4%     |
| Konsult 1 får i bonus                   | 5000 * (195 / 371) ≈ 2 628 SEK         |
| Konsult 2 får i bonus                   | 5000 * (176 / 371) ≈ 2 372 SEK         |

## Övriga krav på systemet
- Alla tidsstämplar ska visas enligt ÅÅÅÅ-MM-DD
- Kommentarer ska vara skrivna i interfaces i backend