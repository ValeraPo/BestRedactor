namespace BestRedactor.Forms
{
    partial class Rotation
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButRight = new System.Windows.Forms.RadioButton();
            this.radioButLeft = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButLeft);
            this.panel1.Controls.Add(this.radioButRight);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 81);
            this.panel1.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(17, 41);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(65, 23);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 15);
            this.label.TabIndex = 1;
            this.label.Text = "Угол:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(207, 12);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButRight
            // 
            this.radioButRight.AutoSize = true;
            this.radioButRight.Location = new System.Drawing.Point(101, 16);
            this.radioButRight.Name = "radioButRight";
            this.radioButRight.Size = new System.Drawing.Size(64, 19);
            this.radioButRight.TabIndex = 4;
            this.radioButRight.TabStop = true;
            this.radioButRight.Text = "по ч. с.";
            this.radioButRight.UseVisualStyleBackColor = true;
            // 
            // radioButLeft
            // 
            this.radioButLeft.AutoSize = true;
            this.radioButLeft.Location = new System.Drawing.Point(101, 41);
            this.radioButLeft.Name = "radioButLeft";
            this.radioButLeft.Size = new System.Drawing.Size(89, 19);
            this.radioButLeft.TabIndex = 5;
            this.radioButLeft.TabStop = true;
            this.radioButLeft.Text = "против ч. с.";
            this.radioButLeft.UseVisualStyleBackColor = true;
            // 
            // Rotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 81);
            this.Controls.Add(this.panel1);
            this.Name = "Rotation";
            this.Text = "Rotation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButLeft;
        private System.Windows.Forms.RadioButton radioButRight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
    }
}