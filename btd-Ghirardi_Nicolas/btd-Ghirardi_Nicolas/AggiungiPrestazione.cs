using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace btd_Ghirardi_Nicolas
{
    public partial class AggiungiPrestazione : Form
    {
        private Socio socio;
        private List<string> categoriePrestazioni;

        public AggiungiPrestazione(Socio socio, List<string> categoriePrestazioni)
        {
             InitializeComponent();
            this.socio = socio;
            this.categoriePrestazioni = categoriePrestazioni;
        }

        private void AggiungiAttivita_Load(object sender, EventArgs e)
        {
           
            PopulateComboBoxCategorie();
        }

        private void PopulateComboBoxCategorie()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(categoriePrestazioni.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.Text;
            string Descrizione = txtDescrizione.Text;
            int ore = Convert.ToInt32(numOre.Value);


            if (!string.IsNullOrWhiteSpace(categoria) && !string.IsNullOrWhiteSpace(Descrizione) && ore > 0)
            {
                Prestazioni nuovaAttivita = new Prestazioni(categoria, Descrizione, socio, ore);
                socio.AggiungiPrestazione(nuovaAttivita);
                MessageBox.Show("Attività aggiunta con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Inserisci tutte le informazioni correttamente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
