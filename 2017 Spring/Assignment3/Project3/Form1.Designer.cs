namespace Project3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.propertyTypeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.propertyListBox = new System.Windows.Forms.ListBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costDisplayLabel = new System.Windows.Forms.Label();
            this.printReportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.residentialRadioButton);
            this.groupBox1.Controls.Add(this.commercialRadioButton);
            this.groupBox1.Controls.Add(this.propertyTypeLabel);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Property";
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(7, 65);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(77, 17);
            this.residentialRadioButton.TabIndex = 4;
            this.residentialRadioButton.Text = "Residential";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Checked = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(7, 41);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(79, 17);
            this.commercialRadioButton.TabIndex = 3;
            this.commercialRadioButton.TabStop = true;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            // 
            // propertyTypeLabel
            // 
            this.propertyTypeLabel.AutoSize = true;
            this.propertyTypeLabel.Location = new System.Drawing.Point(13, 24);
            this.propertyTypeLabel.Name = "propertyTypeLabel";
            this.propertyTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.propertyTypeLabel.TabIndex = 2;
            this.propertyTypeLabel.Text = "Select Type:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(597, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 85);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.propertyListBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property Report";
            // 
            // propertyListBox
            // 
            this.propertyListBox.FormattingEnabled = true;
            this.propertyListBox.Location = new System.Drawing.Point(0, 20);
            this.propertyListBox.Name = "propertyListBox";
            this.propertyListBox.Size = new System.Drawing.Size(738, 147);
            this.propertyListBox.TabIndex = 0;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(13, 311);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(119, 13);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Total Investment Value:";
            // 
            // costDisplayLabel
            // 
            this.costDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costDisplayLabel.Location = new System.Drawing.Point(13, 336);
            this.costDisplayLabel.Name = "costDisplayLabel";
            this.costDisplayLabel.Size = new System.Drawing.Size(132, 36);
            this.costDisplayLabel.TabIndex = 3;
            // 
            // printReportButton
            // 
            this.printReportButton.Location = new System.Drawing.Point(610, 314);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(141, 80);
            this.printReportButton.TabIndex = 4;
            this.printReportButton.Text = "Print Reprot:";
            this.printReportButton.UseVisualStyleBackColor = true;
            this.printReportButton.Click += new System.EventHandler(this.printReportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 403);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.costDisplayLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Real Estate Investment Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label propertyTypeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox propertyListBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label costDisplayLabel;
        private System.Windows.Forms.Button printReportButton;
    }
}

