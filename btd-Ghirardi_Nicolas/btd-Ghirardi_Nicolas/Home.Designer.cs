namespace btd_Ghirardi_Nicolas
{
    partial class Home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewSoci = new System.Windows.Forms.ListView();
            this.btnAggiungiSocio = new System.Windows.Forms.Button();
            this.modificaSoci = new System.Windows.Forms.Button();
            this.eliminaSocio = new System.Windows.Forms.Button();
            this.Categorie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.btnPrestazioniAltri = new System.Windows.Forms.Button();
            this.GestZone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbzona = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewSoci
            // 
            this.listViewSoci.HideSelection = false;
            this.listViewSoci.Location = new System.Drawing.Point(294, 85);
            this.listViewSoci.MultiSelect = false;
            this.listViewSoci.Name = "listViewSoci";
            this.listViewSoci.Size = new System.Drawing.Size(637, 361);
            this.listViewSoci.TabIndex = 0;
            this.listViewSoci.UseCompatibleStateImageBehavior = false;
            this.listViewSoci.View = System.Windows.Forms.View.Details;
            this.listViewSoci.SelectedIndexChanged += new System.EventHandler(this.listViewSoci_SelectedIndexChanged);
            // 
            // btnAggiungiSocio
            // 
            this.btnAggiungiSocio.Location = new System.Drawing.Point(69, 85);
            this.btnAggiungiSocio.Name = "btnAggiungiSocio";
            this.btnAggiungiSocio.Size = new System.Drawing.Size(127, 32);
            this.btnAggiungiSocio.TabIndex = 1;
            this.btnAggiungiSocio.Text = "Aggiungi soci";
            this.btnAggiungiSocio.UseVisualStyleBackColor = true;
            this.btnAggiungiSocio.Visible = false;
            this.btnAggiungiSocio.Click += new System.EventHandler(this.btnAggiungiSocio_Click_1);
            // 
            // modificaSoci
            // 
            this.modificaSoci.Location = new System.Drawing.Point(69, 123);
            this.modificaSoci.Name = "modificaSoci";
            this.modificaSoci.Size = new System.Drawing.Size(127, 33);
            this.modificaSoci.TabIndex = 2;
            this.modificaSoci.Text = "Modifica soci";
            this.modificaSoci.UseVisualStyleBackColor = true;
            this.modificaSoci.Visible = false;
            this.modificaSoci.Click += new System.EventHandler(this.modificaSoci_Click);
            // 
            // eliminaSocio
            // 
            this.eliminaSocio.Location = new System.Drawing.Point(69, 162);
            this.eliminaSocio.Name = "eliminaSocio";
            this.eliminaSocio.Size = new System.Drawing.Size(127, 36);
            this.eliminaSocio.TabIndex = 3;
            this.eliminaSocio.Text = "Elimina soci";
            this.eliminaSocio.UseVisualStyleBackColor = true;
            this.eliminaSocio.Visible = false;
            this.eliminaSocio.Click += new System.EventHandler(this.eliminaSocio_Click);
            // 
            // Categorie
            // 
            this.Categorie.Location = new System.Drawing.Point(69, 204);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(127, 35);
            this.Categorie.TabIndex = 4;
            this.Categorie.Text = "Categorie";
            this.Categorie.UseVisualStyleBackColor = true;
            this.Categorie.Visible = false;
            this.Categorie.Click += new System.EventHandler(this.Categorie_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Prestazioni utente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro Visualizzazzione";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Tutti i Soci",
            "Indebitati",
            "Num. ore decrescente",
            "Num. ore crescente",
            "Segretari"});
            this.cmbFiltro.Location = new System.Drawing.Point(308, 43);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 6;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // btnPrestazioniAltri
            // 
            this.btnPrestazioniAltri.Location = new System.Drawing.Point(69, 286);
            this.btnPrestazioniAltri.Name = "btnPrestazioniAltri";
            this.btnPrestazioniAltri.Size = new System.Drawing.Size(127, 35);
            this.btnPrestazioniAltri.TabIndex = 8;
            this.btnPrestazioniAltri.Text = "Prestazioni altrui";
            this.btnPrestazioniAltri.UseVisualStyleBackColor = true;
            this.btnPrestazioniAltri.Visible = false;
            this.btnPrestazioniAltri.Click += new System.EventHandler(this.btnPrestazioniAltri_Click);
            // 
            // GestZone
            // 
            this.GestZone.Location = new System.Drawing.Point(69, 327);
            this.GestZone.Name = "GestZone";
            this.GestZone.Size = new System.Drawing.Size(127, 35);
            this.GestZone.TabIndex = 9;
            this.GestZone.Text = "Gest. zone";
            this.GestZone.UseVisualStyleBackColor = true;
            this.GestZone.Visible = false;
            this.GestZone.Click += new System.EventHandler(this.GestZone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filtro zona";
            // 
            // cmbzona
            // 
            this.cmbzona.FormattingEnabled = true;
            this.cmbzona.Items.AddRange(new object[] {
            "Tutte le zone"});
            this.cmbzona.Location = new System.Drawing.Point(462, 43);
            this.cmbzona.Name = "cmbzona";
            this.cmbzona.Size = new System.Drawing.Size(121, 24);
            this.cmbzona.TabIndex = 10;
            this.cmbzona.SelectedIndexChanged += new System.EventHandler(this.cmbzona_SelectedIndexChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbzona);
            this.Controls.Add(this.GestZone);
            this.Controls.Add(this.btnPrestazioniAltri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Categorie);
            this.Controls.Add(this.eliminaSocio);
            this.Controls.Add(this.modificaSoci);
            this.Controls.Add(this.btnAggiungiSocio);
            this.Controls.Add(this.listViewSoci);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSoci;
        private System.Windows.Forms.Button btnAggiungiSocio;
        private System.Windows.Forms.Button modificaSoci;
        private System.Windows.Forms.Button eliminaSocio;
        private System.Windows.Forms.Button Categorie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnPrestazioniAltri;
        private System.Windows.Forms.Button GestZone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbzona;
    }
}

