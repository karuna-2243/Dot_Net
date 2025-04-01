namespace CollegeFestEventApp
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
            people = new TextBox();
            button1 = new Button();
            listbox = new ListBox();
            SuspendLayout();
            // 
            // people
            // 
            people.AccessibleName = "people";
            people.Location = new Point(271, 23);
            people.Name = "people";
            people.Size = new Size(256, 31);
            people.TabIndex = 0;
            people.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(343, 78);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Calculate Bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listbox
            // 
            listbox.AccessibleName = "listBox";
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 25;
            listbox.Location = new Point(120, 160);
            listbox.Name = "listbox";
            listbox.Size = new Size(503, 204);
            listbox.TabIndex = 2;
            listbox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listbox);
            Controls.Add(button1);
            Controls.Add(people);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox people;
        private Button button1;
        private ListBox listbox;
        private CheckedListBox checkedListBox1;
    }
}
