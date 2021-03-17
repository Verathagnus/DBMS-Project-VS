namespace DBMS_Project
{
    partial class TransactionsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Book1Label = new System.Windows.Forms.Label();
            this.Book2Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BorrowedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnBookButton_Transactions = new System.Windows.Forms.Button();
            this.IssueBookButton_Transaction = new System.Windows.Forms.Button();
            this.SearchBooksButton_Transaction = new System.Windows.Forms.Button();
            this.ClearButton_Transaction = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AccNo_Borrow_Textbox_Transaction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchBorrowerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BorrowerID_Transaction = new System.Windows.Forms.TextBox();
            this.BorrowerID_Search = new System.Windows.Forms.Label();
            this.TransactionLog = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Book1Label
            // 
            this.Book1Label.AutoSize = true;
            this.Book1Label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book1Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Book1Label.Location = new System.Drawing.Point(930, 65);
            this.Book1Label.Name = "Book1Label";
            this.Book1Label.Size = new System.Drawing.Size(108, 20);
            this.Book1Label.TabIndex = 56;
            this.Book1Label.Text = "Borrowed by";
            // 
            // Book2Label
            // 
            this.Book2Label.AutoSize = true;
            this.Book2Label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book2Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Book2Label.Location = new System.Drawing.Point(930, 119);
            this.Book2Label.Name = "Book2Label";
            this.Book2Label.Size = new System.Drawing.Size(108, 20);
            this.Book2Label.TabIndex = 55;
            this.Book2Label.Text = "Borrowed by";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(762, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Book 2:-";
            // 
            // BorrowedLabel
            // 
            this.BorrowedLabel.AutoSize = true;
            this.BorrowedLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowedLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BorrowedLabel.Location = new System.Drawing.Point(922, 253);
            this.BorrowedLabel.Name = "BorrowedLabel";
            this.BorrowedLabel.Size = new System.Drawing.Size(81, 20);
            this.BorrowedLabel.TabIndex = 53;
            this.BorrowedLabel.Text = "Borrowed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(752, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Borrowed by:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(762, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Book 1:-";
            // 
            // ReturnBookButton_Transactions
            // 
            this.ReturnBookButton_Transactions.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReturnBookButton_Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBookButton_Transactions.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookButton_Transactions.ForeColor = System.Drawing.Color.GhostWhite;
            this.ReturnBookButton_Transactions.Image = global::DBMS_Project.Properties.Resources.Asset_19;
            this.ReturnBookButton_Transactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnBookButton_Transactions.Location = new System.Drawing.Point(827, 471);
            this.ReturnBookButton_Transactions.Name = "ReturnBookButton_Transactions";
            this.ReturnBookButton_Transactions.Size = new System.Drawing.Size(241, 73);
            this.ReturnBookButton_Transactions.TabIndex = 50;
            this.ReturnBookButton_Transactions.Text = "Return Book";
            this.ReturnBookButton_Transactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReturnBookButton_Transactions.UseVisualStyleBackColor = false;
            this.ReturnBookButton_Transactions.Click += new System.EventHandler(this.ReturnBoookButton_Click);
            // 
            // IssueBookButton_Transaction
            // 
            this.IssueBookButton_Transaction.BackColor = System.Drawing.Color.RoyalBlue;
            this.IssueBookButton_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueBookButton_Transaction.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBookButton_Transaction.ForeColor = System.Drawing.Color.GhostWhite;
            this.IssueBookButton_Transaction.Image = global::DBMS_Project.Properties.Resources.Asset_17;
            this.IssueBookButton_Transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IssueBookButton_Transaction.Location = new System.Drawing.Point(59, 471);
            this.IssueBookButton_Transaction.Name = "IssueBookButton_Transaction";
            this.IssueBookButton_Transaction.Size = new System.Drawing.Size(212, 73);
            this.IssueBookButton_Transaction.TabIndex = 49;
            this.IssueBookButton_Transaction.Text = "Issue Book";
            this.IssueBookButton_Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IssueBookButton_Transaction.UseVisualStyleBackColor = false;
            this.IssueBookButton_Transaction.Click += new System.EventHandler(this.IssueBookButton_Click);
            // 
            // SearchBooksButton_Transaction
            // 
            this.SearchBooksButton_Transaction.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchBooksButton_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBooksButton_Transaction.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBooksButton_Transaction.ForeColor = System.Drawing.Color.GhostWhite;
            this.SearchBooksButton_Transaction.Image = global::DBMS_Project.Properties.Resources.Asset_12;
            this.SearchBooksButton_Transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBooksButton_Transaction.Location = new System.Drawing.Point(423, 297);
            this.SearchBooksButton_Transaction.Name = "SearchBooksButton_Transaction";
            this.SearchBooksButton_Transaction.Size = new System.Drawing.Size(241, 73);
            this.SearchBooksButton_Transaction.TabIndex = 48;
            this.SearchBooksButton_Transaction.Text = " Search Books";
            this.SearchBooksButton_Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBooksButton_Transaction.UseVisualStyleBackColor = false;
            this.SearchBooksButton_Transaction.Click += new System.EventHandler(this.SearchBooksButton_Borrow_Click);
            // 
            // ClearButton_Transaction
            // 
            this.ClearButton_Transaction.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClearButton_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton_Transaction.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton_Transaction.ForeColor = System.Drawing.Color.GhostWhite;
            this.ClearButton_Transaction.Image = global::DBMS_Project.Properties.Resources.Asset_18;
            this.ClearButton_Transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton_Transaction.Location = new System.Drawing.Point(435, 385);
            this.ClearButton_Transaction.Name = "ClearButton_Transaction";
            this.ClearButton_Transaction.Size = new System.Drawing.Size(210, 71);
            this.ClearButton_Transaction.TabIndex = 47;
            this.ClearButton_Transaction.Text = "Clear All";
            this.ClearButton_Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClearButton_Transaction.UseVisualStyleBackColor = false;
            this.ClearButton_Transaction.Click += new System.EventHandler(this.ClearButton_Borrow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Location = new System.Drawing.Point(252, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 3);
            this.panel2.TabIndex = 46;
            // 
            // AccNo_Borrow_Textbox_Transaction
            // 
            this.AccNo_Borrow_Textbox_Transaction.BackColor = System.Drawing.Color.Lavender;
            this.AccNo_Borrow_Textbox_Transaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccNo_Borrow_Textbox_Transaction.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNo_Borrow_Textbox_Transaction.ForeColor = System.Drawing.Color.Indigo;
            this.AccNo_Borrow_Textbox_Transaction.Location = new System.Drawing.Point(252, 244);
            this.AccNo_Borrow_Textbox_Transaction.Name = "AccNo_Borrow_Textbox_Transaction";
            this.AccNo_Borrow_Textbox_Transaction.Size = new System.Drawing.Size(444, 20);
            this.AccNo_Borrow_Textbox_Transaction.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(100, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Acc No:-";
            // 
            // SearchBorrowerButton
            // 
            this.SearchBorrowerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchBorrowerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBorrowerButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBorrowerButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.SearchBorrowerButton.Image = global::DBMS_Project.Properties.Resources.Asset_12;
            this.SearchBorrowerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBorrowerButton.Location = new System.Drawing.Point(364, 119);
            this.SearchBorrowerButton.Name = "SearchBorrowerButton";
            this.SearchBorrowerButton.Size = new System.Drawing.Size(281, 73);
            this.SearchBorrowerButton.TabIndex = 43;
            this.SearchBorrowerButton.Text = " Search Borrower";
            this.SearchBorrowerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBorrowerButton.UseVisualStyleBackColor = false;
            this.SearchBorrowerButton.Click += new System.EventHandler(this.SearchBorrowerButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(261, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 3);
            this.panel1.TabIndex = 42;
            // 
            // BorrowerID_Transaction
            // 
            this.BorrowerID_Transaction.BackColor = System.Drawing.Color.Lavender;
            this.BorrowerID_Transaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BorrowerID_Transaction.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowerID_Transaction.ForeColor = System.Drawing.Color.Indigo;
            this.BorrowerID_Transaction.Location = new System.Drawing.Point(261, 56);
            this.BorrowerID_Transaction.Name = "BorrowerID_Transaction";
            this.BorrowerID_Transaction.Size = new System.Drawing.Size(444, 20);
            this.BorrowerID_Transaction.TabIndex = 41;
            // 
            // BorrowerID_Search
            // 
            this.BorrowerID_Search.AutoSize = true;
            this.BorrowerID_Search.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowerID_Search.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BorrowerID_Search.Location = new System.Drawing.Point(64, 56);
            this.BorrowerID_Search.Name = "BorrowerID_Search";
            this.BorrowerID_Search.Size = new System.Drawing.Size(126, 20);
            this.BorrowerID_Search.TabIndex = 40;
            this.BorrowerID_Search.Text = "Borrower ID:-";
            // 
            // TransactionLog
            // 
            this.TransactionLog.BackColor = System.Drawing.Color.RoyalBlue;
            this.TransactionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionLog.ForeColor = System.Drawing.Color.GhostWhite;
            this.TransactionLog.Image = global::DBMS_Project.Properties.Resources.Asset_20;
            this.TransactionLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionLog.Location = new System.Drawing.Point(406, 471);
            this.TransactionLog.Name = "TransactionLog";
            this.TransactionLog.Size = new System.Drawing.Size(276, 73);
            this.TransactionLog.TabIndex = 75;
            this.TransactionLog.Text = "Transaction Logs";
            this.TransactionLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TransactionLog.UseVisualStyleBackColor = false;
            this.TransactionLog.Click += new System.EventHandler(this.TransactionLog_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 563);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 122);
            this.dataGridView1.TabIndex = 76;
            // 
            // TransactionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TransactionLog);
            this.Controls.Add(this.Book1Label);
            this.Controls.Add(this.Book2Label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BorrowedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnBookButton_Transactions);
            this.Controls.Add(this.IssueBookButton_Transaction);
            this.Controls.Add(this.SearchBooksButton_Transaction);
            this.Controls.Add(this.ClearButton_Transaction);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AccNo_Borrow_Textbox_Transaction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchBorrowerButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BorrowerID_Transaction);
            this.Controls.Add(this.BorrowerID_Search);
            this.Name = "TransactionsUserControl";
            this.Size = new System.Drawing.Size(1133, 717);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Book1Label;
        private System.Windows.Forms.Label Book2Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label BorrowedLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnBookButton_Transactions;
        private System.Windows.Forms.Button IssueBookButton_Transaction;
        private System.Windows.Forms.Button SearchBooksButton_Transaction;
        private System.Windows.Forms.Button ClearButton_Transaction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AccNo_Borrow_Textbox_Transaction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchBorrowerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BorrowerID_Transaction;
        private System.Windows.Forms.Label BorrowerID_Search;
        private System.Windows.Forms.Button TransactionLog;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
