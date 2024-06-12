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
    public partial class Warframe : Form
    {
        public Warframe()
        {
            InitializeComponent();

            this.FormClosing += MenuForm_FormClosing;
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // In the situatino the user attempts to clsoe the program move back to the menu instead.
            e.Cancel = true;

            using (CustomApplicationContext appContext = new CustomApplicationContext())
            {
                appContext.ShowHomeForm();
            }

            this.Hide();
        }
    }
}
