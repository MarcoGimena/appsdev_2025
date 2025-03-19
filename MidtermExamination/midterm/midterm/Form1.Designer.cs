namespace midterm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(329, 24);
            label1.TabIndex = 0;
            label1.Text = "Simple iPhone Loan Calculator App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 71);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 1;
            label2.Text = "iPhone Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 71);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Add-Ons";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(443, 71);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 3;
            label4.Text = "Loan Term";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(22, 99);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(160, 139);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(230, 99);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(164, 148);
            checkedListBox1.TabIndex = 5;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(426, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(426, 128);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 7;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 257);
            label5.Name = "label5";
            label5.Size = new Size(85, 17);
            label5.TabIndex = 8;
            label5.Text = "Loan Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 288);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 9;
            label6.Text = "Model";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 313);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 10;
            label7.Text = "Principal Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 342);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 11;
            label8.Text = "Downpayment";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 371);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 12;
            label9.Text = "Loan Term";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 400);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 13;
            label10.Text = "Interest Rate";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 428);
            label11.Name = "label11";
            label11.Size = new Size(119, 15);
            label11.TabIndex = 14;
            label11.Text = "Interest Rate Amount";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 454);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 15;
            label12.Text = "Total Monthly";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 480);
            label13.Name = "label13";
            label13.Size = new Size(79, 15);
            label13.TabIndex = 16;
            label13.Text = "Total Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(559, 532);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
