using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop2
{
	public class SacchettoFruttaAPezzi : Prodotto
	{
		//ATTRIBUTI
		private string marca;
		private string tipoFrutta;
		private int quantitaFrutta;

		//COSTRUTTORE
		public SacchettoFruttaAPezzi(string marca, string tipoFrutta, int quantitaFrutta, string name, string description, float prezzo, int iva) : base(name, description, prezzo, iva)
		{
			this.marca = marca;
			this.tipoFrutta = tipoFrutta;
			this.quantitaFrutta = quantitaFrutta;
		}

		//GETTERS
		public string GetMarca()
		{
			return this.marca;
		}

		public string GetTipoFrutta()
		{
			return this.tipoFrutta;
		}

		public int GetQuantitaFrutta()
		{
			return this.quantitaFrutta;
		}


		//SETTERS


		//METODI

		public void Mangia(int quantitaFruttaDaMangiare)
		{
			Console.WriteLine("Sto mangiando " + quantitaFruttaDaMangiare + " g di frutta");
			this.quantitaFrutta = quantitaFrutta - quantitaFruttaDaMangiare;
			Console.WriteLine("Adesso il sacchetto contiene: " + quantitaFrutta + " g di frutta");
		}
	}
}
