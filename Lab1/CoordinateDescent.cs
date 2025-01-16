using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Lab1
{
    public partial class CoordinateDescent : Form, IView
    {
        private bool checkExistence = false;

        private Size formOriginalSize;
        private Rectangle recCalculateButton;
        private Rectangle recFunctionTextBox;
        private Rectangle recGraph;
        private Rectangle recLabel1;
        private Rectangle recLabel2;
        private Rectangle recFunctionLabel;
        private Rectangle recLabel4;
        private Rectangle recLabel5;
        private Rectangle recLabel6;
        private Rectangle recLabel7;
        private Rectangle recLimitationLabel;
        private Rectangle recLeftLabel;
        private Rectangle recRightLabel;
        private Rectangle recIntervalBox;
        private Rectangle recFunctionLimitBox;
        private Rectangle recTextBoxE;
        private Rectangle recFirstLimitationBox;
        private Rectangle recSecondLimitationBox;
        private Rectangle recEpsilonBox;
        private Rectangle recLimitBox;
        private Rectangle recIterationLabel;
        private Rectangle recIterationBox;
        private Rectangle recGraphDesignLabel;
        private Rectangle recMethodDesignLabel;
        public CoordinateDescent()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
            this.Resize += CoordinateDescent_Resize;
            formOriginalSize = this.Size;
            recFunctionTextBox = new Rectangle(function.Location, function.Size);
            recGraph = new Rectangle(pvGraph.Location, pvGraph.Size);
            recLabel1 = new Rectangle(label1.Location, label1.Size);
            recLabel2 = new Rectangle(label2.Location, label2.Size);
            recFunctionLabel = new Rectangle(functionLabel.Location, functionLabel.Size);
            recLabel4 = new Rectangle(label4.Location, label4.Size);
            recLabel5 = new Rectangle(label5.Location, label5.Size);
            recLabel6 = new Rectangle(label6.Location, label6.Size);
            recLabel7 = new Rectangle(label7.Location, label7.Size);
            recLeftLabel = new Rectangle(leftLabel.Location, leftLabel.Size);
            recRightLabel = new Rectangle(rightLabel.Location, rightLabel.Size);
            recIntervalBox = new Rectangle(interval.Location, interval.Size);
            recFunctionLimitBox = new Rectangle(functionLimitBox.Location, functionLimitBox.Size);
            recTextBoxE = new Rectangle(textBox1.Location, textBox1.Size);
            recFirstLimitationBox = new Rectangle(FirstIntervalLimitation.Location, FirstIntervalLimitation.Size);
            recSecondLimitationBox = new Rectangle(SecondIntervalLimitation.Location, SecondIntervalLimitation.Size);
            recEpsilonBox = new Rectangle(epsilonBox.Location, epsilonBox.Size);
            recLimitBox = new Rectangle(LimitationBox.Location, LimitationBox.Size);
            recIterationLabel = new Rectangle(IterationLabel.Location, IterationLabel.Size);
            recIterationBox = new Rectangle(IterationBox.Location, IterationBox.Size);
            recGraphDesignLabel = new Rectangle(GraphDesignLabel.Location, GraphDesignLabel.Size);
            recMethodDesignLabel = new Rectangle(MethodDesignLabel.Location, MethodDesignLabel.Size);
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
        private void CoordinateDescent_Resize(object sender, EventArgs e)
        {
            AutoResize(function, recFunctionTextBox);
            AutoResize(pvGraph, recGraph);
            AutoResize(label1, recLabel1);
            AutoResize(label2, recLabel2);
            AutoResize(functionLabel, recFunctionLabel);
            AutoResize(label4, recLabel4);
            AutoResize(label5, recLabel5);
            AutoResize(label6, recLabel6);
            AutoResize(label7, recLabel7);
            AutoResize(leftLabel, recLeftLabel);
            AutoResize(rightLabel, recRightLabel);
            AutoResize(interval, recIntervalBox);
            AutoResize(functionLimitBox, recFunctionLimitBox);
            AutoResize(textBox1, recTextBoxE);
            AutoResize(FirstIntervalLimitation, recFirstLimitationBox);
            AutoResize(SecondIntervalLimitation, recSecondLimitationBox);
            AutoResize(epsilonBox, recEpsilonBox);
            AutoResize(LimitationBox, recLimitBox);
            AutoResize(IterationBox, recIterationBox);
            AutoResize(IterationLabel, recIterationLabel);
            AutoResize(GraphDesignLabel, recGraphDesignLabel);
            AutoResize(MethodDesignLabel, recMethodDesignLabel);
        }

        double IView.lowLimit()
        {
            return Convert.ToDouble(functionLimitBox.Text);
        }

        double IView.upLimit()
        {
            return Convert.ToDouble(textBox1.Text);
        }

        double IView.iterationCount()
        {
            return Convert.ToDouble(IterationBox.Text);
        }


        byte IView.Choice()
        {
            byte choice = 1;
            if (radioButton2.Checked)
            {
                choice = 2;
            }
            else if (radioButton3.Checked)
            {
                choice = 3;
            }
            return choice;
        }
        string IView.returnFunction()
        {
            if (function.Text.Contains("x"))
            {
                return function.Text;
            }
            else
            {
                MessageBox.Show("Нет функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "x";
            }
        }

        double IView.firstSide()
        {
            return Convert.ToDouble(FirstIntervalLimitation.Text);
        }

        double IView.Interval()
        {
            return Convert.ToDouble(interval.Text);
        }

        double IView.secondSide()
        {
            return Convert.ToDouble(SecondIntervalLimitation.Text);
        }

        double IView.epsilon()
        {
            return Convert.ToDouble(epsilonBox.Text);
        }

        void IView.UpdateGraph(List<double[]> inputArr)
        {
            var plotModel = this.pvGraph.Model;
            var lineSeries = new LineSeries {
                Title = "точки производной",
                Color = OxyColor.FromRgb(0, 128, 0)
            };
            foreach (var line in inputArr)
            {
                lineSeries.Points.Add(new DataPoint(line[0], line[1]));
            }
            plotModel.Series.Add(lineSeries);
            this.pvGraph.Model = plotModel;
        }

        bool IView.MinimumOrMaximum()
        {
            if (checkBox1.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public event EventHandler<EventArgs> StartDichotomy;
        public event EventHandler<EventArgs> CreateGraph;
        public event EventHandler<EventArgs> StartGoldenRatio;
        public event EventHandler<EventArgs> StartNewton;
        public event EventHandler<EventArgs> StartDescent;

        void IView.ShowGraph(PlotModel plotModel)
        {
            this.pvGraph.Model = plotModel;
            checkExistence = true;
        }
        void IView.ShowResult(double result, double functionResult)
        {
            result = Math.Round(result, Convert.ToInt16(LimitationBox.Text));
            functionResult = Math.Round(functionResult, Convert.ToInt16(LimitationBox.Text));
            if (double.IsNaN(result) && !double.IsNaN(functionResult))
            {
                MessageBox.Show("Метод остановлен: производная достигла 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.IsNaN(result) && double.IsNaN(functionResult))
            {
                if (radioButton2.Checked)
                {
                    MessageBox.Show("Метод остановлен: найден максимум, а не минимум. Измените начальное приближение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioButton3.Checked)
                {
                    MessageBox.Show("Метод остановлен: найден минимум, а не максимум. Измените начальное приближение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (double.IsNaN(result) && double.IsNaN(functionResult))
            {
                MessageBox.Show("Метод остановлен: за введённое число итераций он не подошёл к точке. Проверьте, есть ли у функции точки минимума или максимума, либо увеличьте число итераций", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radioButton2.Checked)
                {
                    MessageBox.Show("Минимум:" + result.ToString() + "\n" + "Значение минимума:" + functionResult.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioButton3.Checked)
                {
                    functionResult = Math.Abs(functionResult);
                    MessageBox.Show("Максимум:" + result.ToString() + "\n" + "Значение максимума:" + functionResult.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }


        private bool ValidateText()
        {
            Regex regex = new Regex(@"^[\d,-]+$");
            bool result = true;
            bool mathces;
            if (string.IsNullOrEmpty(FirstIntervalLimitation.Text) || (mathces = regex.IsMatch(FirstIntervalLimitation.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода начального приближения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(SecondIntervalLimitation.Text) || (mathces = regex.IsMatch(SecondIntervalLimitation.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения численного дифференциала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(epsilonBox.Text) || (mathces = regex.IsMatch(epsilonBox.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения epsilon", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(LimitationBox.Text) || (mathces = regex.IsMatch(LimitationBox.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения требуемой точности", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(interval.Text) || (mathces = regex.IsMatch(interval.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа точек построения осей", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(functionLimitBox.Text) || (mathces = regex.IsMatch(functionLimitBox.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа точек построения отрицательной стороны  функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || (mathces = regex.IsMatch(textBox1.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа точек построения положительной стороны функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(IterationBox.Text) || (mathces = regex.IsMatch(IterationBox.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа итераций", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private void toolStripTextBox1_Click(object sender, EventArgs inputEvent)
        {
            CreateGraph(sender, inputEvent);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs inputEvent)
        {
            StartDescent(sender, inputEvent);
        }
    }
}
