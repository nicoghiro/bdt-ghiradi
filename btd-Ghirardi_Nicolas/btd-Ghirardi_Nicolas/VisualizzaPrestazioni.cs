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
        }

        private void InitializeListViewColumns()
        {
            lstAttivita.Columns.Add("Categoria", 150);
            lstAttivita.Columns.Add("Lavoro", 200);
            lstAttivita.Columns.Add("Telefono", 100);
            lstAttivita.Columns.Add("Stato", 100);
        }

     
        private void PopulateAttivita(List<Prestazioni> attivita)
        {
            lstAttivita.Items.Clear();

            foreach (Prestazioni prestazione in attivita)
            {
                var listItem = new ListViewItem(new[] { prestazione.Categoria, prestazione.Lavoro, prestazione.Ore.ToString(), prestazione.Occupato ? "Occupata" : "Libera" });
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

        private void cmbFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string filtro = cmbFiltro.Text;

            if (filtro == "Non Occupate")
            {
                List<Prestazioni> attivitaNonOccupate = socio.GetPrestazioni(banca.Pres).Where(p => !p.Occupato).ToList();
                PopulateAttivita(attivitaNonOccupate);
            }
            else if (filtro == "Per Ore (decrescente)")
            {
                List<Prestazioni> attivitaOrdinatePerOre = socio.GetPrestazioni(banca.Pres).OrderByDescending(p => p.Ore).ToList();
                PopulateAttivita(attivitaOrdinatePerOre);
            }
            else
            {
                PopulateAttivita(socio.GetPrestazioni(banca.Pres));
            }
        }

        private void cmbCategoriaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaFiltro = cmbCategoriaFiltro.Text;

            if (categoriaFiltro == "Tutte le Categorie")
            {
                PopulateAttivita(socio.GetPrestazioni(banca.Pres));
            }
            else
            {
                List<Prestazioni> attivitaPerCategoria = socio.GetPrestazioni(banca.Pres).Where(p => p.Categoria == categoriaFiltro).ToList();
                PopulateAttivita(attivitaPerCategoria);
            }
        }
    }
}
