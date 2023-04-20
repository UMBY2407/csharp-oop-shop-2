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
		private int litri;
		private string tipo;

		//COSTRUTTORE
		public Acqua(string marca, string tipo, int litri, string name, string description, float prezzo, int iva) : base (name, description, prezzo, iva)
		{
			this.marca = marca;
			this.tipo = tipo;
			this.litri = litri;
		}

		//GETTERS


		//SETTERS


		//METODI


	}
}
