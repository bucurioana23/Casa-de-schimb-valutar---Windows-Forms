using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Tranzactie : ICloneable, IComparable<Tranzactie>, IAdaptareFisier
    {
        
        private int id;
        public int Id { get => id; set => id = value; }

        
        public Valuta Valuta { get; set; }
        public double Suma { get; set; }
        public DateTime Data { get; set; }


        public Tranzactie() 
        {
            id = 0;
            Valuta = new Valuta();
            Suma = 0D;
            Data = DateTime.Now;
        }
        

        public Tranzactie(int id, Valuta valuta, double suma, DateTime data)
        {
            this.id = id;
            if (suma <= 0)
            {
                throw new ArgumentException("Suma introdusa nu e valida!");
            }
            else
            {
                Suma = suma;
            }
            Data = data;
            
        }

        public double ValoareInRON => Suma * Valuta.CursInRON;

        public object Clone()
        {
            Tranzactie clone = (Tranzactie)this.MemberwiseClone();
            clone.Valuta = (Valuta)this.Valuta.Clone();
            return clone;
        }

        public int CompareTo(Tranzactie other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return "Id: " + Id + " - Valuta: " + Valuta.ToString() + " - Suma: " + Suma + " - Data: " + Data;
        }

        public string formaAfisare()
        {
            StringBuilder sb = new StringBuilder(this.Id.ToString());
            sb.Append(",").Append(Valuta.formaAfisare()).Append(",").Append(Suma).Append(",").Append(Data.ToString());
            return sb.ToString();
        }

        public static Tranzactie operator+(Tranzactie t1, Tranzactie t2)
        {
            t1.Suma += t2.Suma;
            return t1;
        }

        public static Tranzactie operator-(Tranzactie t1, Tranzactie t2)
        {
            t1.Suma -= t2.Suma; return t1;
        }
    }
}
