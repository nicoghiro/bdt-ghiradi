namespace btd_Ghirardi_Nicolas
{
    partial class Zone
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
            this.label = new System.Windows.Forms.Label();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.Aggiungi = new System.Windows.Forms.Button();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(26, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 16);
            this.label.TabIndex = 12;
            this.label.Text = "Zona";
            // 
            // cmbZona
            // 
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(29, 55);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(121, 24);
            this.cmbZona.TabIndex = 11;
            this.cmbZona.SelectedIndexChanged += new System.EventHandler(this.cmbZona_SelectedIndexChanged);
            // 
            // Aggiungi
            // 
            this.Aggiungi.Location = new System.Drawing.Point(29, 149);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(92, 30);
            this.Aggiungi.TabIndex = 13;
            this.Aggiungi.Text = "Aggiungi";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // txtZona
            // 
            this.txtZona.Location = new System.Drawing.Point(29, 105);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(100, 22);
            this.txtZona.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Modifica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(264, 149);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(92, 30);
            this.btnElimina.TabIndex = 16;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // Zone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 264);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cmbZona);
            this.Name = "Zone";
            this.Text = "Zone";
            this.Load += new System.EventHandler(this.Zone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Button Aggiungi;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnElimina;
    }
}