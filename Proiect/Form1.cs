using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                 Initial Catalog=Facultate1054;
                                 Integrated Security=True;
                                 Connect Timeout=30;
                                 Encrypt=False;
                                 TrustServerCertificate=False;
                                 ApplicationIntent=ReadWrite;
                                 MultiSubnetFailover=False";

        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\" +
                 "MSSQLLocalDB;Initial Catalog=Facultate1054;Integrated Security=True;" +
                 "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                 "ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public CursValutar cursValutar = new CursValutar();
        public List<Tranzactie> listaTranzactii = new List<Tranzactie>();
        

        public Form1()
        {
            InitializeComponent();
            printPreviewDialog1.Document = printDocument1;
            
        }

        

        private void btn_AdaugaValuta_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this);
            form.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncarcaValuteDinBazaDeDate();
            listView_Valute.Items.Clear();
            foreach(Valuta v in cursValutar.Valute)
            {
                ListViewItem lvi = new ListViewItem(v.Cod.ToString());
                lvi.SubItems.Add(v.Denumire.ToString());
                lvi.SubItems.Add(v.CursInRON.ToString());
                listView_Valute.Items.Add(lvi);
            }
        }

        private void btn_AdaugaTranzactie_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            IncarcaTranzactiiDinBazaDeDate();
        }

        private void btn_AfiseazaTranzactii_Click(object sender, EventArgs e)
        {
            IncarcaTranzactiiDinBazaDeDate();
            listView_Tranzactii.Items.Clear();
            foreach(Tranzactie t in listaTranzactii)
            {
                ListViewItem lvi = new ListViewItem(t.Id.ToString());
                lvi.SubItems.Add(t.Valuta.Cod);
                lvi.SubItems.Add(t.Suma.ToString());
                lvi.SubItems.Add(t.ValoareInRON.ToString());
                lvi.SubItems.Add(t.Data.ToString());
                listView_Tranzactii.Items.Add(lvi);
            }
            textBox1.Clear();
            double suma = 0;
            foreach (Tranzactie t in listaTranzactii)
            {
                suma += t.ValoareInRON;
            }
            textBox1.Text = suma.ToString();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach(Valuta v in cursValutar.Valute)
                {
                    sw.WriteLine(v.formaAfisare());
                }
                sw.Close();
                MessageBox.Show("Fisierul a fost salvat!","Confirmare salvare TXT",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cursValutar.Valute = new List<Valuta>();
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    Valuta v = new Valuta();
                    string[] tokens = linie.Split(',');
                    v.Cod = tokens[0];
                    v.Denumire = tokens[1];
                    v.CursInRON = double.Parse(tokens[2]);
                    cursValutar.AdaugaValuta(v);
                }
                sr.Close();
                MessageBox.Show("Valutele au fost restaurate!", "Confirmare restaurare TXT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Tranzactie t in listaTranzactii)
                {
                    sw.WriteLine(t.formaAfisare());
                }
                sw.Close();
                MessageBox.Show("Fisierul a fost salvat!", "Confirmare salvare TXT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listaCursValutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.ShowDialog();
        }
        //---------------------------------------------------------------------------

        private void afisareGraficValuteBarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this, 0);
            form5.ShowDialog();
        }

        private void afisareGraficValutePieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this,1);
            form5.ShowDialog();
        }

        //------------------------------------------------------------------------------------

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += PrintDocument_PrintPage;

            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float marginLeft = e.MarginBounds.Left;
            float marginTop = e.MarginBounds.Top;

            openFileDialog1.Filter = "(*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string textDeImprimat = "Data: " + DateTime.Now.ToString("dd.MM.yyyy") + "\n\n";
                textDeImprimat += File.ReadAllText(openFileDialog1.FileName); 

                e.Graphics.DrawString(textDeImprimat, font, brush, marginLeft, marginTop);

                e.HasMorePages = false; 
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        //----------------------------------------------------------------------------------
        private void btn_ActualizeazaValuta_Click(object sender, EventArgs e)
        {
            if (listView_Valute.SelectedItems.Count > 0) {
                ListViewItem lvi = listView_Valute.SelectedItems[0];
                string cod = lvi.SubItems[0].Text;
                string denumire = lvi.SubItems[1].Text;
                double curs = double.Parse(lvi.SubItems[2].Text);
                Valuta valuta  = new Valuta(cod, denumire,curs);
                Form3 form = new Form3(this, valuta);
                form.ShowDialog();
                listView_Valute.SelectedItems.Clear();
                IncarcaValuteDinBazaDeDate();
            } else
            {
                MessageBox.Show("ATENTIE! Prea multe elemente selectate!");
            }
        }

        private void IncarcaValuteDinBazaDeDate()
        {
            cursValutar.Valute = new List<Valuta>();
            string query = "SELECT Cod, Denumire, cursInRON FROM Valute";
            
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                  
                    using (SqlCommand command = new SqlCommand(query, connect))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cursValutar.Valute.Add(new Valuta
                            {
                                Cod = reader["cod"].ToString(),
                                Denumire = reader["denumire"].ToString(),
                                CursInRON = double.Parse(reader["cursInRON"].ToString())
                            });
                            
                        }
                        cursValutar.Valute.Sort();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea valutelor: {ex.Message}");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IncarcaValuteDinBazaDeDate();
            IncarcaTranzactiiDinBazaDeDate();
        }

        
        private void btn_StergeValuta_Click(object sender, EventArgs e)
        {
            if (listView_Valute.CheckedItems.Count != 1)
            {
                MessageBox.Show("Selectați o valută pentru ștergere.", "Atenție",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {
                
                if (MessageBox.Show("Sigur doriți să ștergeți valutele selectate?", "Confirmare",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        foreach (ListViewItem item in listView_Valute.CheckedItems)
                        {
                            string cod = item.SubItems[0].Text;

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM Valute WHERE Cod = @cod", conn))
                            {
                                cmd.Parameters.AddWithValue("@cod", cod);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                   
                    IncarcaValuteDinBazaDeDate();
                    MessageBox.Show("Ștergere completă!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la ștergere: {ex.Message}", "Eroare",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------------------------------------------
        private Tranzactie GasesteTranzactieDupaId(int idCautat)
        {
            
            if (idCautat < 1 || idCautat > listaTranzactii.Count)
            {
                return null; 
            }

            return listaTranzactii[idCautat - 1];
        }

        private Tranzactie GasesteTranzactieSelectata()
        {
            if (listView_Tranzactii.SelectedItems.Count > 0)
            {
                int selectedIndex = listView_Tranzactii.SelectedIndices[0];
                int idCautat = selectedIndex + 1;
                return GasesteTranzactieDupaId(idCautat);
            }
            return null;
        }

        private void IncarcaTranzactiiDinBazaDeDate()
        {
            listaTranzactii = new List<Tranzactie>();
            string query = "SELECT id, ValutaCod, suma, data FROM Tranzactii";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(query, conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            string codValuta = reader["ValutaCod"].ToString();
                            Valuta valuta = cursValutar.Valute.FirstOrDefault(v => v.Cod.Equals(codValuta, StringComparison.OrdinalIgnoreCase));

                           
                            Tranzactie tranzactie = new Tranzactie
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Valuta = valuta,
                                Suma = Convert.ToDouble(reader["suma"]),
                                Data = Convert.ToDateTime(reader["data"])
                            };

                            listaTranzactii.Add(tranzactie);
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea tranzacțiilor: {ex.Message}");
            }

            
        }

        private void btn_ActualizeazaTranzactie_Click(object sender, EventArgs e)
        {
            if (listView_Tranzactii.SelectedItems.Count > 0) 
            {
                ListViewItem lvi = listView_Tranzactii.SelectedItems[0];
                Tranzactie t = GasesteTranzactieSelectata();
                if (t != null)
                {
                    Form2 form2 = new Form2(this,t);
                    form2.ShowDialog();
                    listView_Valute.SelectedItems.Clear();
                }
                IncarcaTranzactiiDinBazaDeDate();
            } else
            {
                MessageBox.Show("Niciun tranzactie nu a fost selectata!");
            }
        }

        private void btn_StergeTranzactie_Click(object sender, EventArgs e)
        {
            if (listView_Tranzactii.CheckedItems.Count != 1)
            {
                MessageBox.Show("Selectați o tranzactie pentru ștergere.", "Atenție",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {
                if (MessageBox.Show("Sigur doriți să ștergeți tranzactiile selectate?", "Confirmare",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (ListViewItem item in listView_Tranzactii.CheckedItems)
                    {
                        string id = item.SubItems[0].Text;

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Tranzactii WHERE Id = @id", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }


                IncarcaTranzactiiDinBazaDeDate();
                MessageBox.Show("Ștergere completă!", "Succes",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la ștergere: {ex.Message}", "Eroare",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void yENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.ShowDialog();
        }
    }
}
