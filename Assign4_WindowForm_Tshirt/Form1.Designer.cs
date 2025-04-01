namespace Assign4_WindowForm_Tshirt
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
            input = new TextBox();
            s = new RadioButton();
            m = new RadioButton();
            l = new RadioButton();
            code = new TextBox();
            p = new Label();
            cal = new Button();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(130, 40);
            input.Name = "input";
            input.PlaceholderText = "Enter the no of Tshirt";
            input.Size = new Size(376, 31);
            input.TabIndex = 0;
            input.TextChanged += input_TextChanged;
            // 
            // s
            // 
            s.AutoSize = true;
            s.Location = new Point(130, 110);
            s.Name = "s";
            s.Size = new Size(80, 29);
            s.TabIndex = 1;
            s.TabStop = true;
            s.Text = "Small";
            s.UseVisualStyleBackColor = true;
            // 
            // m
            // 
            m.AutoSize = true;
            m.Location = new Point(318, 110);
            m.Name = "m";
            m.Size = new Size(103, 29);
            m.TabIndex = 2;
            m.TabStop = true;
            m.Text = "Medium";
            m.UseVisualStyleBackColor = true;
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(512, 110);
            l.Name = "l";
            l.Size = new Size(80, 29);
            l.TabIndex = 3;
            l.TabStop = true;
            l.Text = "Large";
            l.UseVisualStyleBackColor = true;
            l.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // code
            // 
            code.Location = new Point(130, 172);
            code.Name = "code";
            code.PlaceholderText = "Refer code";
            code.Size = new Size(150, 31);
            code.TabIndex = 4;
            code.TextChanged += code_TextChanged;
            // 
            // p
            // 
            p.AutoSize = true;
            p.Location = new Point(130, 270);
            p.Name = "p";
            p.Size = new Size(0, 25);
            p.TabIndex = 5;
            // 
            // cal
            // 
            cal.Location = new Point(318, 172);
            cal.Name = "cal";
            cal.Size = new Size(112, 34);
            cal.TabIndex = 6;
            cal.Text = "calculate";
            cal.UseVisualStyleBackColor = true;
            cal.Click += cal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cal);
            Controls.Add(p);
            Controls.Add(code);
            Controls.Add(l);
            Controls.Add(m);
            Controls.Add(s);
            Controls.Add(input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input;
        private RadioButton s;
        private RadioButton m;
        private RadioButton l;
        private TextBox code;
        private Label p;
        private Button cal;
    }
}
