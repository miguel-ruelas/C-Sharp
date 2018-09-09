namespace FlightReservationGui
{
    partial class CreateFlightRequest
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
            this.btnCreFliReq = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbxSearchResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreFliReq
            // 
            this.btnCreFliReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreFliReq.Location = new System.Drawing.Point(12, 21);
            this.btnCreFliReq.Name = "btnCreFliReq";
            this.btnCreFliReq.Size = new System.Drawing.Size(188, 33);
            this.btnCreFliReq.TabIndex = 0;
            this.btnCreFliReq.Text = "Create flight requests";
            this.btnCreFliReq.UseVisualStyleBackColor = true;
            this.btnCreFliReq.Click += new System.EventHandler(this.btnCreFliReq_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(372, 64);
            this.btnSearch.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnSearch.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a request from the list and click the search button.";
            // 
            // lstbxSearchResults
            // 
            this.lstbxSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxSearchResults.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxSearchResults.FormattingEnabled = true;
            this.lstbxSearchResults.ItemHeight = 17;
            this.lstbxSearchResults.Location = new System.Drawing.Point(12, 106);
            this.lstbxSearchResults.Name = "lstbxSearchResults";
            this.lstbxSearchResults.Size = new System.Drawing.Size(460, 276);
            this.lstbxSearchResults.TabIndex = 3;
            // 
            // CreateFlightRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.lstbxSearchResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreFliReq);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "CreateFlightRequest";
            this.Text = "Flight Reservations 2.0";
            this.Load += new System.EventHandler(this.FlightRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreFliReq;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbxSearchResults;
    }
}