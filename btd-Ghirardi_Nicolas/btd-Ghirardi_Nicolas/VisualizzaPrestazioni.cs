using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btd_Ghirardi_Nicolas
{
    public partial class VisualizzaPrestazioni : Form
    {
        private BTD banca;
        private Socio socio;

        public VisualizzaPrestazioni(BTD banca, Socio socio)
        {
            InitializeComponent();
            this.banca = banca;
            this.socio = socio;
            InitializeListViewColumns();
            PopulateAttivita(socio.GetPrestazioni(banca.Pres)); 
        }

        private void VisualizzaPrestazioni_Load(object sender, EventArgs e)
        {
            lstAttivita.FullRowSelect = true;
            cmbFiltro.SelectedIndex = 0;
            cmbCategoriaFiltro.Items.AddRange(banca.CategoriePrestazioni.ToArray());
            cmbCategoriaFiltro.SelectedItem = "Tutte le Categorie";
            cmbFiltro.SelectedItem = "Tutte le Prestazioni";
        }

        private void InitializeListViewColumns()
        {
            lstAttivita.Columns.Add("Categoria", 150);
            lstAttivita.Columns.Add("Lavoro", 200);
            lstAttivita.Columns.Add("Ore", 100);
            lstAttivita.Columns.Add("Stato", 100);
            lstAttivita.Columns.Add("Zona", 100);
        }

     
        private void PopulateAttivita(List<Prestazioni> attivita)
        {
            lstAttivita.Items.Clear();

            foreach (Prestazioni prestazione in attivita)
            {
                var listItem = new ListViewItem(new[] { prestazione.Categoria, prestazione.Lavoro, prestazione.Ore.ToString(), prestazione.Occupato ? "Occupata" : "Libera",prestazione.Zona });
                listItem.Tag = prestazione;
                lstAttivita.Items.Add(listItem);
            }

            lstAttivita.Refresh(); 
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AggiungiPrestazione formAggiungiPrestazione = new AggiungiPrestazione(banca,socio, banca.CategoriePrestazioni))
            {
                DialogResult result = formAggiungiPrestazione.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PopulateAttivita(socio.GetPrestazioni(banca.Pres));
                }
            }
        }

        

       

        private void btnEliminaPrestazione_Click(object sender, EventArgs e)
        {
            if (lstAttivita.SelectedItems.Count > 0)
            {
                Prestazioni prestazioneSelezionata = lstAttivita.SelectedItems[0].Tag as Prestazioni;

                if (prestazioneSelezionata != null)
                {
                    if (prestazioneSelezionata.Occupato)
                    {
                        MessageBox.Show("Questa prestazione è già occupata e non può essere eliminata.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Sei sicuro di voler eliminare questa prestazione?", "Conferma Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            banca.EliminaPrestazione(prestazioneSelezionata.IdDatore);
                            PopulateAttivita(socio.GetPrestazioni(banca.Pres));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleziona una prestazione da eliminare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ApplyFilters()
        {
            string filtro = cmbFiltro.Text;
            string categoriaFiltro = cmbCategoriaFiltro.Text;

            List<Prestazioni> attivitaFiltrate = socio.GetPrestazioni(banca.Pres);

            if (filtro == "Non Occupate")
            {
                attivitaFiltrate = attivitaFiltrate.Where(p => !p.Occupato).ToList();
            }
            else if (filtro == "Per Ore (decrescente)")
            {
                attivitaFiltrate = attivitaFiltrate.OrderByDescending(p => p.Ore).ToList();
            }

            if (categoriaFiltro != "Tutte le Categorie")
            {
                attivitaFiltrate = attivitaFiltrate.Where(p => p.Categoria == categoriaFiltro).ToList();
            }

            PopulateAttivita(attivitaFiltrate);
        }

        private void cmbFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbCategoriaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }


        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lstAttivita.SelectedItems.Count > 0)
            {
                Prestazioni prestazioneSelezionata = lstAttivita.SelectedItems[0].Tag as Prestazioni;

                if (prestazioneSelezionata != null)
                {
                    if (prestazioneSelezionata.Occupato)
                    {
                        MessageBox.Show("Questa prestazione è già occupata e non può essere modificata.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        using (ModificaPrestazione formModificaPrestazione = new ModificaPrestazione(prestazioneSelezionata, banca, socio))
                        {
                            if (formModificaPrestazione.ShowDialog() == DialogResult.OK)
                            {
                                PopulateAttivita(socio.GetPrestazioni(banca.Pres));
                                
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleziona una prestazione da modificare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
