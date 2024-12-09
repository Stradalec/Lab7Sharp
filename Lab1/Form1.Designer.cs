namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dichotomyButton = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            richTextBox6 = new System.Windows.Forms.RichTextBox();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            richTextBox5 = new System.Windows.Forms.RichTextBox();
            richTextBox4 = new System.Windows.Forms.RichTextBox();
            richTextBox3 = new System.Windows.Forms.RichTextBox();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            coordinateDescentButton = new System.Windows.Forms.Button();
            sortingsButton = new System.Windows.Forms.Button();
            GoldenRatioButton = new System.Windows.Forms.Button();
            NewtonButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            integralButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SLAU = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dichotomyButton
            // 
            dichotomyButton.AutoSize = true;
            dichotomyButton.Location = new System.Drawing.Point(817, 5);
            dichotomyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dichotomyButton.Name = "dichotomyButton";
            dichotomyButton.Size = new System.Drawing.Size(192, 54);
            dichotomyButton.TabIndex = 0;
            dichotomyButton.Text = "Метод Дихотомии";
            dichotomyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            dichotomyButton.UseVisualStyleBackColor = true;
            dichotomyButton.Click += dichotomyButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(richTextBox6, 1, 5);
            tableLayoutPanel1.Controls.Add(pictureBox6, 0, 5);
            tableLayoutPanel1.Controls.Add(pictureBox5, 0, 4);
            tableLayoutPanel1.Controls.Add(pictureBox4, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBox5, 1, 4);
            tableLayoutPanel1.Controls.Add(richTextBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(richTextBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(richTextBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(coordinateDescentButton, 2, 3);
            tableLayoutPanel1.Controls.Add(sortingsButton, 2, 4);
            tableLayoutPanel1.Controls.Add(dichotomyButton, 2, 0);
            tableLayoutPanel1.Controls.Add(GoldenRatioButton, 2, 1);
            tableLayoutPanel1.Controls.Add(NewtonButton, 2, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(integralButton, 2, 5);
            tableLayoutPanel1.Controls.Add(SLAU, 2, 6);
            tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new System.Drawing.Point(11, 72);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1017, 498);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new System.Drawing.Point(128, 315);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.ReadOnly = true;
            richTextBox6.Size = new System.Drawing.Size(667, 46);
            richTextBox6.TabIndex = 17;
            richTextBox6.Text = "Расчёт интеграла.\nРасчёт интеграла различнейшими способами.\n\n\n\n\n\n\n\n\nКто вообще это читает?";
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new System.Drawing.Point(7, 315);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(110, 54);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(7, 253);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(110, 54);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(7, 191);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(110, 54);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(7, 129);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(110, 54);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(7, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(110, 54);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new System.Drawing.Point(128, 253);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new System.Drawing.Size(667, 46);
            richTextBox5.TabIndex = 9;
            richTextBox5.Text = "Сортировки.\nСортировки различнейшими способами.\n\n\n";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new System.Drawing.Point(128, 191);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new System.Drawing.Size(667, 46);
            richTextBox4.TabIndex = 8;
            richTextBox4.Text = "Метод покоординатного спуска\nИспользуется для нахождения минимума, максимума функции.\nПостепенное приближение с заданным шагом.\nМетод плох для плоских задач.\n\n";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new System.Drawing.Point(128, 129);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new System.Drawing.Size(667, 46);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "Метод Ньютона\nИспользуется для нахождения минимума, максимума функции, а также точки пересечения её с осью абсциис.\nНахождение касательных к функции.\nМетод хорош для плоских задач.\n\n";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new System.Drawing.Point(128, 67);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new System.Drawing.Size(667, 46);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(128, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(667, 46);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // coordinateDescentButton
            // 
            coordinateDescentButton.AutoSize = true;
            coordinateDescentButton.Location = new System.Drawing.Point(817, 191);
            coordinateDescentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            coordinateDescentButton.Name = "coordinateDescentButton";
            coordinateDescentButton.Size = new System.Drawing.Size(193, 54);
            coordinateDescentButton.TabIndex = 3;
            coordinateDescentButton.Text = "Метод покоординатного спуска";
            coordinateDescentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            coordinateDescentButton.UseVisualStyleBackColor = true;
            coordinateDescentButton.Click += coordinateDescentButton_Click;
            // 
            // sortingsButton
            // 
            sortingsButton.AutoSize = true;
            sortingsButton.Location = new System.Drawing.Point(817, 253);
            sortingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sortingsButton.Name = "sortingsButton";
            sortingsButton.Size = new System.Drawing.Size(192, 54);
            sortingsButton.TabIndex = 4;
            sortingsButton.Text = "Сортировки";
            sortingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sortingsButton.UseVisualStyleBackColor = true;
            sortingsButton.Click += sortingsButton_Click;
            // 
            // GoldenRatioButton
            // 
            GoldenRatioButton.AutoSize = true;
            GoldenRatioButton.Location = new System.Drawing.Point(817, 67);
            GoldenRatioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GoldenRatioButton.Name = "GoldenRatioButton";
            GoldenRatioButton.Size = new System.Drawing.Size(192, 54);
            GoldenRatioButton.TabIndex = 1;
            GoldenRatioButton.Text = "Метод Золотого Сечения";
            GoldenRatioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            GoldenRatioButton.UseVisualStyleBackColor = true;
            GoldenRatioButton.Click += GoldenRatioButton_Click;
            // 
            // NewtonButton
            // 
            NewtonButton.AutoSize = true;
            NewtonButton.Location = new System.Drawing.Point(817, 129);
            NewtonButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewtonButton.Name = "NewtonButton";
            NewtonButton.Size = new System.Drawing.Size(192, 54);
            NewtonButton.TabIndex = 2;
            NewtonButton.Text = "Метод Ньютона";
            NewtonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            NewtonButton.UseVisualStyleBackColor = true;
            NewtonButton.Click += NewtonButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(7, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(110, 54);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // integralButton
            // 
            integralButton.AutoSize = true;
            integralButton.Location = new System.Drawing.Point(817, 315);
            integralButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            integralButton.Name = "integralButton";
            integralButton.Size = new System.Drawing.Size(193, 54);
            integralButton.TabIndex = 15;
            integralButton.Text = "Интеграл";
            integralButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            integralButton.UseVisualStyleBackColor = true;
            integralButton.Click += integralButton_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            label1.Location = new System.Drawing.Point(355, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(313, 28);
            label1.TabIndex = 2;
            label1.Text = "Численные методы (и не только)";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(326, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(374, 15);
            label2.TabIndex = 3;
            label2.Text = "Перед использованием рекомендуется ознакомиться со справкой";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(706, 39);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Справка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SLAU
            // 
            SLAU.AutoSize = true;
            SLAU.Location = new System.Drawing.Point(817, 377);
            SLAU.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SLAU.Name = "SLAU";
            SLAU.Size = new System.Drawing.Size(192, 54);
            SLAU.TabIndex = 18;
            SLAU.Text = "СЛАУ";
            SLAU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            SLAU.UseVisualStyleBackColor = true;
            SLAU.Click += SLAU_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1057, 614);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Приложение";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button dichotomyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GoldenRatioButton;
        private System.Windows.Forms.Button NewtonButton;
        private System.Windows.Forms.Button coordinateDescentButton;
        private System.Windows.Forms.Button sortingsButton;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button integralButton;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Button SLAU;
    }
}

