namespace ORMGenerator
{
    partial class frmHauptfenster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Text = "";

            // dgvTitel
            this.dgvTitel = new System.Windows.Forms.DataGridView();
            this.dgvTitel.Name = "dgvTitel";
            this.dgvTitel.Size = new System.Drawing.Size(300, 400);
            this.dgvTitel.Location = new System.Drawing.Point(5, 5);
            this.dgvTitel.AllowUserToAddRows = true;
            this.dgvTitel.AllowUserToDeleteRows = true;

            // dgvKeys
            this.dgvKeys = new System.Windows.Forms.DataGridView();
            this.dgvKeys.Name = "dgvKeys";
            this.dgvKeys.Size = new System.Drawing.Size(300, 400);
            this.dgvKeys.Location = new System.Drawing.Point(310, 5);
            this.dgvKeys.AllowUserToAddRows = true;
            this.dgvKeys.AllowUserToDeleteRows = true;

            // cmbTemplates
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(200, 30);
            this.cmbTemplates.Location = new System.Drawing.Point(615, 5);
            
            // btnGenerate
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(200, 30);
            this.btnGenerate.Location = new System.Drawing.Point(615, 40);
            this.btnGenerate.Text = "Degenerate.";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            

            // Controls
            this.Controls.Add(this.dgvTitel);
            this.Controls.Add(this.dgvKeys);
            this.Controls.Add(this.cmbTemplates);
            this.Controls.Add(this.btnGenerate);
        }

        private System.Windows.Forms.DataGridView dgvTitel;
        private System.Windows.Forms.DataGridView dgvKeys;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Button btnGenerate;
        
        #endregion
    }
}

