using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DBMS_Project
{

    public partial class AppBody : Form
    {
        //Mouse dragging window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();







        public AppBody()
        {
            InitializeComponent();

            //Initialisation for UI correction in sidebar
            isPanelExpanded = true;
            sidebarExpandedChange();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Login_Timer.Start();
        }

        private void Login_Timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity <= 1.0)
            {
                this.Opacity += 0.25;
            }
            else
            {
                Login_Timer.Stop();
            }
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeWindow_Click(object sender, EventArgs e)
        {
            Form1 logScreen = new Form1();
            this.Hide();
            logScreen.Show();

            
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        public void sidebarExpandedChange()//Buttons from 
        {
            Books.Text = "Books";
            Borrow.Text = "Borrow";
            Transactions.Text = "Transactions";
            Settings.Text = "Settings";
            About.Text = "About";
            SliderButton.Image = Properties.Resources.Retract;
            SliderButton.ImageAlign = ContentAlignment.MiddleCenter;
            Books.Image = null;
            Borrow.Image = null;
            Transactions.Image = null;
            Settings.Image = null;
            About.Image = null;
        }
        public void sidebarRetractedChange()//Buttons from 
        {
            Books.Text = "";
            Borrow.Text = "";
            Transactions.Text = "";
            Settings.Text = "";
            About.Text = "";
            SliderButton.Image = Properties.Resources.Expand;
            SliderButton.ImageAlign = ContentAlignment.MiddleLeft;
            Books.Image = Properties.Resources.Book;
            Borrow.Image = Properties.Resources.Borrow;
            Transactions.Image = Properties.Resources.Transanction;
            Settings.Image = Properties.Resources.settings_blue;
            About.Image = Properties.Resources.about_blue;
        }



        bool isPanelExpanded;
        const float maxWidth = 140;
        const float minWidth = 90;
        private void SliderButton_Click(object sender, EventArgs e)
        {
            if(isPanelExpanded) //retract
            {
                sidebarRetractedChange();
            }
            slidingTimer.Start();
        }

        private void slidingTimer_Tick(object sender, EventArgs e)
        {
            if (isPanelExpanded)//Then retract
            {
                sideBar.Width -= 20;
                if (sideBar.Width <= minWidth)
                {
                    isPanelExpanded = false;
                    slidingTimer.Stop();
                    
                    this.Refresh();
                }
            }
            else//then expand
            {
                sideBar.Width += 20;
                if (sideBar.Width >= maxWidth)
                {
                    isPanelExpanded = true;
                    slidingTimer.Stop();
                    sidebarExpandedChange();//placed here so that expansion change in GUI takes plce at last  
                    this.Refresh();
                }
            }
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Books_Click(object sender, EventArgs e)
        {
            if(!contentPanel.Controls.Contains(BooksUserControl.Instance))
            {
                contentPanel.Controls.Add(BooksUserControl.Instance);
                BooksUserControl.Instance.Dock = DockStyle.Fill;
            }
            BooksUserControl.Instance.BringToFront();
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(BorrowUserControl.Instance))
            {
                contentPanel.Controls.Add(BorrowUserControl.Instance);
                BorrowUserControl.Instance.Dock = DockStyle.Fill;
            }
            BorrowUserControl.Instance.BringToFront();
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(TransactionsUserControl.Instance))
            {
                contentPanel.Controls.Add(TransactionsUserControl.Instance);
                TransactionsUserControl.Instance.Dock = DockStyle.Fill;
            }
            TransactionsUserControl.Instance.BringToFront();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(SettingsUserControl.Instance))
            {
                contentPanel.Controls.Add(SettingsUserControl.Instance);
                SettingsUserControl.Instance.Dock = DockStyle.Fill;
            }
            SettingsUserControl.Instance.BringToFront();
        }

        private void About_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(AboutUserControl.Instance))
            {
                contentPanel.Controls.Add(AboutUserControl.Instance);
                AboutUserControl.Instance.Dock = DockStyle.Fill;
            }
            AboutUserControl.Instance.BringToFront();
        }
    }
}
