using PoddApp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoddApp
{
    public partial class Form1 : Form
    {
        private KategoriManager kategoriManager;
        public Form1()
        {
            InitializeComponent();
            kategoriManager = new KategoriManager();
            FyllKategoriComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLaggTill_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FyllKategoriComboBox()
        {
            List<string> kategorier = kategoriManager.HamtaKategorier();
            comboBoxKategori.Items.Clear();
            comboBoxKategori.Items.AddRange(kategorier.ToArray());
        }
    }
}
