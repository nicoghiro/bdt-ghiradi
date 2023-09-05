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
    public partial class Storico : Form
    {
        private BTD banca;
        public Storico(BTD banca)
        {
            this.banca = banca;
            InitializeComponent();
            InitializeListViewColumns();
        }
        private void InitializeListViewColumns()
        {
            lstPrestazioniAltri.Columns.Add("Categoria", 150);
            lstPrestazioniAltri.Columns.Add("Lavoro", 200);
            lstPrestazioniAltri.Columns.Add("Ore", 50);
            lstPrestazioniAltri.Columns.Add("Richiedente", 150);
            lstPrestazioniAltri.Columns.Add("Datore", 150);
            lstPrestazioniAltri.Columns.Add("zona", 150);
            lstPrestazioniAltri.Columns.Add("data crezione", 150);
        }
        private void Storico_Load(object sender, EventArgs e)
        {
            lstPrestazioniAltri.FullRowSelect = true;
            cmbFiltro.SelectedIndex = 0;
            cmbCategoriaFiltro.Items.AddRange(banca.CategoriePrestazioni.ToArray());
            cmbZona.Items.AddRange(banca.zone.ToArray());
            cmbCategoriaFiltro.SelectedItem = "Tutte le Categorie";
            cmbFiltro.SelectedItem = "Tutte le Prestazioni";
            cmbZona.SelectedItem = "Tutte le zone";
            ApplyFilters();
        }
        private void PopolaPrestazioniFiltrate(List<Prestazioni> prestazioni)
        {
            lstPrestazioniAltri.Items.Clear();

            foreach (Prestazioni prestazione in prestazioni)
            {
               
                    string nomeRichiedente = NomeRichiedente(prestazione);
                    string nomeDatore = NomeDatore(prestazione);

                    var listItem = new ListViewItem(new[] { prestazione.Categoria, prestazione.Lavoro, prestazione.Ore.ToString(), nomeRichiedente, nomeDatore, prestazione.Zona, prestazione.Creazione.ToString() });
                    listItem.Tag = prestazione;
                    lstPrestazioniAltri.Items.Add(listItem);
                
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
            else if (filtro == "Recenza")
            {
                prestazioniFiltrate = prestazioniFiltrate.OrderByDescending(p => p.Creazione).ToList();
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
    }
}
