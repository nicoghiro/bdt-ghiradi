namespace btd_Ghirardi_Nicolas
{
    partial class FormAggiungiSocio
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.chkSegreteria = new System.Windows.Forms.CheckBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(139, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(56, 126);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(139, 22);
            this.txtCognome.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(56, 177);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 22);
            this.txtTelefono.TabIndex = 2;
            // 
            // chkSegreteria
            // 
            this.chkSegreteria.AutoSize = true;
            this.chkSegreteria.Location = new System.Drawing.Point(56, 225);
            this.chkSegreteria.Name = "chkSegreteria";
            this.chkSegreteria.Size = new System.Drawing.Size(92, 20);
            this.chkSegreteria.TabIndex = 3;
            this.chkSegreteria.Text = "Segreteria";
            this.chkSegreteria.UseVisualStyleBackColor = true;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(310, 80);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 4;
            this.btnConferma.Text = "conferma ";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click_1);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(310, 135);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 5;
            this.btnAnnulla.Text = "annulla ";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click_1);
            // 
            // FormAggiungiSocio
            // 
            this.ClientSize = new System.Drawing.Size(499, 424);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.chkSegreteria);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Name = "FormAggiungiSocio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox chkSegreteria;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
    }
}