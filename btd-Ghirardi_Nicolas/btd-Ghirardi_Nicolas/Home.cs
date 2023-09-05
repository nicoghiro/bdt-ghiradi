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
    public partial class Home : Form
    {
        BTD banca;
        public Home()
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
            inizializeZone(banca.zone);
            cmbFiltro.Text = "Tutti i Soci";
            filtra();



        }
        public void inizializeZone(List<string> zone)
        {
            cmbzona.Items.Clear();
            cmbzona.Items.Add("Tutte le zone");
            cmbzona.Items.AddRange(zone.ToArray());
            cmbzona.SelectedIndex = 0;
        }
        public void popola(List<Socio> soci)
        {
            listViewSoci.Clear();
            listViewSoci.Columns.Add("ID", 0);
            listViewSoci.Columns.Add("Cognome", 100);
            listViewSoci.Columns.Add("Nome", 100);
            listViewSoci.Columns.Add("Telefono", 100); 
            listViewSoci.Columns.Add("ore", 40);
            listViewSoci.Columns.Add("segreteria", 150);
            listViewSoci.Columns.Add("zona", 150);
           
            foreach (Socio socio in soci)
            {
                ListViewItem item = new ListViewItem(new string[] {socio.Id.ToString(),socio.Cognome,socio.Nome,socio.Telefono,Convert.ToString(socio.ore),socio.FaParteSegreteria ? "Sì" : "No" ,socio.Zona });
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
                    eliminaSocio.Show();
                    Categorie.Show();
                    button1.Show();
                    btnPrestazioniAltri.Show();
                    GestZone.Show();
                }
                else
                {
                    GestZone.Hide();
                    btnAggiungiSocio.Hide();
                    modificaSoci.Hide();
                    eliminaSocio.Hide();
                    Categorie.Hide();
                    button1.Show();
                    btnPrestazioniAltri.Show();
                }
            }
            else
            {
                GestZone.Hide();
                btnAggiungiSocio.Hide();
                modificaSoci.Hide();
                eliminaSocio.Hide();
                Categorie.Hide();
                button1.Hide();
                btnPrestazioniAltri.Hide();
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
            SalvaDatiSuFile("dati.json");
        }
        private void CaricaDatiDaFile(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                banca = JsonConvert.DeserializeObject<BTD>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il caricamento dei dati: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SalvaDatiSuFile(string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(banca,Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il salvataggio dei dati: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAggiungiSocio_Click_1(object sender, EventArgs e)
        {
            using (FormAggiungiSocio formAggiungiSocio = new FormAggiungiSocio(banca))
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
            using (FormModificaSocio formModifica = new FormModificaSocio(banca.Soci,banca))
            {
                if (formModifica.ShowDialog() == DialogResult.OK)
                {
                    Socio Modificato = formModifica.GetModificato();
                    int index = banca.Soci.BinarySearch(Modificato);
                    if (index >= 0)
                    {
                        banca.Soci[index] = Modificato;
                        popola(banca.Soci);
                    }
                }
            }
        }

        private void eliminaSocio_Click(object sender, EventArgs e)
        {

            using (EliminaSocio formEliminaSocio = new EliminaSocio(banca.Soci))
            {
                if (formEliminaSocio.ShowDialog() == DialogResult.OK)
                {
                    Socio socioDaEliminare = formEliminaSocio.SocioSelezionato;
                    if (socioDaEliminare != null)
                    {
                        banca.Soci.Remove(socioDaEliminare);
                        popola(banca.Soci);
                    }
                }
            }

        }

        private void Categorie_Click(object sender, EventArgs e)
        {
            using (GestioneCategorie formGestioneCategorie = new GestioneCategorie(banca))
            {
                formGestioneCategorie.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisualizzaPrestazioni visualizzaPrestazioniForm = new VisualizzaPrestazioni(banca, GetSocioSelezionato());
            visualizzaPrestazioniForm.Show();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtra();
        }
        private void filtra()
        {
            string filtro = cmbFiltro.Text;
            List<Socio> filtrati = new List<Socio>();
            filtrati = banca.Soci;
           

            if (filtro == "Tutti i Soci")
            {
                filtrati = banca.Soci;
            }
            else if (filtro == "Indebitati")
            {
                filtrati = banca.Soci.Where(socio => socio.ore < 0).ToList();

            }
            else if (filtro == "Num. ore decrescente")
            {
                filtrati = banca.Soci.OrderByDescending(socio => socio.ore).ToList();

            }
            else if (filtro == "Num. ore crescente")
            {
                filtrati = banca.Soci.OrderBy(socio => socio.ore).ToList();

            }
            else if (filtro == "Segretari")
            {
                filtrati = banca.Soci.Where(socio => socio.FaParteSegreteria == true).ToList();

            }
            if (cmbzona.Text != "Tutte le zone")
            { 
                filtrati = filtrati.Where(socio => socio.Zona == cmbzona.Text).ToList();
            }
            
           
            
            popola(filtrati);
        }

        private void btnPrestazioniAltri_Click(object sender, EventArgs e)
        {
            Socio utenteSelezionato = GetSocioSelezionato();

            if (utenteSelezionato != null)
            {
                VisualizzaPrestazioniAltri visualizzaPrestazioniAltriForm = new VisualizzaPrestazioniAltri(banca, utenteSelezionato);
                visualizzaPrestazioniAltriForm.ShowDialog();
                if (visualizzaPrestazioniAltriForm.ShowDialog() == DialogResult.OK)
                {
                    popola(banca.Soci);
                }
            }
            else
            {
                MessageBox.Show("Seleziona un utente per visualizzare le sue prestazioni.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GestZone_Click(object sender, EventArgs e)
        {
            Zone zone=new Zone(banca);
            zone.ShowDialog();  
        }

        private void cmbzona_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtra();
        }

        private void btnStorico_Click(object sender, EventArgs e)
        {
            Storico st = new Storico(banca);
            st.ShowDialog();
        }
    }
}

