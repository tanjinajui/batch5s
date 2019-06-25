namespace Exam
{
    partial class Index
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SaveCustomerAccountInfoButton = new System.Windows.Forms.Button();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.SearchCustomerAccountInfoButton = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SaveCustomerAccountInfoButton
            // 
            this.SaveCustomerAccountInfoButton.Location = new System.Drawing.Point(340, 152);
            this.SaveCustomerAccountInfoButton.Name = "SaveCustomerAccountInfoButton";
            this.SaveCustomerAccountInfoButton.Size = new System.Drawing.Size(215, 23);
            this.SaveCustomerAccountInfoButton.TabIndex = 3;
            this.SaveCustomerAccountInfoButton.Text = "Save Customer and Account Info";
            this.SaveCustomerAccountInfoButton.UseVisualStyleBackColor = true;
            this.SaveCustomerAccountInfoButton.Click += new System.EventHandler(this.SaveCustomerAccountInfoButton_Click);
            // 
            // TransactionButton
            // 
            this.TransactionButton.Location = new System.Drawing.Point(340, 198);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(215, 23);
            this.TransactionButton.TabIndex = 3;
            this.TransactionButton.Text = "Transaction";
            this.TransactionButton.UseVisualStyleBackColor = true;
            this.TransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // SearchCustomerAccountInfoButton
            // 
            this.SearchCustomerAccountInfoButton.Location = new System.Drawing.Point(340, 245);
            this.SearchCustomerAccountInfoButton.Name = "SearchCustomerAccountInfoButton";
            this.SearchCustomerAccountInfoButton.Size = new System.Drawing.Size(215, 23);
            this.SearchCustomerAccountInfoButton.TabIndex = 3;
            this.SearchCustomerAccountInfoButton.Text = "Search Customer and Account Info";
            this.SearchCustomerAccountInfoButton.UseVisualStyleBackColor = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "*";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.SearchCustomerAccountInfoButton);
            this.Controls.Add(this.TransactionButton);
            this.Controls.Add(this.SaveCustomerAccountInfoButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button SaveCustomerAccountInfoButton;
        private System.Windows.Forms.Button TransactionButton;
        private System.Windows.Forms.Button SearchCustomerAccountInfoButton;
    }
}

