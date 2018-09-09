namespace FlightReservationGui
{
    partial class MatchingMultiCityFlights
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(50, 50);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(475, 24);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "The following multi-city flights match your request:";
            // 
            // lbxResults
            // 
            this.lbxResults.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.ItemHeight = 17;
            this.lbxResults.Location = new System.Drawing.Point(12, 86);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(900, 174);
            this.lbxResults.TabIndex = 1;
            // 
            // MatchingMultiCityFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 290);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.lblResult);
            this.Name = "MatchingMultiCityFlights";
            this.Text = "MatchingMultiCityFlights";
            this.Load += new System.EventHandler(this.MatchingMultiCityFlights_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lbxResults;
    }
}