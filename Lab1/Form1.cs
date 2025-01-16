using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        private Size formOriginalSize;
        private Rectangle recMain;
        private Rectangle recLabel1;
        private Rectangle recLabel2;
        private Rectangle recButton;
        public MainForm()
        {
            InitializeComponent();
            this.Resize += MainForm_Resize;
            formOriginalSize = this.Size;
            recMain = new Rectangle(tableLayoutPanel1.Location, tableLayoutPanel1.Size);
            recLabel1 = new Rectangle(label1.Location, label1.Size);
            recLabel2 = new Rectangle(label2.Location, label2.Size);
            recButton = new Rectangle(button1.Location, button1.Size);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            AutoResize(tableLayoutPanel1, recMain);
            AutoResize(label1, recLabel1);
            AutoResize(label2, recLabel2);
            AutoResize(button1, recButton);
        }

        private void AutoResize(System.Windows.Forms.Control control, Rectangle rectangle)
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
        private void dichotomyButton_Click(object sender, EventArgs e)
        {
            dichotomyForm dichotomyForm = new dichotomyForm();
            dichotomyForm.Show();
        }

        private void GoldenRatioButton_Click(object sender, EventArgs e)
        {
            GoldenRatioForm goldenRatioForm = new GoldenRatioForm();
            goldenRatioForm.Show();
        }

        private void NewtonButton_Click(object sender, EventArgs e)
        {
            Newton newton = new Newton();
            newton.Show();
        }

        private void coordinateDescentButton_Click(object sender, EventArgs e)
        {
            CoordinateDescent descent = new CoordinateDescent();
            descent.Show();
        }

        private void sortingsButton_Click(object sender, EventArgs e)
        {
            Sortings sortings = new Sortings();
            sortings.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warning warning = new Warning();
            warning.Show();
        }

        private void integralButton_Click(object sender, EventArgs e)
        {
            IntegralForm integral = new IntegralForm();
            integral.Show();
        }

        private void SLAU_Click(object sender, EventArgs e)
        {
            SystemLinearAlgebraicEquations slau = new SystemLinearAlgebraicEquations();
            slau.Show();
        }
    }
}
