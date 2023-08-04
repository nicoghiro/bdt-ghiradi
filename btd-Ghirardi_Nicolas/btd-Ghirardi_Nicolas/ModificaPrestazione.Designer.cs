namespace btd_Ghirardi_Nicolas
{
    partial class ModificaPrestazione
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
            this.txtLavoro = new System.Windows.Forms.TextBox();
            this.numOre = new System.Windows.Forms.NumericUpDown();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLavoro
            // 
            this.txtLavoro.Location = new System.Drawing.Point(36, 93);
            this.txtLavoro.Name = "txtLavoro";
            this.txtLavoro.Size = new System.Drawing.Size(278, 22);
            this.txtLavoro.TabIndex = 1;
            // 
            // numOre
            // 
            this.numOre.Location = new System.Drawing.Point(189, 47);
            this.numOre.Name = "numOre";
            this.numOre.Size = new System.Drawing.Size(125, 22);
            this.numOre.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(33, 47);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(125, 24);
            this.cmbCategoria.TabIndex = 3;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(33, 137);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(134, 46);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ore emesse";
            // 
            // ModificaPrestazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.numOre);
            this.Controls.Add(this.txtLavoro);
            this.Name = "ModificaPrestazione";
            this.Text = "Ore emesse";
            this.Load += new System.EventHandler(this.ModificaPrestazione_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLavoro;
        private System.Windows.Forms.NumericUpDown numOre;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}