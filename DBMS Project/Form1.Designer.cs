namespace DBMS_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(112, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "Log-In Screen";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.password.Location = new System.Drawing.Point(122, 508);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(251, 22);
            this.password.TabIndex = 4;
            this.password.Text = "Enter Password";
            this.password.Enter += new System.EventHandler(this.Pass_Enter);
            this.password.Leave += new System.EventHandler(this.Pass_Leve);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.username.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.username.Location = new System.Drawing.Point(122, 457);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(251, 22);
            this.username.TabIndex = 2;
            this.username.Text = "Enter Username";
            this.username.Enter += new System.EventHandler(this.User_Enter);
            this.username.Leave += new System.EventHandler(this.User_Leave);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.message.Location = new System.Drawing.Point(146, 620);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(204, 17);
            this.message.TabIndex = 7;
            this.message.Text = "Credentials Entered are Wrong";
            this.message.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(390, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(457, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 35);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 668);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

