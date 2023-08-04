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
            PopolaPrestazioniFiltrate(banca.Pres);
        }

        private void VisualizzaPrestazioniAltri_Load(object sender, EventArgs e)
        {
            lstPrestazioniAltri.FullRowSelect = true;
            cmbFiltro.SelectedIndex = 0;
            cmbCategoriaFiltro.Items.AddRange(banca.CategoriePrestazioni.ToArray());
            cmbCategoriaFiltro.SelectedItem = "Tutte le Categorie";
        }

        private void InitializeListViewColumns()
        {
            lstPrestazioniAltri.Columns.Add("Categoria", 150);
            lstPrestazioniAltri.Columns.Add("Lavoro", 200);
            lstPrestazioniAltri.Columns.Add("Ore", 50);
            lstPrestazioniAltri.Columns.Add("Richiedente", 150);
            lstPrestazioniAltri.Columns.Add("Datore", 150);
        }

        private void PopolaPrestazioniFiltrate(List<Prestazioni> prestazioni)
        {
            lstPrestazioniAltri.Items.Clear();

            foreach (Prestazioni prestazione in prestazioni)
            {
                if (prestazione.IdDatore != utenteSelezionato.Id && prestazione.IdRichiedente != utenteSelezionato.Id)
                {
                    string nomeRichiedente = NomeRichiedente(prestazione);
                    string nomeDatore = NomeDatore(prestazione);

                    var listItem = new ListViewItem(new[] { prestazione.Categoria, prestazione.Lavoro, prestazione.Ore.ToString(), nomeRichiedente, nomeDatore });
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
        private void cmbFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string filtro = cmbFiltro.Text;

            if (filtro == "Non Occupate")
            {
                List<Prestazioni> prestazioniNonOccupate = banca.Pres.Where(p => !p.Occupato).ToList();
                PopolaPrestazioniFiltrate(prestazioniNonOccupate);
            }
            else if (filtro == "Per Ore (decrescente)")
            {
                List<Prestazioni> prestazioniOrdinatePerOre = banca.Pres.OrderByDescending(p => p.Ore).ToList();
                PopolaPrestazioniFiltrate(prestazioniOrdinatePerOre);
            }
            else
            {
                PopolaPrestazioniFiltrate(banca.Pres);
            }
        }

        private void cmbCategoriaFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string categoriaFiltro = cmbCategoriaFiltro.Text;

            if (categoriaFiltro == "Tutte le Categorie")
            {
                PopolaPrestazioniFiltrate(banca.Pres);
            }
            else
            {
                List<Prestazioni> prestazioniPerCategoria = banca.Pres.Where(p => p.Categoria == categoriaFiltro).ToList();
                PopolaPrestazioniFiltrate(prestazioniPerCategoria);
            }
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

                    if (socioRichiedente != null && socioRichiedente.ore >= prestazioneSelezionata.Ore && socioRichiedente.ore >= -25)
                    {
                        try
                        {
                            banca.Occupaprestazione(prestazioneSelezionata, socioRichiedente);
                            PopolaPrestazioniFiltrate(banca.Pres);
                            
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
    }

}
