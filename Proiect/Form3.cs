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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\" +
                "MSSQLLocalDB;Initial Catalog=Facultate1054;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private readonly Form1 _form1;
       
        public Form3(Form1 form1)
        {
            InitializeComponent();
            btn_ActualizeazaValuta.Hide();
            _form1 = form1;
        }

        public Form3(Form1 form1, Valuta v)
        {
            InitializeComponent();
            _form1 = form1;
            txt_Cod.Text = v.Cod;
            txt_denumire.Text = v.Denumire;
            txt_CursInRon.Text = v.CursInRON.ToString();
            txt_Cod.ReadOnly = true;
            btn_AdaugaValuta2.Hide();
        }

        private void btn_AdaugaValuta2_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = txt_Cod.Text;
                if(cod.Length != 3)
                {
                    throw new ArgumentException("Codul introdus nu e valid!!");
                }
                string denumire = txt_denumire.Text;
                if(denumire.Length < 3)
                {
                    throw new ArgumentException("Denumirea introdusa nu e valida!");
                }
                double cursInRon;
                if (!double.TryParse(txt_CursInRon.Text, out cursInRon))
                {
                    throw new ArgumentException("Cursul valutar nu e corect introdus!");
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Valute(Cod,Denumire,CursInRON) VALUES (@cod, @denumire, @cursInRon)", conn);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@denumire", denumire);
                cmd.Parameters.AddWithValue("@cursInRON", ((float)cursInRon).ToString());
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Valuta a fost adaugata!");
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally { 
                txt_Cod.Clear();
                txt_CursInRon.Clear();
                txt_denumire.Clear();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txt_CursInRon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar == (char)46 ) 
            { 
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

        private void btn_ActualizeazaValuta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_denumire.Text.Length < 3)
                {
                    throw new ArgumentException("Denumirea introdusa nu e valida!");
                }
                if (decimal.Parse(txt_CursInRon.Text) <= 0 || txt_CursInRon.Text == null)
                {
                    throw new ArgumentException("Cursul valutar nu e corect introdus!");
                }
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Valute SET Denumire = @denumire, CursInRON = @cursInRon WHERE Cod = @cod", conn);
                cmd.Parameters.AddWithValue("@cod", txt_Cod.Text);
                cmd.Parameters.AddWithValue("@denumire", txt_denumire.Text);
                cmd.Parameters.AddWithValue("@cursInRON", float.Parse(txt_CursInRon.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Valuta cu codul {txt_Cod.Text} a fost actualizata!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                conn.Close();
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txt_Cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= 'A' && e.KeyChar<= 'Z' || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }
    }
}
