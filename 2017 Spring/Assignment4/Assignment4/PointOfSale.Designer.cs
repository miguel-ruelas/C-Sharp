namespace Assignment4
{
    partial class PointOfSale
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
            this.saleListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addQuantityCheckBox = new System.Windows.Forms.CheckBox();
            this.modeGrooupBox = new System.Windows.Forms.GroupBox();
            this.receiptButton = new System.Windows.Forms.Button();
            this.modeGrooupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleListBox
            // 
            this.saleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saleListBox.FormattingEnabled = true;
            this.saleListBox.Location = new System.Drawing.Point(453, 38);
            this.saleListBox.Name = "saleListBox";
            this.saleListBox.Size = new System.Drawing.Size(120, 251);
            this.saleListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.totalLabel.Location = new System.Drawing.Point(453, 292);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(120, 49);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(453, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(120, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addQuantityCheckBox
            // 
            this.addQuantityCheckBox.AutoSize = true;
            this.addQuantityCheckBox.Location = new System.Drawing.Point(40, 36);
            this.addQuantityCheckBox.Name = "addQuantityCheckBox";
            this.addQuantityCheckBox.Size = new System.Drawing.Size(133, 17);
            this.addQuantityCheckBox.TabIndex = 4;
            this.addQuantityCheckBox.Text = "Add Quanity after click";
            this.addQuantityCheckBox.UseVisualStyleBackColor = true;
            // 
            // modeGrooupBox
            // 
            this.modeGrooupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modeGrooupBox.Controls.Add(this.addQuantityCheckBox);
            this.modeGrooupBox.Location = new System.Drawing.Point(238, 359);
            this.modeGrooupBox.Name = "modeGrooupBox";
            this.modeGrooupBox.Size = new System.Drawing.Size(200, 75);
            this.modeGrooupBox.TabIndex = 5;
            this.modeGrooupBox.TabStop = false;
            this.modeGrooupBox.Text = "Change POS Mode";
            // 
            // receiptButton
            // 
            this.receiptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptButton.Location = new System.Drawing.Point(453, 359);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(120, 75);
            this.receiptButton.TabIndex = 6;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // PointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 446);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.modeGrooupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saleListBox);
            this.Name = "PointOfSale";
            this.Text = "PointOfSale";
            this.Load += new System.EventHandler(this.PointOfSale_Load);
            this.modeGrooupBox.ResumeLayout(false);
            this.modeGrooupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox saleListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.CheckBox addQuantityCheckBox;
        private System.Windows.Forms.GroupBox modeGrooupBox;
        private System.Windows.Forms.Button receiptButton;
    }
}