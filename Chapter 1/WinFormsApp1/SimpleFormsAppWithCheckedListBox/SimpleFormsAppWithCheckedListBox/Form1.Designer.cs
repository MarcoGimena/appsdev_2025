﻿namespace SimpleFormsAppWithCheckedListBox
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
            SimpleFavoriteMovie = new Label();
            label1 = new Label();
            movies = new CheckedListBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // SimpleFavoriteMovie
            // 
            SimpleFavoriteMovie.AutoSize = true;
            SimpleFavoriteMovie.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SimpleFavoriteMovie.Location = new Point(12, 22);
            SimpleFavoriteMovie.Name = "SimpleFavoriteMovie";
            SimpleFavoriteMovie.Size = new Size(528, 33);
            SimpleFavoriteMovie.TabIndex = 0;
            SimpleFavoriteMovie.Text = "Simple Favorite Movie Picker App";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 69);
            label1.Name = "label1";
            label1.Size = new Size(154, 18);
            label1.TabIndex = 1;
            label1.Text = "Movie/ Series List";
            // 
            // movies
            // 
            movies.FormattingEnabled = true;
            movies.Location = new Point(22, 98);
            movies.Name = "movies";
            movies.Size = new Size(172, 130);
            movies.TabIndex = 2;
            movies.SelectedIndexChanged += movie_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(22, 234);
            button1.Name = "button1";
            button1.Size = new Size(172, 26);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(225, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(143, 124);
            listBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(374, 98);
            button2.Name = "button2";
            button2.Size = new Size(113, 22);
            button2.TabIndex = 5;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(374, 126);
            button3.Name = "button3";
            button3.Size = new Size(113, 25);
            button3.TabIndex = 6;
            button3.Text = "Clear All";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 69);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 7;
            label2.Text = "My Movies";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(639, 372);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(movies);
            Controls.Add(label1);
            Controls.Add(SimpleFavoriteMovie);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SimpleFavoriteMovie;
        private Label label1;
        private CheckedListBox movies;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}
