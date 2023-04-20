using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop2
{
	public class Prodotto
	{
		//ATTRIBUTI
		private int codice;
		private string name;
		private string description;
		private float price;
		private float priceWithIva;
		private int iva;

		//COSTRUTTORI
		public Prodotto(string nome, string descrizione, float prezzo, int iva)
		{
			this.name = nome;
			this.description = descrizione;
			this.price = prezzo;
			this.iva = iva;
		}


		//GETTER
		public string getNome()
		{
			return this.name;
		}

		public string getDescription()
		{
			return this.description;
		}

		public float getPrice()
		{
			return this.price;
		}

		public float getPriceWithIva()
		{
			return this.priceWithIva;
		}


		//SETTER
		public void setNome(string nome)
		{
			this.name = nome;
		}

		public void setDescription(string descrizione)
		{
			this.description = descrizione;
		}

		public void setPrezzo(float prezzo)
		{
			this.price = prezzo;
		}

		public void setIva(int iva)
		{

			this.iva = iva;
		}

		public void setPriceWithIva()
		{
			this.priceWithIva = price + (price / 100) * iva; ;
		}


		//METODI	
		private int creaCodice()
		{
			Random rdn = new Random();
			codice = rdn.Next();
			return this.codice;
		}

		public void stampaProdotto()
		{
			setPriceWithIva();
			Console.WriteLine("-------------- PRODOTTO -----------------");
			Console.WriteLine("Codice prodotto: " + creaCodice());
			Console.WriteLine("Nome prodotto: " + getNome());
			Console.WriteLine("Descrizione prodotto: " + getDescription());
			Console.WriteLine("Prezzo prodotto (iva esclusa): " + getPrice() + " EUR");
			Console.WriteLine("Prezzo prodotto (+ iva): " + getPriceWithIva() + " EUR");
			Console.WriteLine("-------------------------------------------");
		}

		public string GetProdottoStringa()
		{
			setPriceWithIva();
			string rapprStringa = "Codice prodotto: " + creaCodice() + ", ";
			rapprStringa += "Nome prodotto: " + this.name + ", ";
			rapprStringa += "Descrizione del prodotto: " + this.description + ", ";
			rapprStringa += "Prezzo prodotto (iva inclusa): " + this.priceWithIva + " EUR";

			return rapprStringa;
		}
	}
}
