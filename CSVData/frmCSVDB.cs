using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Linq;
using System.Text;
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
        private string getTableName()
        {
            string distyString = Path.GetFileNameWithoutExtension(strFileName);
            return new String(distyString.Where(Char.IsLetterOrDigit).ToArray());
        }

        private string[] getColumns()
        {
            string[] columnNames = new string[dgvCSV.Columns.Count];
            string[] columnNamesClean = new string[columnNames.Length];

            for (int i = 0; i < dgvCSV.Columns.Count; i++)
            {
                if (!(string.IsNullOrEmpty(dgvCSV.Columns[i].HeaderText.ToString())))
                {
                    columnNames[i] += dgvCSV.Columns[i].HeaderText.ToString();
                }
            }

            for (int i = 0; i < columnNames.Length; i++)
            {
                columnNamesClean[i] += new String(columnNames[i].Where(Char.IsLetterOrDigit).ToArray());
            }

            return columnNamesClean;
        }
        private void exportData()
        {
            try
            {
                string[] columnNames = getColumns();

                MySqlConnection conn = new MySqlConnection($"SERVER= localhost; PORT=3308; DATABASE=dbcsv; USERID=root");

                conn.Open();

                string fileName = getTableName();

                string dropTableQuery = $"DROP TABLE IF EXISTS {fileName};";
                MySqlCommand cmdDrop = new MySqlCommand(dropTableQuery, conn);
                cmdDrop.ExecuteNonQuery();
                string createQuery = $"CREATE TABLE {fileName} ({columnNames[0]}  VARCHAR(50));";
                MySqlCommand cmdCreate = new MySqlCommand(createQuery, conn);
                cmdCreate.ExecuteNonQuery();

                for (int i = 1; i < columnNames.Length; i++)
                {
                    string alterQuery = $"ALTER TABLE {fileName} ADD {columnNames[i]} VARCHAR (50);";
                    MySqlCommand cmdAlter = new MySqlCommand(alterQuery, conn);
                    cmdAlter.ExecuteNonQuery();
                }

                conn.Close();

                MessageBox.Show($"Data exported successfully to the data base.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void createDataGrid()
        {
            dgvCSV.AllowUserToAddRows = true;
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

            while (!(string.IsNullOrEmpty(line = streamReader.ReadLine())))
            {
                if (lineCounter > 0)
                {
                    if (!(string.IsNullOrEmpty(line)))
                    {
                        values = line.Split(delimiterChars);

                        dgvCSV.Rows.Add(values.ToArray());
                    }
                }

                lineCounter++;
            }
            streamReader.Close();
        }

        private void btnSaveLocal_Click(object sender, EventArgs e)
        {
            if (dgvCSV.Rows.Count > 0)
            {
                dgvCSV.AllowUserToAddRows = false;
                try
                {
                    int columnCount = dgvCSV.Columns.Count;
                    string columnNames = "";
                    string[] outputCsv = new string[dgvCSV.Rows.Count + 1];

                    for (int i = 0; i < columnCount; i++)
                    {
                        if (!(string.IsNullOrEmpty(dgvCSV.Columns[i].HeaderText.ToString())))
                        {
                            if (i != (columnCount - 1))
                            {
                                columnNames += dgvCSV.Columns[i].HeaderText.ToString() + ";";
                            }
                            else
                            {
                                columnNames += dgvCSV.Columns[i].HeaderText.ToString();
                            }
                        }
                    }

                    outputCsv[0] += columnNames;

                    for (int i = 1; (i - 1) < dgvCSV.Rows.Count; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            if (dgvCSV.Rows[i - 1].Cells[j].Value == null)
                            {
                                outputCsv[i] += " ;";
                            }
                            else
                            {
                                if (j != (columnCount - 1))
                                {
                                    outputCsv[i] += dgvCSV.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                                else
                                {
                                    outputCsv[i] += dgvCSV.Rows[i - 1].Cells[j].Value.ToString();
                                }
                            }
                        }
                    }

                    File.WriteAllLines(strFileName, outputCsv, Encoding.UTF8);
                    lblPath.Text = $"Path: {strFileName}";
                    MessageBox.Show($"File saved", "File status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    createDataGrid();
                    rtbCSV.Text = File.ReadAllText(strFileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Comma Separated Value| *.csv";
            openFileDialog.DefaultExt = "csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog.OpenFile()) != null)
                {
                    strFileName = openFileDialog.FileName;
                    lblPath.Text = $"Path: {strFileName}";

                    createDataGrid();

                    rtbCSV.Text = File.ReadAllText(strFileName);
                    myStream.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Do you want to delete the file?", "File status", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    rtbCSV.Clear();
                    dgvCSV.Rows.Clear();
                    dgvCSV.Columns.Clear();
                    dgvCSV.Refresh();

                    myStream.Close();
                    File.Delete(strFileName);
                    strFileName = "";
                    lblPath.Text = $"Path: {strFileName}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"You have not opened any file. Open a file and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            exportData();
        }
    }
}
