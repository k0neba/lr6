namespace lr6vrode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_calculate = new Button();
            button_clear = new Button();
            button_exit = new Button();
            label_x1 = new Label();
            label_X2 = new Label();
            label_resulatate = new Label();
            label_x1_x2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label_sqrt = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button_calculate
            // 
            button_calculate.Location = new Point(24, 504);
            button_calculate.Margin = new Padding(3, 4, 3, 4);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(221, 65);
            button_calculate.TabIndex = 0;
            button_calculate.Text = "Обчислить";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(336, 504);
            button_clear.Margin = new Padding(3, 4, 3, 4);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(221, 65);
            button_clear.TabIndex = 1;
            button_clear.Text = "Очистить";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(647, 504);
            button_exit.Margin = new Padding(3, 4, 3, 4);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(221, 65);
            button_exit.TabIndex = 2;
            button_exit.Text = "Вихід";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // label_x1
            // 
            label_x1.AutoSize = true;
            label_x1.Location = new Point(149, 39);
            label_x1.Name = "label_x1";
            label_x1.Size = new Size(86, 20);
            label_x1.TabIndex = 3;
            label_x1.Text = "Змінна Х1: ";
            label_x1.Click += label1_Click;
            // 
            // label_X2
            // 
            label_X2.AutoSize = true;
            label_X2.Location = new Point(149, 119);
            label_X2.Name = "label_X2";
            label_X2.Size = new Size(82, 20);
            label_X2.TabIndex = 4;
            label_X2.Text = "Змінна Х2:";
            label_X2.Click += label2_Click;
            // 
            // label_resulatate
            // 
            label_resulatate.AutoSize = true;
            label_resulatate.Location = new Point(24, 212);
            label_resulatate.Name = "label_resulatate";
            label_resulatate.Size = new Size(220, 20);
            label_resulatate.TabIndex = 5;
            label_resulatate.Text = "Результат обчислення функції:";
            // 
            // label_x1_x2
            // 
            label_x1_x2.AutoSize = true;
            label_x1_x2.Location = new Point(23, 304);
            label_x1_x2.Name = "label_x1_x2";
            label_x1_x2.Size = new Size(222, 20);
            label_x1_x2.TabIndex = 6;
            label_x1_x2.Text = "Середьне арефметичне Х1, Х2:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 39);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 119);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(336, 212);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(336, 304);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label_sqrt
            // 
            label_sqrt.AutoSize = true;
            label_sqrt.Location = new Point(24, 379);
            label_sqrt.Name = "label_sqrt";
            label_sqrt.Size = new Size(219, 20);
            label_sqrt.TabIndex = 11;
            label_sqrt.Text = "Середьне геометричне Х1, Х2:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(336, 379);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 27);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox5);
            Controls.Add(label_sqrt);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_x1_x2);
            Controls.Add(label_resulatate);
            Controls.Add(label_X2);
            Controls.Add(label_x1);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(button_calculate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Калькулятор f(x1,x2)=(x1^2)+(x2*3)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_calculate;
        private Button button_clear;
        private Button button_exit;
        private Label label_x1;
        private Label label_X2;
        private Label label_resulatate;
        private Label label_x1_x2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label_sqrt;
        private TextBox textBox5;
    }
}
