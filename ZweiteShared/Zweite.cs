using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZweiteShared {
	public class Klijent {
		public int ID;
		public string Ime;
		public string Prezime;
		public string InterniBroj;

		public Klijent() {
		}

		public Klijent(int ID, string Ime, string Prezime, string InterniBroj) {
			this.ID = ID;
			this.Ime = Ime;
			this.Prezime = Prezime;
			this.InterniBroj = InterniBroj;
		}
	}
}
