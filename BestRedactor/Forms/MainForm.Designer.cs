
namespace BestRedactor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlPage = new System.Windows.Forms.TabControl();
            this.toolStripTools = new System.Windows.Forms.ToolStrip();
            this.tsButt_color1 = new System.Windows.Forms.ToolStripButton();
            this.tsButt_color2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBrushButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPenButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonFigure = new System.Windows.Forms.ToolStripSplitButton();
            this.splitButtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dropDownButtToolStripMenuItemFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonCursor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFill = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPipette = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFraming = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCurrentSizeLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStripTools.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newToolStripMenuItem.Text = "Создать";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem1.Text = "Сохранить";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Сохранить как";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator4,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copyToolStripMenuItem.Text = "Копировать";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pasteToolStripMenuItem.Text = "Вставить";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(136, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(136, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearToolStripMenuItem.Text = "Очистить";
            // 
            // tabControlPage
            // 
            this.tabControlPage.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlPage.Location = new System.Drawing.Point(27, 24);
            this.tabControlPage.Name = "tabControlPage";
            this.tabControlPage.SelectedIndex = 0;
            this.tabControlPage.Size = new System.Drawing.Size(752, 401);
            this.tabControlPage.TabIndex = 1;
            // 
            // toolStripTools
            // 
            this.toolStripTools.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButt_color1,
            this.tsButt_color2,
            this.toolStripBrushButton,
            this.toolStripPenButton,
            this.toolStripSplitButtonFigure,
            this.toolStripDropDownButton1,
            this.toolStripButtonCursor,
            this.toolStripButtonFill,
            this.toolStripButtonPipette,
            this.toolStripButtonFraming});
            this.toolStripTools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripTools.Location = new System.Drawing.Point(0, 24);
            this.toolStripTools.Name = "toolStripTools";
            this.toolStripTools.Size = new System.Drawing.Size(33, 241);
            this.toolStripTools.TabIndex = 2;
            this.toolStripTools.Text = "tools";
            // 
            // tsButt_color1
            // 
            this.tsButt_color1.AutoSize = false;
            this.tsButt_color1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsButt_color1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButt_color1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButt_color1.Name = "tsButt_color1";
            this.tsButt_color1.Size = new System.Drawing.Size(20, 20);
            this.tsButt_color1.Text = "toolStripButton1";
            this.tsButt_color1.ToolTipText = "цвет 1";
            // 
            // tsButt_color2
            // 
            this.tsButt_color2.AutoSize = false;
            this.tsButt_color2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsButt_color2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButt_color2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButt_color2.Name = "tsButt_color2";
            this.tsButt_color2.Size = new System.Drawing.Size(20, 20);
            this.tsButt_color2.Text = "toolStripButton3";
            this.tsButt_color2.ToolTipText = "цвет 2";
            // 
            // toolStripBrushButton
            // 
            this.toolStripBrushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBrushButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBrushButton.Image")));
            this.toolStripBrushButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBrushButton.Name = "toolStripBrushButton";
            this.toolStripBrushButton.Size = new System.Drawing.Size(31, 20);
            this.toolStripBrushButton.Text = "toolStripButton4";
            this.toolStripBrushButton.ToolTipText = "Кисть";
            // 
            // toolStripPenButton
            // 
            this.toolStripPenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPenButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPenButton.Image")));
            this.toolStripPenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPenButton.Name = "toolStripPenButton";
            this.toolStripPenButton.Size = new System.Drawing.Size(31, 20);
            this.toolStripPenButton.Text = "toolStripButton5";
            this.toolStripPenButton.ToolTipText = "Карандаш";
            // 
            // toolStripSplitButtonFigure
            // 
            this.toolStripSplitButtonFigure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonFigure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitButtToolStripMenuItem,
            this.testToolStripMenuItem,
            this.test1ToolStripMenuItem});
            this.toolStripSplitButtonFigure.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonFigure.Image")));
            this.toolStripSplitButtonFigure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonFigure.Name = "toolStripSplitButtonFigure";
            this.toolStripSplitButtonFigure.Size = new System.Drawing.Size(31, 20);
            this.toolStripSplitButtonFigure.Text = "Форма";
            // 
            // splitButtToolStripMenuItem
            // 
            this.splitButtToolStripMenuItem.Name = "splitButtToolStripMenuItem";
            this.splitButtToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.splitButtToolStripMenuItem.Text = "тут будут формы";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.testToolStripMenuItem.Text = "test";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.test1ToolStripMenuItem.Text = "test1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropDownButtToolStripMenuItemFilters,
            this.testToolStripMenuItem1,
            this.testToolStripMenuItem2});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(31, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // dropDownButtToolStripMenuItemFilters
            // 
            this.dropDownButtToolStripMenuItemFilters.Name = "dropDownButtToolStripMenuItemFilters";
            this.dropDownButtToolStripMenuItemFilters.Size = new System.Drawing.Size(124, 22);
            this.dropDownButtToolStripMenuItemFilters.Text = "фильтры";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.testToolStripMenuItem1.Text = "test";
            // 
            // testToolStripMenuItem2
            // 
            this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            this.testToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.testToolStripMenuItem2.Text = "test";
            // 
            // toolStripButtonCursor
            // 
            this.toolStripButtonCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCursor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCursor.Image")));
            this.toolStripButtonCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCursor.Name = "toolStripButtonCursor";
            this.toolStripButtonCursor.Size = new System.Drawing.Size(31, 20);
            this.toolStripButtonCursor.Text = "toolStripButton1";
            this.toolStripButtonCursor.ToolTipText = "указатель";
            // 
            // toolStripButtonFill
            // 
            this.toolStripButtonFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFill.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFill.Image")));
            this.toolStripButtonFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFill.Name = "toolStripButtonFill";
            this.toolStripButtonFill.Size = new System.Drawing.Size(31, 20);
            this.toolStripButtonFill.Text = "toolStripButton1";
            this.toolStripButtonFill.ToolTipText = "Заливка";
            // 
            // toolStripButtonPipette
            // 
            this.toolStripButtonPipette.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPipette.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPipette.Image")));
            this.toolStripButtonPipette.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPipette.Name = "toolStripButtonPipette";
            this.toolStripButtonPipette.Size = new System.Drawing.Size(31, 20);
            this.toolStripButtonPipette.Text = "toolStripButton1";
            this.toolStripButtonPipette.ToolTipText = "Пипетка";
            // 
            // toolStripButtonFraming
            // 
            this.toolStripButtonFraming.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFraming.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFraming.Image")));
            this.toolStripButtonFraming.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFraming.Name = "toolStripButtonFraming";
            this.toolStripButtonFraming.Size = new System.Drawing.Size(31, 20);
            this.toolStripButtonFraming.Text = "toolStripButton1";
            this.toolStripButtonFraming.ToolTipText = "Кадрирование";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusCurrentSizeLb,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusCurrentSizeLb
            // 
            this.toolStripStatusCurrentSizeLb.Name = "toolStripStatusCurrentSizeLb";
            this.toolStripStatusCurrentSizeLb.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusCurrentSizeLb.Text = "полжение курсора";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel1.Text = "размер в пикселях";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(191, 17);
            this.toolStripStatusLabel2.Text = "здесь будет изменение масштаба";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(782, 281);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 4;
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Enabled = true;
            this.timerAutoSave.Interval = 300;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStripTools);
            this.Controls.Add(this.tabControlPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripTools.ResumeLayout(false);
            this.toolStripTools.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripTools;
        private System.Windows.Forms.ToolStripButton tsButt_color1;
        private System.Windows.Forms.ToolStripButton tsButt_color2;
        private System.Windows.Forms.ToolStripButton toolStripBrushButton;
        private System.Windows.Forms.ToolStripButton toolStripPenButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonFigure;
        private System.Windows.Forms.ToolStripMenuItem splitButtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dropDownButtToolStripMenuItemFilters;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCurrentSizeLb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCursor;
        private System.Windows.Forms.ToolStripButton toolStripButtonFill;
        private System.Windows.Forms.ToolStripButton toolStripButtonPipette;
        private System.Windows.Forms.ToolStripButton toolStripButtonFraming;
        private System.Windows.Forms.Timer timerAutoSave;
    }
}

