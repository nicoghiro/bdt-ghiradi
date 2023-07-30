namespace btd_Ghirardi_Nicolas
{
    partial class EliminaSocio
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
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSoci
            // 
            this.listViewSoci.HideSelection = false;
            this.listViewSoci.Location = new System.Drawing.Point(137, 76);
            this.listViewSoci.MultiSelect = false;
            this.listViewSoci.Name = "listViewSoci";
            this.listViewSoci.Size = new System.Drawing.Size(505, 295);
            this.listViewSoci.TabIndex = 2;
            this.listViewSoci.UseCompatibleStateImageBehavior = false;
            this.listViewSoci.View = System.Windows.Forms.View.Details;
            this.listViewSoci.SelectedIndexChanged += new System.EventHandler(this.listViewSoci_SelectedIndexChanged);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(351, 396);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 11;
            this.btnAnnulla.Text = "annulla ";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // EliminaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.listViewSoci);
            this.Name = "EliminaSocio";
            this.Text = "EliminaSocio";
            this.Load += new System.EventHandler(this.EliminaSocio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSoci;
        private System.Windows.Forms.Button btnAnnulla;
    }
}