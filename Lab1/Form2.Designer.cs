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
            pvGraph = new OxyPlot.WindowsForms.PlotView();
            function = new System.Windows.Forms.TextBox();
            FirstIntervalLimitation = new System.Windows.Forms.TextBox();
            SecondIntervalLimitation = new System.Windows.Forms.TextBox();
            functionLabel = new System.Windows.Forms.Label();
            limitationLabel = new System.Windows.Forms.Label();
            leftLabel = new System.Windows.Forms.Label();
            rightLabel = new System.Windows.Forms.Label();
            epsilonBox = new System.Windows.Forms.TextBox();
            LimitationBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            interval = new System.Windows.Forms.TextBox();
            functionLimitBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pvGraph
            // 
            pvGraph.Location = new System.Drawing.Point(364, 35);
            pvGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pvGraph.Name = "pvGraph";
            pvGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            pvGraph.Size = new System.Drawing.Size(555, 477);
            pvGraph.TabIndex = 2;
            pvGraph.Text = "plotView1";
            pvGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            pvGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            pvGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // function
            // 
            function.Location = new System.Drawing.Point(28, 65);
            function.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            function.Name = "function";
            function.Size = new System.Drawing.Size(321, 23);
            function.TabIndex = 3;
            function.Text = "x +1";
            // 
            // FirstIntervalLimitation
            // 
            FirstIntervalLimitation.Location = new System.Drawing.Point(28, 322);
            FirstIntervalLimitation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FirstIntervalLimitation.Name = "FirstIntervalLimitation";
            FirstIntervalLimitation.Size = new System.Drawing.Size(80, 23);
            FirstIntervalLimitation.TabIndex = 5;
            FirstIntervalLimitation.Text = "-2";
            // 
            // SecondIntervalLimitation
            // 
            SecondIntervalLimitation.Location = new System.Drawing.Point(134, 322);
            SecondIntervalLimitation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SecondIntervalLimitation.Name = "SecondIntervalLimitation";
            SecondIntervalLimitation.Size = new System.Drawing.Size(80, 23);
            SecondIntervalLimitation.TabIndex = 6;
            SecondIntervalLimitation.Text = "0";
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Location = new System.Drawing.Point(24, 46);
            functionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new System.Drawing.Size(91, 15);
            functionLabel.TabIndex = 7;
            functionLabel.Text = "Ваша функция:";
            // 
            // limitationLabel
            // 
            limitationLabel.AutoSize = true;
            limitationLabel.Location = new System.Drawing.Point(90, 277);
            limitationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            limitationLabel.Name = "limitationLabel";
            limitationLabel.Size = new System.Drawing.Size(144, 15);
            limitationLabel.TabIndex = 8;
            limitationLabel.Text = "Ограничение интервала:";
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Location = new System.Drawing.Point(28, 303);
            leftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new System.Drawing.Size(40, 15);
            leftLabel.TabIndex = 9;
            leftLabel.Text = "Левое";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Location = new System.Drawing.Point(131, 303);
            rightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new System.Drawing.Size(48, 15);
            rightLabel.TabIndex = 10;
            rightLabel.Text = "Правое";
            // 
            // epsilonBox
            // 
            epsilonBox.Location = new System.Drawing.Point(230, 322);
            epsilonBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            epsilonBox.Name = "epsilonBox";
            epsilonBox.Size = new System.Drawing.Size(80, 23);
            epsilonBox.TabIndex = 13;
            epsilonBox.Text = "0,1";
            // 
            // LimitationBox
            // 
            LimitationBox.Location = new System.Drawing.Point(134, 392);
            LimitationBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LimitationBox.Name = "LimitationBox";
            LimitationBox.Size = new System.Drawing.Size(80, 23);
            LimitationBox.TabIndex = 14;
            LimitationBox.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(230, 303);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 15;
            label1.Text = "Epsilon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(24, 374);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(303, 15);
            label2.TabIndex = 16;
            label2.Text = "Необходимая точность (число знаков после запятой)";
            // 
            // interval
            // 
            interval.Location = new System.Drawing.Point(208, 167);
            interval.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            interval.Name = "interval";
            interval.Size = new System.Drawing.Size(80, 23);
            interval.TabIndex = 19;
            interval.Text = "0";
            // 
            // functionLimitBox
            // 
            functionLimitBox.Location = new System.Drawing.Point(38, 164);
            functionLimitBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            functionLimitBox.Name = "functionLimitBox";
            functionLimitBox.Size = new System.Drawing.Size(80, 23);
            functionLimitBox.TabIndex = 20;
            functionLimitBox.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(90, 125);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(144, 15);
            label4.TabIndex = 21;
            label4.Text = "Число точек построения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(208, 145);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(33, 15);
            label5.TabIndex = 22;
            label5.Text = "осей";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(35, 145);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(151, 15);
            label6.TabIndex = 23;
            label6.Text = "функции (отриц. сторона)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(35, 201);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(155, 15);
            label7.TabIndex = 24;
            label7.Text = "функции (полож. сторона)";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(38, 222);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(80, 23);
            textBox1.TabIndex = 25;
            textBox1.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(933, 27);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new System.Drawing.Size(116, 23);
            toolStripTextBox1.Text = "Построить";
            toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.ReadOnly = true;
            toolStripTextBox2.Size = new System.Drawing.Size(116, 23);
            toolStripTextBox2.Text = "Искать";
            toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // dichotomyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(functionLimitBox);
            Controls.Add(interval);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LimitationBox);
            Controls.Add(epsilonBox);
            Controls.Add(rightLabel);
            Controls.Add(leftLabel);
            Controls.Add(limitationLabel);
            Controls.Add(functionLabel);
            Controls.Add(SecondIntervalLimitation);
            Controls.Add(FirstIntervalLimitation);
            Controls.Add(function);
            Controls.Add(pvGraph);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "dichotomyForm";
            Text = "Метод Дихотомии";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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