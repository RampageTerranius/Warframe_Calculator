﻿namespace Warframe_Calculator
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
            this.lbl_bHealth = new System.Windows.Forms.Label();
            this.tbox_bHealth = new System.Windows.Forms.TextBox();
            this.lbl_Health = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnl_.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_
            // 
            this.pnl_.Controls.Add(this.lbl_bHealth);
            this.pnl_.Controls.Add(this.tbox_bHealth);
            this.pnl_.Controls.Add(this.lbl_Health);
            this.pnl_.Location = new System.Drawing.Point(12, 27);
            this.pnl_.Name = "pnl_";
            this.pnl_.Size = new System.Drawing.Size(200, 304);
            this.pnl_.TabIndex = 0;
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
            // tbox_bHealth
            // 
            this.tbox_bHealth.Location = new System.Drawing.Point(3, 55);
            this.tbox_bHealth.Name = "tbox_bHealth";
            this.tbox_bHealth.Size = new System.Drawing.Size(194, 23);
            this.tbox_bHealth.TabIndex = 1;
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
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Warframe";
            this.Text = "Warframe";
            this.pnl_.ResumeLayout(false);
            this.pnl_.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_;
        private TextBox tbox_bHealth;
        private Label lbl_Health;
        private Label lbl_bHealth;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}