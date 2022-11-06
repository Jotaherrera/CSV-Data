using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVData
{
    public partial class frmCSVDB : Form
    {
        string strFileName;
        Stream myStream;
        char[] delimiterChars = { ';', ',' };
        public frmCSVDB()
        {
            InitializeComponent();
        }

        private void createDataGrid()
        {
            dgvCSV.Rows.Clear();
            dgvCSV.Columns.Clear();
            dgvCSV.Refresh();

            if (new FileInfo(strFileName).Length == 0)
            {
                MessageBox.Show($"This file may be empty", "File status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] headers = new string[0];
            string[] values = new string[0];
            string line;
            int lineCounter = 0;

            string line1 = File.ReadLines(strFileName).First();
            headers = line1.Split(delimiterChars).ToArray();

            dgvCSV.ColumnCount = headers.Length;

            for (var i = 0; i < headers.Length; i++)
            {
                dgvCSV.Columns[i].Name = headers[i];
            }

            StreamReader streamReader = new StreamReader(strFileName);

            while ((line = streamReader.ReadLine()) != null)
            {
                if (lineCounter > 0)
                {
                    values = line.Split(delimiterChars);

                    dgvCSV.Rows.Add(values.ToArray());
                }

                lineCounter++;
            }
            streamReader.Close();
        }

        private void btnSaveLocal_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(strFileName);
                sw.Write(rtbCSV.Text);
                sw.Close();
                lblPath.Text = strFileName;
                MessageBox.Show($"File saved", "File status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                createDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"You need to open or create a file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
