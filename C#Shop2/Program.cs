// See https://aka.ms/new-console-template for more information
using C_Shop2;

Console.WriteLine("Ciao, Utente!");

//DICHIARARE IL NEGOZIO

Negozio Emmelunga = new Negozio("EmmeLunga", "Torino", "Corso Umberto I", 45);

Acqua LeteBlu = new Acqua("Lete", "Naturale", 1.5, 10, "Monte Nonso", "Lete Blu", "Acqua Naturale della Lete", 2.5f, 22);
Emmelunga.aggiungiProdotto(LeteBlu);
SacchettoFruttaAPezzi SacchettoFragole = new SacchettoFruttaAPezzi("Fruttolo", "Fragole", 250, "Fragole 250g", "Fragole della Fruttolo in sacchetto", 3.5f, 10);
Emmelunga.aggiungiProdotto(SacchettoFragole);
CiboInScatola Simmental300 = new CiboInScatola("Manzo italiano", "Simmental", 300, "Simmental300", "Carne in Scatola Simmental da 300g", 15f, 22);
Emmelunga.aggiungiProdotto(Simmental300);


LeteBlu.Bevi(1);
LeteBlu.Svuota();
LeteBlu.Riempi(0.7);

SacchettoFragole.Mangia(100);
Simmental300.Mangia(298);