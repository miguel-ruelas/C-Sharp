namespace FlightReservationGui
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lnklblAssignment1 = new System.Windows.Forms.LinkLabel();
            this.lnklblAssignment2 = new System.Windows.Forms.LinkLabel();
            this.lnkLblAssignment3 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(373, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Flight Reservations 1.3";
            // 
            // lnklblAssignment1
            // 
            this.lnklblAssignment1.AutoSize = true;
            this.lnklblAssignment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblAssignment1.Location = new System.Drawing.Point(12, 128);
            this.lnklblAssignment1.Name = "lnklblAssignment1";
            this.lnklblAssignment1.Size = new System.Drawing.Size(496, 24);
            this.lnklblAssignment1.TabIndex = 1;
            this.lnklblAssignment1.TabStop = true;
            this.lnklblAssignment1.Text = "Create and display the flights.xml file (Assignment 1)";
            this.lnklblAssignment1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAssignment1_LinkClicked);
            // 
            // lnklblAssignment2
            // 
            this.lnklblAssignment2.AutoSize = true;
            this.lnklblAssignment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblAssignment2.Location = new System.Drawing.Point(12, 175);
            this.lnklblAssignment2.Name = "lnklblAssignment2";
            this.lnklblAssignment2.Size = new System.Drawing.Size(306, 24);
            this.lnklblAssignment2.TabIndex = 2;
            this.lnklblAssignment2.TabStop = true;
            this.lnklblAssignment2.Text = "Search for flights (Assignment2)";
            this.lnklblAssignment2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAssignment2_LinkClicked);
            // 
            // lnkLblAssignment3
            // 
            this.lnkLblAssignment3.AutoSize = true;
            this.lnkLblAssignment3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblAssignment3.Location = new System.Drawing.Point(12, 223);
            this.lnkLblAssignment3.Name = "lnkLblAssignment3";
            this.lnkLblAssignment3.Size = new System.Drawing.Size(368, 24);
            this.lnkLblAssignment3.TabIndex = 3;
            this.lnkLblAssignment3.TabStop = true;
            this.lnkLblAssignment3.Text = "Display matching flights (Assignment3)";
            this.lnkLblAssignment3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblAssignment3_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 303);
            this.Controls.Add(this.lnkLblAssignment3);
            this.Controls.Add(this.lnklblAssignment2);
            this.Controls.Add(this.lnklblAssignment1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Flight Reservations 1.3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lnklblAssignment1;
        private System.Windows.Forms.LinkLabel lnklblAssignment2;
        private System.Windows.Forms.LinkLabel lnkLblAssignment3;
    }
}