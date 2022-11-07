﻿namespace CSVData
{
    partial class frmCSVDB
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
            this.rtbCSV = new System.Windows.Forms.RichTextBox();
            this.dgvCSV = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSaveLocal = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbCSV
            // 
            this.rtbCSV.Location = new System.Drawing.Point(170, 36);
            this.rtbCSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbCSV.Name = "rtbCSV";
            this.rtbCSV.Size = new System.Drawing.Size(575, 181);
            this.rtbCSV.TabIndex = 0;
            this.rtbCSV.Text = "";
            // 
            // dgvCSV
            // 
            this.dgvCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSV.Location = new System.Drawing.Point(170, 235);
            this.dgvCSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCSV.Name = "dgvCSV";
            this.dgvCSV.RowHeadersWidth = 62;
            this.dgvCSV.RowTemplate.Height = 28;
            this.dgvCSV.Size = new System.Drawing.Size(573, 234);
            this.dgvCSV.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(25, 119);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(113, 40);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnSaveLocal
            // 
            this.btnSaveLocal.Location = new System.Drawing.Point(25, 260);
            this.btnSaveLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveLocal.Name = "btnSaveLocal";
            this.btnSaveLocal.Size = new System.Drawing.Size(113, 40);
            this.btnSaveLocal.TabIndex = 4;
            this.btnSaveLocal.Text = "Save Local";
            this.btnSaveLocal.UseVisualStyleBackColor = true;
            this.btnSaveLocal.Click += new System.EventHandler(this.btnSaveLocal_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 330);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(167, 12);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Path";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(25, 190);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(113, 40);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmCSVDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 488);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveLocal);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dgvCSV);
            this.Controls.Add(this.rtbCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCSVDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSVDB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCSV;
        private System.Windows.Forms.DataGridView dgvCSV;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSaveLocal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnOpen;
    }
}