﻿using PoddApp.BLL;
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
        private KategoriManager kategoriManager; //fält som refererar till BLL-lagret
        public Form1() //konstruktor som skapar en instans av BLL-lagret (KategoriManager)
        {
            InitializeComponent();
            kategoriManager = new KategoriManager();
            FyllKategoriComboBox(); //metod som fyller comboboxen med kategorier - se metodkropp längre ner
            FiltreraKategorierComboBox(); //metod som filterar kategorier
            listBoxRedigeraKategorierFyll();
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

        private void FyllKategoriComboBox() //metod som fyller cb. Hämtar data från DAL-lagret med hjälp av mellanhanden BLL
        {
            List<string> kategorier = kategoriManager.HamtaKategorier();
            comboBoxKategori.Items.Clear();
            comboBoxKategori.Items.AddRange(kategorier.ToArray());
        }

        private void comboBoxFiltreraKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FiltreraKategorierComboBox() //metod som filtrerar kategoirer. Använder samma metoder i BLL som FyllKategoriComboBox gör.
        {
            List<string> kategorier = kategoriManager.HamtaKategorier();
            comboBoxFiltreraKategori.Items.Clear();
            comboBoxFiltreraKategori.Items.AddRange(kategorier.ToArray());
        }

        private void listBoxRedigerakategorier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxRedigeraKategorierFyll()
        {
            List<string> kategorier = kategoriManager.HamtaKategorier();
            listBoxRedigerakategorier.Items.Clear();
            listBoxRedigerakategorier.Items.AddRange(kategorier.ToArray());
        }

        private void textBoxAndraKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLaggTillKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = textBoxHanteraKategori.Text.Trim(); //trim tar bort oönskade mellanslag 
            if (!string.IsNullOrEmpty(nyKategori))
            {
                kategoriManager.LaggTillKategori(nyKategori); //anropa metod i BLL-lagret
                listBoxRedigeraKategorierFyll(); //fyller listboxen igen för att se den nya kategorin
                textBoxHanteraKategori.Clear(); //rensar textbox efter att vi lagt till kategorin
            }

            else
            {
                MessageBox.Show("Ange en kategori.");
            }
        }

        private void buttonAndra_Click(object sender, EventArgs e)
        {
            string gammalKategori = listBoxRedigerakategorier.SelectedItem?.ToString(); // Hämta den valda kategorin
            string nyKategori = textBoxHanteraKategori.Text.Trim(); // Hämta det nya namnet

            if (!string.IsNullOrEmpty(gammalKategori) && !string.IsNullOrEmpty(nyKategori))
            {
                kategoriManager.AndraKategori(gammalKategori, nyKategori); // Anropa metoden i BLL-lagret
                listBoxRedigeraKategorierFyll(); // Uppdatera listboxen
                textBoxHanteraKategori.Clear(); // Rensa textfältet
            }
            else
            {
                MessageBox.Show("Vänligen välj en kategori och ange ett nytt namn.");
            }
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            string gammalKategori = listBoxRedigerakategorier.SelectedItem?.ToString(); // Hämta den valda kategorin

        }
    }
    }

