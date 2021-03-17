using System;
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

    public partial class SettingsUserControl : UserControl
    {
        private static SettingsUserControl _instance;

        public static SettingsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SettingsUserControl();
                }
                return _instance;
            }
        }
        public SettingsUserControl()
        {
            InitializeComponent();
        }
    }
}
