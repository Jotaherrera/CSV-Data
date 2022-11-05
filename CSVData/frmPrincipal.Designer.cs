namespace CSVData
{
    partial class frmPrincipal
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
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnCSV = new System.Windows.Forms.Button();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnCSV);
            this.grpButtons.Location = new System.Drawing.Point(12, 7);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(331, 431);
            this.grpButtons.TabIndex = 0;
            this.grpButtons.TabStop = false;
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(90, 191);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(150, 45);
            this.btnCSV.TabIndex = 0;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Transfer";
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnCSV;
    }
}

