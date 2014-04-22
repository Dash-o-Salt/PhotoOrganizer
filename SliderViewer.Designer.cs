namespace PhotoOrganizer
{
    partial class SliderViewer
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
            this.tbImageSelector = new System.Windows.Forms.TrackBar();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbImageInformation = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.numPictures = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // tbImageSelector
            // 
            this.tbImageSelector.Location = new System.Drawing.Point(12, 618);
            this.tbImageSelector.Name = "tbImageSelector";
            this.tbImageSelector.Size = new System.Drawing.Size(1070, 45);
            this.tbImageSelector.TabIndex = 0;
            this.tbImageSelector.ValueChanged += new System.EventHandler(this.tbImageSelector_ValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(1007, 640);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbImageInformation
            // 
            this.lbImageInformation.AutoSize = true;
            this.lbImageInformation.Location = new System.Drawing.Point(9, 669);
            this.lbImageInformation.Name = "lbImageInformation";
            this.lbImageInformation.Size = new System.Drawing.Size(0, 13);
            this.lbImageInformation.TabIndex = 2;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(12, 12);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1070, 600);
            this.flowPanel.TabIndex = 3;
            // 
            // numPictures
            // 
            this.numPictures.Location = new System.Drawing.Point(881, 640);
            this.numPictures.Name = "numPictures";
            this.numPictures.Size = new System.Drawing.Size(120, 20);
            this.numPictures.TabIndex = 4;
            this.numPictures.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SliderViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 698);
            this.Controls.Add(this.numPictures);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.lbImageInformation);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbImageSelector);
            this.Name = "SliderViewer";
            this.Text = "Slider Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.tbImageSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbImageSelector;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbImageInformation;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.NumericUpDown numPictures;
    }
}