namespace SimpleFormsAppWithListBox
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
            lstbox = new ListBox();
            txtbox = new TextBox();
            Add = new Button();
            Remove = new Button();
            Clear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstbox
            // 
            lstbox.FormattingEnabled = true;
            lstbox.ItemHeight = 15;
            lstbox.Location = new Point(24, 61);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(120, 169);
            lstbox.TabIndex = 0;
            // 
            // txtbox
            // 
            txtbox.Location = new Point(150, 61);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(100, 23);
            txtbox.TabIndex = 1;
            // 
            // Add
            // 
            Add.Location = new Point(150, 98);
            Add.Name = "Add";
            Add.Size = new Size(100, 40);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.Location = new Point(150, 144);
            Remove.Name = "Remove";
            Remove.Size = new Size(100, 40);
            Remove.TabIndex = 3;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(150, 190);
            Clear.Name = "Clear";
            Clear.Size = new Size(100, 40);
            Clear.TabIndex = 4;
            Clear.Text = "Clear all";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(285, 28);
            label1.TabIndex = 5;
            label1.Text = "List of Programming Language ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(315, 315);
            Controls.Add(label1);
            Controls.Add(Clear);
            Controls.Add(Remove);
            Controls.Add(Add);
            Controls.Add(txtbox);
            Controls.Add(lstbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbox;
        private TextBox txtbox;
        private Button Add;
        private Button Remove;
        private Button Clear;
        private Label label1;
    }
}
