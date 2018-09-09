namespace ConsumeBookFinderService
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
            this.btnCallService = new System.Windows.Forms.Button();
            this.lblBookinfo = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCallService
            // 
            this.btnCallService.Location = new System.Drawing.Point(50, 80);
            this.btnCallService.Name = "btnCallService";
            this.btnCallService.Size = new System.Drawing.Size(75, 23);
            this.btnCallService.TabIndex = 0;
            this.btnCallService.Text = "Call Service";
            this.btnCallService.UseVisualStyleBackColor = true;
            this.btnCallService.Click += new System.EventHandler(this.btnCallService_Click);
            // 
            // lblBookinfo
            // 
            this.lblBookinfo.AutoSize = true;
            this.lblBookinfo.Location = new System.Drawing.Point(47, 126);
            this.lblBookinfo.Name = "lblBookinfo";
            this.lblBookinfo.Size = new System.Drawing.Size(35, 13);
            this.lblBookinfo.TabIndex = 1;
            this.lblBookinfo.Text = "label1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(50, 41);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 459);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblBookinfo);
            this.Controls.Add(this.btnCallService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallService;
        private System.Windows.Forms.Label lblBookinfo;
        private System.Windows.Forms.TextBox txtInput;
    }
}

