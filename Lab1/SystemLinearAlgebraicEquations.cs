using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class SystemLinearAlgebraicEquations : Form, IAlgebraicView
    {
        public SystemLinearAlgebraicEquations()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int matrixCount = Convert.ToInt32(textBox1.Text);
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

            // Инициализировать значения в таблице для матрицы
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

            // Инициализировать значения в таблице для вектора-столбца
            for (int vectorSpawnIndex = 0; vectorSpawnIndex < matrixCount; ++vectorSpawnIndex)
            {
                dataGridView2.Rows[vectorSpawnIndex].Cells[0].Value = 0;
            }


        }

        private void startCalculate_Click(object sender, EventArgs inputEvent)
        {
            StartGauss(sender, inputEvent);
        }

        public event EventHandler<EventArgs> StartGauss;

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
