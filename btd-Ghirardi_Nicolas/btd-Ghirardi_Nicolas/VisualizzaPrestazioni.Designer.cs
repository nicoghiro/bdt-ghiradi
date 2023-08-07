namespace btd_Ghirardi_Nicolas
{
    partial class VisualizzaPrestazioni
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
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAttivita = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCategoriaFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminaPrestazione = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Tutte le Prestazioni",
            "Non Occupate",
            "Per Ore (decrescente)"});
            this.cmbFiltro.Location = new System.Drawing.Point(27, 65);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 0;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro Visualizzazzione";
            // 
            // lstAttivita
            // 
            this.lstAttivita.HideSelection = false;
            this.lstAttivita.Location = new System.Drawing.Point(293, 46);
            this.lstAttivita.MultiSelect = false;
            this.lstAttivita.Name = "lstAttivita";
            this.lstAttivita.Size = new System.Drawing.Size(478, 341);
            this.lstAttivita.TabIndex = 2;
            this.lstAttivita.UseCompatibleStateImageBehavior = false;
            this.lstAttivita.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aggiungi prestazione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCategoriaFiltro
            // 
            this.cmbCategoriaFiltro.FormattingEnabled = true;
            this.cmbCategoriaFiltro.Items.AddRange(new object[] {
            "Tutte le Categorie"});
            this.cmbCategoriaFiltro.Location = new System.Drawing.Point(27, 121);
            this.cmbCategoriaFiltro.Name = "cmbCategoriaFiltro";
            this.cmbCategoriaFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoriaFiltro.TabIndex = 4;
            this.cmbCategoriaFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro Categoria";
            // 
            // btnEliminaPrestazione
            // 
            this.btnEliminaPrestazione.Location = new System.Drawing.Point(27, 203);
            this.btnEliminaPrestazione.Name = "btnEliminaPrestazione";
            this.btnEliminaPrestazione.Size = new System.Drawing.Size(134, 46);
            this.btnEliminaPrestazione.TabIndex = 6;
            this.btnEliminaPrestazione.Text = "elimina";
            this.btnEliminaPrestazione.UseVisualStyleBackColor = true;
            this.btnEliminaPrestazione.Click += new System.EventHandler(this.btnEliminaPrestazione_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(27, 255);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(134, 46);
            this.btnModifica.TabIndex = 7;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // VisualizzaPrestazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnEliminaPrestazione);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoriaFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstAttivita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Name = "VisualizzaPrestazioni";
            this.Text = "VisualizzaPrestazioni";
            this.Load += new System.EventHandler(this.VisualizzaPrestazioni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstAttivita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCategoriaFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminaPrestazione;
        private System.Windows.Forms.Button btnModifica;
    }
}