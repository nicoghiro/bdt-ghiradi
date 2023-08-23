using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btd_Ghirardi_Nicolas
{
    public partial class VisualizzaPrestazioniAltri : Form
    {
        private BTD banca;
        private Socio utenteSelezionato;

        public VisualizzaPrestazioniAltri(BTD banca, Socio utenteSelezionato)
        {
            InitializeComponent();
            this.banca = banca;
            this.utenteSelezionato = utenteSelezionato;
            InitializeListViewColumns();
           
        }

        private void VisualizzaPrestazioniAltri_Load(object sender, EventArgs e)
        {
            lstPrestazioniAltri.FullRowSelect = true;
            cmbFiltro.SelectedIndex = 0;
            cmbCategoriaFiltro.Items.AddRange(banca.CategoriePrestazioni.ToArray());
            cmbZona.Items.AddRange(banca.zone.ToArray());
            cmbCategoriaFiltro.SelectedItem = "Tutte le Categorie";
            cmbFiltro.SelectedItem = "Tutte le Prestazioni";
            cmbZona.SelectedItem=utenteSelezionato.Zona;
            ApplyFilters();
        }

        private void InitializeListViewColumns()
        {
            lstPrestazioniAltri.Columns.Add("Categoria", 150);
            lstPrestazioniAltri.Columns.Add("Lavoro", 200);
            lstPrestazioniAltri.Columns.Add("Ore", 50);
            lstPrestazioniAltri.Columns.Add("Richiedente", 150);
            lstPrestazioniAltri.Columns.Add("Datore", 150);
            lstPrestazioniAltri.Columns.Add("zona", 150);
        }

        private void PopolaPrestazioniFiltrate(List<Prestazioni> prestazioni)
        {
            lstPrestazioniAltri.Items.Clear();

            foreach (Prestazioni prestazione in prestazioni)
            {
                if (prestazione.IdDatore != utenteSelezionato.Id)
                {
                    string nomeRichiedente = NomeRichiedente(prestazione);
                    string nomeDatore = NomeDatore(prestazione);

                    var listItem = new ListViewItem(new[] { prestazione.Categoria, prestazione.Lavoro, prestazione.Ore.ToString(), nomeRichiedente, nomeDatore,prestazione.Zona });
                    listItem.Tag = prestazione;
                    lstPrestazioniAltri.Items.Add(listItem);
                }
            }

            lstPrestazioniAltri.Refresh();
        }

        private string NomeRichiedente(Prestazioni prestazione)
        {
            Socio richiedente = banca.Soci.FirstOrDefault(s => s.Id == prestazione.IdRichiedente);
            return richiedente != null ? $"{richiedente.Cognome} {richiedente.Nome}" : "N/A";
        }

        private string NomeDatore(Prestazioni prestazione)
        {
            Socio datore = banca.Soci.FirstOrDefault(s => s.Id == prestazione.IdDatore);
            return datore != null ? $"{datore.Cognome} {datore.Nome}" : "N/A";
        }

    

        private void btnOccupare_Click(object sender, EventArgs e)
        {
            if (lstPrestazioniAltri.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstPrestazioniAltri.SelectedItems[0];
                Prestazioni prestazioneSelezionata = selectedItem.Tag as Prestazioni;

                if (prestazioneSelezionata != null && !prestazioneSelezionata.Occupato)
                {
                    Socio socioRichiedente = utenteSelezionato;

                    if (socioRichiedente != null  && socioRichiedente.ore-prestazioneSelezionata.Ore >= -25)
                    {
                        try
                        {
                            banca.Occupaprestazione(prestazioneSelezionata, socioRichiedente);
                            ApplyFilters(); 

                           

                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Il richiedente non ha abbastanza ore disponibili.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("L'attività selezionata è già occupata.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleziona un'attività da occupare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyFilters()
        {
            string filtro = cmbFiltro.Text;
            string categoriaFiltro = cmbCategoriaFiltro.Text;

            List<Prestazioni> prestazioniFiltrate = banca.Pres;

            if (filtro == "Tutte le Prestazioni")
            {
                
            }
            else if (filtro == "Non Occupate")
            {
                prestazioniFiltrate = prestazioniFiltrate.Where(p => !p.Occupato).ToList();
            }
            else if (filtro == "Per Ore (decrescente)")
            {
                prestazioniFiltrate = prestazioniFiltrate.OrderByDescending(p => p.Ore).ToList();
            }

            if (categoriaFiltro != "Tutte le Categorie")
            {
                prestazioniFiltrate = prestazioniFiltrate.Where(p => p.Categoria == categoriaFiltro).ToList();
            }
            if (cmbZona.Text != "Tutte le zone")
            {
                prestazioniFiltrate = prestazioniFiltrate.Where(socio => socio.Zona == cmbZona.Text).ToList();
            }


            PopolaPrestazioniFiltrate(prestazioniFiltrate);
        }

        private void cmbFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbCategoriaFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilters();
        }


        private void VisualizzaPrestazioniAltri_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult = DialogResult.OK;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }

}
