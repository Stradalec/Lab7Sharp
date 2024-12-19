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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class SystemLinearAlgebraicEquations : Form, IAlgebraicView
    {
        private string path = string.Empty;
        private Size formOriginalSize;
        private Rectangle recTextBox1;
        private Rectangle recHand;
        private Rectangle recFile;
        private Rectangle recInput;
        private Rectangle recButton1;
        private Rectangle recChoose;
        private Rectangle recGauss;
        private Rectangle recJordanoGauss;
        private Rectangle recCramer;
        private Rectangle recStartCalculate;
        private Rectangle recSize;

        public SystemLinearAlgebraicEquations()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
            this.Resize += SystemLinearAlgebraicEquations_Resize;
            formOriginalSize = this.Size;
            recTextBox1 = new Rectangle(textBox1.Location, textBox1.Size);
            recHand = new Rectangle(hand.Location, hand.Size);
            recFile = new Rectangle(file.Location, file.Size);
            recInput = new Rectangle(input.Location, input.Size);
            recButton1 = new Rectangle(button1.Location, button1.Size);
            recChoose = new Rectangle(Choose.Location, Choose.Size);
            recGauss = new Rectangle(Gauss.Location, Gauss.Size);
            recJordanoGauss = new Rectangle(JordanoGauss.Location, JordanoGauss.Size);
            recCramer = new Rectangle(Cramer.Location, Cramer.Size); 
            recStartCalculate = new Rectangle(startCalculate.Location, startCalculate.Size);
            recSize = new Rectangle(size.Location, size.Size);
        }

        private void SystemLinearAlgebraicEquations_Resize(object sender, EventArgs e)
        {
            AutoResize(textBox1, recTextBox1);
            AutoResize(hand, recHand);
            AutoResize(file, recFile);
            AutoResize(input, recInput);
            AutoResize(button1, recButton1);
            AutoResize(Choose, recChoose);
            AutoResize(Gauss, recGauss);
            AutoResize(JordanoGauss, recJordanoGauss);
            AutoResize(Cramer, recCramer);
            AutoResize(startCalculate, recStartCalculate);
            AutoResize(size, recSize);
        }

        private void AutoResize(Control control, Rectangle rectangle)
        {
            double xRatio = (double)(this.Width) / (double)(formOriginalSize.Width);
            double yRatio = (double)(this.Height) / (double)(formOriginalSize.Height);
            int newX = (int)(rectangle.X * xRatio);
            int newY = (int)(rectangle.Y * yRatio);

            int newWidth = (int)(rectangle.Width * xRatio);
            int newHeight = (int)(rectangle.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[\d,-]+$");
            bool result = true;
            bool mathces;
            int matrixCount;
            if (string.IsNullOrEmpty(textBox1.Text) || (regex.IsMatch(textBox1.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода размерности матрицы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                matrixCount = 1;
            }
            else 
            {
                matrixCount = Convert.ToInt32(textBox1.Text);
            }
            
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
                else
                {
                    MessageBox.Show("Ошибка ввода пути папки", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    resultString += "x" + (outputIndex + 1) + " = " + Math.Round(result[outputIndex], 2).ToString() + "\n";
                }
                
            }
            MessageBox.Show(resultString, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
