// See https://aka.ms/new-console-template for more information
using C_Shop2;

Console.WriteLine("Ciao, Utente!");

//DICHIARARE IL NEGOZIO

Negozio Emmelunga = new Negozio("EmmeLunga", "Torino", "Corso Umberto I", 45);

Acqua Lete = new Acqua("Lete", "Naturale", 1.5, 10, "Monte Nonso", "Lete Blu", "Acqua Naturale della Lete", 2.5f, 22);
SacchettoFruttaAPezzi SacchettoFragole = new SacchettoFruttaAPezzi("Fruttolo", "Fragole", 250, "Fragole 250g", "Fragole della Fruttolo in sacchetto", 3.5f, 10);

Lete.Bevi(1);
//Lete.Svuota();
Lete.Riempi(0.7);

SacchettoFragole.Mangia(100);