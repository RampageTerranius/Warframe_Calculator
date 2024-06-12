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

            numUpDown_BaseArmor.Maximum = Decimal.MaxValue;
            numUpDown_ArmorBonus.Maximum = Decimal.MaxValue;
            numUpDown_ArmorPercent.Maximum = Decimal.MaxValue;
            numUpDown_TrueArmor.Maximum = Decimal.MaxValue;

            numUpDown_DamageReduction.DecimalPlaces = 1;
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

        private void CalculateHealth()
        {
                     
            // Calculation for true health is base health * (1 + (health percentage / 100)) + static bonuses.

            // Static bonuses includes arcanes (guardian, blessing etc...) and archon shards, these do not add to base and are a flat increase.
            decimal trueHP = numUpDown_BaseHealth.Value * (1 + (numUpDown_HealthPercent.Value / 100)) + numUpDown_HealthBonus.Value;
            numUpDown_TrueHealth.Value = trueHP;
        }
        private void CalculateArmor()
        {
            // Calculation for true armor is base armor * (1 + (armor percentage / 100)) + static bonuses.
            // Calculation for damage reduction is true armor / (true armor + 300), rounded to 3 decimal points.
            // Static bonuses includes arcanes (guardian, blessing etc...) and archon shards, these do not add to base and are a flat increase.

            decimal trueArmor = numUpDown_BaseArmor.Value * (1 + (numUpDown_ArmorPercent.Value / 100)) + numUpDown_ArmorBonus.Value;
            numUpDown_TrueArmor.Value = trueArmor;

            decimal damageReduction = (trueArmor / (trueArmor + 300)) * 100;
            numUpDown_DamageReduction.Value = damageReduction;
        }        

        // Recalculate any time values are changed.
        private void BaseHealth_ValueChanged(object sender, EventArgs e)
        {
            CalculateHealth();
        }

        private void HealthPercent_ValueChanged(object sender, EventArgs e)
        {
            CalculateHealth();
        }

        private void HealthBonus_ValueChanged(object sender, EventArgs e)
        {
            CalculateHealth();
        }

        private void BaseArmor_ValueChanged(object sender, EventArgs e)
        {
            CalculateArmor();
        }

        private void ArmorPercent_ValueChanged(object sender, EventArgs e)
        {
            CalculateArmor();
        }

        private void ArmorBonus_ValueChanged(object sender, EventArgs e)
        {
            CalculateArmor();
        }
    }
}
