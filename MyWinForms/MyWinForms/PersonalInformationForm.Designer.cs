namespace MyWinForms
{
    partial class PersonalInformationForm
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
            this.AddressButton = new System.Windows.Forms.Button();
            this.ParentsButton = new System.Windows.Forms.Button();
            this.NameButton = new System.Windows.Forms.Button();
            this.showAllInformationButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.mothersNameTextBox = new System.Windows.Forms.TextBox();
            this.fathersnameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddressButton
            // 
            this.AddressButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressButton.Location = new System.Drawing.Point(480, 402);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(141, 34);
            this.AddressButton.TabIndex = 31;
            this.AddressButton.Text = "Address";
            this.AddressButton.UseVisualStyleBackColor = true;
            this.AddressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // ParentsButton
            // 
            this.ParentsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParentsButton.Location = new System.Drawing.Point(321, 402);
            this.ParentsButton.Name = "ParentsButton";
            this.ParentsButton.Size = new System.Drawing.Size(138, 34);
            this.ParentsButton.TabIndex = 30;
            this.ParentsButton.Text = "Parents Name";
            this.ParentsButton.UseVisualStyleBackColor = true;
            this.ParentsButton.Click += new System.EventHandler(this.ParentsButton_Click);
            // 
            // NameButton
            // 
            this.NameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameButton.Location = new System.Drawing.Point(207, 402);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(91, 34);
            this.NameButton.TabIndex = 29;
            this.NameButton.Text = "Name";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // showAllInformationButton
            // 
            this.showAllInformationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllInformationButton.Location = new System.Drawing.Point(415, 340);
            this.showAllInformationButton.Name = "showAllInformationButton";
            this.showAllInformationButton.Size = new System.Drawing.Size(171, 34);
            this.showAllInformationButton.TabIndex = 28;
            this.showAllInformationButton.Text = "Show All Information";
            this.showAllInformationButton.UseVisualStyleBackColor = true;
            this.showAllInformationButton.Click += new System.EventHandler(this.showAllInformationButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(281, 340);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 34);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(298, 274);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(218, 29);
            this.AddressTextBox.TabIndex = 26;
            // 
            // mothersNameTextBox
            // 
            this.mothersNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mothersNameTextBox.Location = new System.Drawing.Point(298, 230);
            this.mothersNameTextBox.Name = "mothersNameTextBox";
            this.mothersNameTextBox.Size = new System.Drawing.Size(218, 29);
            this.mothersNameTextBox.TabIndex = 25;
            // 
            // fathersnameTextBox
            // 
            this.fathersnameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathersnameTextBox.Location = new System.Drawing.Point(298, 181);
            this.fathersnameTextBox.Name = "fathersnameTextBox";
            this.fathersnameTextBox.Size = new System.Drawing.Size(218, 29);
            this.fathersnameTextBox.TabIndex = 24;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(298, 137);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(218, 29);
            this.lastNameTextBox.TabIndex = 23;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(298, 97);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(218, 29);
            this.FirstNameTextBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mother\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Father\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Personal Information";
            // 
            // saveRichTextBox
            // 
            this.saveRichTextBox.Location = new System.Drawing.Point(593, 97);
            this.saveRichTextBox.Name = "saveRichTextBox";
            this.saveRichTextBox.Size = new System.Drawing.Size(186, 206);
            this.saveRichTextBox.TabIndex = 32;
            this.saveRichTextBox.Text = "";
            // 
            // PersonalInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveRichTextBox);
            this.Controls.Add(this.AddressButton);
            this.Controls.Add(this.ParentsButton);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.showAllInformationButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.mothersNameTextBox);
            this.Controls.Add(this.fathersnameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonalInformationForm";
            this.Text = "PersonalInformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddressButton;
        private System.Windows.Forms.Button ParentsButton;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.Button showAllInformationButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox mothersNameTextBox;
        private System.Windows.Forms.TextBox fathersnameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox saveRichTextBox;
    }
}