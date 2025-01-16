namespace Lab1
{
    partial class GoldenRatioForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.functionLimitBox = new System.Windows.Forms.TextBox();
            this.interval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LimitationBox = new System.Windows.Forms.TextBox();
            this.epsilonBox = new System.Windows.Forms.TextBox();
            this.rightLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.limitationLabel = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.SecondIntervalLimitation = new System.Windows.Forms.TextBox();
            this.FirstIntervalLimitation = new System.Windows.Forms.TextBox();
            this.function = new System.Windows.Forms.TextBox();
            this.pvGraph = new OxyPlot.WindowsForms.PlotView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minimumButton = new System.Windows.Forms.RadioButton();
            this.maximumButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "функции (полож. сторона)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "функции (отриц. сторона)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "осей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Число точек построения";
            // 
            // functionLimitBox
            // 
            this.functionLimitBox.Location = new System.Drawing.Point(33, 146);
            this.functionLimitBox.Name = "functionLimitBox";
            this.functionLimitBox.Size = new System.Drawing.Size(69, 20);
            this.functionLimitBox.TabIndex = 40;
            this.functionLimitBox.Text = "5";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(178, 149);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(69, 20);
            this.interval.TabIndex = 39;
            this.interval.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Необходимая точность (число знаков после запятой)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Epsilon";
            // 
            // LimitationBox
            // 
            this.LimitationBox.Location = new System.Drawing.Point(115, 344);
            this.LimitationBox.Name = "LimitationBox";
            this.LimitationBox.Size = new System.Drawing.Size(69, 20);
            this.LimitationBox.TabIndex = 36;
            this.LimitationBox.Text = "0";
            // 
            // epsilonBox
            // 
            this.epsilonBox.Location = new System.Drawing.Point(197, 283);
            this.epsilonBox.Name = "epsilonBox";
            this.epsilonBox.Size = new System.Drawing.Size(69, 20);
            this.epsilonBox.TabIndex = 35;
            this.epsilonBox.Text = "0,1";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Location = new System.Drawing.Point(112, 267);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(45, 13);
            this.rightLabel.TabIndex = 34;
            this.rightLabel.Text = "Правое";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(24, 267);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(39, 13);
            this.leftLabel.TabIndex = 33;
            this.leftLabel.Text = "Левое";
            // 
            // limitationLabel
            // 
            this.limitationLabel.AutoSize = true;
            this.limitationLabel.Location = new System.Drawing.Point(77, 244);
            this.limitationLabel.Name = "limitationLabel";
            this.limitationLabel.Size = new System.Drawing.Size(132, 13);
            this.limitationLabel.TabIndex = 32;
            this.limitationLabel.Text = "Ограничение интервала:";
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(21, 44);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(83, 13);
            this.functionLabel.TabIndex = 31;
            this.functionLabel.Text = "Ваша функция:";
            // 
            // SecondIntervalLimitation
            // 
            this.SecondIntervalLimitation.Location = new System.Drawing.Point(115, 283);
            this.SecondIntervalLimitation.Name = "SecondIntervalLimitation";
            this.SecondIntervalLimitation.Size = new System.Drawing.Size(69, 20);
            this.SecondIntervalLimitation.TabIndex = 30;
            this.SecondIntervalLimitation.Text = "5";
            // 
            // FirstIntervalLimitation
            // 
            this.FirstIntervalLimitation.Location = new System.Drawing.Point(24, 283);
            this.FirstIntervalLimitation.Name = "FirstIntervalLimitation";
            this.FirstIntervalLimitation.Size = new System.Drawing.Size(69, 20);
            this.FirstIntervalLimitation.TabIndex = 29;
            this.FirstIntervalLimitation.Text = "0";
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(24, 60);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(276, 20);
            this.function.TabIndex = 28;
            this.function.Text = "(x-2)^2";
            // 
            // pvGraph
            // 
            this.pvGraph.Location = new System.Drawing.Point(312, 34);
            this.pvGraph.Name = "pvGraph";
            this.pvGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pvGraph.Size = new System.Drawing.Size(476, 413);
            this.pvGraph.TabIndex = 27;
            this.pvGraph.Text = "plotView1";
            this.pvGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pvGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pvGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 46;
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
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click_1);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Искать";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maximumButton);
            this.groupBox1.Controls.Add(this.minimumButton);
            this.groupBox1.Location = new System.Drawing.Point(68, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 67);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ищем:";
            // 
            // minimumButton
            // 
            this.minimumButton.AutoSize = true;
            this.minimumButton.Location = new System.Drawing.Point(15, 19);
            this.minimumButton.Name = "minimumButton";
            this.minimumButton.Size = new System.Drawing.Size(73, 17);
            this.minimumButton.TabIndex = 0;
            this.minimumButton.Text = "Минимум";
            this.minimumButton.UseVisualStyleBackColor = true;
            // 
            // maximumButton
            // 
            this.maximumButton.AutoSize = true;
            this.maximumButton.Location = new System.Drawing.Point(15, 42);
            this.maximumButton.Name = "maximumButton";
            this.maximumButton.Size = new System.Drawing.Size(79, 17);
            this.maximumButton.TabIndex = 1;
            this.maximumButton.Text = "Максимум";
            this.maximumButton.UseVisualStyleBackColor = true;
            // 
            // GoldenRatioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "GoldenRatioForm";
            this.Text = "Метод Золотого сечения";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label limitationLabel;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox SecondIntervalLimitation;
        private System.Windows.Forms.TextBox FirstIntervalLimitation;
        private System.Windows.Forms.TextBox function;
        public OxyPlot.WindowsForms.PlotView pvGraph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton maximumButton;
        private System.Windows.Forms.RadioButton minimumButton;
    }
}