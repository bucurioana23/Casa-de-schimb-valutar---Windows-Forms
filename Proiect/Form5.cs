using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect
{
    public partial class Form5 : Form
    {
        Form1 _form1;
        public Form5(Form1 form1,int i)
        {
            InitializeComponent();
            _form1 = form1;
            if(i == 0)
            {
                afisareGraficValuteBars();
            } else
            {
                afisareGraficValutePie();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void afisareGraficValuteBars()
        {
            if (_form1.cursValutar.Valute.Count != 0)
            {
                chart2.Series["Valute"].Points.Clear();
                chart2.Titles.Clear();
                chart2.Visible = true;
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                for (int i = 0; i < _form1.cursValutar.Valute.Count; i++)
                {
                    chart2.Series["Valute"].Points.AddXY(_form1.cursValutar.Valute[i].Cod, _form1.cursValutar.Valute[i].CursInRON);
                }
                chart2.Titles.Add("Curs valutar");
            }
            else
            {
                MessageBox.Show("Nu exitsa date in cursul valutar curent!");
            }
        }

        private void salvare_bmp(Control c, string nume_fisier)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y, c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(nume_fisier);
            img.Dispose();
        }

        private void chart2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Doresti sa salvezi graficul?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                salvare_bmp(chart2, "Grafic_" + DateTime.Now.ToString("dd-MM-yyyy") + ".bmp");
                MessageBox.Show("S-a salvat graficul!");
            }
        }


        private void afisareGraficValutePie()
        {
            if (_form1.cursValutar.Valute.Count != 0)
            {
                chart2.Series["Valute"].Points.Clear();
                chart2.Titles.Clear();
                chart2.Visible = true;
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                for (int i = 0; i < _form1.cursValutar.Valute.Count; i++)
                {
                    chart2.Series["Valute"].Points.AddXY(_form1.cursValutar.Valute[i].Cod, _form1.cursValutar.Valute[i].CursInRON);
                }
                chart2.Titles.Add("Curs valutar");
            }
            else
            {
                MessageBox.Show("Nu exitsa date in cursul valutar curent!");
            }
        }

        
        
    }
}
