namespace Proiect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AdaugaTranzactie = new System.Windows.Forms.Button();
            this.btn_AfiseazaTranzactii = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AdaugaValuta = new System.Windows.Forms.Button();
            this.listView_Valute = new System.Windows.Forms.ListView();
            this.Cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CursInRON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_AfiseazaValute = new System.Windows.Forms.Button();
            this.listView_Tranzactii = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valuta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumaInValuta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumaInRON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valutetxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiitxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCursValutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficValuteBarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficValutePieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_ActualizeazaValuta = new System.Windows.Forms.Button();
            this.btn_StergeValuta = new System.Windows.Forms.Button();
            this.btn_ActualizeazaTranzactie = new System.Windows.Forms.Button();
            this.btn_StergeTranzactie = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(329, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANZACTII";
            // 
            // btn_AdaugaTranzactie
            // 
            this.btn_AdaugaTranzactie.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_AdaugaTranzactie.Location = new System.Drawing.Point(40, 123);
            this.btn_AdaugaTranzactie.Name = "btn_AdaugaTranzactie";
            this.btn_AdaugaTranzactie.Size = new System.Drawing.Size(174, 66);
            this.btn_AdaugaTranzactie.TabIndex = 1;
            this.btn_AdaugaTranzactie.Text = "Adauga tranzactie";
            this.btn_AdaugaTranzactie.UseVisualStyleBackColor = false;
            this.btn_AdaugaTranzactie.Click += new System.EventHandler(this.btn_AdaugaTranzactie_Click);
            // 
            // btn_AfiseazaTranzactii
            // 
            this.btn_AfiseazaTranzactii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_AfiseazaTranzactii.Location = new System.Drawing.Point(560, 123);
            this.btn_AfiseazaTranzactii.Name = "btn_AfiseazaTranzactii";
            this.btn_AfiseazaTranzactii.Size = new System.Drawing.Size(173, 66);
            this.btn_AfiseazaTranzactii.TabIndex = 2;
            this.btn_AfiseazaTranzactii.Text = "Afiseaza tranzactii";
            this.btn_AfiseazaTranzactii.UseVisualStyleBackColor = false;
            this.btn_AfiseazaTranzactii.Click += new System.EventHandler(this.btn_AfiseazaTranzactii_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(1229, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALUTE";
            // 
            // btn_AdaugaValuta
            // 
            this.btn_AdaugaValuta.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_AdaugaValuta.ForeColor = System.Drawing.Color.Black;
            this.btn_AdaugaValuta.Location = new System.Drawing.Point(983, 123);
            this.btn_AdaugaValuta.Name = "btn_AdaugaValuta";
            this.btn_AdaugaValuta.Size = new System.Drawing.Size(163, 66);
            this.btn_AdaugaValuta.TabIndex = 4;
            this.btn_AdaugaValuta.Text = "Adauga valuta";
            this.btn_AdaugaValuta.UseVisualStyleBackColor = false;
            this.btn_AdaugaValuta.Click += new System.EventHandler(this.btn_AdaugaValuta_Click);
            // 
            // listView_Valute
            // 
            this.listView_Valute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView_Valute.CheckBoxes = true;
            this.listView_Valute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cod,
            this.Denumire,
            this.CursInRON});
            this.listView_Valute.GridLines = true;
            this.listView_Valute.HideSelection = false;
            this.listView_Valute.Location = new System.Drawing.Point(983, 381);
            this.listView_Valute.Name = "listView_Valute";
            this.listView_Valute.Size = new System.Drawing.Size(580, 382);
            this.listView_Valute.TabIndex = 5;
            this.listView_Valute.UseCompatibleStateImageBehavior = false;
            this.listView_Valute.View = System.Windows.Forms.View.Details;
            // 
            // Cod
            // 
            this.Cod.Text = "Cod";
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 100;
            // 
            // CursInRON
            // 
            this.CursInRON.Text = "Curs in RON";
            this.CursInRON.Width = 120;
            // 
            // btn_AfiseazaValute
            // 
            this.btn_AfiseazaValute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_AfiseazaValute.Location = new System.Drawing.Point(1400, 123);
            this.btn_AfiseazaValute.Name = "btn_AfiseazaValute";
            this.btn_AfiseazaValute.Size = new System.Drawing.Size(163, 66);
            this.btn_AfiseazaValute.TabIndex = 6;
            this.btn_AfiseazaValute.Text = "Afiseaza valute";
            this.btn_AfiseazaValute.UseVisualStyleBackColor = false;
            this.btn_AfiseazaValute.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_Tranzactii
            // 
            this.listView_Tranzactii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView_Tranzactii.CheckBoxes = true;
            this.listView_Tranzactii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Valuta,
            this.SumaInValuta,
            this.SumaInRON,
            this.Data});
            this.listView_Tranzactii.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Tranzactii.GridLines = true;
            this.listView_Tranzactii.HideSelection = false;
            this.listView_Tranzactii.Location = new System.Drawing.Point(40, 381);
            this.listView_Tranzactii.Name = "listView_Tranzactii";
            this.listView_Tranzactii.Size = new System.Drawing.Size(693, 382);
            this.listView_Tranzactii.TabIndex = 7;
            this.listView_Tranzactii.UseCompatibleStateImageBehavior = false;
            this.listView_Tranzactii.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Valuta
            // 
            this.Valuta.Text = "Valuta";
            this.Valuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Valuta.Width = 80;
            // 
            // SumaInValuta
            // 
            this.SumaInValuta.Text = "Suma in valuta";
            this.SumaInValuta.Width = 100;
            // 
            // SumaInRON
            // 
            this.SumaInRON.Text = "Suma in RON";
            this.SumaInRON.Width = 80;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2177, 38);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valutetxtToolStripMenuItem,
            this.tranzactiitxtToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // valutetxtToolStripMenuItem
            // 
            this.valutetxtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem});
            this.valutetxtToolStripMenuItem.Name = "valutetxtToolStripMenuItem";
            this.valutetxtToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.valutetxtToolStripMenuItem.Text = "Valute.txt";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(197, 40);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // tranzactiitxtToolStripMenuItem
            // 
            this.tranzactiitxtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem1});
            this.tranzactiitxtToolStripMenuItem.Name = "tranzactiitxtToolStripMenuItem";
            this.tranzactiitxtToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.tranzactiitxtToolStripMenuItem.Text = "Tranzactii.txt";
            // 
            // salvareToolStripMenuItem1
            // 
            this.salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            this.salvareToolStripMenuItem1.Size = new System.Drawing.Size(197, 40);
            this.salvareToolStripMenuItem1.Text = "Salvare";
            this.salvareToolStripMenuItem1.Click += new System.EventHandler(this.salvareToolStripMenuItem1_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCursValutarToolStripMenuItem,
            this.graficeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // listaCursValutarToolStripMenuItem
            // 
            this.listaCursValutarToolStripMenuItem.Name = "listaCursValutarToolStripMenuItem";
            this.listaCursValutarToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.listaCursValutarToolStripMenuItem.Text = "Lista Curs Valutar";
            this.listaCursValutarToolStripMenuItem.Click += new System.EventHandler(this.listaCursValutarToolStripMenuItem_Click);
            // 
            // graficeToolStripMenuItem
            // 
            this.graficeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareGraficValuteBarsToolStripMenuItem,
            this.afisareGraficValutePieToolStripMenuItem});
            this.graficeToolStripMenuItem.Name = "graficeToolStripMenuItem";
            this.graficeToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.graficeToolStripMenuItem.Text = "Grafice";
            // 
            // afisareGraficValuteBarsToolStripMenuItem
            // 
            this.afisareGraficValuteBarsToolStripMenuItem.Name = "afisareGraficValuteBarsToolStripMenuItem";
            this.afisareGraficValuteBarsToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.afisareGraficValuteBarsToolStripMenuItem.Text = "Afisare grafic valute bars";
            this.afisareGraficValuteBarsToolStripMenuItem.Click += new System.EventHandler(this.afisareGraficValuteBarsToolStripMenuItem_Click);
            // 
            // afisareGraficValutePieToolStripMenuItem
            // 
            this.afisareGraficValutePieToolStripMenuItem.Name = "afisareGraficValutePieToolStripMenuItem";
            this.afisareGraficValutePieToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.afisareGraficValutePieToolStripMenuItem.Text = "Afisare grafic valute pie";
            this.afisareGraficValutePieToolStripMenuItem.Click += new System.EventHandler(this.afisareGraficValutePieToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_ActualizeazaValuta
            // 
            this.btn_ActualizeazaValuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ActualizeazaValuta.Location = new System.Drawing.Point(983, 268);
            this.btn_ActualizeazaValuta.Name = "btn_ActualizeazaValuta";
            this.btn_ActualizeazaValuta.Size = new System.Drawing.Size(163, 68);
            this.btn_ActualizeazaValuta.TabIndex = 10;
            this.btn_ActualizeazaValuta.Text = "Actualizeaza valuta";
            this.btn_ActualizeazaValuta.UseVisualStyleBackColor = false;
            this.btn_ActualizeazaValuta.Click += new System.EventHandler(this.btn_ActualizeazaValuta_Click);
            // 
            // btn_StergeValuta
            // 
            this.btn_StergeValuta.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_StergeValuta.Location = new System.Drawing.Point(1400, 268);
            this.btn_StergeValuta.Name = "btn_StergeValuta";
            this.btn_StergeValuta.Size = new System.Drawing.Size(163, 68);
            this.btn_StergeValuta.TabIndex = 11;
            this.btn_StergeValuta.Text = "Sterge valuta";
            this.btn_StergeValuta.UseVisualStyleBackColor = false;
            this.btn_StergeValuta.Click += new System.EventHandler(this.btn_StergeValuta_Click);
            // 
            // btn_ActualizeazaTranzactie
            // 
            this.btn_ActualizeazaTranzactie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ActualizeazaTranzactie.Location = new System.Drawing.Point(40, 268);
            this.btn_ActualizeazaTranzactie.Name = "btn_ActualizeazaTranzactie";
            this.btn_ActualizeazaTranzactie.Size = new System.Drawing.Size(174, 68);
            this.btn_ActualizeazaTranzactie.TabIndex = 12;
            this.btn_ActualizeazaTranzactie.Text = "Actualizeaza tranzactie";
            this.btn_ActualizeazaTranzactie.UseVisualStyleBackColor = false;
            this.btn_ActualizeazaTranzactie.Click += new System.EventHandler(this.btn_ActualizeazaTranzactie_Click);
            // 
            // btn_StergeTranzactie
            // 
            this.btn_StergeTranzactie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_StergeTranzactie.Location = new System.Drawing.Point(560, 268);
            this.btn_StergeTranzactie.Name = "btn_StergeTranzactie";
            this.btn_StergeTranzactie.Size = new System.Drawing.Size(173, 68);
            this.btn_StergeTranzactie.TabIndex = 13;
            this.btn_StergeTranzactie.Text = "Sterge tranzactie";
            this.btn_StergeTranzactie.UseVisualStyleBackColor = false;
            this.btn_StergeTranzactie.Click += new System.EventHandler(this.btn_StergeTranzactie_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 29);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Valoare totala tranzactii in RON:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yENToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(271, 78);
            // 
            // yENToolStripMenuItem
            // 
            this.yENToolStripMenuItem.Name = "yENToolStripMenuItem";
            this.yENToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.yENToolStripMenuItem.Text = "Vezi valoare";
            this.yENToolStripMenuItem.Click += new System.EventHandler(this.yENToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2177, 930);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_StergeTranzactie);
            this.Controls.Add(this.btn_ActualizeazaTranzactie);
            this.Controls.Add(this.btn_StergeValuta);
            this.Controls.Add(this.btn_ActualizeazaValuta);
            this.Controls.Add(this.listView_Tranzactii);
            this.Controls.Add(this.btn_AfiseazaValute);
            this.Controls.Add(this.listView_Valute);
            this.Controls.Add(this.btn_AdaugaValuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AfiseazaTranzactii);
            this.Controls.Add(this.btn_AdaugaTranzactie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AdaugaTranzactie;
        private System.Windows.Forms.Button btn_AfiseazaTranzactii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AdaugaValuta;
        private System.Windows.Forms.ListView listView_Valute;
        private System.Windows.Forms.ColumnHeader Cod;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader CursInRON;
        private System.Windows.Forms.Button btn_AfiseazaValute;
        private System.Windows.Forms.ListView listView_Tranzactii;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Valuta;
        private System.Windows.Forms.ColumnHeader SumaInValuta;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader SumaInRON;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valutetxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactiitxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCursValutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficValuteBarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficValutePieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.Button btn_ActualizeazaValuta;
        private System.Windows.Forms.Button btn_StergeValuta;
        private System.Windows.Forms.Button btn_ActualizeazaTranzactie;
        private System.Windows.Forms.Button btn_StergeTranzactie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yENToolStripMenuItem;
    }
}

