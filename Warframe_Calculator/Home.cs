using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warframe_Calculator
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void btn_newWarframe_Click(object sender, EventArgs e)
        {
            // Show the "new Warframe" form. 
            using (CustomApplicationContext appContext = new CustomApplicationContext())
            {
                appContext.ShowWarframeForm();
            }

            this.Hide();
        }
    }
}
