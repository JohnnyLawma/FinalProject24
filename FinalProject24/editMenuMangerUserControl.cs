using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject24
{
    public partial class editMenuMangerUserControl : UserControl

    {

        public static editMenuMangerUserControl _instance;

        public static editMenuMangerUserControl Instance
        {
            get
            {
                // If the instance is null, create it
                if (_instance == null)
                {
                    _instance = new editMenuMangerUserControl();
                }
                // Return the existing or new instance
                return _instance;

            }
        }
        public editMenuMangerUserControl()
        {
            InitializeComponent();
        }
    }
}
