namespace Lab1
{
    partial class SystemLinearAlgebraicEquations
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
            button1 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            startCalculate = new System.Windows.Forms.Button();
            Choose = new System.Windows.Forms.GroupBox();
            Cramer = new System.Windows.Forms.RadioButton();
            JordanoGauss = new System.Windows.Forms.RadioButton();
            Gauss = new System.Windows.Forms.RadioButton();
            input = new System.Windows.Forms.GroupBox();
            file = new System.Windows.Forms.RadioButton();
            hand = new System.Windows.Forms.RadioButton();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            size = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Choose.SuspendLayout();
            input.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(490, 163);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(104, 23);
            button1.TabIndex = 0;
            button1.Text = "Начать ввод";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(490, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(325, 249);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(354, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new System.Drawing.Size(108, 249);
            dataGridView2.TabIndex = 3;
            // 
            // startCalculate
            // 
            startCalculate.Location = new System.Drawing.Point(655, 138);
            startCalculate.Name = "startCalculate";
            startCalculate.Size = new System.Drawing.Size(75, 23);
            startCalculate.TabIndex = 4;
            startCalculate.Text = "Посчитать";
            startCalculate.UseVisualStyleBackColor = true;
            startCalculate.Click += startCalculate_Click;
            // 
            // Choose
            // 
            Choose.Controls.Add(Cramer);
            Choose.Controls.Add(JordanoGauss);
            Choose.Controls.Add(Gauss);
            Choose.Location = new System.Drawing.Point(626, 14);
            Choose.Name = "Choose";
            Choose.Size = new System.Drawing.Size(132, 100);
            Choose.TabIndex = 5;
            Choose.TabStop = false;
            Choose.Text = "Выбор метода";
            // 
            // Cramer
            // 
            Cramer.AutoSize = true;
            Cramer.Location = new System.Drawing.Point(11, 72);
            Cramer.Name = "Cramer";
            Cramer.Size = new System.Drawing.Size(67, 19);
            Cramer.TabIndex = 2;
            Cramer.TabStop = true;
            Cramer.Text = "Крамер";
            Cramer.UseVisualStyleBackColor = true;
            // 
            // JordanoGauss
            // 
            JordanoGauss.AutoSize = true;
            JordanoGauss.Location = new System.Drawing.Point(11, 47);
            JordanoGauss.Name = "JordanoGauss";
            JordanoGauss.Size = new System.Drawing.Size(111, 19);
            JordanoGauss.TabIndex = 1;
            JordanoGauss.TabStop = true;
            JordanoGauss.Text = "Жордано-Гаусс";
            JordanoGauss.UseVisualStyleBackColor = true;
            // 
            // Gauss
            // 
            Gauss.AutoSize = true;
            Gauss.Location = new System.Drawing.Point(11, 22);
            Gauss.Name = "Gauss";
            Gauss.Size = new System.Drawing.Size(55, 19);
            Gauss.TabIndex = 0;
            Gauss.TabStop = true;
            Gauss.Text = "Гаусс";
            Gauss.UseVisualStyleBackColor = true;
            // 
            // input
            // 
            input.Controls.Add(file);
            input.Controls.Add(hand);
            input.Location = new System.Drawing.Point(490, 69);
            input.Name = "input";
            input.Size = new System.Drawing.Size(109, 85);
            input.TabIndex = 6;
            input.TabStop = false;
            input.Text = "Ввод:";
            // 
            // file
            // 
            file.AutoSize = true;
            file.Location = new System.Drawing.Point(8, 51);
            file.Name = "file";
            file.Size = new System.Drawing.Size(77, 19);
            file.TabIndex = 1;
            file.TabStop = true;
            file.Text = "Из файла";
            file.UseVisualStyleBackColor = true;
            // 
            // hand
            // 
            hand.AutoSize = true;
            hand.Location = new System.Drawing.Point(8, 26);
            hand.Name = "hand";
            hand.Size = new System.Drawing.Size(66, 19);
            hand.TabIndex = 0;
            hand.TabStop = true;
            hand.Text = "Ручной";
            hand.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // size
            // 
            size.AutoSize = true;
            size.Location = new System.Drawing.Point(486, 14);
            size.Name = "size";
            size.Size = new System.Drawing.Size(134, 15);
            size.TabIndex = 7;
            size.Text = "Размерность матрицы:";
            // 
            // SystemLinearAlgebraicEquations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 522);
            Controls.Add(size);
            Controls.Add(input);
            Controls.Add(Choose);
            Controls.Add(startCalculate);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "SystemLinearAlgebraicEquations";
            Text = "SystemLinearAlgebraicEquations";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Choose.ResumeLayout(false);
            Choose.PerformLayout();
            input.ResumeLayout(false);
            input.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button startCalculate;
        private System.Windows.Forms.GroupBox Choose;
        private System.Windows.Forms.RadioButton Gauss;
        private System.Windows.Forms.RadioButton Cramer;
        private System.Windows.Forms.RadioButton JordanoGauss;
        private System.Windows.Forms.GroupBox input;
        private System.Windows.Forms.RadioButton file;
        private System.Windows.Forms.RadioButton hand;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label size;
    }
}