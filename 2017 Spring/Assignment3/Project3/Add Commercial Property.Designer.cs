namespace Project3
{
    partial class AddCommercialProperty
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
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.propertyInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.squareFeetTextBox = new System.Windows.Forms.TextBox();
            this.squareFeetLabel = new System.Windows.Forms.Label();
            this.yearBuiltTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.comStreetTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.propertyInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Industrial",
            "Office",
            "Retail"});
            this.typeComboBox.Location = new System.Drawing.Point(123, 19);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 0;
            // 
            // propertyInfoGroupBox
            // 
            this.propertyInfoGroupBox.Controls.Add(this.zipCodeTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.label4);
            this.propertyInfoGroupBox.Controls.Add(this.stateTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.label3);
            this.propertyInfoGroupBox.Controls.Add(this.cityTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.label2);
            this.propertyInfoGroupBox.Controls.Add(this.unitTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.label1);
            this.propertyInfoGroupBox.Controls.Add(this.squareFeetTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.squareFeetLabel);
            this.propertyInfoGroupBox.Controls.Add(this.yearBuiltTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.yearLabel);
            this.propertyInfoGroupBox.Controls.Add(this.comStreetTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.addressLabel);
            this.propertyInfoGroupBox.Location = new System.Drawing.Point(13, 80);
            this.propertyInfoGroupBox.Name = "propertyInfoGroupBox";
            this.propertyInfoGroupBox.Size = new System.Drawing.Size(369, 200);
            this.propertyInfoGroupBox.TabIndex = 1;
            this.propertyInfoGroupBox.TabStop = false;
            this.propertyInfoGroupBox.Text = "Property Information:";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(271, 114);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(72, 20);
            this.zipCodeTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zipcode:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(91, 114);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(78, 20);
            this.stateTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "State:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(91, 88);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(252, 20);
            this.cityTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "City";
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(91, 62);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(252, 20);
            this.unitTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unit";
            // 
            // squareFeetTextBox
            // 
            this.squareFeetTextBox.Location = new System.Drawing.Point(91, 178);
            this.squareFeetTextBox.Name = "squareFeetTextBox";
            this.squareFeetTextBox.Size = new System.Drawing.Size(121, 20);
            this.squareFeetTextBox.TabIndex = 6;
            // 
            // squareFeetLabel
            // 
            this.squareFeetLabel.AutoSize = true;
            this.squareFeetLabel.Location = new System.Drawing.Point(12, 178);
            this.squareFeetLabel.Name = "squareFeetLabel";
            this.squareFeetLabel.Size = new System.Drawing.Size(68, 13);
            this.squareFeetLabel.TabIndex = 4;
            this.squareFeetLabel.Text = "Square Feet:";
            // 
            // yearBuiltTextBox
            // 
            this.yearBuiltTextBox.Location = new System.Drawing.Point(91, 152);
            this.yearBuiltTextBox.Name = "yearBuiltTextBox";
            this.yearBuiltTextBox.Size = new System.Drawing.Size(121, 20);
            this.yearBuiltTextBox.TabIndex = 5;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 152);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(55, 13);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Year Built:";
            // 
            // comStreetTextBox
            // 
            this.comStreetTextBox.Location = new System.Drawing.Point(91, 36);
            this.comStreetTextBox.Name = "comStreetTextBox";
            this.comStreetTextBox.Size = new System.Drawing.Size(252, 20);
            this.comStreetTextBox.TabIndex = 0;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 36);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(35, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Street";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(135, 299);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 65);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddCommercialProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 376);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.propertyInfoGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCommercialProperty";
            this.Text = "Add Commercial Property";
            this.Load += new System.EventHandler(this.AddCommercialProperty_Load);
            this.groupBox1.ResumeLayout(false);
            this.propertyInfoGroupBox.ResumeLayout(false);
            this.propertyInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.GroupBox propertyInfoGroupBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox squareFeetTextBox;
        private System.Windows.Forms.Label squareFeetLabel;
        private System.Windows.Forms.TextBox yearBuiltTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox comStreetTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button addButton;
    }
}