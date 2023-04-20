using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Shop2
{
	public class Acqua : Prodotto
	{
		//ATTRIBUTI
		private string marca;
		private double litriBottiglia;
		private double MaxLitri = 1.5f;
		private int ph;
		private string sorgente;
		private string tipo;

		//COSTRUTTORE
		public Acqua(string marca, string tipo, double litriBottiglia, int ph,string sorgente, string name, string description, float prezzo, int iva) : base (name, description, prezzo, iva)
		{
			this.marca = marca;
			this.tipo = tipo;
			this.litriBottiglia = litriBottiglia;
			this.ph = ph;
			this.sorgente = sorgente;
		}

		//GETTERS
		public string GetMarca()
		{
			return this.marca;
		}

		public double GetLitri()
		{
			return this.litriBottiglia;
		}

		public string GetTipo()
		{
			return this.tipo;
		}

		public int GetPh()
		{
			return this.ph;
		}

		public string GetSorgente()
		{
			return this.sorgente;
		}

		//SETTERS


		//METODI

		public void Bevi(double litriDaBere)
		{
			Console.WriteLine("Sto Bevendo: " + litriBottiglia + " litri");
		}

		public void Riempi(double litri)
		{
			if(litriBottiglia + litri <= MaxLitri)
			{
				this.litriBottiglia += litri;
			}
			else
			{
				Console.WriteLine("Mi spiace hai raggiunto la capienza massima");
				this.litriBottiglia = MaxLitri;
			}
		}

		public void Svuota()
		{
			this.litriBottiglia = 0f;
		}
	}
}
