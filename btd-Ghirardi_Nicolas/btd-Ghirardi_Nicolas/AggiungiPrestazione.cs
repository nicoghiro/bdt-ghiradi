using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace btd_Ghirardi_Nicolas
{
    public partial class AggiungiPrestazione : Form
    {
        private BTD banca;
        public Socio selezionato;
        private List<string> categoriePrestazioni;

        public AggiungiPrestazione(BTD banca,Socio sele, List<string> categoriePrestazioni)
        {
            InitializeComponent();

            if (banca == null)
                throw new Exception( "L'oggetto banca non può essere null.");

            if (categoriePrestazioni == null)
                throw new Exception( "La lista delle categorie prestazioni non può essere null.");
            if (sele== null)
                throw new Exception("Il socio selezionato non può essere null.");
            this.selezionato = sele;
            this.banca = banca;
            this.categoriePrestazioni = categoriePrestazioni;

            InitializeComboBoxCategorie();
        }

        private void AggiungiPrestazione_Load(object sender, EventArgs e)
        {
            InitializeComboBoxCategorie();
        }

        private void InitializeComboBoxCategorie()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(categoriePrestazioni.ToArray());
            cmbCategoria.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.Text;
            string descrizione = txtDescrizione.Text;
            int ore = Convert.ToInt32(numOre.Value);

            if (!string.IsNullOrWhiteSpace(categoria) && !string.IsNullOrWhiteSpace(descrizione) && ore > 0)
            {
                if (selezionato.FaParteSegreteria || !categoria.Contains("Segreteria"))
                {
                    banca.AggiungiPrestazione(categoria, descrizione, selezionato.Id, ore);

                    MessageBox.Show("Prestazione aggiunta con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Il socio non può accettare lavori dalla segreteria.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserisci tutte le informazioni correttamente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
