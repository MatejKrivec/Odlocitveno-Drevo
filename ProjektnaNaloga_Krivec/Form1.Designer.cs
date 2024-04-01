namespace ProjektnaNaloga_Krivec
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Drevo = new System.Windows.Forms.TreeView();
            this.DodajButton = new System.Windows.Forms.Button();
            this.textBoxDodaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAlternativa = new System.Windows.Forms.TextBox();
            this.DodajAlternativo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OdstraniButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVerjetnostVeje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVeja = new System.Windows.Forms.TextBox();
            this.DodajVejo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVrednostAlternative = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxVrednostVeje = new System.Windows.Forms.TextBox();
            this.Izračunaj = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.UvoziButton = new System.Windows.Forms.Button();
            this.IzvoziButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Drevo
            // 
            this.Drevo.Location = new System.Drawing.Point(613, 12);
            this.Drevo.Name = "Drevo";
            this.Drevo.Size = new System.Drawing.Size(620, 603);
            this.Drevo.TabIndex = 0;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(24, 59);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(75, 23);
            this.DodajButton.TabIndex = 1;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // textBoxDodaj
            // 
            this.textBoxDodaj.Location = new System.Drawing.Point(12, 30);
            this.textBoxDodaj.Name = "textBoxDodaj";
            this.textBoxDodaj.Size = new System.Drawing.Size(100, 23);
            this.textBoxDodaj.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dodajanje korena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dodajanje alternativ";
            // 
            // textBoxAlternativa
            // 
            this.textBoxAlternativa.Location = new System.Drawing.Point(12, 140);
            this.textBoxAlternativa.Name = "textBoxAlternativa";
            this.textBoxAlternativa.Size = new System.Drawing.Size(100, 23);
            this.textBoxAlternativa.TabIndex = 5;
            // 
            // DodajAlternativo
            // 
            this.DodajAlternativo.Location = new System.Drawing.Point(12, 169);
            this.DodajAlternativo.Name = "DodajAlternativo";
            this.DodajAlternativo.Size = new System.Drawing.Size(75, 23);
            this.DodajAlternativo.TabIndex = 4;
            this.DodajAlternativo.Text = "Dodaj";
            this.DodajAlternativo.UseVisualStyleBackColor = true;
            this.DodajAlternativo.Click += new System.EventHandler(this.DodajAlternativo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Odstrai vejo";
            // 
            // OdstraniButton
            // 
            this.OdstraniButton.Location = new System.Drawing.Point(148, 30);
            this.OdstraniButton.Name = "OdstraniButton";
            this.OdstraniButton.Size = new System.Drawing.Size(75, 23);
            this.OdstraniButton.TabIndex = 8;
            this.OdstraniButton.Text = "Odstrani";
            this.OdstraniButton.UseVisualStyleBackColor = true;
            this.OdstraniButton.Click += new System.EventHandler(this.OdstraniButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ime alternative";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Verjetnost veje";
            // 
            // textBoxVerjetnostVeje
            // 
            this.textBoxVerjetnostVeje.Location = new System.Drawing.Point(148, 267);
            this.textBoxVerjetnostVeje.Name = "textBoxVerjetnostVeje";
            this.textBoxVerjetnostVeje.Size = new System.Drawing.Size(51, 23);
            this.textBoxVerjetnostVeje.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ime veje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dodajanje vej";
            // 
            // textBoxVeja
            // 
            this.textBoxVeja.Location = new System.Drawing.Point(12, 267);
            this.textBoxVeja.Name = "textBoxVeja";
            this.textBoxVeja.Size = new System.Drawing.Size(100, 23);
            this.textBoxVeja.TabIndex = 13;
            // 
            // DodajVejo
            // 
            this.DodajVejo.Location = new System.Drawing.Point(12, 296);
            this.DodajVejo.Name = "DodajVejo";
            this.DodajVejo.Size = new System.Drawing.Size(75, 23);
            this.DodajVejo.TabIndex = 12;
            this.DodajVejo.Text = "Dodaj";
            this.DodajVejo.UseVisualStyleBackColor = true;
            this.DodajVejo.Click += new System.EventHandler(this.DodajVejo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vrednost alternative";
            // 
            // textBoxVrednostAlternative
            // 
            this.textBoxVrednostAlternative.Location = new System.Drawing.Point(163, 140);
            this.textBoxVrednostAlternative.Name = "textBoxVrednostAlternative";
            this.textBoxVrednostAlternative.Size = new System.Drawing.Size(51, 23);
            this.textBoxVrednostAlternative.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Vrednost veje";
            // 
            // textBoxVrednostVeje
            // 
            this.textBoxVrednostVeje.Location = new System.Drawing.Point(246, 267);
            this.textBoxVrednostVeje.Name = "textBoxVrednostVeje";
            this.textBoxVrednostVeje.Size = new System.Drawing.Size(51, 23);
            this.textBoxVrednostVeje.TabIndex = 20;
            // 
            // Izračunaj
            // 
            this.Izračunaj.Location = new System.Drawing.Point(422, 19);
            this.Izračunaj.Name = "Izračunaj";
            this.Izračunaj.Size = new System.Drawing.Size(143, 34);
            this.Izračunaj.TabIndex = 22;
            this.Izračunaj.Text = "Analiziraj";
            this.Izračunaj.UseVisualStyleBackColor = true;
            this.Izračunaj.Click += new System.EventHandler(this.Izračunaj_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(613, 631);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "...";
            // 
            // UvoziButton
            // 
            this.UvoziButton.Location = new System.Drawing.Point(1079, 621);
            this.UvoziButton.Name = "UvoziButton";
            this.UvoziButton.Size = new System.Drawing.Size(75, 23);
            this.UvoziButton.TabIndex = 24;
            this.UvoziButton.Text = "Uvozi";
            this.UvoziButton.UseVisualStyleBackColor = true;
            this.UvoziButton.Click += new System.EventHandler(this.UvoziButton_Click);
            // 
            // IzvoziButton
            // 
            this.IzvoziButton.Location = new System.Drawing.Point(1158, 621);
            this.IzvoziButton.Name = "IzvoziButton";
            this.IzvoziButton.Size = new System.Drawing.Size(75, 23);
            this.IzvoziButton.TabIndex = 25;
            this.IzvoziButton.Text = "Izvozi";
            this.IzvoziButton.UseVisualStyleBackColor = true;
            this.IzvoziButton.Click += new System.EventHandler(this.IzvoziButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 703);
            this.Controls.Add(this.IzvoziButton);
            this.Controls.Add(this.UvoziButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Izračunaj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxVrednostVeje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxVrednostAlternative);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxVerjetnostVeje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxVeja);
            this.Controls.Add(this.DodajVejo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OdstraniButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAlternativa);
            this.Controls.Add(this.DodajAlternativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDodaj);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.Drevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView Drevo;
        private Button DodajButton;
        private TextBox textBoxDodaj;
        private Label label1;
        private Label label2;
        private TextBox textBoxAlternativa;
        private Button DodajAlternativo;
        private Label label3;
        private Button OdstraniButton;
        private Label label4;
        private Label label6;
        private TextBox textBoxVerjetnostVeje;
        private Label label7;
        private Label label8;
        private TextBox textBoxVeja;
        private Button DodajVejo;
        private Label label5;
        private TextBox textBoxVrednostAlternative;
        private Label label9;
        private TextBox textBoxVrednostVeje;
        private Button Izračunaj;
        private Label label10;
        private Button UvoziButton;
        private Button IzvoziButton;
    }
}