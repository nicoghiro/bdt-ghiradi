namespace btd_Ghirardi_Nicolas
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // listViewSoci
            // 
            this.listViewSoci.HideSelection = false;
            this.listViewSoci.Location = new System.Drawing.Point(579, 85);
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
            this.btnAggiungiSocio.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungiSocio.TabIndex = 1;
            this.btnAggiungiSocio.Text = "aggiungi soci";
            this.btnAggiungiSocio.UseVisualStyleBackColor = true;
            this.btnAggiungiSocio.Visible = false;
            this.btnAggiungiSocio.Click += new System.EventHandler(this.btnAggiungiSocio_Click_1);
            // 
            // modificaSoci
            // 
            this.modificaSoci.Location = new System.Drawing.Point(69, 123);
            this.modificaSoci.Name = "modificaSoci";
            this.modificaSoci.Size = new System.Drawing.Size(75, 23);
            this.modificaSoci.TabIndex = 2;
            this.modificaSoci.Text = "modifica";
            this.modificaSoci.UseVisualStyleBackColor = true;
            this.modificaSoci.Visible = false;
            this.modificaSoci.Click += new System.EventHandler(this.modificaSoci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 483);
            this.Controls.Add(this.modificaSoci);
            this.Controls.Add(this.btnAggiungiSocio);
            this.Controls.Add(this.listViewSoci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSoci;
        private System.Windows.Forms.Button btnAggiungiSocio;
        private System.Windows.Forms.Button modificaSoci;
    }
}

