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
		private string tipo;

		//COSTRUTTORE
		public SacchettoFruttaAPezzi(string marca, string tipoFrutta, int quantitaFrutta, string tipo, string name, string description, float prezzo, int iva) : base(name, description, prezzo, iva)
		{
			this.marca = marca;
			this.tipoFrutta = tipoFrutta;
			this.quantitaFrutta = quantitaFrutta;
			this.tipo = tipo;
		}

		//GETTERS


		//SETTERS


		//METODI


	}
}
