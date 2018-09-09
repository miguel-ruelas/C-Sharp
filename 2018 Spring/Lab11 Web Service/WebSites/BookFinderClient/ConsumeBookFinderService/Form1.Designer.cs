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
            this.btnGetComplete = new System.Windows.Forms.Button();
            this.txtPartial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetComplete
            // 
            this.btnGetComplete.Location = new System.Drawing.Point(268, 64);
            this.btnGetComplete.Name = "btnGetComplete";
            this.btnGetComplete.Size = new System.Drawing.Size(133, 33);
            this.btnGetComplete.TabIndex = 0;
            this.btnGetComplete.Text = "Get Complete Book List";
            this.btnGetComplete.UseVisualStyleBackColor = true;
            this.btnGetComplete.Click += new System.EventHandler(this.btnGetComplete_Click);
            // 
            // txtPartial
            // 
            this.txtPartial.Location = new System.Drawing.Point(34, 38);
            this.txtPartial.Name = "txtPartial";
            this.txtPartial.Size = new System.Drawing.Size(286, 20);
            this.txtPartial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a partial book title:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(34, 64);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(124, 33);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find matching books";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(524, 64);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(35, 20);
            this.txtSort.TabIndex = 5;
            this.txtSort.Text = "I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sort Flag (I/T/A/Y)";
            // 
            // lbxResults
            // 
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.Location = new System.Drawing.Point(23, 128);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(600, 303);
            this.lbxResults.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 459);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPartial);
            this.Controls.Add(this.btnGetComplete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetComplete;
        private System.Windows.Forms.TextBox txtPartial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxResults;
    }
}

