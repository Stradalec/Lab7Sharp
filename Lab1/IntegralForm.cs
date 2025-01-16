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
using NPOI.SS.Formula.Functions;

namespace Lab1
{
    public partial class IntegralForm : Form, IIntegralView
    {
        private Size formOriginalSize;
        private Regex regex = new Regex(@"^[\d,-]+$");
        private Rectangle recGraphDesignLabel;
        private Rectangle recfunctionLabel;
        private Rectangle recUpBorder;
        private Rectangle recLowBorder;
        private Rectangle recIntegral;
        private Rectangle recpvGraph;
        private Rectangle recfunction;
        private Rectangle recdx;
        private Rectangle reclabel4;
        private Rectangle recInterval;
        private Rectangle recMethodDesignLabel;
        private Rectangle recIntegralGroup;
        private Rectangle recRectangle;
        private Rectangle recTrapezoid;
        private Rectangle recSimpson;
        private Rectangle recCountOfIterations;
        private Rectangle recIntervalLimitation;
        private Rectangle reclabel1;
        private Rectangle recformatBox;
        private Rectangle recResultBox;
        private Rectangle recRectangleResultLabel;
        private Rectangle recRectangleResult;
        private Rectangle recTrapezoidResultLabel;
        private Rectangle recTrapezoidResult;
        private Rectangle recSimpsonResultLabel;
        private Rectangle recSimpsonResult;
        private Rectangle recRecViz;
        private Rectangle recTrapViz;
        private Rectangle recSimpsonViz;

        public IntegralForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
            this.Resize += IntegralForm_Resize;
            formOriginalSize = this.Size;
            recGraphDesignLabel = new Rectangle(GraphDesignLabel.Location, GraphDesignLabel.Size);
            recfunctionLabel = new Rectangle(functionLabel.Location, functionLabel.Size);
            recUpBorder = new Rectangle(upBorder.Location, upBorder.Size);
            recLowBorder = new Rectangle(lowBorder.Location, lowBorder.Size);
            recIntegral = new Rectangle(integral.Location, integral.Size);
            recpvGraph = new Rectangle(pvGraph.Location, pvGraph.Size);
            recfunction = new Rectangle(function.Location, function.Size);
            recdx = new Rectangle(dx.Location, dx.Size);
            reclabel4 = new Rectangle(label4.Location, label4.Size);
            recInterval = new Rectangle(interval.Location, interval.Size);
            recMethodDesignLabel = new Rectangle(MethodDesignLabel.Location, MethodDesignLabel.Size);
            recIntegralGroup = new Rectangle(integralGroup.Location, integralGroup.Size);
            recRectangle = new Rectangle(rectangle.Location, rectangle.Size);
            recTrapezoid = new Rectangle(trapezoid.Location, trapezoid.Size);
            recSimpson = new Rectangle(simpsonT.Location, simpsonT.Size);
            recCountOfIterations = new Rectangle(countOfIterations.Location, countOfIterations.Size);
            recIntervalLimitation = new Rectangle(IntervalLimitation.Location, IntervalLimitation.Size);
            reclabel1 = new Rectangle(label1.Location, label1.Size);
            recformatBox = new Rectangle(formatBox.Location, formatBox.Size);
            recResultBox =  new Rectangle(resultBox.Location, resultBox.Size);
            recRectangleResultLabel = new Rectangle(rectangleResultLabel.Location, rectangleResultLabel.Size);
            recRectangleResult = new Rectangle(rectangleResult.Location, rectangleResult.Size);
            recTrapezoidResultLabel = new Rectangle(trapezoidResultLabel.Location, trapezoidResultLabel.Size);
            recTrapezoidResult = new Rectangle(trapezoidResult.Location, trapezoidResult.Size);
            recSimpsonResultLabel = new Rectangle(SimpsonResultLabel.Location, SimpsonResultLabel.Size);
            recSimpsonResult = new Rectangle(simpsonResult.Location, simpsonResult.Size);
            recRecViz = new Rectangle(recViz.Location, recViz.Size);
            recTrapViz = new Rectangle(trapViz.Location, trapViz.Size);
            recSimpsonViz = new Rectangle(simpsonViz.Location, simpsonViz.Size);
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

        private void IntegralForm_Resize(object sender, EventArgs e)
        {
            AutoResize(GraphDesignLabel, recGraphDesignLabel);
            AutoResize(functionLabel, recfunctionLabel);
            AutoResize(upBorder, recUpBorder);
            AutoResize(lowBorder, recLowBorder);
            AutoResize(integral, recIntegral);
            AutoResize(pvGraph, recpvGraph);
            AutoResize(function, recfunction);
            AutoResize(dx, recdx);
            AutoResize(label4, reclabel4);
            AutoResize(interval, recInterval);
            AutoResize(MethodDesignLabel, recMethodDesignLabel);
            AutoResize(integralGroup, recIntegralGroup);
            AutoResize(rectangle, recRectangle);
            AutoResize(trapezoid, recTrapezoid);
            AutoResize(simpsonT, recSimpson);
            AutoResize(countOfIterations, recCountOfIterations);
            AutoResize(IntervalLimitation, recIntervalLimitation);
            AutoResize(label1, reclabel1);
            AutoResize(formatBox, recformatBox);
            AutoResize(resultBox, recResultBox);
            AutoResize(rectangleResultLabel, recRectangleResultLabel);
            AutoResize(rectangleResult, recRectangleResult);
            AutoResize(trapezoidResultLabel, recTrapezoidResultLabel);
            AutoResize(trapezoidResult, recTrapezoidResult);
            AutoResize(SimpsonResultLabel, recSimpsonResultLabel);
            AutoResize(simpsonResult, recSimpsonResult);
            AutoResize(recViz, recRecViz);
            AutoResize(trapViz, recTrapViz);
            AutoResize(simpsonViz, recSimpsonViz);
        }

