namespace PoddApp
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
            this.textBoxHanteraKategori = new System.Windows.Forms.TextBox();
            this.buttonAndra = new System.Windows.Forms.Button();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.labelMinaKategorier = new System.Windows.Forms.Label();
            this.listBoxAvsnitt = new System.Windows.Forms.ListBox();
            this.labelAvsnitt = new System.Windows.Forms.Label();
            this.labelBeskrivning = new System.Windows.Forms.Label();
            this.textBoxBeskrivning = new System.Windows.Forms.TextBox();
            this.labelAndraKategori = new System.Windows.Forms.Label();
            this.labelLaggTillPodd = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.labelTilldelaKategori = new System.Windows.Forms.Label();
            this.textBoxEgetNamn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFiltreraKategori = new System.Windows.Forms.ComboBox();
            this.labelFiltreraKategori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLaggTill
            // 
            this.buttonLaggTill.Location = new System.Drawing.Point(212, 312);
            this.buttonLaggTill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLaggTill.Name = "buttonLaggTill";
            this.buttonLaggTill.Size = new System.Drawing.Size(112, 41);
            this.buttonLaggTill.TabIndex = 0;
            this.buttonLaggTill.Text = "Lägg till";
            this.buttonLaggTill.UseVisualStyleBackColor = true;
            this.buttonLaggTill.Click += new System.EventHandler(this.buttonLaggTill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "PODDAPP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLaggTillKategori
            // 
            this.buttonLaggTillKategori.Location = new System.Drawing.Point(1179, 583);
            this.buttonLaggTillKategori.Name = "buttonLaggTillKategori";
            this.buttonLaggTillKategori.Size = new System.Drawing.Size(98, 38);
            this.buttonLaggTillKategori.TabIndex = 2;
            this.buttonLaggTillKategori.Text = "Lägg till";
            this.buttonLaggTillKategori.UseVisualStyleBackColor = true;
            this.buttonLaggTillKategori.Click += new System.EventHandler(this.buttonLaggTillKategori_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(40, 103);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(284, 31);
            this.textBoxUrl.TabIndex = 3;
            // 
            // labelAngeURL
            // 
            this.labelAngeURL.AutoSize = true;
            this.labelAngeURL.Location = new System.Drawing.Point(34, 73);
            this.labelAngeURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngeURL.Name = "labelAngeURL";
            this.labelAngeURL.Size = new System.Drawing.Size(116, 25);
            this.labelAngeURL.TabIndex = 4;
            this.labelAngeURL.Text = "Ange URL:";
            this.labelAngeURL.Click += new System.EventHandler(this.label2_Click);
            // 
            // listViewPoddar
            // 
            this.listViewPoddar.HideSelection = false;
            this.listViewPoddar.Location = new System.Drawing.Point(39, 363);
            this.listViewPoddar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewPoddar.Name = "listViewPoddar";
            this.listViewPoddar.Size = new System.Drawing.Size(591, 420);
            this.listViewPoddar.TabIndex = 5;
            this.listViewPoddar.UseCompatibleStateImageBehavior = false;
            this.listViewPoddar.SelectedIndexChanged += new System.EventHandler(this.listViewPoddar_SelectedIndexChanged);
            // 
            // labelRedigeraKategorier
            // 
            this.labelRedigeraKategorier.AutoSize = true;
            this.labelRedigeraKategorier.Location = new System.Drawing.Point(1174, 467);
            this.labelRedigeraKategorier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRedigeraKategorier.Name = "labelRedigeraKategorier";
            this.labelRedigeraKategorier.Size = new System.Drawing.Size(318, 25);
            this.labelRedigeraKategorier.TabIndex = 6;
            this.labelRedigeraKategorier.Text = "Lägg till/ändra befintlig kategori:";
            // 
            // listBoxRedigerakategorier
            // 
            this.listBoxRedigerakategorier.FormattingEnabled = true;
            this.listBoxRedigerakategorier.ItemHeight = 25;
            this.listBoxRedigerakategorier.Location = new System.Drawing.Point(1226, 212);
            this.listBoxRedigerakategorier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxRedigerakategorier.Name = "listBoxRedigerakategorier";
            this.listBoxRedigerakategorier.Size = new System.Drawing.Size(223, 229);
            this.listBoxRedigerakategorier.TabIndex = 7;
            this.listBoxRedigerakategorier.SelectedIndexChanged += new System.EventHandler(this.listBoxRedigerakategorier_SelectedIndexChanged);
            // 
            // textBoxHanteraKategori
            // 
            this.textBoxHanteraKategori.Location = new System.Drawing.Point(1256, 519);
            this.textBoxHanteraKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHanteraKategori.Name = "textBoxHanteraKategori";
            this.textBoxHanteraKategori.Size = new System.Drawing.Size(186, 31);
            this.textBoxHanteraKategori.TabIndex = 8;
            this.textBoxHanteraKategori.TextChanged += new System.EventHandler(this.textBoxAndraKategori_TextChanged);
            // 
            // buttonAndra
            // 
            this.buttonAndra.Location = new System.Drawing.Point(1304, 583);
            this.buttonAndra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAndra.Name = "buttonAndra";
            this.buttonAndra.Size = new System.Drawing.Size(84, 36);
            this.buttonAndra.TabIndex = 9;
            this.buttonAndra.Text = "Ändra";
            this.buttonAndra.UseVisualStyleBackColor = true;
            this.buttonAndra.Click += new System.EventHandler(this.buttonAndra_Click);
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Location = new System.Drawing.Point(1413, 583);
            this.buttonTaBort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(92, 36);
            this.buttonTaBort.TabIndex = 10;
            this.buttonTaBort.Text = "Ta bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            this.buttonTaBort.Click += new System.EventHandler(this.buttonTaBort_Click);
            // 
            // labelMinaKategorier
            // 
            this.labelMinaKategorier.AutoSize = true;
            this.labelMinaKategorier.Location = new System.Drawing.Point(1220, 172);
            this.labelMinaKategorier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinaKategorier.Name = "labelMinaKategorier";
            this.labelMinaKategorier.Size = new System.Drawing.Size(170, 25);
            this.labelMinaKategorier.TabIndex = 11;
            this.labelMinaKategorier.Text = "Mina Kategorier:";
            // 
            // listBoxAvsnitt
            // 
            this.listBoxAvsnitt.FormattingEnabled = true;
            this.listBoxAvsnitt.ItemHeight = 25;
            this.listBoxAvsnitt.Location = new System.Drawing.Point(644, 388);
            this.listBoxAvsnitt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAvsnitt.Name = "listBoxAvsnitt";
            this.listBoxAvsnitt.Size = new System.Drawing.Size(252, 179);
            this.listBoxAvsnitt.TabIndex = 12;
            // 
            // labelAvsnitt
            // 
            this.labelAvsnitt.AutoSize = true;
            this.labelAvsnitt.Location = new System.Drawing.Point(639, 358);
            this.labelAvsnitt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvsnitt.Name = "labelAvsnitt";
            this.labelAvsnitt.Size = new System.Drawing.Size(83, 25);
            this.labelAvsnitt.TabIndex = 13;
            this.labelAvsnitt.Text = "Avsnitt:";
            // 
            // labelBeskrivning
            // 
            this.labelBeskrivning.AutoSize = true;
            this.labelBeskrivning.Location = new System.Drawing.Point(639, 583);
            this.labelBeskrivning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBeskrivning.Name = "labelBeskrivning";
            this.labelBeskrivning.Size = new System.Drawing.Size(130, 25);
            this.labelBeskrivning.TabIndex = 14;
            this.labelBeskrivning.Text = "Beskrivning:";
            // 
            // textBoxBeskrivning
            // 
            this.textBoxBeskrivning.Location = new System.Drawing.Point(644, 627);
            this.textBoxBeskrivning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBeskrivning.Name = "textBoxBeskrivning";
            this.textBoxBeskrivning.Size = new System.Drawing.Size(252, 31);
            this.textBoxBeskrivning.TabIndex = 15;
            // 
            // labelAndraKategori
            // 
            this.labelAndraKategori.AutoSize = true;
            this.labelAndraKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAndraKategori.Location = new System.Drawing.Point(1256, 73);
            this.labelAndraKategori.Name = "labelAndraKategori";
            this.labelAndraKategori.Size = new System.Drawing.Size(166, 25);
            this.labelAndraKategori.TabIndex = 16;
            this.labelAndraKategori.Text = "Ändra kategori";
            // 
            // labelLaggTillPodd
            // 
            this.labelLaggTillPodd.AutoSize = true;
            this.labelLaggTillPodd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaggTillPodd.Location = new System.Drawing.Point(34, 35);
            this.labelLaggTillPodd.Name = "labelLaggTillPodd";
            this.labelLaggTillPodd.Size = new System.Drawing.Size(271, 25);
            this.labelLaggTillPodd.TabIndex = 17;
            this.labelLaggTillPodd.Text = "Lägg till podd i bibliotek:";
            this.labelLaggTillPodd.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(40, 191);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(284, 33);
            this.comboBoxKategori.TabIndex = 18;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // labelTilldelaKategori
            // 
            this.labelTilldelaKategori.AutoSize = true;
            this.labelTilldelaKategori.Location = new System.Drawing.Point(35, 153);
            this.labelTilldelaKategori.Name = "labelTilldelaKategori";
            this.labelTilldelaKategori.Size = new System.Drawing.Size(170, 25);
            this.labelTilldelaKategori.TabIndex = 19;
            this.labelTilldelaKategori.Text = "Tilldela kategori:";
            // 
            // textBoxEgetNamn
            // 
            this.textBoxEgetNamn.Location = new System.Drawing.Point(40, 273);
            this.textBoxEgetNamn.Name = "textBoxEgetNamn";
            this.textBoxEgetNamn.Size = new System.Drawing.Size(284, 31);
            this.textBoxEgetNamn.TabIndex = 20;
            this.textBoxEgetNamn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ange poddnamn:";
            // 
            // comboBoxFiltreraKategori
            // 
            this.comboBoxFiltreraKategori.FormattingEnabled = true;
            this.comboBoxFiltreraKategori.Location = new System.Drawing.Point(644, 236);
            this.comboBoxFiltreraKategori.Name = "comboBoxFiltreraKategori";
            this.comboBoxFiltreraKategori.Size = new System.Drawing.Size(163, 33);
            this.comboBoxFiltreraKategori.TabIndex = 22;
            this.comboBoxFiltreraKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltreraKategori_SelectedIndexChanged);
            // 
            // labelFiltreraKategori
            // 
            this.labelFiltreraKategori.AutoSize = true;
            this.labelFiltreraKategori.Location = new System.Drawing.Point(639, 194);
            this.labelFiltreraKategori.Name = "labelFiltreraKategori";
            this.labelFiltreraKategori.Size = new System.Drawing.Size(168, 25);
            this.labelFiltreraKategori.TabIndex = 23;
            this.labelFiltreraKategori.Text = "Filtrera kategori:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 880);
            this.Controls.Add(this.labelFiltreraKategori);
            this.Controls.Add(this.comboBoxFiltreraKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEgetNamn);
            this.Controls.Add(this.labelTilldelaKategori);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.labelLaggTillPodd);
            this.Controls.Add(this.labelAndraKategori);
            this.Controls.Add(this.textBoxBeskrivning);
            this.Controls.Add(this.labelBeskrivning);
            this.Controls.Add(this.labelAvsnitt);
            this.Controls.Add(this.listBoxAvsnitt);
            this.Controls.Add(this.labelMinaKategorier);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.buttonAndra);
            this.Controls.Add(this.textBoxHanteraKategori);
            this.Controls.Add(this.listBoxRedigerakategorier);
            this.Controls.Add(this.labelRedigeraKategorier);
            this.Controls.Add(this.listViewPoddar);
            this.Controls.Add(this.labelAngeURL);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonLaggTillKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLaggTill);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox textBoxHanteraKategori;
        private System.Windows.Forms.Button buttonAndra;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Label labelMinaKategorier;
        private System.Windows.Forms.ListBox listBoxAvsnitt;
        private System.Windows.Forms.Label labelAvsnitt;
        private System.Windows.Forms.Label labelBeskrivning;
        private System.Windows.Forms.TextBox textBoxBeskrivning;
        private System.Windows.Forms.Label labelAndraKategori;
        private System.Windows.Forms.Label labelLaggTillPodd;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Label labelTilldelaKategori;
        private System.Windows.Forms.TextBox textBoxEgetNamn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFiltreraKategori;
        private System.Windows.Forms.Label labelFiltreraKategori;
    }
}

