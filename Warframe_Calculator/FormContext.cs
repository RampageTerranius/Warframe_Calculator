using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warframe_Calculator
{
    public class CustomApplicationContext : ApplicationContext
    {
        private static Form home = new Home(); // the home form, used for recalling to menu.
        private static Form warframe = new Warframe(); // the warframe form, used to calculate eHP and shield gating.

        // Base constructor.
        public CustomApplicationContext()
        {
            // Setup the response when the menu is closed and show the menu.
            home.FormClosed += home_FormClosed;
            home.Show();
        }

        // As we are giving a custom context we need to specify that the program should shutdown upon the home form closing.
        private void home_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ExitThread();
        }

        public void ShowHomeForm()
        {
            home.Show();
        }

        public void ShowWarframeForm()
        {
            warframe.Show();
        }
    }    
}
