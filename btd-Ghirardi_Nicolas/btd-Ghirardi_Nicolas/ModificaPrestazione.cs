using System;
using System.Windows.Forms;

namespace btd_Ghirardi_Nicolas
{
    public partial class ModificaPrestazione : Form
    {
        private BTD banca;
        private Socio socio;
        private Prestazioni prestazioneDaModificare;

        public ModificaPrestazione(Prestazioni prestazione, BTD banca, Socio socio)
        {
            InitializeComponent();
            this.banca = banca;
            this.socio = socio;
            prestazioneDaModificare = prestazione;
        }

        private void ModificaPrestazione_Load(object sender, EventArgs e)
        {
            InitializeComboBoxCategorie();

            cmbCategoria.SelectedItem = prestazioneDaModificare.Categoria;
            txtLavoro.Text = prestazioneDaModificare.Lavoro;
            numOre.Value = prestazioneDaModificare.Ore;
        }

        private void InitializeComboBoxCategorie()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(banca.CategoriePrestazioni.ToArray());

            if (!socio.FaParteSegreteria)
            {
                cmbCategoria.Items.Remove("Segreteria");
            }
        }

        

        private void btnModifica_Click_1(object sender, EventArgs e)
        {
            string nuovaCategoria = cmbCategoria.Text;
            string nuovoLavoro = txtLavoro.Text;
            int nuoveOre = (int)numOre.Value;

            if (!string.IsNullOrWhiteSpace(nuovaCategoria) && !string.IsNullOrWhiteSpace(nuovoLavoro) && nuoveOre > 0)
            {
                if (prestazioneDaModificare.Categoria != nuovaCategoria)
                {
                    banca.EliminaPrestazione(prestazioneDaModificare.IdDatore);
                    banca.AggiungiPrestazione(nuovaCategoria, nuovoLavoro, prestazioneDaModificare.IdDatore, nuoveOre,socio.Zona);
                }
                else
                {
                    prestazioneDaModificare.ModificaPrestazione(nuovaCategoria, nuovoLavoro, nuoveOre);
                }

                MessageBox.Show("Prestazione modificata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Inserisci tutte le informazioni correttamente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
         }
    }
}
