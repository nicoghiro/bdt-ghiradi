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
    public partial class Zone : Form
    {
        BTD banca;
        public Zone(BTD banca)
        {
            InitializeComponent();
            popola(banca.zone);
            this.banca = banca;
        }

        private void Zone_Load(object sender, EventArgs e)
        {

        }
        public void popola(List<string> zone)
        {
            cmbZona.Items.Clear();
            cmbZona.Items.AddRange(zone.ToArray());
            cmbZona.SelectedIndex = 0;
        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            string nuova=txtZona.Text;
            if (string.IsNullOrEmpty(nuova))
            {
                MessageBox.Show("inserire del testo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try { 
            banca.Contiene(nuova);
            banca.zone.Add(nuova);
            MessageBox.Show("Zona inserita con successo","Aggiunta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            popola(banca.zone);
            }
            catch(Exception )
            {
                MessageBox.Show("Zona gia presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtZona.Text = cmbZona.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nuova = txtZona.Text;
            if (string.IsNullOrEmpty(nuova))
            {
                MessageBox.Show("inserire del testo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                banca.Contiene(nuova);
                banca.zone.Remove(cmbZona.Text);
                banca.zone.Add(nuova);
                MessageBox.Show("Zona modificata con successo", "Aggiunta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popola(banca.zone);
            }
            catch (Exception)
            {
                MessageBox.Show("Zona gia presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Sei sicuro di voler eliminare questa zona?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                banca.zone.Remove(cmbZona.Text);
                MessageBox.Show("Zona eliminata con successo", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popola(banca.zone);
            }

        }
        
    }
}
