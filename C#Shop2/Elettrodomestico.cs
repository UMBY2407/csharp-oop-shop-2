using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop2
{
	public class Elettrodomestico : Prodotto
	{
		//ATTRIBUTI
		private string tipo;
		private string marca;
		private string modello;
		private int anno;

		//COSTRUTTORE
		public Elettrodomestico(string tipo, string marca, string modello, int anno, string name, string description, float prezzo, int iva) : base(name, description, prezzo, iva)
		{ 
			this.tipo = tipo;
			this.marca = marca;
			this.modello = modello;
			this.anno = anno;
		}

		//GETTERS


		//SETTERS


		//METODI


	}
}
