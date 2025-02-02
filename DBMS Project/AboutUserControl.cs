﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{

    public partial class AboutUserControl : UserControl
    {
        private static AboutUserControl _instance;

        public static AboutUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AboutUserControl();
                }
                return _instance;
            }
        }
        public AboutUserControl()
        {
            InitializeComponent();
        }
    }
}
