using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public class CursValutar 
    {
        List<Valuta> valute;
        public List<Valuta> Valute {  get=> valute; set => valute = value; }
        public static string MonedaDeBaza { get; set; } = "RON";

        public CursValutar() {  Valute = new List<Valuta>();}

        public CursValutar(List<Valuta> valute)
        {
            Valute = new List<Valuta>();
            foreach (Valuta v in valute)
            {
                Valute.Add((Valuta)v.Clone());
            }
        }

        public void AdaugaValuta(Valuta v)
        {
            if(Valute.Contains(v))
            {
                throw new ArgumentException("Aceasta valuta exista deja!");
            }
          
            Valute.Add(v);
        }

        public void StergeValutaDupaCod(string cod)
        {
            for (int i = Valute.Count - 1; i >= 0; i--)
            {
                if (Valute[i].Cod == cod)
                    Valute.RemoveAt(i);
            }
        }

        public void SorteazaValute()
        {
            Valute.Sort();
        }

        public Valuta this[int index]
        {
            get
            {
                if (index >= 0 && index < Valute.Count)
                    return Valute[index];
                else
                    throw new IndexOutOfRangeException("Index invalid.");
            }
            set
            {
                if (index >= 0 && index < Valute.Count)
                    Valute[index] = value;
                else
                    throw new IndexOutOfRangeException("Index invalid.");
            }
        }

        public static CursValutar operator +(CursValutar a, CursValutar b)
        {
            var cursNou = new CursValutar(a.Valute);
            foreach (var valuta in b.Valute)
            {
                if (!cursNou.Valute.Any(v => v.Cod == valuta.Cod))
                    cursNou.Valute.Add(valuta);
            }
            return cursNou;
        }
    }
}
