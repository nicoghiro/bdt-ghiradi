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
    public partial class VisualizzaPrestazioni : Form
    {
            private BTD banca;
            private Socio socio;
            public VisualizzaPrestazioni(BTD banca, Socio socio)
            {
                InitializeComponent();
                this.banca = banca;
                this.socio = socio;
                PopulateAttivita(socio.Pres);
            }

        private void VisualizzaPrestazioni_Load(object sender, EventArgs e)
        {
            lstAttivita.FullRowSelect=true;
            lstAttivita.Columns.Add("Categoria", 150);
            lstAttivita.Columns.Add("Lavoro", 200);
            lstAttivita.Columns.Add("Ore", 100);
            lstAttivita.Columns.Add("Stato", 100);
        }
       private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
         {
                string filtro = cmbFiltro.Text;

                if (filtro == "Non Occupate")
                {
                    var attivitaNonOccupate = socio.Pres.Where(p => !p.occupato).ToList();
                    PopulateAttivita(attivitaNonOccupate);
                }
                else if (filtro == "Per Ore (decrescente)")
                {
                    var attivitaOrdinatePerOre = socio.Pres.OrderByDescending(p => p.ore).ToList();
                    PopulateAttivita(attivitaOrdinatePerOre);
                }
                else
                {
                    PopulateAttivita(socio.Pres);
                }
        }

            private void PopulateAttivita(List<Prestazioni> attivita)
            {
                lstAttivita.Items.Clear();
           

            foreach (var prestazione in attivita)
                {
                    var listItem = new ListViewItem(new[] { prestazione.Categoria, prestazione.lavoro, prestazione.ore.ToString(), prestazione.occupato ? "Occupata" : "Libera" });
                    listItem.Tag = prestazione;
                    lstAttivita.Items.Add(listItem);
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AggiungiPrestazione formAggiungiAttivita = new AggiungiPrestazione(socio,banca.CategoriePrestazioni))
            {
                DialogResult result = formAggiungiAttivita.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PopulateAttivita(socio.Pres);
                }
            }
        }
    }
    }



