using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop2
{
	public class CiboInScatola : Prodotto
	{
		//ATTRIBUTI
		private string tipoDiCibo;
		private string marca;
		private int quantitaCibo;

		//COSTRUTTORE
		public CiboInScatola(string tipoDiCibo, string marca, int quantitaCibo, string name, string description, float prezzo, int iva) : base(name, description, prezzo, iva)
		{
			this.marca = marca;
			this.tipoDiCibo = tipoDiCibo;
			this.marca = marca;
			this.quantitaCibo = quantitaCibo;
		}

		//GETTERS
		public string getTipoDiCibo()
		{
			return this.tipoDiCibo;
		}

		public string getMarca()
		{
			return this.marca;
		}

		public int getQuantitaCibo()
		{
			return this.quantitaCibo;
		}

		//SETTERS


		//METODI

		public void Mangia(int quantitaFruttaDaMangiare)
		{
			Console.WriteLine("Sto mangiando " + quantitaFruttaDaMangiare + " g di " + getTipoDiCibo());
			this.quantitaCibo = quantitaCibo - quantitaFruttaDaMangiare;
			Console.WriteLine("Adesso il sacchetto contiene: " + quantitaCibo + " g di " + getTipoDiCibo());
		}
	}
}
