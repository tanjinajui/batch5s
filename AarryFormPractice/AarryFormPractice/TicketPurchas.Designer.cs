namespace AarryFormPractice
{
    partial class TicketPurchas
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
            this.TotalPriceButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfTicketTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalPriceButton
            // 
            this.TotalPriceButton.Location = new System.Drawing.Point(103, 138);
            this.TotalPriceButton.Name = "TotalPriceButton";
            this.TotalPriceButton.Size = new System.Drawing.Size(75, 23);
            this.TotalPriceButton.TabIndex = 0;
            this.TotalPriceButton.Text = "Total Price";
            this.TotalPriceButton.UseVisualStyleBackColor = true;
            this.TotalPriceButton.Click += new System.EventHandler(this.TotalPriceButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(184, 138);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(75, 23);
            this.DetailsButton.TabIndex = 1;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(159, 46);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // numberOfTicketTextBox
            // 
            this.numberOfTicketTextBox.Location = new System.Drawing.Point(159, 78);
            this.numberOfTicketTextBox.Name = "numberOfTicketTextBox";
            this.numberOfTicketTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfTicketTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CustomerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Ticket";
            // 
            // TicketPurchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfTicketTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.TotalPriceButton);
            this.Name = "TicketPurchas";
            this.Text = "TicketPurchas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TotalPriceButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox numberOfTicketTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}