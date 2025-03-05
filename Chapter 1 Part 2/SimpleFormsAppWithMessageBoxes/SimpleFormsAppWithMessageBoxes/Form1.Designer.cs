namespace WinFormsApp1
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
            Firstname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Middlename = new TextBox();
            Lastname = new TextBox();
            label4 = new Label();
            Suffix = new TextBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 90);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // Firstname
            // 
            Firstname.Location = new Point(64, 108);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(263, 23);
            Firstname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 143);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Middle Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 199);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // Middlename
            // 
            Middlename.Location = new Point(64, 161);
            Middlename.Name = "Middlename";
            Middlename.Size = new Size(263, 23);
            Middlename.TabIndex = 4;
            // 
            // Lastname
            // 
            Lastname.Location = new Point(64, 217);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(263, 23);
            Lastname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 253);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "suffix";
            label4.Click += label4_Click;
            // 
            // Suffix
            // 
            Suffix.Location = new Point(64, 271);
            Suffix.Name = "Suffix";
            Suffix.Size = new Size(263, 23);
            Suffix.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(64, 311);
            button1.Name = "button1";
            button1.Size = new Size(263, 29);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(70, 40);
            label5.Name = "label5";
            label5.Size = new Size(257, 30);
            label5.TabIndex = 9;
            label5.Text = "Simple Form Application";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(377, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(Suffix);
            Controls.Add(label4);
            Controls.Add(Lastname);
            Controls.Add(Middlename);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Firstname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Firstname;
        private Label label2;
        private Label label3;
        private TextBox Middlename;
        private TextBox Lastname;
        private Label label4;
        private TextBox Suffix;
        private Button button1;
        private Label label5;
    }
}
