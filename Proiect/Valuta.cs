using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Valuta : ICloneable, IComparable<Valuta>, IAdaptareFisier
    {
        public string Cod { get; set; }
        public string Denumire { get; set; }
        public double CursInRON { get; set; }

        public Valuta()
        {
            Cod = string.Empty;
            Denumire = string.Empty;
            CursInRON = 0D;
        }

        public Valuta(string cod, string denumire, double cursInRON)
        {
            if (cod.Length != 3) {
                throw new ArgumentException("Codul introdus nu e valid! Va rugam introduceti un cod din 3 litere!");
            }
            Cod = cod;
            Denumire = denumire;
            if (cursInRON <= 0)
            {
                throw new ArgumentException("Curs in RON invalid!");
            }
            CursInRON = cursInRON;
        }

        public object Clone()
        {
            Valuta copy = new Valuta(Cod, Denumire, CursInRON);
            return copy;
        }

        public int CompareTo(Valuta v)
        {
            return this.CursInRON.CompareTo(v.CursInRON);
        }

        public override string ToString()
        {
            return "Cod: " + Cod + " - Denumire: " + Denumire + " - Curs in RON: " + CursInRON;
        }

        public override bool Equals(object obj)
        {
            return obj is Valuta valuta &&
                   Cod == valuta.Cod &&
                   Denumire == valuta.Denumire &&
                   CursInRON == valuta.CursInRON;
        }

        public string formaAfisare()
        {
            StringBuilder sb = new StringBuilder(this.Cod);
            sb.Append(",").Append(this.Denumire).Append(",").Append(this.CursInRON);
            return sb.ToString();
        }



        public static Valuta operator++(Valuta v)
        {
            v.CursInRON += 0.01D;
            return v;
        }

        public static bool operator<(Valuta v1, Valuta v2)
        {
            return (v1.CursInRON <  v2.CursInRON);
        }

        public static bool operator>(Valuta v1, Valuta v2)
        {
            return (v1.CursInRON > v2.CursInRON);
        }
    }
}
