BibBoek boek1 = new BibBoek();
boek1.ontlener = "Sten";
boek1.uitgeleend = DateTime.Now.AddDays(2);
boek1.verlengTermijn(4);
boek1.gegevens();
