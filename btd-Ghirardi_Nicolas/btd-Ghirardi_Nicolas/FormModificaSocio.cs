using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btd_Ghirardi_Nicolas
{
    public partial class FormModificaSocio : Form
    {
        public FormModificaSocio()
        {
            InitializeComponent();
        }
        List<Socio> soci;
        public FormModificaSocio(List<Socio> soci,BTD banca) 
        {
            InitializeComponent();
            this.soci = soci;
            popola(banca.zone);
           
        }
        public void popola(List<string> zone)
        {
            cmbZona.Items.Clear();
            cmbZona.Items.AddRange(zone.ToArray());
            cmbZona.SelectedIndex = 0;
        }

        private Socio GetSocioSelezionato()
        {
            if (listViewSoci.SelectedItems.Count > 0)
            {


                ListViewItem itemSelezionato = listViewSoci.SelectedItems[0];
                Socio socioSelezionato = itemSelezionato.Tag as Socio;
                return socioSelezionato;
            }

            return null;
        }
        
        public void popola(List<Socio> soci)
        {
            listViewSoci.Clear();
            listViewSoci.Columns.Add("ID", 0);
            listViewSoci.Columns.Add("Cognome", 100);
            listViewSoci.Columns.Add("Nome", 100);
            listViewSoci.Columns.Add("Telefono", 100);
            listViewSoci.Columns.Add("segreteria", 150);
            listViewSoci.Columns.Add("ore", 40);
            listViewSoci.Columns.Add("zona", 150);
            foreach (Socio socio in soci)
            {
                ListViewItem item = new ListViewItem(new string[] { socio.Id.ToString(), socio.Cognome, socio.Nome, socio.Telefono, socio.FaParteSegreteria ? "Sì" : "No", socio.ore.ToString(),socio.Zona });
                item.Tag = socio;
                listViewSoci.Items.Add(item);
            }
        }
        private void FormModificaSocio_Load(object sender, EventArgs e)
        {
            popola(soci);
            listViewSoci.FullRowSelect = true;
        }
        public Socio GetModificato()
        {
            int id = GetSocioSelezionato().Id;
            string cognome = txtCognome.Text;
            string nome = txtNome.Text;
            string telefono = txtTelefono.Text;
            bool faParteSegreteria = chkSegreteria.Checked;
            int numOre = Convert.ToInt32(numericUpDown1.Value);
            string zona=cmbZona.Text;

            
            Socio nuovoSocio = new Socio(id,cognome, nome, telefono, numOre,zona,faParteSegreteria);

          
            return nuovoSocio;
        }

        private void listViewSoci_SelectedIndexChanged(object sender, EventArgs e)
        {
            Socio selezionato = GetSocioSelezionato();
            if (selezionato != null)
            {
                if (selezionato.Id != 0)
                {
                    txtNome.Text = selezionato.Nome;
                    txtCognome.Text = selezionato.Cognome;
                    txtTelefono.Text = selezionato.Telefono;
                    chkSegreteria.Checked = selezionato.FaParteSegreteria;
                    numericUpDown1.Value = selezionato.ore;
                    cmbZona.Text = selezionato.Zona;
                }
                else
                {
                    MessageBox.Show("non è possibile modificare l'utente admin", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtNome.Text = "";
                txtCognome.Text = "";
                txtTelefono.Text ="";
                chkSegreteria.Checked = false;
            }
        
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (VerificaCampi())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
    }
 }
