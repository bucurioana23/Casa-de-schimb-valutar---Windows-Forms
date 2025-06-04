namespace Proiect
{
    partial class Form3
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
            this.txt_Cod = new System.Windows.Forms.TextBox();
            this.txt_denumire = new System.Windows.Forms.TextBox();
            this.txt_CursInRon = new System.Windows.Forms.TextBox();
            this.btn_AdaugaValuta2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Denumire = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ActualizeazaValuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Cod
            // 
            this.txt_Cod.Location = new System.Drawing.Point(245, 111);
            this.txt_Cod.Name = "txt_Cod";
            this.txt_Cod.Size = new System.Drawing.Size(338, 29);
            this.txt_Cod.TabIndex = 0;
            this.txt_Cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_KeyPress);
            // 
            // txt_denumire
            // 
            this.txt_denumire.Location = new System.Drawing.Point(245, 237);
            this.txt_denumire.Name = "txt_denumire";
            this.txt_denumire.Size = new System.Drawing.Size(337, 29);
            this.txt_denumire.TabIndex = 1;
            // 
            // txt_CursInRon
            // 
            this.txt_CursInRon.Location = new System.Drawing.Point(245, 366);
            this.txt_CursInRon.Name = "txt_CursInRon";
            this.txt_CursInRon.Size = new System.Drawing.Size(337, 29);
            this.txt_CursInRon.TabIndex = 2;
            this.txt_CursInRon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CursInRon_KeyPress);
            // 
            // btn_AdaugaValuta2
            // 
            this.btn_AdaugaValuta2.BackColor = System.Drawing.Color.Purple;
            this.btn_AdaugaValuta2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AdaugaValuta2.Location = new System.Drawing.Point(307, 483);
            this.btn_AdaugaValuta2.Name = "btn_AdaugaValuta2";
            this.btn_AdaugaValuta2.Size = new System.Drawing.Size(209, 58);
            this.btn_AdaugaValuta2.TabIndex = 3;
            this.btn_AdaugaValuta2.Text = "Adauga valuta";
            this.btn_AdaugaValuta2.UseVisualStyleBackColor = false;
            this.btn_AdaugaValuta2.Click += new System.EventHandler(this.btn_AdaugaValuta2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cod";
            // 
            // Denumire
            // 
            this.Denumire.AutoSize = true;
            this.Denumire.Location = new System.Drawing.Point(75, 241);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(96, 25);
            this.Denumire.TabIndex = 5;
            this.Denumire.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Curs in RON";
            // 
            // btn_ActualizeazaValuta
            // 
            this.btn_ActualizeazaValuta.BackColor = System.Drawing.Color.Purple;
            this.btn_ActualizeazaValuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ActualizeazaValuta.Location = new System.Drawing.Point(283, 470);
            this.btn_ActualizeazaValuta.Name = "btn_ActualizeazaValuta";
            this.btn_ActualizeazaValuta.Size = new System.Drawing.Size(233, 71);
            this.btn_ActualizeazaValuta.TabIndex = 7;
            this.btn_ActualizeazaValuta.Text = "Actualizeaza valuta";
            this.btn_ActualizeazaValuta.UseVisualStyleBackColor = false;
            this.btn_ActualizeazaValuta.Click += new System.EventHandler(this.btn_ActualizeazaValuta_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(748, 607);
            this.Controls.Add(this.btn_ActualizeazaValuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AdaugaValuta2);
            this.Controls.Add(this.txt_CursInRon);
            this.Controls.Add(this.txt_denumire);
            this.Controls.Add(this.txt_Cod);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cod;
        private System.Windows.Forms.TextBox txt_denumire;
        private System.Windows.Forms.TextBox txt_CursInRon;
        private System.Windows.Forms.Button btn_AdaugaValuta2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Denumire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ActualizeazaValuta;
    }
}