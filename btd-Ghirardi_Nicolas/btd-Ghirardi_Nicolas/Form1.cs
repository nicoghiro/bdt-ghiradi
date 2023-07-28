using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace btd_Ghirardi_Nicolas
{
    public partial class Form1 : Form
    {
        BTD banca;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
            banca = new BTD();
            CaricaDatiDaFile("dati.json");
            popola(banca.Soci);
            listViewSoci.FullRowSelect = true;

        }
        public void popola(List<Socio> soci)
        {
            listViewSoci.Clear();
            listViewSoci.Columns.Add("ID", 0);
            listViewSoci.Columns.Add("Cognome", 100);
            listViewSoci.Columns.Add("Nome", 100);
            listViewSoci.Columns.Add("Telefono", 100);
            listViewSoci.Columns.Add("segreteria", 150);
            foreach (Socio socio in soci)
            {
                ListViewItem item = new ListViewItem(new string[] {
            socio.Id.ToString(),
            socio.Cognome,
            socio.Nome,
            socio.Telefono,
            socio.FaParteSegreteria ? "Sì" : "No"
        });
                item.Tag = socio;
                listViewSoci.Items.Add(item);
            }
        }

        private void listViewSoci_SelectedIndexChanged(object sender, EventArgs e)
        {
            Socio selezionato = GetSocioSelezionato();
            if (selezionato != null)
            {
                if (selezionato.FaParteSegreteria)
                {
                    btnAggiungiSocio.Show();
                    modificaSoci.Show();
                }
                else
                {
                    btnAggiungiSocio.Hide();
                    modificaSoci.Hide();
                }
            }
            else
            {
                btnAggiungiSocio.Hide();
                modificaSoci.Hide();
            }

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
       


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            banca.SalvaDatiSuFile("dati.json");
        }
        private void CaricaDatiDaFile(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<Socio> soci = JsonConvert.DeserializeObject<List<Socio>>(json);
                banca.Soci.AddRange(soci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il caricamento dei dati: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        private void btnAggiungiSocio_Click_1(object sender, EventArgs e)
        {
            using (FormAggiungiSocio formAggiungiSocio = new FormAggiungiSocio())
            {
                if (formAggiungiSocio.ShowDialog() == DialogResult.OK)
                {
                    
                    Socio nuovoSocio = formAggiungiSocio.GetNuovoSocio();
                    banca.AggiungiSocio(nuovoSocio);
                    popola(banca.Soci);
                }
            }
        }

        private void modificaSoci_Click(object sender, EventArgs e)
        {
            using (FormModificaSocio formModifica = new FormModificaSocio(banca.Soci))
            {
                if (formModifica.ShowDialog() == DialogResult.OK)
                {

                    Socio Modificato = formModifica.GetModificato();
                    MessageBox.Show(Modificato.ToString());
                    Socio oggettoDaSostituire = banca.Soci.FirstOrDefault(s => s.Id == Modificato.Id);

                    if (oggettoDaSostituire != null)
                    {
                        int indiceDaSostituire = banca.Soci.IndexOf(oggettoDaSostituire);
                        banca.Soci[indiceDaSostituire] = Modificato;
                        popola(banca.Soci); // Potrebbe non essere necessario aggiornare nuovamente la ListView, dipende dal resto del codice.
                    }
                }
                }
            }
        }
    }

