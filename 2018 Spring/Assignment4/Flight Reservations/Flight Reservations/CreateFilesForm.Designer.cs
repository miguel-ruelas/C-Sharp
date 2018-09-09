namespace FlightReservationGui
{
    partial class CreateFilesForm
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
            this.btnCreateFlights = new System.Windows.Forms.Button();
            this.btnDisplayFlights = new System.Windows.Forms.Button();
            this.lstbxFlightSchedules = new System.Windows.Forms.ListBox();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateFlights
            // 
            this.btnCreateFlights.Location = new System.Drawing.Point(32, 12);
            this.btnCreateFlights.Name = "btnCreateFlights";
            this.btnCreateFlights.Size = new System.Drawing.Size(280, 70);
            this.btnCreateFlights.TabIndex = 0;
            this.btnCreateFlights.Text = "Create the flights.xml file";
            this.btnCreateFlights.UseVisualStyleBackColor = true;
            this.btnCreateFlights.Click += new System.EventHandler(this.btnCreateFlights_Click);
            // 
            // btnDisplayFlights
            // 
            this.btnDisplayFlights.Location = new System.Drawing.Point(321, 14);
            this.btnDisplayFlights.Name = "btnDisplayFlights";
            this.btnDisplayFlights.Size = new System.Drawing.Size(302, 66);
            this.btnDisplayFlights.TabIndex = 2;
            this.btnDisplayFlights.Text = "Display the sample.xml file in a Web browser window";
            this.btnDisplayFlights.UseVisualStyleBackColor = true;
            this.btnDisplayFlights.Click += new System.EventHandler(this.btnDisplayFlights_Click);
            // 
            // lstbxFlightSchedules
            // 
            this.lstbxFlightSchedules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxFlightSchedules.Font = new System.Drawing.Font("Courier New", 11F);
            this.lstbxFlightSchedules.FormattingEnabled = true;
            this.lstbxFlightSchedules.HorizontalScrollbar = true;
            this.lstbxFlightSchedules.ItemHeight = 17;
            this.lstbxFlightSchedules.Location = new System.Drawing.Point(32, 197);
            this.lstbxFlightSchedules.Name = "lstbxFlightSchedules";
            this.lstbxFlightSchedules.Size = new System.Drawing.Size(591, 293);
            this.lstbxFlightSchedules.TabIndex = 5;
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(32, 98);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(280, 70);
            this.btnDeserialize.TabIndex = 6;
            this.btnDeserialize.Text = "Deserialize the flights.xml and display it below";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 513);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.lstbxFlightSchedules);
            this.Controls.Add(this.btnDisplayFlights);
            this.Controls.Add(this.btnCreateFlights);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Reservations 1.0";
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFlights;
        private System.Windows.Forms.Button btnDisplayFlights;
        private System.Windows.Forms.ListBox lstbxFlightSchedules;
        private System.Windows.Forms.Button btnDeserialize;
    }
}

