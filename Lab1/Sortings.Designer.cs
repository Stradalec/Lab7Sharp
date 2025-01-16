namespace Lab1
{
    partial class Sortings
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
            bubble = new System.Windows.Forms.CheckBox();
            inserts = new System.Windows.Forms.CheckBox();
            fast = new System.Windows.Forms.CheckBox();
            shake = new System.Windows.Forms.CheckBox();
            swamp = new System.Windows.Forms.CheckBox();
            sortGroup = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            iterationsSwamp = new System.Windows.Forms.TextBox();
            inputBox = new System.Windows.Forms.GroupBox();
            chooseFileButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            randomArray = new System.Windows.Forms.TextBox();
            file = new System.Windows.Forms.RadioButton();
            generation = new System.Windows.Forms.RadioButton();
            hand = new System.Windows.Forms.RadioButton();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            testingButton = new System.Windows.Forms.ToolStripTextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Iterations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            decreasing = new System.Windows.Forms.RadioButton();
            increasing = new System.Windows.Forms.RadioButton();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            left = new System.Windows.Forms.TextBox();
            right = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            doub = new System.Windows.Forms.RadioButton();
            integ = new System.Windows.Forms.RadioButton();
            sortGroup.SuspendLayout();
            inputBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // bubble
            // 
            bubble.AutoSize = true;
            bubble.Location = new System.Drawing.Point(15, 22);
            bubble.Name = "bubble";
            bubble.Size = new System.Drawing.Size(90, 19);
            bubble.TabIndex = 0;
            bubble.Text = "Пузырьком";
            bubble.UseVisualStyleBackColor = true;
            // 
            // inserts
            // 
            inserts.AutoSize = true;
            inserts.Location = new System.Drawing.Point(15, 54);
            inserts.Name = "inserts";
            inserts.Size = new System.Drawing.Size(84, 19);
            inserts.TabIndex = 1;
            inserts.Text = "Вставками";
            inserts.UseVisualStyleBackColor = true;
            // 
            // fast
            // 
            fast.AutoSize = true;
            fast.Location = new System.Drawing.Point(15, 88);
            fast.Name = "fast";
            fast.Size = new System.Drawing.Size(72, 19);
            fast.TabIndex = 2;
            fast.Text = "Быстрая";
            fast.UseVisualStyleBackColor = true;
            // 
            // shake
            // 
            shake.AutoSize = true;
            shake.Location = new System.Drawing.Point(15, 120);
            shake.Name = "shake";
            shake.Size = new System.Drawing.Size(88, 19);
            shake.TabIndex = 3;
            shake.Text = "Шейкерная";
            shake.UseVisualStyleBackColor = true;
            // 
            // swamp
            // 
            swamp.AutoSize = true;
            swamp.Location = new System.Drawing.Point(15, 154);
            swamp.Name = "swamp";
            swamp.Size = new System.Drawing.Size(78, 19);
            swamp.TabIndex = 4;
            swamp.Text = "Болотная";
            swamp.UseVisualStyleBackColor = true;
            // 
            // sortGroup
            // 
            sortGroup.AutoSize = true;
            sortGroup.Controls.Add(label1);
            sortGroup.Controls.Add(iterationsSwamp);
            sortGroup.Controls.Add(bubble);
            sortGroup.Controls.Add(swamp);
            sortGroup.Controls.Add(inserts);
            sortGroup.Controls.Add(shake);
            sortGroup.Controls.Add(fast);
            sortGroup.Location = new System.Drawing.Point(12, 30);
            sortGroup.Margin = new System.Windows.Forms.Padding(5);
            sortGroup.Name = "sortGroup";
            sortGroup.Size = new System.Drawing.Size(216, 195);
            sortGroup.TabIndex = 5;
            sortGroup.TabStop = false;
            sortGroup.Text = "Сортировки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(116, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 15);
            label1.TabIndex = 7;
            label1.Text = "Макс. итераций";
            // 
            // iterationsSwamp
            // 
            iterationsSwamp.Location = new System.Drawing.Point(116, 150);
            iterationsSwamp.Name = "iterationsSwamp";
            iterationsSwamp.Size = new System.Drawing.Size(94, 23);
            iterationsSwamp.TabIndex = 5;
            // 
            // inputBox
            // 
            inputBox.AutoSize = true;
            inputBox.Controls.Add(chooseFileButton);
            inputBox.Controls.Add(label2);
            inputBox.Controls.Add(randomArray);
            inputBox.Controls.Add(file);
            inputBox.Controls.Add(generation);
            inputBox.Controls.Add(hand);
            inputBox.Location = new System.Drawing.Point(245, 30);
            inputBox.Name = "inputBox";
            inputBox.Size = new System.Drawing.Size(194, 137);
            inputBox.TabIndex = 6;
            inputBox.TabStop = false;
            inputBox.Text = "Тип ввода";
            // 
            // chooseFileButton
            // 
            chooseFileButton.Location = new System.Drawing.Point(99, 92);
            chooseFileButton.Name = "chooseFileButton";
            chooseFileButton.Size = new System.Drawing.Size(89, 23);
            chooseFileButton.TabIndex = 10;
            chooseFileButton.Text = "Выбор пути";
            chooseFileButton.UseVisualStyleBackColor = true;
            chooseFileButton.Click += chooseFileButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(112, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 9;
            label2.Text = "Сколько?";
            // 
            // randomArray
            // 
            randomArray.Location = new System.Drawing.Point(99, 58);
            randomArray.Name = "randomArray";
            randomArray.Size = new System.Drawing.Size(89, 23);
            randomArray.TabIndex = 8;
            // 
            // file
            // 
            file.AutoSize = true;
            file.Location = new System.Drawing.Point(6, 94);
            file.Name = "file";
            file.Size = new System.Drawing.Size(77, 19);
            file.TabIndex = 2;
            file.TabStop = true;
            file.Text = "Из файла";
            file.UseVisualStyleBackColor = true;
            // 
            // generation
            // 
            generation.AutoSize = true;
            generation.Location = new System.Drawing.Point(6, 58);
            generation.Name = "generation";
            generation.Size = new System.Drawing.Size(83, 19);
            generation.TabIndex = 1;
            generation.TabStop = true;
            generation.Text = "Генерация";
            generation.UseVisualStyleBackColor = true;
            // 
            // hand
            // 
            hand.AutoSize = true;
            hand.Location = new System.Drawing.Point(6, 22);
            hand.Name = "hand";
            hand.Size = new System.Drawing.Size(66, 19);
            hand.TabIndex = 0;
            hand.TabStop = true;
            hand.Text = "Ручной";
            hand.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripTextBox1, toolStripTextBox2, testingButton });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 27);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            toolStripTextBox1.Text = "Начать ввод";
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.ReadOnly = true;
            toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            toolStripTextBox2.Text = "Сортировать";
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // testingButton
            // 
            testingButton.Name = "testingButton";
            testingButton.ReadOnly = true;
            testingButton.Size = new System.Drawing.Size(100, 23);
            testingButton.Text = "Тестирование";
            testingButton.Click += testingButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new System.Drawing.Point(601, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(146, 195);
            dataGridView1.TabIndex = 8;
            dataGridView1.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Числа для сортировки";
            Column1.Name = "Column1";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Method, Iterations, Time, Column4 });
            dataGridView2.Location = new System.Drawing.Point(12, 250);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new System.Drawing.Size(445, 188);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Method
            // 
            Method.HeaderText = "Метод";
            Method.Name = "Method";
            // 
            // Iterations
            // 
            Iterations.HeaderText = "Итерации";
            Iterations.Name = "Iterations";
            // 
            // Time
            // 
            Time.HeaderText = "Время";
            Time.Name = "Time";
            // 
            // Column4
            // 
            Column4.HeaderText = "Открыть файл";
            Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(decreasing);
            groupBox1.Controls.Add(increasing);
            groupBox1.Location = new System.Drawing.Point(245, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(194, 63);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сортировка по:";
            // 
            // decreasing
            // 
            decreasing.AutoSize = true;
            decreasing.Location = new System.Drawing.Point(104, 22);
            decreasing.Name = "decreasing";
            decreasing.Size = new System.Drawing.Size(84, 19);
            decreasing.TabIndex = 2;
            decreasing.TabStop = true;
            decreasing.Text = "Убыванию";
            decreasing.UseVisualStyleBackColor = true;
            // 
            // increasing
            // 
            increasing.AutoSize = true;
            increasing.Location = new System.Drawing.Point(6, 22);
            increasing.Name = "increasing";
            increasing.Size = new System.Drawing.Size(98, 19);
            increasing.TabIndex = 1;
            increasing.TabStop = true;
            increasing.Text = "Возрастанию";
            increasing.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(454, 200);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(107, 23);
            progressBar1.TabIndex = 11;
            // 
            // left
            // 
            left.Location = new System.Drawing.Point(463, 45);
            left.Name = "left";
            left.Size = new System.Drawing.Size(66, 23);
            left.TabIndex = 12;
            // 
            // right
            // 
            right.Location = new System.Drawing.Point(463, 95);
            right.Name = "right";
            right.Size = new System.Drawing.Size(66, 23);
            right.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(445, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(107, 15);
            label3.TabIndex = 14;
            label3.Text = "Нижний диапазон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(445, 77);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 15);
            label4.TabIndex = 15;
            label4.Text = "Верхний диапазон";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(doub);
            groupBox2.Controls.Add(integ);
            groupBox2.Location = new System.Drawing.Point(454, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(107, 69);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Генерировать:";
            // 
            // doub
            // 
            doub.AutoSize = true;
            doub.Location = new System.Drawing.Point(8, 44);
            doub.Name = "doub";
            doub.Size = new System.Drawing.Size(76, 19);
            doub.TabIndex = 1;
            doub.TabStop = true;
            doub.Text = "Дробные";
            doub.UseVisualStyleBackColor = true;
            // 
            // integ
            // 
            integ.AutoSize = true;
            integ.Location = new System.Drawing.Point(8, 22);
            integ.Name = "integ";
            integ.Size = new System.Drawing.Size(62, 19);
            integ.TabIndex = 0;
            integ.TabStop = true;
            integ.Text = "Целые";
            integ.UseVisualStyleBackColor = true;
            // 
            // Sortings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(progressBar1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(inputBox);
            Controls.Add(sortGroup);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Sortings";
            Text = "Sortings";
            sortGroup.ResumeLayout(false);
            sortGroup.PerformLayout();
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox bubble;
        private System.Windows.Forms.CheckBox inserts;
        private System.Windows.Forms.CheckBox fast;
        private System.Windows.Forms.CheckBox shake;
        private System.Windows.Forms.CheckBox swamp;
        private System.Windows.Forms.GroupBox sortGroup;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.RadioButton file;
        private System.Windows.Forms.RadioButton generation;
        private System.Windows.Forms.RadioButton hand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iterationsSwamp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decreasing;
        private System.Windows.Forms.RadioButton increasing;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox randomArray;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.ToolStripTextBox testingButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.TextBox right;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iterations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton doub;
        private System.Windows.Forms.RadioButton integ;
    }
}