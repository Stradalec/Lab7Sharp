using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
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

namespace Lab1
{
    public partial class SystemLinearAlgebraicEquations : Form, IAlgebraicView
    {
        private string path = string.Empty;
        public SystemLinearAlgebraicEquations()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int matrixCount = Convert.ToInt32(textBox1.Text);
            if (hand.Checked) 
            {                
                foreach (Control control in this.Controls)
                {
                    if (control is DataGridView)
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView2.Rows.Clear();
                        dataGridView2.Columns.Clear();
                    }
                }

                for (int mainColumnIndex = 0; mainColumnIndex < matrixCount; ++mainColumnIndex)
                {
                    dataGridView1.Columns.Add("col" + mainColumnIndex.ToString(), "X [" + (mainColumnIndex + 1).ToString() + "]");
                }

                // Добавить строки в таблицу для матрицы
                for (int mainRowIndex = 0; mainRowIndex < matrixCount; ++mainRowIndex)
                {
                    dataGridView1.Rows.Add();
                }

                // Заспавнить значения в таблице для матрицы
                for (int spawnZeroIndex = 0; spawnZeroIndex < matrixCount; ++spawnZeroIndex)
                {
                    for (int ZeroIndex = 0; ZeroIndex < matrixCount; ++ZeroIndex)
                    {
                        dataGridView1.Rows[spawnZeroIndex].Cells[ZeroIndex].Value = 0;
                    }
                }

                dataGridView2.Columns.Add("col1", "X");

                // Добавить строки в таблицу для вектора-столбца
                for (int vectorIndex = 0; vectorIndex < matrixCount; ++vectorIndex)
                {
                    dataGridView2.Rows.Add();
                }

                // Заспавнить значения в таблице для вектора-столбца
                for (int vectorSpawnIndex = 0; vectorSpawnIndex < matrixCount; ++vectorSpawnIndex)
                {
                    dataGridView2.Rows[vectorSpawnIndex].Cells[0].Value = 0;
                }
            }
            if (file.Checked) 
            {
                foreach (Control control in this.Controls)
                {
                    if (control is DataGridView)
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView2.Rows.Clear();
                        dataGridView2.Columns.Clear();
                    }
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                }
                using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(file);
                    ISheet sheet = workbook.GetSheetAt(0);
                    // Извлечь данные из таблицы
                    int rows = sheet.PhysicalNumberOfRows;
                    int columns = sheet.GetRow(0).LastCellNum;

                    // Добавить столбцы в матрицу
                    for (int columnMatrixIndex = 0; columnMatrixIndex < columns - 1; ++columnMatrixIndex)
                    {
                        dataGridView1.Columns.Add("col" + columnMatrixIndex.ToString(), "X [" + (columnMatrixIndex + 1).ToString() + "]");
                    }

                    // Добавить строки в матрицу
                    for (int rowMatrixIndex = 0; rowMatrixIndex < rows - 1; ++rowMatrixIndex)
                    {
                        dataGridView1.Rows.Add();
                    }
                    dataGridView2.Columns.Add("col1", "X");
                    // Добавить строки в вектор
                    for (int vectorIndex = 0; vectorIndex < rows - 1; ++vectorIndex)
                    {
                        dataGridView2.Rows.Add();
                    }

                    // Заполнить dataGridViewMatrix и dataGridViewVector данными
                    for (int fillRow = 0; fillRow < rows - 1; ++fillRow)
                    {
                        var row = sheet.GetRow(fillRow + 1);
                        if (row != null) 
                        {
                            for (int fillColumn = 0; fillColumn < columns - 1; ++fillColumn)
                            {
                                if (row.GetCell(fillColumn) != null)
                                {
                                    dataGridView1.Rows[fillRow].Cells[fillColumn].Value = row.GetCell(fillColumn).NumericCellValue;
                                }

                            }
                            if (row.GetCell(columns - 1) != null) 
                            {
                                dataGridView2.Rows[fillRow].Cells[0].Value = row.GetCell(columns - 1).NumericCellValue;
                            }
                            
                        }
                        
                    }
                }
            }


        }

        private void startCalculate_Click(object sender, EventArgs inputEvent)
        {
            if (Gauss.Checked) 
            {
                StartGauss(sender, inputEvent);
            }
            if (JordanoGauss.Checked) 
            {
                StartJordanoGauss(sender, inputEvent);
            }
            if (Cramer.Checked) 
            {
                StartCramer(sender, inputEvent);
            }
        }

        public event EventHandler<EventArgs> StartGauss;
        public event EventHandler<EventArgs> StartJordanoGauss;
        public event EventHandler<EventArgs> StartCramer;

        double[,] IAlgebraicView.GetMatrix()
        {
            double[,] matrix = new double[dataGridView1.Rows.Count - 1, dataGridView1.Columns.Count];
            for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count - 1; ++rowIndex)
            {
                for (int columnIndex = 0; columnIndex < dataGridView1.Columns.Count; ++columnIndex)
                {
                    matrix[rowIndex, columnIndex] = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[columnIndex].Value);
                }
            }
            return matrix;
        }

        double[] IAlgebraicView.GetVector()
        {
            double[] vector = new double[dataGridView2.Rows.Count - 1];
            for (int vectorIndex = 0; vectorIndex < dataGridView2.Rows.Count - 1; ++vectorIndex)
            {
                vector[vectorIndex] = Convert.ToDouble(dataGridView2.Rows[vectorIndex].Cells[0].Value);
            }
            return vector;
        }

        void IAlgebraicView.ShowResult(double[] result)
        {
            string resultString = "";
            if (result != null) 
            {
                for (int outputIndex = 0; outputIndex < result.Length; ++outputIndex) 
                {
                    resultString += "x" + (outputIndex + 1) + " = " + result[outputIndex].ToString() + "\n";
                }
                
            }
            MessageBox.Show(resultString, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
