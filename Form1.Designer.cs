﻿namespace PoddApp
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
            this.buttonLaggTill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLaggTillKategori = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.labelAngeURL = new System.Windows.Forms.Label();
            this.listViewPoddar = new System.Windows.Forms.ListView();
            this.labelRedigeraKategorier = new System.Windows.Forms.Label();
            this.listBoxRedigerakategorier = new System.Windows.Forms.ListBox();
            this.textBoxAndraKategori = new System.Windows.Forms.TextBox();
            this.buttonAndra = new System.Windows.Forms.Button();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.labelMinaKategorier = new System.Windows.Forms.Label();
            this.Avsnitt = new System.Windows.Forms.ListBox();
            this.labelAvsnitt = new System.Windows.Forms.Label();
            this.labelBeskrivning = new System.Windows.Forms.Label();
            this.textBoxBeskrivning = new System.Windows.Forms.TextBox();
            this.labelAndraKategori = new System.Windows.Forms.Label();
            this.labelLaggTillPodd = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.labelTilldelaKategori = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFiltreraKategori = new System.Windows.Forms.ComboBox();
            this.labelFiltreraKategori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLaggTill
            // 
            this.buttonLaggTill.Location = new System.Drawing.Point(79, 213);
            this.buttonLaggTill.Name = "buttonLaggTill";
            this.buttonLaggTill.Size = new System.Drawing.Size(75, 26);
            this.buttonLaggTill.TabIndex = 0;
            this.buttonLaggTill.Text = "Lägg till";
            this.buttonLaggTill.UseVisualStyleBackColor = true;
            this.buttonLaggTill.Click += new System.EventHandler(this.buttonLaggTill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "PODDAPP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLaggTillKategori
            // 
            this.buttonLaggTillKategori.Location = new System.Drawing.Point(786, 373);
            this.buttonLaggTillKategori.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLaggTillKategori.Name = "buttonLaggTillKategori";
            this.buttonLaggTillKategori.Size = new System.Drawing.Size(65, 24);
            this.buttonLaggTillKategori.TabIndex = 2;
            this.buttonLaggTillKategori.Text = "Lägg till";
            this.buttonLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(27, 98);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(191, 22);
            this.textBoxUrl.TabIndex = 3;
            // 
            // labelAngeURL
            // 
            this.labelAngeURL.AutoSize = true;
            this.labelAngeURL.Location = new System.Drawing.Point(23, 79);
            this.labelAngeURL.Name = "labelAngeURL";
            this.labelAngeURL.Size = new System.Drawing.Size(72, 16);
            this.labelAngeURL.TabIndex = 4;
            this.labelAngeURL.Text = "Ange URL:";
            this.labelAngeURL.Click += new System.EventHandler(this.label2_Click);
            // 
            // listViewPoddar
            // 
            this.listViewPoddar.HideSelection = false;
            this.listViewPoddar.Location = new System.Drawing.Point(27, 262);
            this.listViewPoddar.Name = "listViewPoddar";
            this.listViewPoddar.Size = new System.Drawing.Size(191, 270);
            this.listViewPoddar.TabIndex = 5;
            this.listViewPoddar.UseCompatibleStateImageBehavior = false;
            // 
            // labelRedigeraKategorier
            // 
            this.labelRedigeraKategorier.AutoSize = true;
            this.labelRedigeraKategorier.Location = new System.Drawing.Point(783, 299);
            this.labelRedigeraKategorier.Name = "labelRedigeraKategorier";
            this.labelRedigeraKategorier.Size = new System.Drawing.Size(196, 16);
            this.labelRedigeraKategorier.TabIndex = 6;
            this.labelRedigeraKategorier.Text = "Lägg till/ändra befintlig kategori:";
            // 
            // listBoxRedigerakategorier
            // 
            this.listBoxRedigerakategorier.FormattingEnabled = true;
            this.listBoxRedigerakategorier.ItemHeight = 16;
            this.listBoxRedigerakategorier.Location = new System.Drawing.Point(817, 136);
            this.listBoxRedigerakategorier.Name = "listBoxRedigerakategorier";
            this.listBoxRedigerakategorier.Size = new System.Drawing.Size(150, 148);
            this.listBoxRedigerakategorier.TabIndex = 7;
            // 
            // textBoxAndraKategori
            // 
            this.textBoxAndraKategori.Location = new System.Drawing.Point(837, 332);
            this.textBoxAndraKategori.Name = "textBoxAndraKategori";
            this.textBoxAndraKategori.Size = new System.Drawing.Size(125, 22);
            this.textBoxAndraKategori.TabIndex = 8;
            // 
            // buttonAndra
            // 
            this.buttonAndra.Location = new System.Drawing.Point(869, 373);
            this.buttonAndra.Name = "buttonAndra";
            this.buttonAndra.Size = new System.Drawing.Size(56, 23);
            this.buttonAndra.TabIndex = 9;
            this.buttonAndra.Text = "Ändra";
            this.buttonAndra.UseVisualStyleBackColor = true;
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Location = new System.Drawing.Point(942, 373);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(61, 23);
            this.buttonTaBort.TabIndex = 10;
            this.buttonTaBort.Text = "Ta bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            // 
            // labelMinaKategorier
            // 
            this.labelMinaKategorier.AutoSize = true;
            this.labelMinaKategorier.Location = new System.Drawing.Point(813, 110);
            this.labelMinaKategorier.Name = "labelMinaKategorier";
            this.labelMinaKategorier.Size = new System.Drawing.Size(104, 16);
            this.labelMinaKategorier.TabIndex = 11;
            this.labelMinaKategorier.Text = "Mina Kategorier:";
            // 
            // Avsnitt
            // 
            this.Avsnitt.FormattingEnabled = true;
            this.Avsnitt.ItemHeight = 16;
            this.Avsnitt.Location = new System.Drawing.Point(429, 248);
            this.Avsnitt.Name = "Avsnitt";
            this.Avsnitt.Size = new System.Drawing.Size(169, 116);
            this.Avsnitt.TabIndex = 12;
            // 
            // labelAvsnitt
            // 
            this.labelAvsnitt.AutoSize = true;
            this.labelAvsnitt.Location = new System.Drawing.Point(426, 229);
            this.labelAvsnitt.Name = "labelAvsnitt";
            this.labelAvsnitt.Size = new System.Drawing.Size(49, 16);
            this.labelAvsnitt.TabIndex = 13;
            this.labelAvsnitt.Text = "Avsnitt:";
            // 
            // labelBeskrivning
            // 
            this.labelBeskrivning.AutoSize = true;
            this.labelBeskrivning.Location = new System.Drawing.Point(426, 373);
            this.labelBeskrivning.Name = "labelBeskrivning";
            this.labelBeskrivning.Size = new System.Drawing.Size(80, 16);
            this.labelBeskrivning.TabIndex = 14;
            this.labelBeskrivning.Text = "Beskrivning:";
            // 
            // textBoxBeskrivning
            // 
            this.textBoxBeskrivning.Location = new System.Drawing.Point(429, 401);
            this.textBoxBeskrivning.Name = "textBoxBeskrivning";
            this.textBoxBeskrivning.Size = new System.Drawing.Size(169, 22);
            this.textBoxBeskrivning.TabIndex = 15;
            // 
            // labelAndraKategori
            // 
            this.labelAndraKategori.AutoSize = true;
            this.labelAndraKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAndraKategori.Location = new System.Drawing.Point(837, 47);
            this.labelAndraKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAndraKategori.Name = "labelAndraKategori";
            this.labelAndraKategori.Size = new System.Drawing.Size(115, 17);
            this.labelAndraKategori.TabIndex = 16;
            this.labelAndraKategori.Text = "Ändra kategori";
            // 
            // labelLaggTillPodd
            // 
            this.labelLaggTillPodd.AutoSize = true;
            this.labelLaggTillPodd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaggTillPodd.Location = new System.Drawing.Point(23, 47);
            this.labelLaggTillPodd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLaggTillPodd.Name = "labelLaggTillPodd";
            this.labelLaggTillPodd.Size = new System.Drawing.Size(187, 17);
            this.labelLaggTillPodd.TabIndex = 17;
            this.labelLaggTillPodd.Text = "Lägg till podd i bibliotek:";
            this.labelLaggTillPodd.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(27, 136);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(191, 24);
            this.comboBoxKategori.TabIndex = 18;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // labelTilldelaKategori
            // 
            this.labelTilldelaKategori.AutoSize = true;
            this.labelTilldelaKategori.Location = new System.Drawing.Point(23, 118);
            this.labelTilldelaKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTilldelaKategori.Name = "labelTilldelaKategori";
            this.labelTilldelaKategori.Size = new System.Drawing.Size(107, 16);
            this.labelTilldelaKategori.TabIndex = 19;
            this.labelTilldelaKategori.Text = "Tilldela kategori:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 182);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ange poddnamn:";
            // 
            // comboBoxFiltreraKategori
            // 
            this.comboBoxFiltreraKategori.FormattingEnabled = true;
            this.comboBoxFiltreraKategori.Location = new System.Drawing.Point(229, 286);
            this.comboBoxFiltreraKategori.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFiltreraKategori.Name = "comboBoxFiltreraKategori";
            this.comboBoxFiltreraKategori.Size = new System.Drawing.Size(110, 24);
            this.comboBoxFiltreraKategori.TabIndex = 22;
            this.comboBoxFiltreraKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltreraKategori_SelectedIndexChanged);
            // 
            // labelFiltreraKategori
            // 
            this.labelFiltreraKategori.AutoSize = true;
            this.labelFiltreraKategori.Location = new System.Drawing.Point(225, 262);
            this.labelFiltreraKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiltreraKategori.Name = "labelFiltreraKategori";
            this.labelFiltreraKategori.Size = new System.Drawing.Size(103, 16);
            this.labelFiltreraKategori.TabIndex = 23;
            this.labelFiltreraKategori.Text = "Filtrera kategori:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 563);
            this.Controls.Add(this.labelFiltreraKategori);
            this.Controls.Add(this.comboBoxFiltreraKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTilldelaKategori);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.labelLaggTillPodd);
            this.Controls.Add(this.labelAndraKategori);
            this.Controls.Add(this.textBoxBeskrivning);
            this.Controls.Add(this.labelBeskrivning);
            this.Controls.Add(this.labelAvsnitt);
            this.Controls.Add(this.Avsnitt);
            this.Controls.Add(this.labelMinaKategorier);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.buttonAndra);
            this.Controls.Add(this.textBoxAndraKategori);
            this.Controls.Add(this.listBoxRedigerakategorier);
            this.Controls.Add(this.labelRedigeraKategorier);
            this.Controls.Add(this.listViewPoddar);
            this.Controls.Add(this.labelAngeURL);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonLaggTillKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLaggTill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLaggTill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLaggTillKategori;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label labelAngeURL;
        private System.Windows.Forms.ListView listViewPoddar;
        private System.Windows.Forms.Label labelRedigeraKategorier;
        private System.Windows.Forms.ListBox listBoxRedigerakategorier;
        private System.Windows.Forms.TextBox textBoxAndraKategori;
        private System.Windows.Forms.Button buttonAndra;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Label labelMinaKategorier;
        private System.Windows.Forms.ListBox Avsnitt;
        private System.Windows.Forms.Label labelAvsnitt;
        private System.Windows.Forms.Label labelBeskrivning;
        private System.Windows.Forms.TextBox textBoxBeskrivning;
        private System.Windows.Forms.Label labelAndraKategori;
        private System.Windows.Forms.Label labelLaggTillPodd;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Label labelTilldelaKategori;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFiltreraKategori;
        private System.Windows.Forms.Label labelFiltreraKategori;
    }
}