        double IIntegralView.Interval()
        {
            bool matches;
            if (string.IsNullOrEmpty(interval.Text) || (matches = regex.IsMatch(interval.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода числа построения осей", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
                
            }
            else 
            {
                return Convert.ToDouble(interval.Text);
            }
            
        }

        double IIntegralView.upLimit()
        {
            bool matches;
            if (string.IsNullOrEmpty(upBorder.Text) || (matches = regex.IsMatch(upBorder.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода верхнего значения интеграла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;               
            }
            else
            {
                
                return Convert.ToDouble(upBorder.Text);
            }
            
        }

        double IIntegralView.lowLimit()
        {
            bool matches;
            if (string.IsNullOrEmpty(lowBorder.Text) || (matches = regex.IsMatch(lowBorder.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода нижнего значения интеграла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {                
                return Convert.ToDouble(lowBorder.Text);               
            }
        }

        double IIntegralView.Accuracy()
        {
            bool matches;
            if (string.IsNullOrEmpty(formatBox.Text) || (matches = regex.IsMatch(formatBox.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода значения точности", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
                
            }
            else
            {
                return Convert.ToDouble(formatBox.Text);
            }
        }

        int IIntegralView.IntegralIntervalCount()
        {
            bool matches;
            if (string.IsNullOrEmpty(IntervalLimitation.Text) || (matches = regex.IsMatch(IntervalLimitation.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода значения количества интервалов", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
                
            }
            else
            {
                return Convert.ToInt32(IntervalLimitation.Text);
            }
        }

        void IIntegralView.UpdateGraph(List<double[]> inputArr, byte choice)
        {
            var plotModel = this.pvGraph.Model;
            if (choice == 0 && recViz.Checked)
            {
                var lineSeries = new LineSeries {
                    Title = "Метод прямоугольников",
                    Color = OxyColor.FromRgb(0, 128, 0)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            else if (choice == 1 && trapViz.Checked)
            {
                var lineSeries = new LineSeries {
                    Title = "Метод трапеций",
                    Color = OxyColor.FromRgb(0, 0, 0)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            else if (choice == 2 && simpsonViz.Checked) 
            {
                var lineSeries = new LineSeries {
                    Title = "Метод Симпсона",
                    Color = OxyColor.FromRgb(153, 50, 204)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            
        }
        bool IIntegralView.IsRectangleActive()
        {
            if (rectangle.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IIntegralView.IsTrapezoidActive()
        {
            if (trapezoid.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IIntegralView.IsSimpsonActive()
        {
            if (simpsonT.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void IIntegralView.ShowResult(double[] inputArray)
        {
            if (formatBox.Text.Length != 0)
            {
                inputArray[0] = Math.Truncate(inputArray[0] * Math.Pow(10, Convert.ToInt32(formatBox.Text))) / Math.Pow(10, Convert.ToInt32(formatBox.Text));
                inputArray[1] = Math.Truncate(inputArray[1] * Math.Pow(10, Convert.ToInt32(formatBox.Text))) / Math.Pow(10, Convert.ToInt32(formatBox.Text));
                inputArray[2] = Math.Truncate(inputArray[2] * Math.Pow(10, Convert.ToInt32(formatBox.Text))) / Math.Pow(10, Convert.ToInt32(formatBox.Text));
            }
            rectangleResult.Text = inputArray[0].ToString();
            trapezoidResult.Text = inputArray[1].ToString();
            simpsonResult.Text = inputArray[2].ToString();

        }

        void IIntegralView.ReverseResult(int countOfIterations)
        {
            MessageBox.Show("Необходимое n = " + countOfIterations, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string IIntegralView.returnFunction()
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

        void IIntegralView.ShowGraph(PlotModel plotModel)
        {
            this.pvGraph.Model = plotModel;
        }

        public event EventHandler<EventArgs> CreateIntegralGraph;
        public event EventHandler<EventArgs> Calculate;
        public event EventHandler<EventArgs> ReverseMode;

        private void toolStripTextBox1_Click(object sender, EventArgs inputEvent)
        {
            CreateIntegralGraph(sender, inputEvent);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs inputEvent)
        {
            Calculate(sender, inputEvent);
        }

        private void toolStripTextBox3_Click(object sender, EventArgs inputEvent)
        {
            ReverseMode(sender, inputEvent);
        }
    }
}
