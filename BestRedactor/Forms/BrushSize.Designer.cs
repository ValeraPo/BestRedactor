namespace BestRedactor.Forms
{
    partial class BrushSize
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
            this.lblSize = new System.Windows.Forms.Label();
            this.trackBarBrushSize = new System.Windows.Forms.TrackBar();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 9);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(50, 15);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Размер:";
            // 
            // trackBarBrushSize
            // 
            this.trackBarBrushSize.AutoSize = false;
            this.trackBarBrushSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarBrushSize.LargeChange = 2;
            this.trackBarBrushSize.Location = new System.Drawing.Point(12, 34);
            this.trackBarBrushSize.Maximum = 100;
            this.trackBarBrushSize.Minimum = 1;
            this.trackBarBrushSize.Name = "trackBarBrushSize";
            this.trackBarBrushSize.Size = new System.Drawing.Size(191, 24);
            this.trackBarBrushSize.TabIndex = 1;
            this.trackBarBrushSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBrushSize.Value = 3;
            this.trackBarBrushSize.Scroll += new System.EventHandler(this.trackBarBrushSize_Scroll);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(138, 12);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxSize.Size = new System.Drawing.Size(65, 23);
            this.textBoxSize.TabIndex = 2;
            this.textBoxSize.Text = "3";
            this.textBoxSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSize_KeyDown);
            // 
            // BrushSize
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(215, 70);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.trackBarBrushSize);
            this.Controls.Add(this.lblSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrushSize";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Размер Кисти";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TrackBar trackBarBrushSize;
        private System.Windows.Forms.TextBox textBoxSize;
    }
}