
namespace LibraryCatalog
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.ComboBox categoryFilterComboBox;
        private System.Windows.Forms.ComboBox statusFilterComboBox;
        private System.Windows.Forms.PictureBox bookPictureBox;
        private LinkLabel instructionsLinkLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            addBookButton = new Button();
            removeBookButton = new Button();
            categoryFilterComboBox = new ComboBox();
            statusFilterComboBox = new ComboBox();
            bookPictureBox = new PictureBox();
            instructionsLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SandyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(591, 307);
            dataGridView1.TabIndex = 0;
            // 
            // addBookButton
            // 
            addBookButton.Location = new Point(12, 354);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(75, 23);
            addBookButton.TabIndex = 1;
            addBookButton.Text = "Add Book";
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += AddBookButton_Click;
            // 
            // removeBookButton
            // 
            removeBookButton.Location = new Point(93, 354);
            removeBookButton.Name = "removeBookButton";
            removeBookButton.Size = new Size(75, 23);
            removeBookButton.TabIndex = 2;
            removeBookButton.Text = "Remove Book";
            removeBookButton.UseVisualStyleBackColor = true;
            removeBookButton.Click += RemoveBookButton_Click;
            // 
            // categoryFilterComboBox
            // 
            categoryFilterComboBox.BackColor = Color.White;
            categoryFilterComboBox.ForeColor = SystemColors.WindowText;
            categoryFilterComboBox.FormattingEnabled = true;
            categoryFilterComboBox.Items.AddRange(new object[] { "All Categories", "Fiction", "Non-Fiction", "Science", "Biography" });
            categoryFilterComboBox.Location = new Point(12, 12);
            categoryFilterComboBox.Name = "categoryFilterComboBox";
            categoryFilterComboBox.Size = new Size(121, 23);
            categoryFilterComboBox.TabIndex = 3;
            categoryFilterComboBox.Text = "All Categories";
            categoryFilterComboBox.SelectedIndexChanged += CategoryFilterComboBox_SelectedIndexChanged;
            // 
            // statusFilterComboBox
            // 
            statusFilterComboBox.FormattingEnabled = true;
            statusFilterComboBox.Items.AddRange(new object[] { "All Statuses", "Read", "Unread", "In Progress" });
            statusFilterComboBox.Location = new Point(139, 12);
            statusFilterComboBox.Name = "statusFilterComboBox";
            statusFilterComboBox.Size = new Size(121, 23);
            statusFilterComboBox.TabIndex = 4;
            statusFilterComboBox.Text = "All Statuses";
            statusFilterComboBox.SelectedIndexChanged += StatusFilterComboBox_SelectedIndexChanged;
            // 
            // bookPictureBox
            // 
            bookPictureBox.BackColor = Color.SandyBrown;
            bookPictureBox.Location = new Point(624, 41);
            bookPictureBox.Name = "bookPictureBox";
            bookPictureBox.Size = new Size(200, 307);
            bookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            bookPictureBox.TabIndex = 5;
            bookPictureBox.TabStop = false;
            // 
            // instructionsLinkLabel
            // 
            instructionsLinkLabel.ActiveLinkColor = Color.OrangeRed;
            instructionsLinkLabel.AutoSize = true;
            instructionsLinkLabel.LinkColor = Color.SaddleBrown;
            instructionsLinkLabel.Location = new Point(266, 15);
            instructionsLinkLabel.Name = "instructionsLinkLabel";
            instructionsLinkLabel.Size = new Size(98, 15);
            instructionsLinkLabel.TabIndex = 6;
            instructionsLinkLabel.TabStop = true;
            instructionsLinkLabel.Text = "Read Instructions";
            instructionsLinkLabel.LinkClicked += InstructionsLinkLabel_LinkClicked;
            // 
            // Form1
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(842, 389);
            Controls.Add(bookPictureBox);
            Controls.Add(statusFilterComboBox);
            Controls.Add(categoryFilterComboBox);
            Controls.Add(removeBookButton);
            Controls.Add(addBookButton);
            Controls.Add(dataGridView1);
            Controls.Add(instructionsLinkLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Library Catalog";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}