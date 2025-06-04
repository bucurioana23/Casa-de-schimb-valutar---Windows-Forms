using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form4 : Form
    {
        CursValutar _cursValutar = new CursValutar();
        Form1 _form1;
        private bool _isDoubleClick = false;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            _cursValutar = form1.cursValutar;
            _form1 = form1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Valuta v in _cursValutar.Valute)
            {
                ListViewItem lvi = new ListViewItem(v.Cod);
                lvi.SubItems.Add(v.CursInRON.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                _isDoubleClick = true;
                ListViewItem selectedItem = listView1.SelectedItems[0];

                string cod = selectedItem.SubItems[0].Text;

                foreach (Valuta v in _cursValutar.Valute)
                {
                    if (v.Cod == cod)
                    {
                        MessageBox.Show(v.ToString(),v.Cod,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }

        private async void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isDoubleClick)
            {
                _isDoubleClick = false;
                return;
            }

            await Task.Delay(SystemInformation.DoubleClickTime);

            if (_isDoubleClick == false)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];

                    string cod = selectedItem.SubItems[0].Text;
                    DialogResult result = MessageBox.Show($"Sunteti sigur ca doriti modificarea cursului valutar pentru valuta {cod}?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {

                        try
                        {
                            using (SqlConnection conn = new SqlConnection(_form1.connectionString))
                            {
                                conn.Open();

                                using (SqlCommand cmd = new SqlCommand("UPDATE Valute SET CursInRON = CursInRON + 0.01 WHERE Cod = @cod", conn))
                                {
                                    cmd.Parameters.AddWithValue("@cod", cod);
                                    cmd.ExecuteNonQuery();
                                }

                                MessageBox.Show($"Cursul in Ron pentru valuta {cod} a fost modificat!");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Eroare");
                        }
                    }
                }
            }
        }
    }
}
