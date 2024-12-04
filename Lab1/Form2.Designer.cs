namespace Lab1
{
    partial class dichotomyForm
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
            this.pvGraph = new OxyPlot.WindowsForms.PlotView();
            this.function = new System.Windows.Forms.TextBox();
            this.FirstIntervalLimitation = new System.Windows.Forms.TextBox();
            this.SecondIntervalLimitation = new System.Windows.Forms.TextBox();
            this.functionLabel = new System.Windows.Forms.Label();
            this.limitationLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.epsilonBox = new System.Windows.Forms.TextBox();
            this.LimitationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.TextBox();
            this.functionLimitBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pvGraph
            // 
            this.pvGraph.Location = new System.Drawing.Point(312, 30);
            this.pvGraph.Name = "pvGraph";
            this.pvGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pvGraph.Size = new System.Drawing.Size(476, 413);
            this.pvGraph.TabIndex = 2;
            this.pvGraph.Text = "plotView1";
            this.pvGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pvGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pvGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(24, 56);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(276, 20);
            this.function.TabIndex = 3;
            this.function.Text = "x +1";
            // 
            // FirstIntervalLimitation
            // 
            this.FirstIntervalLimitation.Location = new System.Drawing.Point(24, 279);
            this.FirstIntervalLimitation.Name = "FirstIntervalLimitation";
            this.FirstIntervalLimitation.Size = new System.Drawing.Size(69, 20);
            this.FirstIntervalLimitation.TabIndex = 5;
            this.FirstIntervalLimitation.Text = "-2";
            // 
            // SecondIntervalLimitation
            // 
            this.SecondIntervalLimitation.Location = new System.Drawing.Point(115, 279);
            this.SecondIntervalLimitation.Name = "SecondIntervalLimitation";
            this.SecondIntervalLimitation.Size = new System.Drawing.Size(69, 20);
            this.SecondIntervalLimitation.TabIndex = 6;
            this.SecondIntervalLimitation.Text = "0";
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(21, 40);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(83, 13);
            this.functionLabel.TabIndex = 7;
            this.functionLabel.Text = "Ваша функция:";
            // 
            // limitationLabel
            // 
            this.limitationLabel.AutoSize = true;
            this.limitationLabel.Location = new System.Drawing.Point(77, 240);
            this.limitationLabel.Name = "limitationLabel";
            this.limitationLabel.Size = new System.Drawing.Size(132, 13);
            this.limitationLabel.TabIndex = 8;
            this.limitationLabel.Text = "Ограничение интервала:";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(24, 263);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(39, 13);
            this.leftLabel.TabIndex = 9;
            this.leftLabel.Text = "Левое";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Location = new System.Drawing.Point(112, 263);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(45, 13);
            this.rightLabel.TabIndex = 10;
            this.rightLabel.Text = "Правое";
            // 
            // epsilonBox
            // 
            this.epsilonBox.Location = new System.Drawing.Point(197, 279);
            this.epsilonBox.Name = "epsilonBox";
            this.epsilonBox.Size = new System.Drawing.Size(69, 20);
            this.epsilonBox.TabIndex = 13;
            this.epsilonBox.Text = "0,1";
            // 
            // LimitationBox
            // 
            this.LimitationBox.Location = new System.Drawing.Point(115, 340);
            this.LimitationBox.Name = "LimitationBox";
            this.LimitationBox.Size = new System.Drawing.Size(69, 20);
            this.LimitationBox.TabIndex = 14;
            this.LimitationBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Epsilon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Необходимая точность (число знаков после запятой)";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(178, 145);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(69, 20);
            this.interval.TabIndex = 19;
            this.interval.Text = "0";
            // 
            // functionLimitBox
            // 
            this.functionLimitBox.Location = new System.Drawing.Point(33, 142);
            this.functionLimitBox.Name = "functionLimitBox";
            this.functionLimitBox.Size = new System.Drawing.Size(69, 20);
            this.functionLimitBox.TabIndex = 20;
            this.functionLimitBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Число точек построения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "осей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "функции (отриц. сторона)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "функции (полож. сторона)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Построить";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Искать";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // dichotomyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.functionLimitBox);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimitationBox);
            this.Controls.Add(this.epsilonBox);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.limitationLabel);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.SecondIntervalLimitation);
            this.Controls.Add(this.FirstIntervalLimitation);
            this.Controls.Add(this.function);
            this.Controls.Add(this.pvGraph);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dichotomyForm";
            this.Text = "Метод Дихотомии";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public OxyPlot.WindowsForms.PlotView pvGraph;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.TextBox FirstIntervalLimitation;
        private System.Windows.Forms.TextBox SecondIntervalLimitation;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.Label limitationLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.TextBox epsilonBox;
        private System.Windows.Forms.TextBox LimitationBox;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.TextBox functionLimitBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}