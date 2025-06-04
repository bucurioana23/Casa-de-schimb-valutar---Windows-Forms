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
    public partial class Form2 : Form
    {
        private readonly Form1 _form1;
        private Tranzactie tranzactie;
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\" +
                "MSSQLLocalDB;Initial Catalog=Facultate1054;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form2(Form1 form1)
        {
            
            InitializeComponent();
            this._form1 = form1;
            comboBox_Valute.DataSource = _form1.cursValutar.Valute;
            comboBox_Valute.DisplayMember = "Denumire";
            comboBox_Valute.ValueMember = "Cod";

            btn_ActualizeazaTranzactie2.Hide();
            
            label4.Hide();
            tb_IdTranzactie.Hide();
        }



        public Form2(Form1 form1, Tranzactie tranzactie)
        {
            InitializeComponent();
            _form1 = form1;
            this.tranzactie = tranzactie;
            comboBox_Valute.DataSource = _form1.cursValutar.Valute;
            comboBox_Valute.DisplayMember = "Denumire";
            comboBox_Valute.ValueMember = "Cod";
            for (int i = 0; i < comboBox_Valute.Items.Count; i++)
            {
                Valuta v = (Valuta)comboBox_Valute.Items[i];
                if(v.Cod.Equals(tranzactie.Valuta.Cod))
                {
                    comboBox_Valute.SelectedValue = v.Cod;
                }
            }

            tb_IdTranzactie.Text = tranzactie.Id.ToString();
            txt_Suma.Text = tranzactie.Suma.ToString();
            dateTimePicker1.Value = tranzactie.Data;
            btn_AdaugaTranzactie2.Hide();
        }

        private void btn_AdaugaTranzactie2_Click(object sender, EventArgs e)
        {
            if (comboBox_Valute.SelectedItem == null || string.IsNullOrEmpty(txt_Suma.Text))
            {
                MessageBox.Show("Selectați o valută și introduceți suma!");
                return;
            }

         


            try
            {
                
                string cod = ((Valuta)comboBox_Valute.SelectedItem).Cod;
                decimal suma;
                if (!decimal.TryParse(txt_Suma.Text, out suma))
                {
                    throw new ArgumentException("Suma introdusa nu este valida!");
                }
                if(dateTimePicker1.Value > DateTime.Now)
                {
                    throw new ArgumentException("Data introdusa nu este valida!");
                }
                DateTime data = dateTimePicker1.Value;
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tranzactii(ValutaCod,Suma,Data) VALUES (@valutaCod, @suma, @data)", conn);
                //cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@valutaCod", cod);
                cmd.Parameters.AddWithValue("@suma", suma);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Tranzactia a fost adaugata!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           
        }

        private void txt_Suma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar == (char)46)
            {
                e.Handled = false;
            } else
            {
                e.Handled= true;
            }
        }

        private void btn_ActualizeazaTranzactie2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tranzactii SET ValutaCod = @valutaCod, Suma = @suma, Data = @data WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@valutaCod", comboBox_Valute.SelectedValue);
            cmd.Parameters.AddWithValue("@suma", decimal.Parse(txt_Suma.Text));
            cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@id", tranzactie.Id);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
