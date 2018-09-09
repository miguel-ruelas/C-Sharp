namespace Assignment4
{
    partial class ManageStock
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
            this.addInventoryButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addInventoryButton
            // 
            this.addInventoryButton.Location = new System.Drawing.Point(12, 10);
            this.addInventoryButton.Name = "addInventoryButton";
            this.addInventoryButton.Size = new System.Drawing.Size(120, 60);
            this.addInventoryButton.TabIndex = 3;
            this.addInventoryButton.Text = "Add New Product";
            this.addInventoryButton.UseVisualStyleBackColor = true;
            this.addInventoryButton.Click += new System.EventHandler(this.addInventoryButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(138, 10);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(120, 60);
            this.editProductButton.TabIndex = 4;
            this.editProductButton.Text = "Edit Product";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(572, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 60);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(12, 100);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.Size = new System.Drawing.Size(680, 330);
            this.inventoryGridView.TabIndex = 6;
            this.inventoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellClick);
            // 
            // ManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.addInventoryButton);
            this.Name = "ManageStock";
            this.Text = "ManageStock";
            this.Load += new System.EventHandler(this.ManageStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addInventoryButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView inventoryGridView;
    }
}