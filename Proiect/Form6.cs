using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form6 : Form
    {
        Form1 _form1;
        public Form6(Form1 form1)
        {
            InitializeComponent();
            this._form1 = form1;
            comboBox1.DataSource = _form1.cursValutar.Valute;
            comboBox1.DisplayMember = "Denumire";
            comboBox1.ValueMember = "Cod";
            textBox1.DataBindings.Add(new Binding("Text",comboBox1,""));
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double suma= 0;
            foreach(Tranzactie t in _form1.listaTranzactii)
            {
                if (t.Valuta.Equals(comboBox1.SelectedItem))
                {
                    suma += t.Suma;
                }
            }
            textBox1.Clear();
            textBox1.Text = suma.ToString();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            int currentIndex = comboBox1.SelectedIndex;
            if (((Button)sender).Text == "<")
            {
                if (currentIndex > 0)
                    comboBox1.SelectedIndex--;
            }
            else
            {
                if (currentIndex < comboBox1.Items.Count - 1)
                    comboBox1.SelectedIndex++;
            }
        }
    }
}
