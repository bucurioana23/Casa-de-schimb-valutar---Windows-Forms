namespace Proiect
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Suma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AdaugaTranzactie2 = new System.Windows.Forms.Button();
            this.comboBox_Valute = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_ActualizeazaTranzactie2 = new System.Windows.Forms.Button();
            this.tb_IdTranzactie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valuta";
            // 
            // txt_Suma
            // 
            this.txt_Suma.Location = new System.Drawing.Point(178, 306);
            this.txt_Suma.Name = "txt_Suma";
            this.txt_Suma.Size = new System.Drawing.Size(283, 29);
            this.txt_Suma.TabIndex = 2;
            this.txt_Suma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Suma_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // btn_AdaugaTranzactie2
            // 
            this.btn_AdaugaTranzactie2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_AdaugaTranzactie2.Location = new System.Drawing.Point(217, 495);
            this.btn_AdaugaTranzactie2.Name = "btn_AdaugaTranzactie2";
            this.btn_AdaugaTranzactie2.Size = new System.Drawing.Size(202, 62);
            this.btn_AdaugaTranzactie2.TabIndex = 6;
            this.btn_AdaugaTranzactie2.Text = "Adauga tranzactie";
            this.btn_AdaugaTranzactie2.UseVisualStyleBackColor = false;
            this.btn_AdaugaTranzactie2.Click += new System.EventHandler(this.btn_AdaugaTranzactie2_Click);
            // 
            // comboBox_Valute
            // 
            this.comboBox_Valute.FormattingEnabled = true;
            this.comboBox_Valute.Location = new System.Drawing.Point(178, 207);
            this.comboBox_Valute.Name = "comboBox_Valute";
            this.comboBox_Valute.Size = new System.Drawing.Size(283, 32);
            this.comboBox_Valute.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 397);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(283, 29);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btn_ActualizeazaTranzactie2
            // 
            this.btn_ActualizeazaTranzactie2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ActualizeazaTranzactie2.Location = new System.Drawing.Point(217, 495);
            this.btn_ActualizeazaTranzactie2.Name = "btn_ActualizeazaTranzactie2";
            this.btn_ActualizeazaTranzactie2.Size = new System.Drawing.Size(202, 62);
            this.btn_ActualizeazaTranzactie2.TabIndex = 9;
            this.btn_ActualizeazaTranzactie2.Text = "Actualizeaza tranzactie";
            this.btn_ActualizeazaTranzactie2.UseVisualStyleBackColor = false;
            this.btn_ActualizeazaTranzactie2.Click += new System.EventHandler(this.btn_ActualizeazaTranzactie2_Click);
            // 
            // tb_IdTranzactie
            // 
            this.tb_IdTranzactie.Location = new System.Drawing.Point(178, 117);
            this.tb_IdTranzactie.Name = "tb_IdTranzactie";
            this.tb_IdTranzactie.ReadOnly = true;
            this.tb_IdTranzactie.Size = new System.Drawing.Size(283, 29);
            this.tb_IdTranzactie.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(613, 704);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_IdTranzactie);
            this.Controls.Add(this.btn_ActualizeazaTranzactie2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_Valute);
            this.Controls.Add(this.btn_AdaugaTranzactie2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Suma);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Suma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AdaugaTranzactie2;
        private System.Windows.Forms.ComboBox comboBox_Valute;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_ActualizeazaTranzactie2;
        private System.Windows.Forms.TextBox tb_IdTranzactie;
        private System.Windows.Forms.Label label4;
    }
}