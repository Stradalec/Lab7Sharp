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
            Cramer = new System.Windows.Forms.CheckBox();
            JordanoGauss = new System.Windows.Forms.CheckBox();
            Gauss = new System.Windows.Forms.CheckBox();
            input = new System.Windows.Forms.GroupBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            generate = new System.Windows.Forms.RadioButton();
            file = new System.Windows.Forms.RadioButton();
            hand = new System.Windows.Forms.RadioButton();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            size = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            richTextBox3 = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Choose.SuspendLayout();
            input.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(490, 238);
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
            startCalculate.Location = new System.Drawing.Point(655, 118);
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
            Cramer.Size = new System.Drawing.Size(68, 19);
            Cramer.TabIndex = 10;
            Cramer.Text = "Крамер";
            Cramer.UseVisualStyleBackColor = true;
            // 
            // JordanoGauss
            // 
            JordanoGauss.AutoSize = true;
            JordanoGauss.Location = new System.Drawing.Point(11, 47);
            JordanoGauss.Name = "JordanoGauss";
            JordanoGauss.Size = new System.Drawing.Size(112, 19);
            JordanoGauss.TabIndex = 9;
            JordanoGauss.Text = "Жордано-Гаусс";
            JordanoGauss.UseVisualStyleBackColor = true;
            // 
            // Gauss
            // 
            Gauss.AutoSize = true;
            Gauss.Location = new System.Drawing.Point(11, 22);
            Gauss.Name = "Gauss";
            Gauss.Size = new System.Drawing.Size(56, 19);
            Gauss.TabIndex = 8;
            Gauss.Text = "Гаусс";
            Gauss.UseVisualStyleBackColor = true;
            // 
            // input
            // 
            input.Controls.Add(textBox2);
            input.Controls.Add(label1);
            input.Controls.Add(generate);
            input.Controls.Add(file);
            input.Controls.Add(hand);
            input.Location = new System.Drawing.Point(490, 69);
            input.Name = "input";
            input.Size = new System.Drawing.Size(109, 163);
            input.TabIndex = 6;
            input.TabStop = false;
            input.Text = "Ввод:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(14, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(81, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 102);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Диапазон";
            // 
            // generate
            // 
            generate.AutoSize = true;
            generate.Location = new System.Drawing.Point(7, 80);
            generate.Name = "generate";
            generate.Size = new System.Drawing.Size(83, 19);
            generate.TabIndex = 2;
            generate.TabStop = true;
            generate.Text = "Генерация";
            generate.UseVisualStyleBackColor = true;
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
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(18, 311);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(183, 199);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new System.Drawing.Point(217, 311);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new System.Drawing.Size(183, 199);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new System.Drawing.Point(416, 311);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new System.Drawing.Size(183, 199);
            richTextBox3.TabIndex = 10;
            richTextBox3.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(97, 290);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 15);
            label2.TabIndex = 11;
            label2.Text = "Гаусс";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(265, 290);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 15);
            label3.TabIndex = 12;
            label3.Text = "Гаусс-Жордано";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(490, 290);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 15);
            label4.TabIndex = 13;
            label4.Text = "Крамер";
            // 
            // SystemLinearAlgebraicEquations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 522);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
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
        private System.Windows.Forms.GroupBox input;
        private System.Windows.Forms.RadioButton file;
        private System.Windows.Forms.RadioButton hand;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.RadioButton generate;
        private System.Windows.Forms.CheckBox Cramer;
        private System.Windows.Forms.CheckBox JordanoGauss;
        private System.Windows.Forms.CheckBox Gauss;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}