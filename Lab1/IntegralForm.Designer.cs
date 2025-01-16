namespace Lab1
{
    partial class IntegralForm
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
            MethodDesignLabel = new System.Windows.Forms.Label();
            GraphDesignLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            interval = new System.Windows.Forms.TextBox();
            countOfIterations = new System.Windows.Forms.Label();
            functionLabel = new System.Windows.Forms.Label();
            IntervalLimitation = new System.Windows.Forms.TextBox();
            function = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            dx = new System.Windows.Forms.Label();
            lowBorder = new System.Windows.Forms.TextBox();
            upBorder = new System.Windows.Forms.TextBox();
            integralGroup = new System.Windows.Forms.GroupBox();
            simpsonT = new System.Windows.Forms.CheckBox();
            trapezoid = new System.Windows.Forms.CheckBox();
            rectangle = new System.Windows.Forms.CheckBox();
            resultBox = new System.Windows.Forms.GroupBox();
            SimpsonResultLabel = new System.Windows.Forms.Label();
            trapezoidResultLabel = new System.Windows.Forms.Label();
            rectangleResultLabel = new System.Windows.Forms.Label();
            simpsonResult = new System.Windows.Forms.TextBox();
            trapezoidResult = new System.Windows.Forms.TextBox();
            rectangleResult = new System.Windows.Forms.TextBox();
            integral = new System.Windows.Forms.Label();
            formatBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            recViz = new System.Windows.Forms.CheckBox();
            trapViz = new System.Windows.Forms.CheckBox();
            simpsonViz = new System.Windows.Forms.CheckBox();
            menuStrip1.SuspendLayout();
            integralGroup.SuspendLayout();
            resultBox.SuspendLayout();
            SuspendLayout();
            // 
            // pvGraph
            // 
            pvGraph.Location = new System.Drawing.Point(356, 12);
            pvGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pvGraph.Name = "pvGraph";
            pvGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            pvGraph.Size = new System.Drawing.Size(555, 495);
            pvGraph.TabIndex = 103;
            pvGraph.Text = "plotView1";
            pvGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            pvGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            pvGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // MethodDesignLabel
            // 
            MethodDesignLabel.AutoSize = true;
            MethodDesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            MethodDesignLabel.Location = new System.Drawing.Point(31, 202);
            MethodDesignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MethodDesignLabel.Name = "MethodDesignLabel";
            MethodDesignLabel.Size = new System.Drawing.Size(213, 20);
            MethodDesignLabel.TabIndex = 101;
            MethodDesignLabel.Text = "Настройка работы метода";
            // 
            // GraphDesignLabel
            // 
            GraphDesignLabel.AutoSize = true;
            GraphDesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            GraphDesignLabel.Location = new System.Drawing.Point(31, 27);
            GraphDesignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            GraphDesignLabel.Name = "GraphDesignLabel";
            GraphDesignLabel.Size = new System.Drawing.Size(254, 20);
            GraphDesignLabel.TabIndex = 100;
            GraphDesignLabel.Text = "Настройка построения графика";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(31, 148);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(173, 15);
            label4.TabIndex = 92;
            label4.Text = "Число точек построения осей";
            // 
            // interval
            // 
            interval.Location = new System.Drawing.Point(31, 166);
            interval.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            interval.Name = "interval";
            interval.Size = new System.Drawing.Size(80, 23);
            interval.TabIndex = 90;
            interval.Text = "5";
            // 
            // countOfIterations
            // 
            countOfIterations.AutoSize = true;
            countOfIterations.Location = new System.Drawing.Point(6, 103);
            countOfIterations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countOfIterations.Name = "countOfIterations";
            countOfIterations.Size = new System.Drawing.Size(91, 15);
            countOfIterations.TabIndex = 84;
            countOfIterations.Text = "Число делений";
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Location = new System.Drawing.Point(31, 84);
            functionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new System.Drawing.Size(87, 15);
            functionLabel.TabIndex = 83;
            functionLabel.Text = "Ваш интеграл:";
            // 
            // IntervalLimitation
            // 
            IntervalLimitation.Location = new System.Drawing.Point(9, 122);
            IntervalLimitation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            IntervalLimitation.Name = "IntervalLimitation";
            IntervalLimitation.Size = new System.Drawing.Size(80, 23);
            IntervalLimitation.TabIndex = 81;
            IntervalLimitation.Text = "5";
            // 
            // function
            // 
            function.Location = new System.Drawing.Point(171, 84);
            function.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            function.Name = "function";
            function.Size = new System.Drawing.Size(129, 23);
            function.TabIndex = 80;
            function.Text = "x";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripTextBox1, toolStripTextBox2, toolStripTextBox3 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(924, 27);
            menuStrip1.TabIndex = 97;
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
            // toolStripTextBox3
            // 
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.ReadOnly = true;
            toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            toolStripTextBox3.Text = "Обратный ход";
            toolStripTextBox3.Click += toolStripTextBox3_Click;
            // 
            // dx
            // 
            dx.AutoSize = true;
            dx.Location = new System.Drawing.Point(307, 88);
            dx.Name = "dx";
            dx.Size = new System.Drawing.Size(20, 15);
            dx.TabIndex = 104;
            dx.Text = "dx";
            // 
            // lowBorder
            // 
            lowBorder.Location = new System.Drawing.Point(116, 122);
            lowBorder.Name = "lowBorder";
            lowBorder.Size = new System.Drawing.Size(48, 23);
            lowBorder.TabIndex = 105;
            lowBorder.Text = "0";
            // 
            // upBorder
            // 
            upBorder.Location = new System.Drawing.Point(116, 50);
            upBorder.Name = "upBorder";
            upBorder.Size = new System.Drawing.Size(48, 23);
            upBorder.TabIndex = 106;
            upBorder.Text = "2";
            // 
            // integralGroup
            // 
            integralGroup.Controls.Add(simpsonT);
            integralGroup.Controls.Add(trapezoid);
            integralGroup.Controls.Add(rectangle);
            integralGroup.Controls.Add(countOfIterations);
            integralGroup.Controls.Add(IntervalLimitation);
            integralGroup.Location = new System.Drawing.Point(34, 225);
            integralGroup.Name = "integralGroup";
            integralGroup.Size = new System.Drawing.Size(170, 165);
            integralGroup.TabIndex = 107;
            integralGroup.TabStop = false;
            integralGroup.Text = "Расчёт интеграла:";
            // 
            // simpsonT
            // 
            simpsonT.AutoSize = true;
            simpsonT.Location = new System.Drawing.Point(6, 72);
            simpsonT.Name = "simpsonT";
            simpsonT.Size = new System.Drawing.Size(83, 19);
            simpsonT.TabIndex = 110;
            simpsonT.Text = "Симпсона";
            simpsonT.UseVisualStyleBackColor = true;
            // 
            // trapezoid
            // 
            trapezoid.AutoSize = true;
            trapezoid.Location = new System.Drawing.Point(6, 47);
            trapezoid.Name = "trapezoid";
            trapezoid.Size = new System.Drawing.Size(94, 19);
            trapezoid.TabIndex = 109;
            trapezoid.Text = "Трапециями";
            trapezoid.UseVisualStyleBackColor = true;
            // 
            // rectangle
            // 
            rectangle.AutoSize = true;
            rectangle.Location = new System.Drawing.Point(6, 22);
            rectangle.Name = "rectangle";
            rectangle.Size = new System.Drawing.Size(137, 19);
            rectangle.TabIndex = 108;
            rectangle.Text = "Прямоугольниками";
            rectangle.UseVisualStyleBackColor = true;
            // 
            // resultBox
            // 
            resultBox.Controls.Add(SimpsonResultLabel);
            resultBox.Controls.Add(trapezoidResultLabel);
            resultBox.Controls.Add(rectangleResultLabel);
            resultBox.Controls.Add(simpsonResult);
            resultBox.Controls.Add(trapezoidResult);
            resultBox.Controls.Add(rectangleResult);
            resultBox.Location = new System.Drawing.Point(34, 396);
            resultBox.Name = "resultBox";
            resultBox.Size = new System.Drawing.Size(200, 111);
            resultBox.TabIndex = 108;
            resultBox.TabStop = false;
            resultBox.Text = "Результаты:";
            // 
            // SimpsonResultLabel
            // 
            SimpsonResultLabel.AutoSize = true;
            SimpsonResultLabel.Location = new System.Drawing.Point(10, 76);
            SimpsonResultLabel.Name = "SimpsonResultLabel";
            SimpsonResultLabel.Size = new System.Drawing.Size(61, 15);
            SimpsonResultLabel.TabIndex = 5;
            SimpsonResultLabel.Text = "Симпсон:";
            // 
            // trapezoidResultLabel
            // 
            trapezoidResultLabel.AutoSize = true;
            trapezoidResultLabel.Location = new System.Drawing.Point(10, 47);
            trapezoidResultLabel.Name = "trapezoidResultLabel";
            trapezoidResultLabel.Size = new System.Drawing.Size(63, 15);
            trapezoidResultLabel.TabIndex = 4;
            trapezoidResultLabel.Text = "Трапеции:";
            // 
            // rectangleResultLabel
            // 
            rectangleResultLabel.AutoSize = true;
            rectangleResultLabel.Location = new System.Drawing.Point(10, 21);
            rectangleResultLabel.Name = "rectangleResultLabel";
            rectangleResultLabel.Size = new System.Drawing.Size(62, 15);
            rectangleResultLabel.TabIndex = 3;
            rectangleResultLabel.Text = "Прямоуг.:";
            // 
            // simpsonResult
            // 
            simpsonResult.Location = new System.Drawing.Point(91, 76);
            simpsonResult.Name = "simpsonResult";
            simpsonResult.Size = new System.Drawing.Size(100, 23);
            simpsonResult.TabIndex = 2;
            // 
            // trapezoidResult
            // 
            trapezoidResult.Location = new System.Drawing.Point(91, 47);
            trapezoidResult.Name = "trapezoidResult";
            trapezoidResult.Size = new System.Drawing.Size(100, 23);
            trapezoidResult.TabIndex = 1;
            // 
            // rectangleResult
            // 
            rectangleResult.Location = new System.Drawing.Point(91, 18);
            rectangleResult.Name = "rectangleResult";
            rectangleResult.Size = new System.Drawing.Size(100, 23);
            rectangleResult.TabIndex = 0;
            // 
            // integral
            // 
            integral.AutoSize = true;
            integral.Font = new System.Drawing.Font("Segoe UI", 25F);
            integral.Location = new System.Drawing.Point(121, 73);
            integral.Name = "integral";
            integral.Size = new System.Drawing.Size(38, 46);
            integral.TabIndex = 109;
            integral.Text = "∫";
            // 
            // formatBox
            // 
            formatBox.Location = new System.Drawing.Point(217, 348);
            formatBox.Name = "formatBox";
            formatBox.Size = new System.Drawing.Size(100, 23);
            formatBox.TabIndex = 110;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(210, 328);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 15);
            label1.TabIndex = 111;
            label1.Text = "Заданная точность:";
            // 
            // recViz
            // 
            recViz.AllowDrop = true;
            recViz.AutoSize = true;
            recViz.Location = new System.Drawing.Point(217, 247);
            recViz.Name = "recViz";
            recViz.Size = new System.Drawing.Size(102, 19);
            recViz.TabIndex = 112;
            recViz.Text = "Визуализация";
            recViz.UseVisualStyleBackColor = true;
            // 
            // trapViz
            // 
            trapViz.AllowDrop = true;
            trapViz.AutoSize = true;
            trapViz.Location = new System.Drawing.Point(217, 272);
            trapViz.Name = "trapViz";
            trapViz.Size = new System.Drawing.Size(102, 19);
            trapViz.TabIndex = 113;
            trapViz.Text = "Визуализация";
            trapViz.UseVisualStyleBackColor = true;
            // 
            // simpsonViz
            // 
            simpsonViz.AllowDrop = true;
            simpsonViz.AutoSize = true;
            simpsonViz.Location = new System.Drawing.Point(217, 297);
            simpsonViz.Name = "simpsonViz";
            simpsonViz.Size = new System.Drawing.Size(102, 19);
            simpsonViz.TabIndex = 114;
            simpsonViz.Text = "Визуализация";
            simpsonViz.UseVisualStyleBackColor = true;
            // 
            // IntegralForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(924, 519);
            Controls.Add(simpsonViz);
            Controls.Add(trapViz);
            Controls.Add(recViz);
            Controls.Add(label1);
            Controls.Add(formatBox);
            Controls.Add(integral);
            Controls.Add(resultBox);
            Controls.Add(integralGroup);
            Controls.Add(upBorder);
            Controls.Add(lowBorder);
            Controls.Add(dx);
            Controls.Add(pvGraph);
            Controls.Add(MethodDesignLabel);
            Controls.Add(GraphDesignLabel);
            Controls.Add(label4);
            Controls.Add(interval);
            Controls.Add(functionLabel);
            Controls.Add(function);
            Controls.Add(menuStrip1);
            Name = "IntegralForm";
            Text = "IntegralForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            integralGroup.ResumeLayout(false);
            integralGroup.PerformLayout();
            resultBox.ResumeLayout(false);
            resultBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public OxyPlot.WindowsForms.PlotView pvGraph;
        private System.Windows.Forms.Label MethodDesignLabel;
        private System.Windows.Forms.Label GraphDesignLabel;
        internal System.Windows.Forms.Label IterationLabel;
        private System.Windows.Forms.TextBox IterationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label trapezoidResultLabel;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LimitationBox;
        private System.Windows.Forms.TextBox epsilonBox;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label countOfIterations;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox SecondIntervalLimitation;
        private System.Windows.Forms.TextBox IntervalLimitation;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Label dx;
        private System.Windows.Forms.TextBox lowBorder;
        private System.Windows.Forms.TextBox upBorder;
        private System.Windows.Forms.GroupBox integralGroup;
        private System.Windows.Forms.CheckBox rectangle;
        private System.Windows.Forms.CheckBox trapezoid;
        private System.Windows.Forms.CheckBox simpsonT;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.TextBox rectangleResult;
        private System.Windows.Forms.TextBox simpsonResult;
        private System.Windows.Forms.TextBox trapezoidResult;
        private System.Windows.Forms.Label integral;
        private System.Windows.Forms.Label SimpsonResultLabel;
        private System.Windows.Forms.Label rectangleResultLabel;
        private System.Windows.Forms.TextBox formatBox;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.CheckBox recViz;
        private System.Windows.Forms.CheckBox trapViz;
        private System.Windows.Forms.CheckBox simpsonViz;
    }
}