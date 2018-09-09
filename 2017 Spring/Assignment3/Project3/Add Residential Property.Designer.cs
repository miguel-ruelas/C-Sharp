namespace Project3
{
    partial class AddResidentialProperty
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
            this.addButton = new System.Windows.Forms.Button();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.squareFeetTextBox = new System.Windows.Forms.TextBox();
            this.squareFeetLabel = new System.Windows.Forms.Label();
            this.yearBuiltTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.propertyInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.floorLabel = new System.Windows.Forms.Label();
            this.waterFrontCheckBox = new System.Windows.Forms.CheckBox();
            this.tennisCourtsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.poolsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.garageCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propertyInfoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(151, 358);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 65);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(271, 114);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(72, 20);
            this.zipCodeTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Zipcode:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(91, 114);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(78, 20);
            this.stateTextBox.TabIndex = 4;
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
            this.cityTextBox.TabIndex = 3;
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
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Single Family Home",
            "Apartment"});
            this.typeComboBox.Location = new System.Drawing.Point(123, 19);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 0;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(91, 62);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(252, 20);
            this.unitTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unit/Apt";
            // 
            // squareFeetTextBox
            // 
            this.squareFeetTextBox.Location = new System.Drawing.Point(91, 178);
            this.squareFeetTextBox.Name = "squareFeetTextBox";
            this.squareFeetTextBox.Size = new System.Drawing.Size(121, 20);
            this.squareFeetTextBox.TabIndex = 8;
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
            this.yearBuiltTextBox.TabIndex = 6;
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
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(91, 36);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(252, 20);
            this.streetTextBox.TabIndex = 1;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 36);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(35, 13);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Street";
            // 
            // propertyInfoGroupBox
            // 
            this.propertyInfoGroupBox.Controls.Add(this.floorTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.floorLabel);
            this.propertyInfoGroupBox.Controls.Add(this.waterFrontCheckBox);
            this.propertyInfoGroupBox.Controls.Add(this.tennisCourtsTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.label6);
            this.propertyInfoGroupBox.Controls.Add(this.poolsTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.label5);
            this.propertyInfoGroupBox.Controls.Add(this.garageCheckBox);
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
            this.propertyInfoGroupBox.Controls.Add(this.streetTextBox);
            this.propertyInfoGroupBox.Controls.Add(this.addressLabel);
            this.propertyInfoGroupBox.Location = new System.Drawing.Point(29, 80);
            this.propertyInfoGroupBox.Name = "propertyInfoGroupBox";
            this.propertyInfoGroupBox.Size = new System.Drawing.Size(369, 272);
            this.propertyInfoGroupBox.TabIndex = 4;
            this.propertyInfoGroupBox.TabStop = false;
            this.propertyInfoGroupBox.Text = "Property Information:";
            // 
            // floorTextBox
            // 
            this.floorTextBox.Location = new System.Drawing.Point(304, 152);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(39, 20);
            this.floorTextBox.TabIndex = 7;
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Location = new System.Drawing.Point(234, 155);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(64, 13);
            this.floorLabel.TabIndex = 20;
            this.floorLabel.Text = "Floor/Level:";
            // 
            // waterFrontCheckBox
            // 
            this.waterFrontCheckBox.AutoSize = true;
            this.waterFrontCheckBox.Location = new System.Drawing.Point(257, 181);
            this.waterFrontCheckBox.Name = "waterFrontCheckBox";
            this.waterFrontCheckBox.Size = new System.Drawing.Size(82, 17);
            this.waterFrontCheckBox.TabIndex = 11;
            this.waterFrontCheckBox.Text = "Water Front";
            this.waterFrontCheckBox.UseVisualStyleBackColor = true;
            // 
            // tennisCourtsTextBox
            // 
            this.tennisCourtsTextBox.Location = new System.Drawing.Point(150, 230);
            this.tennisCourtsTextBox.Name = "tennisCourtsTextBox";
            this.tennisCourtsTextBox.Size = new System.Drawing.Size(62, 20);
            this.tennisCourtsTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Number of Tennis Courts:";
            // 
            // poolsTextBox
            // 
            this.poolsTextBox.Location = new System.Drawing.Point(150, 204);
            this.poolsTextBox.Name = "poolsTextBox";
            this.poolsTextBox.Size = new System.Drawing.Size(62, 20);
            this.poolsTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Number of Pools:";
            // 
            // garageCheckBox
            // 
            this.garageCheckBox.AutoSize = true;
            this.garageCheckBox.Location = new System.Drawing.Point(257, 207);
            this.garageCheckBox.Name = "garageCheckBox";
            this.garageCheckBox.Size = new System.Drawing.Size(61, 17);
            this.garageCheckBox.TabIndex = 12;
            this.garageCheckBox.Text = "Garage";
            this.garageCheckBox.UseVisualStyleBackColor = true;
            this.garageCheckBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Type:";
            // 
            // AddResidentialProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 435);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.propertyInfoGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddResidentialProperty";
            this.Text = "Add Residential Property";
            this.Load += new System.EventHandler(this.AddResidentialProperty_Load);
            this.propertyInfoGroupBox.ResumeLayout(false);
            this.propertyInfoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox squareFeetTextBox;
        private System.Windows.Forms.Label squareFeetLabel;
        private System.Windows.Forms.TextBox yearBuiltTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.GroupBox propertyInfoGroupBox;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.CheckBox waterFrontCheckBox;
        private System.Windows.Forms.TextBox tennisCourtsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox poolsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox garageCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}