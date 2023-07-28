using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using System.Text.RegularExpressions;
namespace btd_Ghirardi_Nicolas
{
    public partial class FormAggiungiSocio : Form
    {
        public FormAggiungiSocio()
        {
            InitializeComponent();
        }


        private bool VerificaCampi()
        {

            if (string.IsNullOrWhiteSpace(txtCognome.Text) ||
                string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Completa tutti i campi prima di confermare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string telefono = txtTelefono.Text;

            // Crea un'espressione regolare per verificare il formato del numero di telefono
            // I formati ammessi sono: "1234567890" o "123 456 7890" (per numeri mobili)
            // "0123456789" o "0123 456789" o "0123 456 789" (per numeri fissi)
            string pattern = @"^((\d{3}\s?\d{3}\s?\d{4})|(\d{4}\s?\d{3}\s?\d{3})|(\d{4}\s?\d{3}\s?\d{2}\s?\d{2}))$";

            if (!Regex.IsMatch(telefono, pattern))
            {
                MessageBox.Show("Inserisci un numero di telefono valido.\n\nEsempi validi: 1234567890, 123 456 7890, 0123456789, 0123 456789, 0123 456 789", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        public Socio GetNuovoSocio()
        {

            string cognome = txtCognome.Text;
            string nome = txtNome.Text;
            string telefono = txtTelefono.Text;
            bool faParteSegreteria = chkSegreteria.Checked;

            Socio nuovoSocio = new Socio(cognome, nome, telefono, faParteSegreteria);
            return nuovoSocio;
        }
        private void btnAnnulla_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConferma_Click_1(object sender, EventArgs e)
        {
            if (VerificaCampi())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
