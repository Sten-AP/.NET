Rekening rekening1 = new Rekening();
rekening1.NaamKlant = "Sten";
rekening1.RekeningNummer = "1234567890";

Rekening rekening2 = new Rekening();
rekening2.NaamKlant = "Kyan";
rekening2.RekeningNummer = "0987654321";

//rekening 2 geeft 300 euro aan rekening 1
rekening1.StortGeld(rekening2.HaalGeldAf(1000));

rekening1.ToonInfo();
rekening2.ToonInfo();