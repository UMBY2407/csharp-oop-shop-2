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
		private List<Acqua> acque;

		//COSTRUTTORE
		public Acqua(string marca, string tipo, double litriBottiglia, int ph, string sorgente, string name, string description, float prezzo, int iva) : base (name, description, prezzo, iva)
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
		public void AddAcque(Acqua acque)
		{
			this.acque.Add(acque);
		}

		public void Bevi(double litriDaBere)
		{
			Console.WriteLine("Sto Bevendo: " + litriDaBere + " litri");
			this.litriBottiglia = litriBottiglia - litriDaBere;
			Console.WriteLine("Ora rimangono " + this.litriBottiglia + " litri");
		}

		public void Riempi(double litri)
		{
			if(litriBottiglia + litri <= MaxLitri)
			{
				this.litriBottiglia += litri;
				Console.WriteLine("Ho riempito: " + litri + " litri");
				Console.WriteLine("Adesso la bottiglia contiene: " + litriBottiglia + " litri");
			}
			else
			{
				Console.WriteLine("Mi spiace hai raggiunto la capienza massima");
				this.litriBottiglia = MaxLitri;
				Console.WriteLine("Adesso la bottiglia contiene: " + litriBottiglia + " litri");
			}
		}

		public void Svuota()
		{
			this.litriBottiglia = 0f;
			Console.WriteLine("Bottiglia svuotata");
		}
	}
}
