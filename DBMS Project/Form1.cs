using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom.Compiler;

namespace DBMS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkCreds(username.Text, password.Text)) {
                message.Visible = false;
                AppBody app = new AppBody();
                this.Hide();
                app.Show();
            }
            else
            {
                message.Visible = true;
            }
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Library.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUserName()
        {
            //Data Fetch from Database
            con.Open();
            String syntax = "SELECT Value from systemTable where Property='Username'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private String getPassword()
        {
            //Data Fetch from Database
            con.Open();
            String syntax = "SELECT Value from systemTable where Property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp =  dr[0].ToString();
            con.Close();
            return temp;
        }
        private bool checkCreds(string User, string Pass)
        {
            String AUser = getUserName();
            String APass = getPassword();
            if(User == AUser && Pass == APass)
            {
                return true;
            }
            return false;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void User_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Enter Username")
            {
                username.Text = "";

                username.ForeColor = Color.White;
            }
        }

        private void User_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Enter Username";

                username.ForeColor = Color.Silver;
            }
        }

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Enter Password")
            {
                password.Text = "";
                password.UseSystemPasswordChar = true;
                password.ForeColor = Color.White;
            }
        }

        private void Pass_Leve(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Enter Password";
                password.UseSystemPasswordChar = false;
                password.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (password.Text == "Enter Password"){
                password.Text = "";
            }
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
