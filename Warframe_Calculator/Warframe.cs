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

            // Set the maximum allowed nubmer to the highest possible.
            numUpDown_BaseHealth.Maximum = Decimal.MaxValue;
            numUpDown_HealthBonus.Maximum = Decimal.MaxValue;
            numUpDown_HealthPercent.Maximum = Decimal.MaxValue;
            numUpDown_TrueHealth.Maximum = Decimal.MaxValue;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            // Push across to MenuForm_FormClosing
            this.Close();
        }

        private void MenuForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // In the situation the user attempts to close the program move back to the menu instead.
            e.Cancel = true;

            using (CustomApplicationContext appContext = new CustomApplicationContext())
            {
                appContext.ShowHomeForm();
            }

            this.Hide();
        }

        private void CalculateEHP()
        {
            // Calculation for effective armor is base armor * (1 + (armor percentage / 100)) + static bonuses.           
            // Calculation for true health is base health * (1 + (health percentage / 100)) + static bonuses.

            // Static bonuses includes arcanes (guardian, blessing etc...) and archon shards, these do not add to base and are a flat increase.
            decimal trueHP = numUpDown_BaseHealth.Value * (1 + (numUpDown_HealthPercent.Value / 100)) + numUpDown_HealthBonus.Value;
            numUpDown_TrueHealth.Value = trueHP;
        }

        // Recalculate any time values are changed.
        private void BaseHealth_ValueChanged(object sender, EventArgs e)
        {
            CalculateEHP();
        }

        private void HealthPercent_ValueChanged(object sender, EventArgs e)
        {
            CalculateEHP();
        }

        private void HelathBonus_ValueChanged(object sender, EventArgs e)
        {
            CalculateEHP();
        }
    }
}
