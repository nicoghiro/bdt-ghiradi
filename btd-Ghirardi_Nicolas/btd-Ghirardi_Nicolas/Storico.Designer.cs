namespace btd_Ghirardi_Nicolas
{
    partial class Storico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPrestazioniAltri = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoriaFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstPrestazioniAltri
            // 
            this.lstPrestazioniAltri.HideSelection = false;
            this.lstPrestazioniAltri.Location = new System.Drawing.Point(192, 32);
            this.lstPrestazioniAltri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPrestazioniAltri.MultiSelect = false;
            this.lstPrestazioniAltri.Name = "lstPrestazioniAltri";
            this.lstPrestazioniAltri.Size = new System.Drawing.Size(742, 301);
            this.lstPrestazioniAltri.TabIndex = 4;
            this.lstPrestazioniAltri.UseCompatibleStateImageBehavior = false;
            this.lstPrestazioniAltri.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Filtro Zona";
            // 
            // cmbZona
            // 
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Items.AddRange(new object[] {
            "Tutte le zone"});
            this.cmbZona.Location = new System.Drawing.Point(50, 211);
            this.cmbZona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(92, 21);
            this.cmbZona.TabIndex = 17;
            this.cmbZona.SelectedIndexChanged += new System.EventHandler(this.cmbZona_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filtro Categoria";
            // 
            // cmbCategoriaFiltro
            // 
            this.cmbCategoriaFiltro.FormattingEnabled = true;
            this.cmbCategoriaFiltro.Items.AddRange(new object[] {
            "Tutte le Categorie"});
            this.cmbCategoriaFiltro.Location = new System.Drawing.Point(50, 162);
            this.cmbCategoriaFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategoriaFiltro.Name = "cmbCategoriaFiltro";
            this.cmbCategoriaFiltro.Size = new System.Drawing.Size(92, 21);
            this.cmbCategoriaFiltro.TabIndex = 15;
            this.cmbCategoriaFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filtro Visualizzazzione";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Tutte le Prestazioni",
            "Non Occupate",
            "Per Ore (decrescente)",
            "Recenza"});
            this.cmbFiltro.Location = new System.Drawing.Point(50, 117);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(92, 21);
            this.cmbFiltro.TabIndex = 13;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // Storico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoriaFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.lstPrestazioniAltri);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Storico";
            this.Text = "Storico";
            this.Load += new System.EventHandler(this.Storico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPrestazioniAltri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoriaFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}