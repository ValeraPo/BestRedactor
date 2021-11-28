
namespace BestRedactor.Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_pipette = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Fill = new System.Windows.Forms.Button();
            this.btn_Rect = new System.Windows.Forms.Button();
            this.btn_Ellipce = new System.Windows.Forms.Button();
            this.btn_Eareser = new System.Windows.Forms.Button();
            this.btn_Pencil = new System.Windows.Forms.Button();
            this.btn_SetColor = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.btn_pipette);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_Line);
            this.panel1.Controls.Add(this.btn_Fill);
            this.panel1.Controls.Add(this.btn_Rect);
            this.panel1.Controls.Add(this.btn_Ellipce);
            this.panel1.Controls.Add(this.btn_Eareser);
            this.panel1.Controls.Add(this.btn_Pencil);
            this.panel1.Controls.Add(this.btn_SetColor);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(6, 377);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(39, 25);
            this.btn_load.TabIndex = 10;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_pipette
            // 
            this.btn_pipette.Location = new System.Drawing.Point(12, 78);
            this.btn_pipette.Name = "btn_pipette";
            this.btn_pipette.Size = new System.Drawing.Size(33, 27);
            this.btn_pipette.TabIndex = 9;
            this.btn_pipette.Text = "pipette";
            this.btn_pipette.UseVisualStyleBackColor = true;
            this.btn_pipette.Click += new System.EventHandler(this.btn_pipette_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(6, 346);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(39, 25);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(6, 311);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(39, 29);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.Location = new System.Drawing.Point(12, 278);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(33, 27);
            this.btn_Line.TabIndex = 7;
            this.btn_Line.Text = "Line";
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Fill
            // 
            this.btn_Fill.Location = new System.Drawing.Point(12, 113);
            this.btn_Fill.Name = "btn_Fill";
            this.btn_Fill.Size = new System.Drawing.Size(33, 27);
            this.btn_Fill.TabIndex = 6;
            this.btn_Fill.Text = "Fill";
            this.btn_Fill.UseVisualStyleBackColor = true;
            this.btn_Fill.Click += new System.EventHandler(this.btn_Fill_Click);
            // 
            // btn_Rect
            // 
            this.btn_Rect.Location = new System.Drawing.Point(12, 245);
            this.btn_Rect.Name = "btn_Rect";
            this.btn_Rect.Size = new System.Drawing.Size(33, 27);
            this.btn_Rect.TabIndex = 5;
            this.btn_Rect.Text = "Rectangle";
            this.btn_Rect.UseVisualStyleBackColor = true;
            this.btn_Rect.Click += new System.EventHandler(this.btn_Rect_Click);
            // 
            // btn_Ellipce
            // 
            this.btn_Ellipce.Location = new System.Drawing.Point(12, 212);
            this.btn_Ellipce.Name = "btn_Ellipce";
            this.btn_Ellipce.Size = new System.Drawing.Size(33, 27);
            this.btn_Ellipce.TabIndex = 4;
            this.btn_Ellipce.Text = "Ellipce";
            this.btn_Ellipce.UseVisualStyleBackColor = true;
            this.btn_Ellipce.Click += new System.EventHandler(this.btn_Ellipce_Click);
            // 
            // btn_Eareser
            // 
            this.btn_Eareser.Location = new System.Drawing.Point(12, 179);
            this.btn_Eareser.Name = "btn_Eareser";
            this.btn_Eareser.Size = new System.Drawing.Size(33, 27);
            this.btn_Eareser.TabIndex = 3;
            this.btn_Eareser.Text = "eareser";
            this.btn_Eareser.UseVisualStyleBackColor = true;
            this.btn_Eareser.Click += new System.EventHandler(this.btn_Eareser_Click);
            // 
            // btn_Pencil
            // 
            this.btn_Pencil.Location = new System.Drawing.Point(12, 146);
            this.btn_Pencil.Name = "btn_Pencil";
            this.btn_Pencil.Size = new System.Drawing.Size(33, 27);
            this.btn_Pencil.TabIndex = 2;
            this.btn_Pencil.Text = "pencil";
            this.btn_Pencil.UseVisualStyleBackColor = true;
            this.btn_Pencil.Click += new System.EventHandler(this.btn_Pencil_Click);
            // 
            // btn_SetColor
            // 
            this.btn_SetColor.Location = new System.Drawing.Point(12, 45);
            this.btn_SetColor.Name = "btn_SetColor";
            this.btn_SetColor.Size = new System.Drawing.Size(33, 27);
            this.btn_SetColor.TabIndex = 1;
            this.btn_SetColor.Text = "SetColor";
            this.btn_SetColor.UseVisualStyleBackColor = true;
            this.btn_SetColor.Click += new System.EventHandler(this.btn_SetColor_Click);
            // 
            // pic_color
            // 
            this.pic_color.Location = new System.Drawing.Point(12, 12);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(33, 27);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(51, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(749, 450);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Fill;
        private System.Windows.Forms.Button btn_Rect;
        private System.Windows.Forms.Button btn_Ellipce;
        private System.Windows.Forms.Button btn_Eareser;
        private System.Windows.Forms.Button btn_Pencil;
        private System.Windows.Forms.Button btn_SetColor;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_pipette;
        private System.Windows.Forms.Button btn_load;
    }
}