namespace btd_Ghirardi_Nicolas
{
    partial class VisualizzaPrestazioniAltri
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoriaFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.btnOccupare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPrestazioniAltri
            // 
            this.lstPrestazioniAltri.HideSelection = false;
            this.lstPrestazioniAltri.Location = new System.Drawing.Point(256, 63);
            this.lstPrestazioniAltri.MultiSelect = false;
            this.lstPrestazioniAltri.Name = "lstPrestazioniAltri";
            this.lstPrestazioniAltri.Size = new System.Drawing.Size(478, 341);
            this.lstPrestazioniAltri.TabIndex = 3;
            this.lstPrestazioniAltri.UseCompatibleStateImageBehavior = false;
            this.lstPrestazioniAltri.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtro Categoria";
            // 
            // cmbCategoriaFiltro
            // 
            this.cmbCategoriaFiltro.FormattingEnabled = true;
            this.cmbCategoriaFiltro.Items.AddRange(new object[] {
            "Tutte le Categorie"});
            this.cmbCategoriaFiltro.Location = new System.Drawing.Point(38, 138);
            this.cmbCategoriaFiltro.Name = "cmbCategoriaFiltro";
            this.cmbCategoriaFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoriaFiltro.TabIndex = 8;
            this.cmbCategoriaFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaFiltro_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro Visualizzazzione";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Tutte le Prestazioni",
            "Non Occupate",
            "Per Ore (decrescente)"});
            this.cmbFiltro.Location = new System.Drawing.Point(38, 82);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 6;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged_1);
            // 
            // btnOccupare
            // 
            this.btnOccupare.Location = new System.Drawing.Point(38, 179);
            this.btnOccupare.Name = "btnOccupare";
            this.btnOccupare.Size = new System.Drawing.Size(121, 34);
            this.btnOccupare.TabIndex = 10;
            this.btnOccupare.Text = "occupa";
            this.btnOccupare.UseVisualStyleBackColor = true;
            this.btnOccupare.Click += new System.EventHandler(this.btnOccupare_Click);
            // 
            // VisualizzaPrestazioniAltri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOccupare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoriaFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.lstPrestazioniAltri);
            this.Name = "VisualizzaPrestazioniAltri";
            this.Text = "VisualizzaPrestazioniAltri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisualizzaPrestazioniAltri_FormClosing);
            this.Load += new System.EventHandler(this.VisualizzaPrestazioniAltri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPrestazioniAltri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoriaFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnOccupare;
    }
}