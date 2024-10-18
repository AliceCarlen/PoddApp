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
            this.textBoxAndraKategori = new System.Windows.Forms.TextBox();
            this.buttonAndra = new System.Windows.Forms.Button();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.labelMinaKategorier = new System.Windows.Forms.Label();
            this.Avsnitt = new System.Windows.Forms.ListBox();
            this.labelAvsnitt = new System.Windows.Forms.Label();
            this.labelBeskrivning = new System.Windows.Forms.Label();
            this.textBoxBeskrivning = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLaggTill
            // 
            this.buttonLaggTill.Location = new System.Drawing.Point(111, 212);
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
            this.label1.Location = new System.Drawing.Point(537, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "PODDAPP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLaggTillKategori
            // 
            this.buttonLaggTillKategori.Location = new System.Drawing.Point(1047, 666);
            this.buttonLaggTillKategori.Name = "buttonLaggTillKategori";
            this.buttonLaggTillKategori.Size = new System.Drawing.Size(98, 38);
            this.buttonLaggTillKategori.TabIndex = 2;
            this.buttonLaggTillKategori.Text = "Lägg till";
            this.buttonLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(40, 153);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(284, 31);
            this.textBoxUrl.TabIndex = 3;
            // 
            // labelAngeURL
            // 
            this.labelAngeURL.AutoSize = true;
            this.labelAngeURL.Location = new System.Drawing.Point(116, 98);
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
            this.listViewPoddar.Location = new System.Drawing.Point(40, 303);
            this.listViewPoddar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewPoddar.Name = "listViewPoddar";
            this.listViewPoddar.Size = new System.Drawing.Size(284, 420);
            this.listViewPoddar.TabIndex = 5;
            this.listViewPoddar.UseCompatibleStateImageBehavior = false;
            // 
            // labelRedigeraKategorier
            // 
            this.labelRedigeraKategorier.AutoSize = true;
            this.labelRedigeraKategorier.Location = new System.Drawing.Point(1042, 569);
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
            this.listBoxRedigerakategorier.Location = new System.Drawing.Point(1080, 303);
            this.listBoxRedigerakategorier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxRedigerakategorier.Name = "listBoxRedigerakategorier";
            this.listBoxRedigerakategorier.Size = new System.Drawing.Size(223, 229);
            this.listBoxRedigerakategorier.TabIndex = 7;
            // 
            // textBoxAndraKategori
            // 
            this.textBoxAndraKategori.Location = new System.Drawing.Point(1096, 617);
            this.textBoxAndraKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAndraKategori.Name = "textBoxAndraKategori";
            this.textBoxAndraKategori.Size = new System.Drawing.Size(186, 31);
            this.textBoxAndraKategori.TabIndex = 8;
            // 
            // buttonAndra
            // 
            this.buttonAndra.Location = new System.Drawing.Point(1152, 666);
            this.buttonAndra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAndra.Name = "buttonAndra";
            this.buttonAndra.Size = new System.Drawing.Size(84, 36);
            this.buttonAndra.TabIndex = 9;
            this.buttonAndra.Text = "Ändra";
            this.buttonAndra.UseVisualStyleBackColor = true;
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Location = new System.Drawing.Point(1245, 666);
            this.buttonTaBort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(92, 36);
            this.buttonTaBort.TabIndex = 10;
            this.buttonTaBort.Text = "Ta bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            // 
            // labelMinaKategorier
            // 
            this.labelMinaKategorier.AutoSize = true;
            this.labelMinaKategorier.Location = new System.Drawing.Point(1113, 228);
            this.labelMinaKategorier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinaKategorier.Name = "labelMinaKategorier";
            this.labelMinaKategorier.Size = new System.Drawing.Size(170, 25);
            this.labelMinaKategorier.TabIndex = 11;
            this.labelMinaKategorier.Text = "Mina Kategorier:";
            // 
            // Avsnitt
            // 
            this.Avsnitt.FormattingEnabled = true;
            this.Avsnitt.ItemHeight = 25;
            this.Avsnitt.Location = new System.Drawing.Point(374, 353);
            this.Avsnitt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Avsnitt.Name = "Avsnitt";
            this.Avsnitt.Size = new System.Drawing.Size(252, 179);
            this.Avsnitt.TabIndex = 12;
            // 
            // labelAvsnitt
            // 
            this.labelAvsnitt.AutoSize = true;
            this.labelAvsnitt.Location = new System.Drawing.Point(459, 303);
            this.labelAvsnitt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvsnitt.Name = "labelAvsnitt";
            this.labelAvsnitt.Size = new System.Drawing.Size(83, 25);
            this.labelAvsnitt.TabIndex = 13;
            this.labelAvsnitt.Text = "Avsnitt:";
            // 
            // labelBeskrivning
            // 
            this.labelBeskrivning.AutoSize = true;
            this.labelBeskrivning.Location = new System.Drawing.Point(440, 569);
            this.labelBeskrivning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBeskrivning.Name = "labelBeskrivning";
            this.labelBeskrivning.Size = new System.Drawing.Size(130, 25);
            this.labelBeskrivning.TabIndex = 14;
            this.labelBeskrivning.Text = "Beskrivning:";
            // 
            // textBoxBeskrivning
            // 
            this.textBoxBeskrivning.Location = new System.Drawing.Point(374, 617);
            this.textBoxBeskrivning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBeskrivning.Name = "textBoxBeskrivning";
            this.textBoxBeskrivning.Size = new System.Drawing.Size(252, 31);
            this.textBoxBeskrivning.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "labelTest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 880);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox textBoxAndraKategori;
        private System.Windows.Forms.Button buttonAndra;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Label labelMinaKategorier;
        private System.Windows.Forms.ListBox Avsnitt;
        private System.Windows.Forms.Label labelAvsnitt;
        private System.Windows.Forms.Label labelBeskrivning;
        private System.Windows.Forms.TextBox textBoxBeskrivning;
        private System.Windows.Forms.Label label2;
    }
}

