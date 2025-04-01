namespace Calculator
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
            textBox1 = new TextBox();
            one = new Button();
            two = new Button();
            three = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            zero = new Button();
            plus = new Button();
            divide = new Button();
            mul = new Button();
            minus = new Button();
            clear = new Button();
            equal = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // one
            // 
            one.Location = new Point(164, 112);
            one.Name = "one";
            one.Size = new Size(112, 34);
            one.TabIndex = 1;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // two
            // 
            two.Location = new Point(293, 112);
            two.Name = "two";
            two.Size = new Size(112, 34);
            two.TabIndex = 2;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // three
            // 
            three.Location = new Point(424, 112);
            three.Name = "three";
            three.Size = new Size(112, 34);
            three.TabIndex = 3;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // four
            // 
            four.Location = new Point(552, 112);
            four.Name = "four";
            four.Size = new Size(112, 34);
            four.TabIndex = 4;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // five
            // 
            five.Location = new Point(164, 172);
            five.Name = "five";
            five.Size = new Size(112, 34);
            five.TabIndex = 5;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // six
            // 
            six.Location = new Point(293, 172);
            six.Name = "six";
            six.Size = new Size(112, 34);
            six.TabIndex = 6;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // seven
            // 
            seven.Location = new Point(424, 172);
            seven.Name = "seven";
            seven.Size = new Size(112, 34);
            seven.TabIndex = 7;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // eight
            // 
            eight.Location = new Point(552, 172);
            eight.Name = "eight";
            eight.Size = new Size(112, 34);
            eight.TabIndex = 8;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // nine
            // 
            nine.Location = new Point(164, 230);
            nine.Name = "nine";
            nine.Size = new Size(112, 34);
            nine.TabIndex = 9;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // zero
            // 
            zero.Location = new Point(293, 230);
            zero.Name = "zero";
            zero.Size = new Size(112, 34);
            zero.TabIndex = 10;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // plus
            // 
            plus.Location = new Point(164, 282);
            plus.Name = "plus";
            plus.Size = new Size(112, 34);
            plus.TabIndex = 11;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // divide
            // 
            divide.Location = new Point(552, 282);
            divide.Name = "divide";
            divide.Size = new Size(112, 34);
            divide.TabIndex = 12;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // mul
            // 
            mul.Location = new Point(424, 282);
            mul.Name = "mul";
            mul.Size = new Size(112, 34);
            mul.TabIndex = 13;
            mul.Text = "*";
            mul.UseVisualStyleBackColor = true;
            mul.Click += mul_Click;
            // 
            // minus
            // 
            minus.Location = new Point(293, 282);
            minus.Name = "minus";
            minus.Size = new Size(112, 34);
            minus.TabIndex = 14;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // clear
            // 
            clear.Location = new Point(424, 230);
            clear.Name = "clear";
            clear.Size = new Size(112, 34);
            clear.TabIndex = 16;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // equal
            // 
            equal.Location = new Point(552, 230);
            equal.Name = "equal";
            equal.Size = new Size(112, 34);
            equal.TabIndex = 17;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(equal);
            Controls.Add(clear);
            Controls.Add(minus);
            Controls.Add(mul);
            Controls.Add(divide);
            Controls.Add(plus);
            Controls.Add(zero);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button zero;
        private Button plus;
        private Button divide;
        private Button mul;
        private Button minus;
        private Button button1;
        private Button clear;
        private Button equal;
    }
}
