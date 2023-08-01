namespace btd_Ghirardi_Nicolas
{
    partial class FormModificaSocio
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
            this.listViewSoci = new System.Windows.Forms.ListView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.chkSegreteria = new System.Windows.Forms.CheckBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numOre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewSoci
            // 
            this.listViewSoci.HideSelection = false;
            this.listViewSoci.Location = new System.Drawing.Point(302, 77);
            this.listViewSoci.MultiSelect = false;
            this.listViewSoci.Name = "listViewSoci";
            this.listViewSoci.Size = new System.Drawing.Size(505, 295);
            this.listViewSoci.TabIndex = 1;
            this.listViewSoci.UseCompatibleStateImageBehavior = false;
            this.listViewSoci.View = System.Windows.Forms.View.Details;
            this.listViewSoci.SelectedIndexChanged += new System.EventHandler(this.listViewSoci_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(139, 22);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(70, 165);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(139, 22);
            this.txtCognome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(70, 221);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // chkSegreteria
            // 
            this.chkSegreteria.AutoSize = true;
            this.chkSegreteria.Location = new System.Drawing.Point(70, 302);
            this.chkSegreteria.Name = "chkSegreteria";
            this.chkSegreteria.Size = new System.Drawing.Size(92, 20);
            this.chkSegreteria.TabIndex = 8;
            this.chkSegreteria.Text = "Segreteria";
            this.chkSegreteria.UseVisualStyleBackColor = true;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(70, 340);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 9;
            this.btnConferma.Text = "conferma ";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(151, 340);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 10;
            this.btnAnnulla.Text = "annulla ";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 274);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 11;
            // 
            // numOre
            // 
            this.numOre.AutoSize = true;
            this.numOre.Location = new System.Drawing.Point(67, 255);
            this.numOre.Name = "numOre";
            this.numOre.Size = new System.Drawing.Size(29, 16);
            this.numOre.TabIndex = 12;
            this.numOre.Text = "Ore";
            // 
            // FormModificaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 445);
            this.Controls.Add(this.numOre);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.chkSegreteria);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.listViewSoci);
            this.Name = "FormModificaSocio";
            this.Text = "FormModificaSocio";
            this.Load += new System.EventHandler(this.FormModificaSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSoci;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox chkSegreteria;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label numOre;
    }
}