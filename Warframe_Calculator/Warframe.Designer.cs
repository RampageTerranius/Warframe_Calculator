namespace Warframe_Calculator
{
    partial class Warframe
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
            this.pnl_Health = new System.Windows.Forms.Panel();
            this.numUpDown_TrueHealth = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_HealthBonus = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_HealthPercent = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_BaseHealth = new System.Windows.Forms.NumericUpDown();
            this.lbl_TrueHealth = new System.Windows.Forms.Label();
            this.lbl_RawHealthBonus = new System.Windows.Forms.Label();
            this.lbl_HealthPercent = new System.Windows.Forms.Label();
            this.lbl_bHealth = new System.Windows.Forms.Label();
            this.lbl_Health = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnl_Armor = new System.Windows.Forms.Panel();
            this.numUpDown_DamageReduction = new System.Windows.Forms.NumericUpDown();
            this.lbl_DamageReduction = new System.Windows.Forms.Label();
            this.numUpDown_TrueArmor = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_ArmorBonus = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_ArmorPercent = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_BaseArmor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_RawArmorBonus = new System.Windows.Forms.Label();
            this.lbl_ArmorPercent = new System.Windows.Forms.Label();
            this.lbl_BaseArmor = new System.Windows.Forms.Label();
            this.lbl_Armor = new System.Windows.Forms.Label();
            this.pnl_EffectiveStats = new System.Windows.Forms.Panel();
            this.numUpDown_EHP = new System.Windows.Forms.NumericUpDown();
            this.lbl_EHP = new System.Windows.Forms.Label();
            this.lbl_Effective = new System.Windows.Forms.Label();
            this.pnl_Health.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_TrueHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_HealthBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_HealthPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BaseHealth)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Armor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DamageReduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_TrueArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ArmorBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ArmorPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BaseArmor)).BeginInit();
            this.pnl_EffectiveStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_EHP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Health
            // 
            this.pnl_Health.Controls.Add(this.numUpDown_TrueHealth);
            this.pnl_Health.Controls.Add(this.numUpDown_HealthBonus);
            this.pnl_Health.Controls.Add(this.numUpDown_HealthPercent);
            this.pnl_Health.Controls.Add(this.numUpDown_BaseHealth);
            this.pnl_Health.Controls.Add(this.lbl_TrueHealth);
            this.pnl_Health.Controls.Add(this.lbl_RawHealthBonus);
            this.pnl_Health.Controls.Add(this.lbl_HealthPercent);
            this.pnl_Health.Controls.Add(this.lbl_bHealth);
            this.pnl_Health.Controls.Add(this.lbl_Health);
            this.pnl_Health.Location = new System.Drawing.Point(12, 27);
            this.pnl_Health.Name = "pnl_Health";
            this.pnl_Health.Size = new System.Drawing.Size(200, 224);
            this.pnl_Health.TabIndex = 0;
            // 
            // numUpDown_TrueHealth
            // 
            this.numUpDown_TrueHealth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_TrueHealth.Enabled = false;
            this.numUpDown_TrueHealth.Location = new System.Drawing.Point(3, 187);
            this.numUpDown_TrueHealth.Name = "numUpDown_TrueHealth";
            this.numUpDown_TrueHealth.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_TrueHealth.TabIndex = 10;
            // 
            // numUpDown_HealthBonus
            // 
            this.numUpDown_HealthBonus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_HealthBonus.Location = new System.Drawing.Point(3, 143);
            this.numUpDown_HealthBonus.Name = "numUpDown_HealthBonus";
            this.numUpDown_HealthBonus.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_HealthBonus.TabIndex = 9;
            this.numUpDown_HealthBonus.ValueChanged += new System.EventHandler(this.HealthBonus_ValueChanged);
            // 
            // numUpDown_HealthPercent
            // 
            this.numUpDown_HealthPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_HealthPercent.Location = new System.Drawing.Point(3, 99);
            this.numUpDown_HealthPercent.Name = "numUpDown_HealthPercent";
            this.numUpDown_HealthPercent.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_HealthPercent.TabIndex = 8;
            this.numUpDown_HealthPercent.ValueChanged += new System.EventHandler(this.HealthPercent_ValueChanged);
            // 
            // numUpDown_BaseHealth
            // 
            this.numUpDown_BaseHealth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_BaseHealth.Location = new System.Drawing.Point(3, 55);
            this.numUpDown_BaseHealth.Name = "numUpDown_BaseHealth";
            this.numUpDown_BaseHealth.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_BaseHealth.TabIndex = 2;
            this.numUpDown_BaseHealth.ValueChanged += new System.EventHandler(this.BaseHealth_ValueChanged);
            // 
            // lbl_TrueHealth
            // 
            this.lbl_TrueHealth.AutoSize = true;
            this.lbl_TrueHealth.Location = new System.Drawing.Point(3, 169);
            this.lbl_TrueHealth.Name = "lbl_TrueHealth";
            this.lbl_TrueHealth.Size = new System.Drawing.Size(65, 15);
            this.lbl_TrueHealth.TabIndex = 7;
            this.lbl_TrueHealth.Text = "True health";
            // 
            // lbl_RawHealthBonus
            // 
            this.lbl_RawHealthBonus.AutoSize = true;
            this.lbl_RawHealthBonus.Location = new System.Drawing.Point(3, 125);
            this.lbl_RawHealthBonus.Name = "lbl_RawHealthBonus";
            this.lbl_RawHealthBonus.Size = new System.Drawing.Size(101, 15);
            this.lbl_RawHealthBonus.TabIndex = 5;
            this.lbl_RawHealthBonus.Text = "Raw health bonus";
            // 
            // lbl_HealthPercent
            // 
            this.lbl_HealthPercent.AutoSize = true;
            this.lbl_HealthPercent.Location = new System.Drawing.Point(3, 81);
            this.lbl_HealthPercent.Name = "lbl_HealthPercent";
            this.lbl_HealthPercent.Size = new System.Drawing.Size(101, 15);
            this.lbl_HealthPercent.TabIndex = 4;
            this.lbl_HealthPercent.Text = "Health % increase";
            // 
            // lbl_bHealth
            // 
            this.lbl_bHealth.AutoSize = true;
            this.lbl_bHealth.Location = new System.Drawing.Point(3, 37);
            this.lbl_bHealth.Name = "lbl_bHealth";
            this.lbl_bHealth.Size = new System.Drawing.Size(67, 15);
            this.lbl_bHealth.TabIndex = 2;
            this.lbl_bHealth.Text = "Base health";
            // 
            // lbl_Health
            // 
            this.lbl_Health.AutoSize = true;
            this.lbl_Health.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Health.Location = new System.Drawing.Point(3, 0);
            this.lbl_Health.Name = "lbl_Health";
            this.lbl_Health.Size = new System.Drawing.Size(55, 21);
            this.lbl_Health.TabIndex = 0;
            this.lbl_Health.Text = "Health";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnl_Armor
            // 
            this.pnl_Armor.Controls.Add(this.numUpDown_DamageReduction);
            this.pnl_Armor.Controls.Add(this.lbl_DamageReduction);
            this.pnl_Armor.Controls.Add(this.numUpDown_TrueArmor);
            this.pnl_Armor.Controls.Add(this.numUpDown_ArmorBonus);
            this.pnl_Armor.Controls.Add(this.numUpDown_ArmorPercent);
            this.pnl_Armor.Controls.Add(this.numUpDown_BaseArmor);
            this.pnl_Armor.Controls.Add(this.label1);
            this.pnl_Armor.Controls.Add(this.lbl_RawArmorBonus);
            this.pnl_Armor.Controls.Add(this.lbl_ArmorPercent);
            this.pnl_Armor.Controls.Add(this.lbl_BaseArmor);
            this.pnl_Armor.Controls.Add(this.lbl_Armor);
            this.pnl_Armor.Location = new System.Drawing.Point(218, 27);
            this.pnl_Armor.Name = "pnl_Armor";
            this.pnl_Armor.Size = new System.Drawing.Size(200, 269);
            this.pnl_Armor.TabIndex = 11;
            // 
            // numUpDown_DamageReduction
            // 
            this.numUpDown_DamageReduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_DamageReduction.Enabled = false;
            this.numUpDown_DamageReduction.Location = new System.Drawing.Point(3, 231);
            this.numUpDown_DamageReduction.Name = "numUpDown_DamageReduction";
            this.numUpDown_DamageReduction.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_DamageReduction.TabIndex = 12;
            // 
            // lbl_DamageReduction
            // 
            this.lbl_DamageReduction.AutoSize = true;
            this.lbl_DamageReduction.Location = new System.Drawing.Point(3, 213);
            this.lbl_DamageReduction.Name = "lbl_DamageReduction";
            this.lbl_DamageReduction.Size = new System.Drawing.Size(185, 15);
            this.lbl_DamageReduction.TabIndex = 11;
            this.lbl_DamageReduction.Text = "Health damage reduction percent";
            // 
            // numUpDown_TrueArmor
            // 
            this.numUpDown_TrueArmor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_TrueArmor.Enabled = false;
            this.numUpDown_TrueArmor.Location = new System.Drawing.Point(3, 187);
            this.numUpDown_TrueArmor.Name = "numUpDown_TrueArmor";
            this.numUpDown_TrueArmor.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_TrueArmor.TabIndex = 10;
            // 
            // numUpDown_ArmorBonus
            // 
            this.numUpDown_ArmorBonus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_ArmorBonus.Location = new System.Drawing.Point(3, 143);
            this.numUpDown_ArmorBonus.Name = "numUpDown_ArmorBonus";
            this.numUpDown_ArmorBonus.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_ArmorBonus.TabIndex = 9;
            this.numUpDown_ArmorBonus.ValueChanged += new System.EventHandler(this.ArmorBonus_ValueChanged);
            // 
            // numUpDown_ArmorPercent
            // 
            this.numUpDown_ArmorPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_ArmorPercent.Location = new System.Drawing.Point(3, 99);
            this.numUpDown_ArmorPercent.Name = "numUpDown_ArmorPercent";
            this.numUpDown_ArmorPercent.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_ArmorPercent.TabIndex = 8;
            this.numUpDown_ArmorPercent.ValueChanged += new System.EventHandler(this.ArmorPercent_ValueChanged);
            // 
            // numUpDown_BaseArmor
            // 
            this.numUpDown_BaseArmor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_BaseArmor.Location = new System.Drawing.Point(3, 55);
            this.numUpDown_BaseArmor.Name = "numUpDown_BaseArmor";
            this.numUpDown_BaseArmor.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_BaseArmor.TabIndex = 2;
            this.numUpDown_BaseArmor.ValueChanged += new System.EventHandler(this.BaseArmor_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "True armor";
            // 
            // lbl_RawArmorBonus
            // 
            this.lbl_RawArmorBonus.AutoSize = true;
            this.lbl_RawArmorBonus.Location = new System.Drawing.Point(3, 125);
            this.lbl_RawArmorBonus.Name = "lbl_RawArmorBonus";
            this.lbl_RawArmorBonus.Size = new System.Drawing.Size(100, 15);
            this.lbl_RawArmorBonus.TabIndex = 5;
            this.lbl_RawArmorBonus.Text = "Raw armor bonus";
            // 
            // lbl_ArmorPercent
            // 
            this.lbl_ArmorPercent.AutoSize = true;
            this.lbl_ArmorPercent.Location = new System.Drawing.Point(3, 81);
            this.lbl_ArmorPercent.Name = "lbl_ArmorPercent";
            this.lbl_ArmorPercent.Size = new System.Drawing.Size(100, 15);
            this.lbl_ArmorPercent.TabIndex = 4;
            this.lbl_ArmorPercent.Text = "Armor % increase";
            // 
            // lbl_BaseArmor
            // 
            this.lbl_BaseArmor.AutoSize = true;
            this.lbl_BaseArmor.Location = new System.Drawing.Point(3, 37);
            this.lbl_BaseArmor.Name = "lbl_BaseArmor";
            this.lbl_BaseArmor.Size = new System.Drawing.Size(66, 15);
            this.lbl_BaseArmor.TabIndex = 2;
            this.lbl_BaseArmor.Text = "Base armor";
            // 
            // lbl_Armor
            // 
            this.lbl_Armor.AutoSize = true;
            this.lbl_Armor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Armor.Location = new System.Drawing.Point(3, 0);
            this.lbl_Armor.Name = "lbl_Armor";
            this.lbl_Armor.Size = new System.Drawing.Size(55, 21);
            this.lbl_Armor.TabIndex = 0;
            this.lbl_Armor.Text = "Armor";
            // 
            // pnl_EffectiveStats
            // 
            this.pnl_EffectiveStats.Controls.Add(this.numUpDown_EHP);
            this.pnl_EffectiveStats.Controls.Add(this.lbl_EHP);
            this.pnl_EffectiveStats.Controls.Add(this.lbl_Effective);
            this.pnl_EffectiveStats.Location = new System.Drawing.Point(424, 27);
            this.pnl_EffectiveStats.Name = "pnl_EffectiveStats";
            this.pnl_EffectiveStats.Size = new System.Drawing.Size(200, 269);
            this.pnl_EffectiveStats.TabIndex = 13;
            // 
            // numUpDown_EHP
            // 
            this.numUpDown_EHP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_EHP.Enabled = false;
            this.numUpDown_EHP.Location = new System.Drawing.Point(3, 55);
            this.numUpDown_EHP.Name = "numUpDown_EHP";
            this.numUpDown_EHP.Size = new System.Drawing.Size(194, 23);
            this.numUpDown_EHP.TabIndex = 2;
            // 
            // lbl_EHP
            // 
            this.lbl_EHP.AutoSize = true;
            this.lbl_EHP.Location = new System.Drawing.Point(3, 37);
            this.lbl_EHP.Name = "lbl_EHP";
            this.lbl_EHP.Size = new System.Drawing.Size(90, 15);
            this.lbl_EHP.TabIndex = 2;
            this.lbl_EHP.Text = "Effective Health";
            // 
            // lbl_Effective
            // 
            this.lbl_Effective.AutoSize = true;
            this.lbl_Effective.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Effective.Location = new System.Drawing.Point(3, 0);
            this.lbl_Effective.Name = "lbl_Effective";
            this.lbl_Effective.Size = new System.Drawing.Size(105, 21);
            this.lbl_Effective.TabIndex = 0;
            this.lbl_Effective.Text = "Effective Stats";
            // 
            // Warframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.pnl_EffectiveStats);
            this.Controls.Add(this.pnl_Armor);
            this.Controls.Add(this.pnl_Health);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Warframe";
            this.Text = "Warframe";
            this.pnl_Health.ResumeLayout(false);
            this.pnl_Health.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_TrueHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_HealthBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_HealthPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BaseHealth)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Armor.ResumeLayout(false);
            this.pnl_Armor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DamageReduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_TrueArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ArmorBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ArmorPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BaseArmor)).EndInit();
            this.pnl_EffectiveStats.ResumeLayout(false);
            this.pnl_EffectiveStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_EHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_Health;
        private Label lbl_Health;
        private Label lbl_bHealth;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Label lbl_RawHealthBonus;
        private Label lbl_HealthPercent;
        private Label lbl_TrueHealth;
        private NumericUpDown numUpDown_TrueHealth;
        private NumericUpDown numUpDown_HealthBonus;
        private NumericUpDown numUpDown_HealthPercent;
        private NumericUpDown numUpDown_BaseHealth;
        private Panel pnl_Armor;
        private NumericUpDown numUpDown_TrueArmor;
        private NumericUpDown numUpDown_ArmorBonus;
        private NumericUpDown numUpDown_ArmorPercent;
        private NumericUpDown numUpDown_BaseArmor;
        private Label label1;
        private Label lbl_RawArmorBonus;
        private Label lbl_ArmorPercent;
        private Label lbl_BaseArmor;
        private Label lbl_Armor;
        private NumericUpDown numUpDown_DamageReduction;
        private Label lbl_DamageReduction;
        private Panel pnl_EffectiveStats;
        private NumericUpDown numUpDown_EHP;
        private Label lbl_EHP;
        private Label lbl_Effective;
    }
}