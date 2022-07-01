Određeni dio koda je objašnjen već kroz komentare, ali ovdje ćemo dodatno razjasniti.

U main funkciji se unose potrebni podaci za obradu, i poziva se funkcija searchSuggestions(x,x)

Unutar te funkcije prvo se kreira pomoćna lista za spremanje podataka.
Zatik se vrši preliminarni .sort unesene "baze podataka riječi" kako bi se kasnije izbjeglo 
Neprestano sortiranje dobivene liste.
Unutar for petlje se vrši trunkacija 'trazene rijeci' na dužinu iteratora petlje, kao simulacija sekvencijalnog unosa slova.
Taj dobiveni subString se provjera direktno s svim riječima 'baze podataka' koristeći built-in funkciju C# startsWith, koja provjerava
da li neki stringa počinje s datum subString-om. Dobiveni rezultati se trunkiraju na nacionalno 3 riječi i dodaju na listu s .toLidt.

Svaka se tako lista od do 3 riječi dodjeljuje iznad spomenutoj pomoćnoj listi, koja se nakon završavanje for petlje vraća kao rezultat.

Onda se Main funkciji vrši ispis.
