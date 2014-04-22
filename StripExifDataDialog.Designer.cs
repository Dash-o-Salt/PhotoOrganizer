namespace PhotoOrganizer
{
    partial class StripExifDataDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StripExifDataDialog));
            this.lblTemplate = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(12, 59);
            this.lblTemplate.MaximumSize = new System.Drawing.Size(500, 100);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(496, 26);
            this.lblTemplate.TabIndex = 1;
            this.lblTemplate.Text = "WARNING: Stripping EXIF metadata from files in this folder will replace all of th" +
                "e existing image files with copies of those images that do not contain the EXIF " +
                "metadata. Do you wish to proceed?";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(316, 167);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Location = new System.Drawing.Point(12, 9);
            this.lblExplanation.MaximumSize = new System.Drawing.Size(500, 100);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(0, 13);
            this.lblExplanation.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 106);
            this.lblStatus.MaximumSize = new System.Drawing.Size(500, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(141, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Stripping data from this path:";
            this.lblStatus.Visible = false;
            // 
            // lblStatusPath
            // 
            this.lblStatusPath.AutoSize = true;
            this.lblStatusPath.Location = new System.Drawing.Point(12, 128);
            this.lblStatusPath.MaximumSize = new System.Drawing.Size(500, 100);
            this.lblStatusPath.Name = "lblStatusPath";
            this.lblStatusPath.Size = new System.Drawing.Size(182, 13);
            this.lblStatusPath.TabIndex = 8;
            this.lblStatusPath.Text = "This is the path that is being stripped.";
            this.lblStatusPath.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(500, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // StripExifDataDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatusPath);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblTemplate);
            this.Name = "StripExifDataDialog";
            this.Text = "Strip EXIF Metadata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemplate;
        internal System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusPath;
        private System.Windows.Forms.Label label1;
    }
}