namespace DBMS_Project
{
    partial class AppBody
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.Login_Timer = new System.Windows.Forms.Timer(this.components);
            this.TitleBar = new System.Windows.Forms.Panel();
            this.slidingTimer = new System.Windows.Forms.Timer(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sideBar = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.Borrow = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.SliderButton = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.LogOff = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Timer
            // 
            this.Login_Timer.Interval = 30;
            this.Login_Timer.Tick += new System.EventHandler(this.Login_Timer_Tick);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBar.BackgroundImage")));
            this.TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleBar.Controls.Add(this.MinimizeButton);
            this.TitleBar.Controls.Add(this.LogOff);
            this.TitleBar.Controls.Add(this.closeButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1333, 47);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // slidingTimer
            // 
            this.slidingTimer.Interval = 25;
            this.slidingTimer.Tick += new System.EventHandler(this.slidingTimer_Tick);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPanel.Location = new System.Drawing.Point(200, 47);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1133, 717);
            this.contentPanel.TabIndex = 2;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Transparent;
            this.sideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideBar.BackgroundImage")));
            this.sideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sideBar.Controls.Add(this.About);
            this.sideBar.Controls.Add(this.Borrow);
            this.sideBar.Controls.Add(this.Books);
            this.sideBar.Controls.Add(this.Settings);
            this.sideBar.Controls.Add(this.SliderButton);
            this.sideBar.Controls.Add(this.Transactions);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 47);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(204, 717);
            this.sideBar.TabIndex = 1;
            // 
            // About
            // 
            this.About.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.About.Image = global::DBMS_Project.Properties.Resources.about_blue;
            this.About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.Location = new System.Drawing.Point(3, 472);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(198, 94);
            this.About.TabIndex = 7;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Borrow
            // 
            this.Borrow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Borrow.BackColor = System.Drawing.Color.Transparent;
            this.Borrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Borrow.Image = global::DBMS_Project.Properties.Resources.Borrow;
            this.Borrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrow.Location = new System.Drawing.Point(3, 185);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(198, 100);
            this.Borrow.TabIndex = 4;
            this.Borrow.Text = "Borrow";
            this.Borrow.UseVisualStyleBackColor = false;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // Books
            // 
            this.Books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Books.BackColor = System.Drawing.Color.Transparent;
            this.Books.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Books.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Books.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Books.Image = global::DBMS_Project.Properties.Resources.Book;
            this.Books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Books.Location = new System.Drawing.Point(3, 94);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(198, 100);
            this.Books.TabIndex = 3;
            this.Books.Text = "Books";
            this.Books.UseVisualStyleBackColor = false;
            this.Books.Click += new System.EventHandler(this.Books_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Settings.Image = global::DBMS_Project.Properties.Resources.settings_blue;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(3, 376);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(198, 100);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // SliderButton
            // 
            this.SliderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SliderButton.BackColor = System.Drawing.Color.Transparent;
            this.SliderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SliderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SliderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SliderButton.Image = global::DBMS_Project.Properties.Resources.Retract;
            this.SliderButton.Location = new System.Drawing.Point(3, 0);
            this.SliderButton.Name = "SliderButton";
            this.SliderButton.Size = new System.Drawing.Size(198, 100);
            this.SliderButton.TabIndex = 2;
            this.SliderButton.UseVisualStyleBackColor = false;
            this.SliderButton.Click += new System.EventHandler(this.SliderButton_Click);
            // 
            // Transactions
            // 
            this.Transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transactions.BackColor = System.Drawing.Color.Transparent;
            this.Transactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transactions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transactions.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Transactions.Image = global::DBMS_Project.Properties.Resources.Transanction;
            this.Transactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transactions.Location = new System.Drawing.Point(3, 279);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(198, 100);
            this.Transactions.TabIndex = 5;
            this.Transactions.Text = "Transactions";
            this.Transactions.UseVisualStyleBackColor = false;
            this.Transactions.Click += new System.EventHandler(this.Transactions_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.MinimizeButton.Location = new System.Drawing.Point(1235, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinimizeButton.Size = new System.Drawing.Size(41, 36);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // LogOff
            // 
            this.LogOff.BackColor = System.Drawing.Color.Transparent;
            this.LogOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOff.BackgroundImage")));
            this.LogOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogOff.FlatAppearance.BorderSize = 0;
            this.LogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOff.ForeColor = System.Drawing.Color.BlueViolet;
            this.LogOff.Location = new System.Drawing.Point(1188, 3);
            this.LogOff.Name = "LogOff";
            this.LogOff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogOff.Size = new System.Drawing.Size(41, 36);
            this.LogOff.TabIndex = 2;
            this.LogOff.UseVisualStyleBackColor = false;
            this.LogOff.Click += new System.EventHandler(this.MinimizeWindow_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.closeButton.Location = new System.Drawing.Point(1282, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeButton.Size = new System.Drawing.Size(42, 36);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 764);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.TitleBar.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Login_Timer;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button LogOff;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Button SliderButton;
        private System.Windows.Forms.Timer slidingTimer;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Transactions;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button Books;
        private System.Windows.Forms.Panel contentPanel;
    }
}