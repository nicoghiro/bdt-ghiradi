namespace btd_Ghirardi_Nicolas
{
    partial class GestioneCategorie
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
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.textBoxNuovaCategoria = new System.Windows.Forms.TextBox();
            this.modifica = new System.Windows.Forms.Button();
            this.elimina = new System.Windows.Forms.Button();
            this.aggiungi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(35, 77);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategorie.TabIndex = 0;
            // 
            // textBoxNuovaCategoria
            // 
            this.textBoxNuovaCategoria.Location = new System.Drawing.Point(35, 134);
            this.textBoxNuovaCategoria.Name = "textBoxNuovaCategoria";
            this.textBoxNuovaCategoria.Size = new System.Drawing.Size(237, 22);
            this.textBoxNuovaCategoria.TabIndex = 1;
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(111, 162);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(75, 23);
            this.modifica.TabIndex = 2;
            this.modifica.Text = "modifica";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // elimina
            // 
            this.elimina.Location = new System.Drawing.Point(192, 162);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(75, 23);
            this.elimina.TabIndex = 3;
            this.elimina.Text = "elimina";
            this.elimina.UseVisualStyleBackColor = true;
            this.elimina.Click += new System.EventHandler(this.elimina_Click);
            // 
            // aggiungi
            // 
            this.aggiungi.Location = new System.Drawing.Point(35, 162);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(75, 23);
            this.aggiungi.TabIndex = 4;
            this.aggiungi.Text = "aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Esistenti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nuova";
            // 
            // GestioneCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.elimina);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.textBoxNuovaCategoria);
            this.Controls.Add(this.comboBoxCategorie);
            this.Name = "GestioneCategorie";
            this.Text = "GestioneCategorie";
            this.Load += new System.EventHandler(this.GestioneCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.TextBox textBoxNuovaCategoria;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.Button elimina;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}