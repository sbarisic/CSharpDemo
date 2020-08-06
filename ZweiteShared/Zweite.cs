using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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

	public class CustomConfig {
		static CustomConfig CfgInstance;

		public static CustomConfig GetInstance() {
			if (CfgInstance != null)
				return CfgInstance;

			CfgInstance = new CustomConfig();
			FieldInfo[] Fields = CfgInstance.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance).Where(F => F.FieldType == typeof(string)).ToArray();

			foreach (FieldInfo F in Fields)
				F.SetValue(CfgInstance, ConfigurationManager.AppSettings[F.Name]);

			return CfgInstance;
		}

		public string ConnectionString;
	}
}
