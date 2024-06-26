﻿namespace Library_manangement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            logoutBtn = new Button();
            btnReturnBooks = new Button();
            btnIssueBooks = new Button();
            btnAddBooks = new Button();
            btnDashBoard = new Button();
            greetLabel = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            returnBooks1 = new ReturnBooks();
            issuedBooks1 = new IssuedBooks();
            addBooks1 = new AddBooks();
            dashboard1 = new Dashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 35);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(345, 22);
            label2.TabIndex = 1;
            label2.Text = "Library Manangement System | Main Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(1070, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 22);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 128, 87);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(logoutBtn);
            panel2.Controls.Add(btnReturnBooks);
            panel2.Controls.Add(btnIssueBooks);
            panel2.Controls.Add(btnAddBooks);
            panel2.Controls.Add(btnDashBoard);
            panel2.Controls.Add(greetLabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Cursor = Cursors.Hand;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 565);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(44, 531);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 7;
            label4.Text = "log out";
            // 
            // logoutBtn
            // 
            logoutBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            logoutBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.ForeColor = Color.WhiteSmoke;
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.Location = new Point(3, 525);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(35, 35);
            logoutBtn.TabIndex = 6;
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // btnReturnBooks
            // 
            btnReturnBooks.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            btnReturnBooks.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnReturnBooks.FlatStyle = FlatStyle.Flat;
            btnReturnBooks.ForeColor = Color.WhiteSmoke;
            btnReturnBooks.Image = (Image)resources.GetObject("btnReturnBooks.Image");
            btnReturnBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturnBooks.Location = new Point(3, 331);
            btnReturnBooks.Name = "btnReturnBooks";
            btnReturnBooks.Size = new Size(208, 45);
            btnReturnBooks.TabIndex = 5;
            btnReturnBooks.Text = "RETURN BOOKS";
            btnReturnBooks.UseVisualStyleBackColor = true;
            btnReturnBooks.Click += btnReturnBooks_Click;
            // 
            // btnIssueBooks
            // 
            btnIssueBooks.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            btnIssueBooks.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnIssueBooks.FlatStyle = FlatStyle.Flat;
            btnIssueBooks.ForeColor = Color.WhiteSmoke;
            btnIssueBooks.Image = (Image)resources.GetObject("btnIssueBooks.Image");
            btnIssueBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btnIssueBooks.Location = new Point(3, 280);
            btnIssueBooks.Name = "btnIssueBooks";
            btnIssueBooks.Size = new Size(208, 45);
            btnIssueBooks.TabIndex = 4;
            btnIssueBooks.Text = "ISSUE BOOKS";
            btnIssueBooks.UseVisualStyleBackColor = true;
            btnIssueBooks.Click += btnIssueBooks_Click;
            // 
            // btnAddBooks
            // 
            btnAddBooks.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            btnAddBooks.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnAddBooks.FlatStyle = FlatStyle.Flat;
            btnAddBooks.ForeColor = Color.WhiteSmoke;
            btnAddBooks.Image = (Image)resources.GetObject("btnAddBooks.Image");
            btnAddBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBooks.Location = new Point(3, 229);
            btnAddBooks.Name = "btnAddBooks";
            btnAddBooks.Size = new Size(208, 45);
            btnAddBooks.TabIndex = 3;
            btnAddBooks.Text = "ADD BOOKS";
            btnAddBooks.UseVisualStyleBackColor = true;
            btnAddBooks.Click += btnAddBooks_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            btnDashBoard.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.ForeColor = Color.WhiteSmoke;
            btnDashBoard.Location = new Point(3, 178);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(208, 45);
            btnDashBoard.TabIndex = 2;
            btnDashBoard.Text = "DASHBOARD";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // greetLabel
            // 
            greetLabel.AutoSize = true;
            greetLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greetLabel.ForeColor = Color.WhiteSmoke;
            greetLabel.Location = new Point(21, 124);
            greetLabel.Name = "greetLabel";
            greetLabel.Size = new Size(160, 24);
            greetLabel.TabIndex = 1;
            greetLabel.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(returnBooks1);
            panel3.Controls.Add(issuedBooks1);
            panel3.Controls.Add(addBooks1);
            panel3.Controls.Add(dashboard1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(220, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 565);
            panel3.TabIndex = 2;
            // 
            // returnBooks1
            // 
            returnBooks1.Location = new Point(1, 2);
            returnBooks1.Name = "returnBooks1";
            returnBooks1.Size = new Size(1100, 706);
            returnBooks1.TabIndex = 3;
            // 
            // issuedBooks1
            // 
            issuedBooks1.Location = new Point(0, -1);
            issuedBooks1.Name = "issuedBooks1";
            issuedBooks1.Size = new Size(1100, 720);
            issuedBooks1.TabIndex = 2;
            // 
            // addBooks1
            // 
            addBooks1.Location = new Point(0, 0);
            addBooks1.Name = "addBooks1";
            addBooks1.Size = new Size(997, 641);
            addBooks1.TabIndex = 1;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(3, 3);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1100, 706);
            dashboard1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label greetLabel;
        private PictureBox pictureBox1;
        private Button btnDashBoard;
        private Button btnAddBooks;
        private Button btnIssueBooks;
        private Button btnReturnBooks;
        private Button logoutBtn;
        private Label label4;
        private Panel panel3;
        private IssuedBooks issuedBooks1;
        private AddBooks addBooks1;
        private Dashboard dashboard1;
        private ReturnBooks returnBooks1;
    }
}