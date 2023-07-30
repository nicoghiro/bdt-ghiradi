using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace btd_Ghirardi_Nicolas
{
    public partial class EliminaSocio : Form
    {
        public Socio SocioSelezionato { get; private set; }
        private List<Socio> soci;

        public EliminaSocio(List<Socio> soci)
        {
            InitializeComponent();
            this.soci = soci;
            popola(soci);
        }

        private void EliminaSocio_Load(object sender, EventArgs e)
        {
            popola(soci);
            listViewSoci.FullRowSelect = true;
        }

        private void popola(List<Socio> soci)
        {
            listViewSoci.Clear();
            listViewSoci.Columns.Add("ID", 50);
            listViewSoci.Columns.Add("Cognome", 100);
            listViewSoci.Columns.Add("Nome", 100);
            listViewSoci.Columns.Add("Telefono", 100);
            listViewSoci.Columns.Add("Segreteria", 80);
            listViewSoci.Columns.Add("Ore", 50);

            foreach (Socio socio in soci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    socio.Id.ToString(),
                    socio.Cognome,
                    socio.Nome,
                    socio.Telefono,
                    socio.FaParteSegreteria ? "Sì" : "No",
                    socio.ore.ToString()
                });
                item.Tag = socio;
                listViewSoci.Items.Add(item);
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private Socio GetSocioSelezionato()
        {
            if (listViewSoci.SelectedItems.Count > 0)
            {
                ListViewItem itemSelezionato = listViewSoci.SelectedItems[0];
                return itemSelezionato.Tag as Socio;
            }

            return null;
        }

        private void listViewSoci_SelectedIndexChanged(object sender, EventArgs e)
        {
            SocioSelezionato = GetSocioSelezionato();
            if (SocioSelezionato != null)
            {
                if (SocioSelezionato.Id == 0)
                {
                    MessageBox.Show("Non è possibile eliminare l'utente admin.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SocioSelezionato = null;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Sei sicuro di voler eliminare il socio selezionato?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
           
        }
    }
}
