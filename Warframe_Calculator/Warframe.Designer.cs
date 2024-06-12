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
            this.pnl_ = new System.Windows.Forms.Panel();
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
            this.pnl_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_TrueHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_HealthBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_HealthPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BaseHealth)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_
            // 
            this.pnl_.Controls.Add(this.numUpDown_TrueHealth);
            this.pnl_.Controls.Add(this.numUpDown_HealthBonus);
            this.pnl_.Controls.Add(this.numUpDown_HealthPercent);
            this.pnl_.Controls.Add(this.numUpDown_BaseHealth);
            this.pnl_.Controls.Add(this.lbl_TrueHealth);
            this.pnl_.Controls.Add(this.lbl_RawHealthBonus);
            this.pnl_.Controls.Add(this.lbl_HealthPercent);
            this.pnl_.Controls.Add(this.lbl_bHealth);
            this.pnl_.Controls.Add(this.lbl_Health);
            this.pnl_.Location = new System.Drawing.Point(12, 27);
            this.pnl_.Name = "pnl_";
            this.pnl_.Size = new System.Drawing.Size(200, 224);
            this.pnl_.TabIndex = 0;
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
            this.numUpDown_HealthBonus.ValueChanged += new System.EventHandler(this.HelathBonus_ValueChanged);
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
            // Warframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.pnl_);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Warframe";
            this.Text = "Warframe";
            this.pnl_.ResumeLayout(false);
            this.pnl_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_TrueHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_HealthBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_HealthPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BaseHealth)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_;
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
    }
}