namespace MyWinForms
{
    partial class ConditionalStatementForm
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
            this.planetNameComboBox = new System.Windows.Forms.ComboBox();
            this.showPlanetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // planetNameComboBox
            // 
            this.planetNameComboBox.FormattingEnabled = true;
            this.planetNameComboBox.Location = new System.Drawing.Point(153, 51);
            this.planetNameComboBox.Name = "planetNameComboBox";
            this.planetNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.planetNameComboBox.TabIndex = 0;
            // 
            // showPlanetButton
            // 
            this.showPlanetButton.Location = new System.Drawing.Point(199, 100);
            this.showPlanetButton.Name = "showPlanetButton";
            this.showPlanetButton.Size = new System.Drawing.Size(75, 23);
            this.showPlanetButton.TabIndex = 1;
            this.showPlanetButton.Text = "Show Planet Number";
            this.showPlanetButton.UseVisualStyleBackColor = true;
            this.showPlanetButton.Click += new System.EventHandler(this.showPlanetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Planet Name";
            // 
            // ConditionalStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPlanetButton);
            this.Controls.Add(this.planetNameComboBox);
            this.Name = "ConditionalStatementForm";
            this.Text = "ConditionalStatementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox planetNameComboBox;
        private System.Windows.Forms.Button showPlanetButton;
        private System.Windows.Forms.Label label1;
    }
}