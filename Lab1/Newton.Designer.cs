namespace Lab1
{
    partial class Newton
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
            textBox1 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            functionLimitBox = new System.Windows.Forms.TextBox();
            interval = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            LimitationBox = new System.Windows.Forms.TextBox();
            epsilonBox = new System.Windows.Forms.TextBox();
            rightLabel = new System.Windows.Forms.Label();
            leftLabel = new System.Windows.Forms.Label();
            functionLabel = new System.Windows.Forms.Label();
            SecondIntervalLimitation = new System.Windows.Forms.TextBox();
            FirstIntervalLimitation = new System.Windows.Forms.TextBox();
            function = new System.Windows.Forms.TextBox();
            pvGraph = new OxyPlot.WindowsForms.PlotView();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            IterationLabel = new System.Windows.Forms.Label();
            IterationBox = new System.Windows.Forms.TextBox();
            GraphDesignLabel = new System.Windows.Forms.Label();
            MethodDesignLabel = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(35, 242);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(80, 23);
            textBox1.TabIndex = 45;
            textBox1.Text = "5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(31, 222);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(155, 15);
            label7.TabIndex = 44;
            label7.Text = "функции (полож. сторона)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(31, 166);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(151, 15);
            label6.TabIndex = 43;
            label6.Text = "функции (отриц. сторона)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(204, 166);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(33, 15);
            label5.TabIndex = 42;
            label5.Text = "осей";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(31, 136);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(144, 15);
            label4.TabIndex = 41;
            label4.Text = "Число точек построения";
            // 
            // functionLimitBox
            // 
            functionLimitBox.Location = new System.Drawing.Point(35, 185);
            functionLimitBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            functionLimitBox.Name = "functionLimitBox";
            functionLimitBox.Size = new System.Drawing.Size(80, 23);
            functionLimitBox.TabIndex = 40;
            functionLimitBox.Text = "5";
            // 
            // interval
            // 
            interval.Location = new System.Drawing.Point(204, 188);
            interval.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            interval.Name = "interval";
            interval.Size = new System.Drawing.Size(80, 23);
            interval.TabIndex = 39;
            interval.Text = "5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 436);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 15);
            label2.TabIndex = 38;
            label2.Text = "Необходимая точность";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 372);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 37;
            label1.Text = "Epsilon";
            // 
            // LimitationBox
            // 
            LimitationBox.Location = new System.Drawing.Point(31, 455);
            LimitationBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LimitationBox.Name = "LimitationBox";
            LimitationBox.Size = new System.Drawing.Size(80, 23);
            LimitationBox.TabIndex = 36;
            LimitationBox.Text = "0";
            // 
            // epsilonBox
            // 
            epsilonBox.Location = new System.Drawing.Point(31, 390);
            epsilonBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            epsilonBox.Name = "epsilonBox";
            epsilonBox.Size = new System.Drawing.Size(80, 23);
            epsilonBox.TabIndex = 35;
            epsilonBox.Text = "0,1";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Location = new System.Drawing.Point(191, 316);
            rightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new System.Drawing.Size(126, 15);
            rightLabel.TabIndex = 34;
            rightLabel.Text = "Знач. для числ. дифф";
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Location = new System.Drawing.Point(28, 316);
            leftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new System.Drawing.Size(112, 15);
            leftLabel.TabIndex = 33;
            leftLabel.Text = "Нач. приближение";
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Location = new System.Drawing.Point(31, 81);
            functionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new System.Drawing.Size(91, 15);
            functionLabel.TabIndex = 31;
            functionLabel.Text = "Ваша функция:";
            // 
            // SecondIntervalLimitation
            // 
            SecondIntervalLimitation.Location = new System.Drawing.Point(195, 335);
            SecondIntervalLimitation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SecondIntervalLimitation.Name = "SecondIntervalLimitation";
            SecondIntervalLimitation.Size = new System.Drawing.Size(80, 23);
            SecondIntervalLimitation.TabIndex = 30;
            SecondIntervalLimitation.Text = "0,01";
            // 
            // FirstIntervalLimitation
            // 
            FirstIntervalLimitation.Location = new System.Drawing.Point(31, 335);
            FirstIntervalLimitation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FirstIntervalLimitation.Name = "FirstIntervalLimitation";
            FirstIntervalLimitation.Size = new System.Drawing.Size(80, 23);
            FirstIntervalLimitation.TabIndex = 29;
            FirstIntervalLimitation.Text = "0";
            // 
            // function
            // 
            function.Location = new System.Drawing.Point(35, 99);
            function.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            function.Name = "function";
            function.Size = new System.Drawing.Size(321, 23);
            function.TabIndex = 28;
            function.Text = "-x^3+3*x^2+4";
            // 
            // pvGraph
            // 
            pvGraph.Location = new System.Drawing.Point(364, 14);
            pvGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pvGraph.Name = "pvGraph";
            pvGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            pvGraph.Size = new System.Drawing.Size(555, 477);
            pvGraph.TabIndex = 27;
            pvGraph.Text = "plotView1";
            pvGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            pvGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            pvGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(933, 27);
            menuStrip1.TabIndex = 46;
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
            // IterationLabel
            // 
            IterationLabel.AutoSize = true;
            IterationLabel.Location = new System.Drawing.Point(191, 372);
            IterationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            IterationLabel.Name = "IterationLabel";
            IterationLabel.Size = new System.Drawing.Size(97, 15);
            IterationLabel.TabIndex = 50;
            IterationLabel.Text = "Число итераций";
            // 
            // IterationBox
            // 
            IterationBox.Location = new System.Drawing.Point(195, 390);
            IterationBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            IterationBox.Name = "IterationBox";
            IterationBox.Size = new System.Drawing.Size(80, 23);
            IterationBox.TabIndex = 49;
            IterationBox.Text = "10";
            // 
            // GraphDesignLabel
            // 
            GraphDesignLabel.AutoSize = true;
            GraphDesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            GraphDesignLabel.Location = new System.Drawing.Point(30, 42);
            GraphDesignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            GraphDesignLabel.Name = "GraphDesignLabel";
            GraphDesignLabel.Size = new System.Drawing.Size(254, 20);
            GraphDesignLabel.TabIndex = 51;
            GraphDesignLabel.Text = "Настройка построения графика";
            // 
            // MethodDesignLabel
            // 
            MethodDesignLabel.AutoSize = true;
            MethodDesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            MethodDesignLabel.Location = new System.Drawing.Point(27, 277);
            MethodDesignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MethodDesignLabel.Name = "MethodDesignLabel";
            MethodDesignLabel.Size = new System.Drawing.Size(213, 20);
            MethodDesignLabel.TabIndex = 52;
            MethodDesignLabel.Text = "Настройка работы метода";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new System.Drawing.Point(195, 420);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(132, 85);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(9, 59);
            radioButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(85, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Максимум";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(9, 37);
            radioButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(81, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Минимум";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(9, 16);
            radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(98, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Пересечение";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Newton
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(groupBox1);
            Controls.Add(MethodDesignLabel);
            Controls.Add(GraphDesignLabel);
            Controls.Add(IterationLabel);
            Controls.Add(IterationBox);
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
            Controls.Add(functionLabel);
            Controls.Add(SecondIntervalLimitation);
            Controls.Add(FirstIntervalLimitation);
            Controls.Add(function);
            Controls.Add(pvGraph);
            Controls.Add(menuStrip1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Newton";
            Text = "Newton";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox functionLimitBox;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LimitationBox;
        private System.Windows.Forms.TextBox epsilonBox;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox SecondIntervalLimitation;
        private System.Windows.Forms.TextBox FirstIntervalLimitation;
        private System.Windows.Forms.TextBox function;
        public OxyPlot.WindowsForms.PlotView pvGraph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        internal System.Windows.Forms.Label IterationLabel;
        private System.Windows.Forms.TextBox IterationBox;
        private System.Windows.Forms.Label GraphDesignLabel;
        private System.Windows.Forms.Label MethodDesignLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}