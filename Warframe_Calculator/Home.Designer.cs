namespace Warframe_Calculator
{
    partial class Home
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
            this.btn_newWarframe = new System.Windows.Forms.Button();
            this.btn_newPrimary = new System.Windows.Forms.Button();
            this.btn_newSecondary = new System.Windows.Forms.Button();
            this.btn_newMeele = new System.Windows.Forms.Button();
            this.tblLayout_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayout_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_newWarframe
            // 
            this.btn_newWarframe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newWarframe.AutoSize = true;
            this.btn_newWarframe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newWarframe.Location = new System.Drawing.Point(3, 3);
            this.btn_newWarframe.Name = "btn_newWarframe";
            this.btn_newWarframe.Size = new System.Drawing.Size(548, 90);
            this.btn_newWarframe.TabIndex = 0;
            this.btn_newWarframe.Text = "New Warframe";
            this.btn_newWarframe.UseVisualStyleBackColor = true;
            // 
            // btn_newPrimary
            // 
            this.btn_newPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newPrimary.AutoSize = true;
            this.btn_newPrimary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newPrimary.Location = new System.Drawing.Point(3, 99);
            this.btn_newPrimary.Name = "btn_newPrimary";
            this.btn_newPrimary.Size = new System.Drawing.Size(548, 90);
            this.btn_newPrimary.TabIndex = 1;
            this.btn_newPrimary.Text = "New Primary";
            this.btn_newPrimary.UseVisualStyleBackColor = true;
            // 
            // btn_newSecondary
            // 
            this.btn_newSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newSecondary.AutoSize = true;
            this.btn_newSecondary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newSecondary.Location = new System.Drawing.Point(3, 195);
            this.btn_newSecondary.Name = "btn_newSecondary";
            this.btn_newSecondary.Size = new System.Drawing.Size(548, 90);
            this.btn_newSecondary.TabIndex = 2;
            this.btn_newSecondary.Text = "New Secondary";
            this.btn_newSecondary.UseVisualStyleBackColor = true;
            // 
            // btn_newMeele
            // 
            this.btn_newMeele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newMeele.AutoSize = true;
            this.btn_newMeele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newMeele.Location = new System.Drawing.Point(3, 291);
            this.btn_newMeele.Name = "btn_newMeele";
            this.btn_newMeele.Size = new System.Drawing.Size(548, 92);
            this.btn_newMeele.TabIndex = 3;
            this.btn_newMeele.Text = "New Meele";
            this.btn_newMeele.UseVisualStyleBackColor = true;
            // 
            // tblLayout_Main
            // 
            this.tblLayout_Main.ColumnCount = 1;
            this.tblLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_Main.Controls.Add(this.btn_newPrimary, 0, 1);
            this.tblLayout_Main.Controls.Add(this.btn_newWarframe, 0, 0);
            this.tblLayout_Main.Controls.Add(this.btn_newMeele, 0, 3);
            this.tblLayout_Main.Controls.Add(this.btn_newSecondary, 0, 2);
            this.tblLayout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Main.Location = new System.Drawing.Point(0, 0);
            this.tblLayout_Main.Name = "tblLayout_Main";
            this.tblLayout_Main.RowCount = 4;
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_Main.Size = new System.Drawing.Size(554, 386);
            this.tblLayout_Main.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(554, 386);
            this.Controls.Add(this.tblLayout_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.tblLayout_Main.ResumeLayout(false);
            this.tblLayout_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_newWarframe;
        private Button btn_newPrimary;
        private Button btn_newSecondary;
        private Button btn_newMeele;
        private TableLayoutPanel tblLayout_Main;
    }
}