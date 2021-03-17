using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_Project
{
    public partial class TransactionsUserControl : UserControl
    {
        private static TransactionsUserControl _instance;

        public static TransactionsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransactionsUserControl();
                }
                return _instance;
            }
        }
        public TransactionsUserControl()
        {
            InitializeComponent();
        }

        public String Book1, Book2, Borrower; 

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Library.mdf\";Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataReader dr;

        private void ClearButton_Borrow_Click(object sender, EventArgs e)
        {
            BorrowerID_Transaction.Text = "";
            AccNo_Borrow_Textbox_Transaction.Text = "";
        }
        private void SearchBooksButton_Borrow_Click(object sender, EventArgs e)
        {
            //Get Borrower
            con.Open();
            String syntax = "Select Borrower FROM Books WHERE AccNo='" + AccNo_Borrow_Textbox_Transaction.Text + "'";
            if (AccNo_Borrow_Textbox_Transaction.Text == "")
            {
                con.Close();
            }
            else
            {
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();

                BorrowedLabel.Text = Borrower = dr[0].ToString();
                con.Close();
            }
        }

        

        private void SearchBorrowerButton_Click(object sender, EventArgs e)
        {
            //Book1
            con.Open();
            String syntax = "Select Book1 FROM Borrow WHERE BrId='" + BorrowerID_Transaction.Text + "'";
            if(BorrowerID_Transaction.Text == "")
            {
                con.Close();
            }
            else
            {
                
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                Book1Label.Text = Book1 = dr[0].ToString();
                con.Close();
            }
            

            //Book2
            con.Open();
            syntax = "Select Book2 FROM Borrow WHERE BrId='" + BorrowerID_Transaction.Text + "'";
            if(BorrowerID_Transaction.Text == "")
            {
                con.Close();
            }
            else
            {
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                Book2Label.Text = Book2 = dr[0].ToString();
                con.Close();
            }
        }

        private void TransactionLog_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    con.Open();
                    String syntax = "Select * FROM TransactionLogs";

                    cmd = new SqlCommand(syntax, con);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("<<<Invalid SQL Opertion>>>:-\n" + ex);
                }
                con.Close();

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void IssueBookButton_Click(object sender, EventArgs e)
        {
            SearchBooksButton_Transaction.PerformClick();
            if (Borrower != "")
            {
                //Already Borrowed
                MessageBox.Show("Book has already been borrowed by someone.");
                return;
            }

            SearchBorrowerButton.PerformClick();
            if((Book1 != "") && (Book2 != ""))
            {
                //Max Borrowed
                MessageBox.Show("Borrower has already borrowed maximum of 2 Books.");
                return;
            }

            //No conflicts so continue making changes
            try
            {
                if(Book1 == "")
                {
                    cmd = new SqlCommand("Transact_UpdateBook1_SP", con);
                }
                else
                {
                    cmd = new SqlCommand("Transact_UpdateBook2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccNo", AccNo_Borrow_Textbox_Transaction.Text);
                cmd.Parameters.AddWithValue("@BrId", BorrowerID_Transaction.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("<<<Invalid SQL Opertion>>>:-\n" + ex);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }

            //Make corresponding changes to Borrower in Books Table
            cmd = new SqlCommand("Transact_UpdateBorrower_SP", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AccNo", AccNo_Borrow_Textbox_Transaction.Text);
            cmd.Parameters.AddWithValue("@BrId", BorrowerID_Transaction.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("<<<Invalid SQL Opertion>>>:-\n" + ex);
            }
            con.Close();


            //-------------------------------------------------
            //Transaction Logs Code

            cmd = new SqlCommand("Transactions_Insert_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bkid", AccNo_Borrow_Textbox_Transaction.Text);
            cmd.Parameters.AddWithValue("@brid", BorrowerID_Transaction.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("<<<Invalid SQL Opertion>>>:\n" + ex);
            }
            con.Close();





            //Update text values for display in UI

            SearchBooksButton_Transaction.PerformClick();
            SearchBorrowerButton.PerformClick();
            MessageBox.Show("Issued Successfully.");
        }

        

        


        private void ReturnBoookButton_Click(object sender, EventArgs e)
        {
            SearchBooksButton_Transaction.PerformClick();
            //Checking if AccNo book borrowed 
            if ((AccNo_Borrow_Textbox_Transaction.Text != Book1) && (AccNo_Borrow_Textbox_Transaction.Text != Book2))
            {
                //Already Borrowed
                MessageBox.Show("Book has not been borrowed by the given Borrower.");
                return;
            }

            //No conflicts so continue making changes for returning book
            try
            {
                if (Book1 == AccNo_Borrow_Textbox_Transaction.Text)
                {
                    cmd = new SqlCommand("Transact_UpdateBook1_SP", con);
                }
                else
                {
                    cmd = new SqlCommand("Transact_UpdateBook2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccNo", (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@BrId", BorrowerID_Transaction.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("<<<Invalid SQL Opertion>>>" + ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            //Make corresponding changes to Borrower in Books Table
            cmd = new SqlCommand("Transact_UpdateBorrower_SP", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AccNo", AccNo_Borrow_Textbox_Transaction.Text);
            cmd.Parameters.AddWithValue("@BrId", (object)DBNull.Value);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("<<<Invalid SQL Opertion>>>" + ex);
            }
            con.Close();


            con.Open();
            //Delete Issue Details into Transactions table
            String syntax = "DELETE FROM Transactions WHERE BId='" + BorrowerID_Transaction.Text + "' AND BookNum='" + AccNo_Borrow_Textbox_Transaction.Text + "'";
            //String syntax2 = "insert into TransactionLogs(Log_Data) values('BORROWER WITH ID = ' + cast(" + BorrowerID_Transaction.Text+" as nvarchar(8)) + ' RETURNED THE BOOK WITH AccNo = ' + cast("+AccNo_Borrow_Textbox_Transaction.Text+" as nvarchar(8)) + ' ON ' + cast(GETDATE() as nvarchar(20))";
            cmd = new SqlCommand(syntax, con);
            //cmd2 = new SqlCommand(syntax2, con);
            //cmd = new SqlCommand("Transactions_Delete_SP", con);
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@bkid", AccNo_Borrow_Textbox_Transaction.Text);
            //cmd.Parameters.AddWithValue("@brid", BorrowerID_Transaction.Text);

            
            try
            {

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("<<<Invalid SQL Opertion>>>:\n" + ex);
            }
            con.Close();

            //Update text values for display in UI
            SearchBooksButton_Transaction.PerformClick();
            SearchBorrowerButton.PerformClick();
            MessageBox.Show("Returned Successfully.");
        }
    }
}
