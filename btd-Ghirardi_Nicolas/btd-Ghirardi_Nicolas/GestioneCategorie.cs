using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace btd_Ghirardi_Nicolas
{
    public partial class GestioneCategorie : Form
    {
        private BTD banca;

        public GestioneCategorie(BTD banca)
        {
            InitializeComponent();
            this.banca = banca;
        }

        private void GestioneCategorie_Load(object sender, EventArgs e)
        {
            
            comboBoxCategorie.Items.AddRange(banca.CategoriePrestazioni.ToArray());
            comboBoxCategorie.SelectedIndex = 0;
        }
        private void modifica_Click(object sender, EventArgs e)
        {
            string categoriaSelezionata = Convert.ToString(comboBoxCategorie.SelectedItem);
            if (!string.IsNullOrEmpty(categoriaSelezionata))
            {
                if (categoriaSelezionata != "Segreteria") { 
                string nuovaCategoria = textBoxNuovaCategoria.Text.Trim();
                if (!string.IsNullOrEmpty(nuovaCategoria))
                {
                    banca.ModificaCategoria(categoriaSelezionata, nuovaCategoria);
                    int index = comboBoxCategorie.SelectedIndex;
                    if (index >= 0)
                    {
                        comboBoxCategorie.Items[index] = nuovaCategoria;
                    }
                    textBoxNuovaCategoria.Clear();
                }
                }
                else
                {
                    MessageBox.Show("Non è possibile modificare la prestazione segreteria.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
            }
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            string categoriaSelezionata = Convert.ToString(comboBoxCategorie.SelectedItem);
            if (!string.IsNullOrEmpty(categoriaSelezionata))
            {
                if (categoriaSelezionata != "Segreteria") {
                banca.EliminaCategoria(categoriaSelezionata);
                comboBoxCategorie.Items.Remove(categoriaSelezionata);
                textBoxNuovaCategoria.Clear(); 
                }
                else
                {
                    MessageBox.Show("Non è possibile eliminare la prestazione segreteria.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            string nuovaCategoria = textBoxNuovaCategoria.Text.Trim();
            if (string.IsNullOrEmpty(nuovaCategoria))
            {
                MessageBox.Show("Inserisci il nome della nuova categoria.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCategorie.Items.Contains(nuovaCategoria))
            {
                MessageBox.Show("La categoria inserita è già presente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            banca.AggiungiCategoria(nuovaCategoria);
            comboBoxCategorie.Items.Add(nuovaCategoria);
            comboBoxCategorie.Text = nuovaCategoria;
            
        }
    }
}
