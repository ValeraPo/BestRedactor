
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BestRedactor.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.toolStripMenuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tabControlPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.btnZoomPlus = new System.Windows.Forms.Button();
            this.btnZoomMinus = new System.Windows.Forms.Button();
            this.lblCursorPos = new System.Windows.Forms.Label();
            this.lblPictureSize = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripTools = new System.Windows.Forms.ToolStrip();
            this.tsBtn_color1 = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_color2 = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBrush = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPen = new System.Windows.Forms.ToolStripButton();
            this.tsSplitButtonShape = new System.Windows.Forms.ToolStripSplitButton();
            this.tsBtnMenuItemLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemEllipce = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemRect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemCircleFill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemEllipceFill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSquareFill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemRectFill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDropDownFilters = new System.Windows.Forms.ToolStripDropDownButton();
            this.drDBtnTSMenuItDiscolor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuInversion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSepia = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItColors = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItSharpness = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuNoize = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItBright = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItDeformations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItRotates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRotBy270 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRotBy180 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxRotateOn = new System.Windows.Forms.ToolStripTextBox();
            this.drDBtnTSMenuItMirror = new System.Windows.Forms.ToolStripMenuItem();
            this.MirrorVertically = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuHoris = new System.Windows.Forms.ToolStripMenuItem();
            this.tsButtonCursor = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFill = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPipette = new System.Windows.Forms.ToolStripButton();
            this.tsButtonFraming = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEraser = new System.Windows.Forms.ToolStripButton();
            this.tsText = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.timerIsToSave = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(115, 24);
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
            this.toolStripMenuSaveAll,
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
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
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
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuSaveAll
            // 
            this.toolStripMenuSaveAll.Name = "toolStripMenuSaveAll";
            this.toolStripMenuSaveAll.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuSaveAll.Text = "Сохранить всё";
            this.toolStripMenuSaveAll.Click += new System.EventHandler(this.SaveAll);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Сохранить как";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
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
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
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
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
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
            this.timerAutoSave.Interval = 10000;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 32);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 32);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(32, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(32, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(729, 345);
            // 
            // tabControlPage
            // 
            this.tabControlPage.Location = new System.Drawing.Point(0, 0);
            this.tabControlPage.Name = "tabControlPage";
            this.tabControlPage.SelectedIndex = 0;
            this.tabControlPage.Size = new System.Drawing.Size(200, 100);
            this.tabControlPage.TabIndex = 2;
            this.tabControlPage.SelectedIndexChanged += new System.EventHandler(this.tabControlPage_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarZoom.AutoSize = false;
            this.trackBarZoom.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.trackBarZoom.LargeChange = 50;
            this.trackBarZoom.Location = new System.Drawing.Point(1239, 1);
            this.trackBarZoom.Maximum = 400;
            this.trackBarZoom.Minimum = 50;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(100, 20);
            this.trackBarZoom.SmallChange = 20;
            this.trackBarZoom.TabIndex = 0;
            this.trackBarZoom.TickFrequency = 20;
            this.trackBarZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarZoom.Value = 100;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // btnZoomPlus
            // 
            this.btnZoomPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomPlus.Location = new System.Drawing.Point(1345, 1);
            this.btnZoomPlus.Name = "btnZoomPlus";
            this.btnZoomPlus.Size = new System.Drawing.Size(18, 18);
            this.btnZoomPlus.TabIndex = 1;
            this.btnZoomPlus.Text = "button1";
            this.btnZoomPlus.UseVisualStyleBackColor = true;
            this.btnZoomPlus.Click += new System.EventHandler(this.btnZoomPlus_Click);
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomMinus.Location = new System.Drawing.Point(1215, 2);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(18, 18);
            this.btnZoomMinus.TabIndex = 4;
            this.btnZoomMinus.Text = "button1";
            this.btnZoomMinus.UseVisualStyleBackColor = true;
            this.btnZoomMinus.Click += new System.EventHandler(this.btnZoomMinus_Click);
            // 
            // lblCursorPos
            // 
            this.lblCursorPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCursorPos.AutoSize = true;
            this.lblCursorPos.Location = new System.Drawing.Point(32, 6);
            this.lblCursorPos.Name = "lblCursorPos";
            this.lblCursorPos.Size = new System.Drawing.Size(86, 15);
            this.lblCursorPos.TabIndex = 5;
            this.lblCursorPos.Text = "cursor position";
            // 
            // lblPictureSize
            // 
            this.lblPictureSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPictureSize.AutoSize = true;
            this.lblPictureSize.Location = new System.Drawing.Point(131, 6);
            this.lblPictureSize.Name = "lblPictureSize";
            this.lblPictureSize.Size = new System.Drawing.Size(101, 15);
            this.lblPictureSize.TabIndex = 6;
            this.lblPictureSize.Text = "current resolution";
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(1170, 2);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(37, 15);
            this.lblZoom.TabIndex = 7;
            this.lblZoom.Text = "zoom";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblZoom);
            this.panel1.Controls.Add(this.lblPictureSize);
            this.panel1.Controls.Add(this.lblCursorPos);
            this.panel1.Controls.Add(this.btnZoomMinus);
            this.panel1.Controls.Add(this.btnZoomPlus);
            this.panel1.Controls.Add(this.trackBarZoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 24);
            this.panel1.TabIndex = 3;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControlPage);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1338, 666);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStripTools);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1370, 691);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripTools
            // 
            this.toolStripTools.AllowDrop = true;
            this.toolStripTools.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toolStripTools.AutoSize = false;
            this.toolStripTools.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_color1,
            this.tsBtn_color2,
            this.tsBtnBrush,
            this.tsBtnPen,
            this.tsSplitButtonShape,
            this.tsDropDownFilters,
            this.tsButtonCursor,
            this.tsBtnFill,
            this.tsBtnPipette,
            this.tsButtonFraming,
            this.tsBtnEraser,
            this.tsText});
            this.toolStripTools.Location = new System.Drawing.Point(0, 3);
            this.toolStripTools.Name = "toolStripTools";
            this.toolStripTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripTools.Size = new System.Drawing.Size(32, 342);
            this.toolStripTools.TabIndex = 4;
            this.toolStripTools.Text = "tools";
            // 
            // tsBtn_color1
            // 
            this.tsBtn_color1.AutoSize = false;
            this.tsBtn_color1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsBtn_color1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_color1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_color1.Name = "tsBtn_color1";
            this.tsBtn_color1.Size = new System.Drawing.Size(20, 20);
            this.tsBtn_color1.Text = "цвет 1";
            this.tsBtn_color1.ToolTipText = "цвет 1";
            this.tsBtn_color1.Click += new System.EventHandler(this.tsBtn_color1_Click);
            // 
            // tsBtn_color2
            // 
            this.tsBtn_color2.AutoSize = false;
            this.tsBtn_color2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsBtn_color2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_color2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_color2.Name = "tsBtn_color2";
            this.tsBtn_color2.Size = new System.Drawing.Size(20, 20);
            this.tsBtn_color2.Text = "toolStripButton3";
            this.tsBtn_color2.ToolTipText = "цвет 2";
            this.tsBtn_color2.Click += new System.EventHandler(this.tsBtn_color2_Click);
            // 
            // tsBtnBrush
            // 
            this.tsBtnBrush.AutoSize = false;
            this.tsBtnBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBrush.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBrush.Image")));
            this.tsBtnBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBrush.Name = "tsBtnBrush";
            this.tsBtnBrush.Size = new System.Drawing.Size(20, 20);
            this.tsBtnBrush.Text = "кисть";
            this.tsBtnBrush.ToolTipText = "Кисть";
            this.tsBtnBrush.Click += new System.EventHandler(this.tsBtnBrush_Click);
            // 
            // tsBtnPen
            // 
            this.tsBtnPen.AutoSize = false;
            this.tsBtnPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPen.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPen.Image")));
            this.tsBtnPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPen.Name = "tsBtnPen";
            this.tsBtnPen.Size = new System.Drawing.Size(20, 20);
            this.tsBtnPen.Text = "toolStripButton5";
            this.tsBtnPen.ToolTipText = "Карандаш";
            this.tsBtnPen.Click += new System.EventHandler(this.tsBtnPen_Click);
            // 
            // tsSplitButtonShape
            // 
            this.tsSplitButtonShape.AutoSize = false;
            this.tsSplitButtonShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSplitButtonShape.DropDownButtonWidth = 7;
            this.tsSplitButtonShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnMenuItemLine,
            this.tsBtnMenuItemCircle,
            this.tsBtnMenuItemEllipce,
            this.toolStripMenuSquare,
            this.tsBtnMenuItemRect,
            this.tsBtnMenuItemCircleFill,
            this.tsBtnMenuItemEllipceFill,
            this.toolStripMenuSquareFill,
            this.tsBtnMenuItemRectFill});
            this.tsSplitButtonShape.Image = ((System.Drawing.Image)(resources.GetObject("tsSplitButtonShape.Image")));
            this.tsSplitButtonShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSplitButtonShape.Name = "tsSplitButtonShape";
            this.tsSplitButtonShape.Size = new System.Drawing.Size(30, 20);
            this.tsSplitButtonShape.Text = "форма";
            this.tsSplitButtonShape.ButtonClick += new System.EventHandler(this.tsSplitButtonShape_ButtonClick);
            // 
            // tsBtnMenuItemLine
            // 
            this.tsBtnMenuItemLine.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMenuItemLine.Image")));
            this.tsBtnMenuItemLine.Name = "tsBtnMenuItemLine";
            this.tsBtnMenuItemLine.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemLine.Text = "линия";
            this.tsBtnMenuItemLine.Click += new System.EventHandler(this.tsBtnMenuItemLine_Click);
            // 
            // tsBtnMenuItemCircle
            // 
            this.tsBtnMenuItemCircle.Name = "tsBtnMenuItemCircle";
            this.tsBtnMenuItemCircle.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemCircle.Text = "Круг";
            this.tsBtnMenuItemCircle.Click += new System.EventHandler(this.tsBtnMenuItemCircle_Click);
            // 
            // tsBtnMenuItemEllipce
            // 
            this.tsBtnMenuItemEllipce.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMenuItemEllipce.Image")));
            this.tsBtnMenuItemEllipce.Name = "tsBtnMenuItemEllipce";
            this.tsBtnMenuItemEllipce.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemEllipce.Text = "Эллипс";
            this.tsBtnMenuItemEllipce.Click += new System.EventHandler(this.tsBtnMenuItemEllipce_Click);
            // 
            // toolStripMenuSquare
            // 
            this.toolStripMenuSquare.Name = "toolStripMenuSquare";
            this.toolStripMenuSquare.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuSquare.Text = "Квадрат";
            this.toolStripMenuSquare.Click += new System.EventHandler(this.toolStripMenuSquare_Click);
            // 
            // tsBtnMenuItemRect
            // 
            this.tsBtnMenuItemRect.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMenuItemRect.Image")));
            this.tsBtnMenuItemRect.Name = "tsBtnMenuItemRect";
            this.tsBtnMenuItemRect.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemRect.Text = "прямоугольник";
            this.tsBtnMenuItemRect.Click += new System.EventHandler(this.tsBtnMenuItemRect_Click);
            // 
            // tsBtnMenuItemCircleFill
            // 
            this.tsBtnMenuItemCircleFill.Name = "tsBtnMenuItemCircleFill";
            this.tsBtnMenuItemCircleFill.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemCircleFill.Text = "Залитый круг";
            this.tsBtnMenuItemCircleFill.Click += new System.EventHandler(this.tsBtnMenuItemCircleFill_Click);
            // 
            // tsBtnMenuItemEllipceFill
            // 
            this.tsBtnMenuItemEllipceFill.Name = "tsBtnMenuItemEllipceFill";
            this.tsBtnMenuItemEllipceFill.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemEllipceFill.Text = "Залитый эликс";
            this.tsBtnMenuItemEllipceFill.Click += new System.EventHandler(this.tsBtnMenuItemEllipceFill_Click);
            // 
            // toolStripMenuSquareFill
            // 
            this.toolStripMenuSquareFill.Name = "toolStripMenuSquareFill";
            this.toolStripMenuSquareFill.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuSquareFill.Text = "Залитый квадрат";
            this.toolStripMenuSquareFill.Click += new System.EventHandler(this.toolStripMenuSquareFill_Click);
            // 
            // tsBtnMenuItemRectFill
            // 
            this.tsBtnMenuItemRectFill.Name = "tsBtnMenuItemRectFill";
            this.tsBtnMenuItemRectFill.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemRectFill.Text = "Залитый прямоугольник";
            this.tsBtnMenuItemRectFill.Click += new System.EventHandler(this.tsBtnMenuItemRectFill_Click);
            // 
            // tsDropDownFilters
            // 
            this.tsDropDownFilters.AutoSize = false;
            this.tsDropDownFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDropDownFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drDBtnTSMenuItDiscolor,
            this.toolStripMenuInversion,
            this.toolStripMenuSepia,
            this.drDBtnTSMenuItColors,
            this.drDBtnTSMenuItSharpness,
            this.toolStripMenuNoize,
            this.drDBtnTSMenuItBright,
            this.drDBtnTSMenuItContrast,
            this.drDBtnTSMenuItBlur,
            this.drDBtnTSMenuItDeformations,
            this.drDBtnTSMenuItRotates,
            this.drDBtnTSMenuItMirror});
            this.tsDropDownFilters.Image = ((System.Drawing.Image)(resources.GetObject("tsDropDownFilters.Image")));
            this.tsDropDownFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropDownFilters.Name = "tsDropDownFilters";
            this.tsDropDownFilters.Size = new System.Drawing.Size(31, 20);
            this.tsDropDownFilters.Text = "фильтры";
            // 
            // drDBtnTSMenuItDiscolor
            // 
            this.drDBtnTSMenuItDiscolor.Name = "drDBtnTSMenuItDiscolor";
            this.drDBtnTSMenuItDiscolor.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItDiscolor.Text = "обесцветить";
            this.drDBtnTSMenuItDiscolor.Click += new System.EventHandler(this.drDBtnTSMenuItDiscolor_Click);
            // 
            // toolStripMenuInversion
            // 
            this.toolStripMenuInversion.Name = "toolStripMenuInversion";
            this.toolStripMenuInversion.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuInversion.Text = "инверсия";
            this.toolStripMenuInversion.Click += new System.EventHandler(this.toolStripMenuInversion_Click);
            // 
            // toolStripMenuSepia
            // 
            this.toolStripMenuSepia.Name = "toolStripMenuSepia";
            this.toolStripMenuSepia.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuSepia.Text = "сепия";
            this.toolStripMenuSepia.Click += new System.EventHandler(this.toolStripMenuSepia_Click);
            // 
            // drDBtnTSMenuItColors
            // 
            this.drDBtnTSMenuItColors.Name = "drDBtnTSMenuItColors";
            this.drDBtnTSMenuItColors.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItColors.Text = "цвета";
            this.drDBtnTSMenuItColors.Click += new System.EventHandler(this.drDBtnTSMenuItColors_Click);
            // 
            // drDBtnTSMenuItSharpness
            // 
            this.drDBtnTSMenuItSharpness.Name = "drDBtnTSMenuItSharpness";
            this.drDBtnTSMenuItSharpness.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItSharpness.Text = "повысить резкость";
            this.drDBtnTSMenuItSharpness.Click += new System.EventHandler(this.drDBtnTSMenuItSharpness_Click);
            // 
            // toolStripMenuNoize
            // 
            this.toolStripMenuNoize.Name = "toolStripMenuNoize";
            this.toolStripMenuNoize.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuNoize.Text = "шум";
            this.toolStripMenuNoize.Click += new System.EventHandler(this.toolStripMenuNoize_Click);
            // 
            // drDBtnTSMenuItBright
            // 
            this.drDBtnTSMenuItBright.Name = "drDBtnTSMenuItBright";
            this.drDBtnTSMenuItBright.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItBright.Text = "яркость";
            this.drDBtnTSMenuItBright.Click += new System.EventHandler(this.drDBtnTSMenuItBright_Click);
            // 
            // drDBtnTSMenuItContrast
            // 
            this.drDBtnTSMenuItContrast.Name = "drDBtnTSMenuItContrast";
            this.drDBtnTSMenuItContrast.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItContrast.Text = "контраст";
            this.drDBtnTSMenuItContrast.Click += new System.EventHandler(this.drDBtnTSMenuItIncreaseContrast_Click);
            // 
            // drDBtnTSMenuItBlur
            // 
            this.drDBtnTSMenuItBlur.Name = "drDBtnTSMenuItBlur";
            this.drDBtnTSMenuItBlur.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItBlur.Text = "размытие";
            this.drDBtnTSMenuItBlur.Click += new System.EventHandler(this.drDBtnTSMenuItBlur_Click);
            // 
            // drDBtnTSMenuItDeformations
            // 
            this.drDBtnTSMenuItDeformations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.drDBtnTSMenuItDeformations.Name = "drDBtnTSMenuItDeformations";
            this.drDBtnTSMenuItDeformations.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItDeformations.Text = "деформации";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // drDBtnTSMenuItRotates
            // 
            this.drDBtnTSMenuItRotates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuRotBy270,
            this.toolStripMenuRotBy180,
            this.toolStripTextBoxRotateOn});
            this.drDBtnTSMenuItRotates.Name = "drDBtnTSMenuItRotates";
            this.drDBtnTSMenuItRotates.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItRotates.Text = "поворот";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem5.Text = "90";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuRotBy270
            // 
            this.toolStripMenuRotBy270.Name = "toolStripMenuRotBy270";
            this.toolStripMenuRotBy270.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuRotBy270.Text = "-90";
            this.toolStripMenuRotBy270.Click += new System.EventHandler(this.toolStripMenuRotBy270_Click);
            // 
            // toolStripMenuRotBy180
            // 
            this.toolStripMenuRotBy180.Name = "toolStripMenuRotBy180";
            this.toolStripMenuRotBy180.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuRotBy180.Text = "180";
            this.toolStripMenuRotBy180.Click += new System.EventHandler(this.toolStripMenuRotBy180_Click);
            // 
            // toolStripTextBoxRotateOn
            // 
            this.toolStripTextBoxRotateOn.Name = "toolStripTextBoxRotateOn";
            this.toolStripTextBoxRotateOn.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxRotateOn.Text = "(произвольный угол)";
            // 
            // drDBtnTSMenuItMirror
            // 
            this.drDBtnTSMenuItMirror.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MirrorVertically,
            this.ToolStripMenuHoris});
            this.drDBtnTSMenuItMirror.Name = "drDBtnTSMenuItMirror";
            this.drDBtnTSMenuItMirror.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItMirror.Text = "зеркальное отображение";
            // 
            // MirrorVertically
            // 
            this.MirrorVertically.Name = "MirrorVertically";
            this.MirrorVertically.Size = new System.Drawing.Size(161, 22);
            this.MirrorVertically.Text = "по вертикали";
            this.MirrorVertically.Click += new System.EventHandler(this.MirrorVertically_Click);
            // 
            // ToolStripMenuHoris
            // 
            this.ToolStripMenuHoris.Name = "ToolStripMenuHoris";
            this.ToolStripMenuHoris.Size = new System.Drawing.Size(161, 22);
            this.ToolStripMenuHoris.Text = "по горизонтали";
            this.ToolStripMenuHoris.Click += new System.EventHandler(this.ToolStripMenuHoris_Click);
            // 
            // tsButtonCursor
            // 
            this.tsButtonCursor.AutoSize = false;
            this.tsButtonCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonCursor.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonCursor.Image")));
            this.tsButtonCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonCursor.Name = "tsButtonCursor";
            this.tsButtonCursor.Size = new System.Drawing.Size(22, 22);
            this.tsButtonCursor.Text = "toolStripButton1";
            this.tsButtonCursor.ToolTipText = "Указатель";
            this.tsButtonCursor.Click += new System.EventHandler(this.tsButtonCursor_Click);
            // 
            // tsBtnFill
            // 
            this.tsBtnFill.AutoSize = false;
            this.tsBtnFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFill.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFill.Image")));
            this.tsBtnFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFill.Name = "tsBtnFill";
            this.tsBtnFill.Size = new System.Drawing.Size(20, 20);
            this.tsBtnFill.Text = "toolStripButton1";
            this.tsBtnFill.ToolTipText = "Заливка";
            this.tsBtnFill.Click += new System.EventHandler(this.tsBtnFill_Click);
            // 
            // tsBtnPipette
            // 
            this.tsBtnPipette.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPipette.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPipette.Image")));
            this.tsBtnPipette.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPipette.Name = "tsBtnPipette";
            this.tsBtnPipette.Size = new System.Drawing.Size(30, 20);
            this.tsBtnPipette.Text = "пипетка";
            this.tsBtnPipette.ToolTipText = "Пипетка";
            this.tsBtnPipette.Click += new System.EventHandler(this.tsBtnPipette_Click);
            // 
            // tsButtonFraming
            // 
            this.tsButtonFraming.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonFraming.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonFraming.Image")));
            this.tsButtonFraming.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonFraming.Name = "tsButtonFraming";
            this.tsButtonFraming.Size = new System.Drawing.Size(30, 20);
            this.tsButtonFraming.Text = "toolStripButton1";
            this.tsButtonFraming.ToolTipText = "Кадрирование";
            // 
            // tsBtnEraser
            // 
            this.tsBtnEraser.AutoSize = false;
            this.tsBtnEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnEraser.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEraser.Image")));
            this.tsBtnEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEraser.Name = "tsBtnEraser";
            this.tsBtnEraser.Size = new System.Drawing.Size(20, 20);
            this.tsBtnEraser.Text = "Резинка";
            this.tsBtnEraser.Click += new System.EventHandler(this.tsBtnEraser_Click);
            // 
            // tsText
            // 
            this.tsText.AutoSize = false;
            this.tsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsText.Image = ((System.Drawing.Image)(resources.GetObject("tsText.Image")));
            this.tsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsText.Name = "tsText";
            this.tsText.Size = new System.Drawing.Size(20, 20);
            this.tsText.Text = "текст";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1MinSize = 23;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1370, 749);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStripContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2MinSize = 23;
            this.splitContainer2.Size = new System.Drawing.Size(1370, 720);
            this.splitContainer2.SplitterDistance = 691;
            this.splitContainer2.TabIndex = 0;
            // 
            // timerIsToSave
            // 
            this.timerIsToSave.Interval = 6000;
            this.timerIsToSave.Tick += new System.EventHandler(this.timerIsToSave_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.MinimumSize = new System.Drawing.Size(420, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "The Best Redactor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripTools.ResumeLayout(false);
            this.toolStripTools.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ColorDialog colorDialog1;
        private VScrollBar vScrollBar1;
        private ToolStripButton toolStripButtonCursor;
        private ToolStripButton toolStripButtonFill;
        private ToolStripButton toolStripButtonPipette;
        private ToolStripButton toolStripButtonFraming;        
        private Timer timerAutoSave;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private TabControl tabControlPage;
        private TabPage tabPage1;
        public PictureBox pictureBox;
        private TrackBar trackBarZoom;
        private Button btnZoomPlus;
        private Button btnZoomMinus;
        private Label lblCursorPos;
        private Label lblPictureSize;
        private Label lblZoom;
        private Panel panel1;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStripTools;
        private ToolStripButton tsBtn_color1;
        private ToolStripButton tsBtn_color2;
        private ToolStripButton tsBtnBrush;
        private ToolStripButton tsBtnPen;
        private ToolStripSplitButton tsSplitButtonShape;
        private ToolStripMenuItem tsBtnMenuItemLine;
        private ToolStripMenuItem tsBtnMenuItemEllipce;
        private ToolStripMenuItem tsBtnMenuItemRect;
        private ToolStripDropDownButton tsDropDownFilters;
        private ToolStripMenuItem drDBtnTSMenuItDiscolor;
        private ToolStripMenuItem drDBtnTSMenuItColors;
        private ToolStripMenuItem drDBtnTSMenuItSharpness;
        private ToolStripMenuItem drDBtnTSMenuItBright;
        private ToolStripMenuItem drDBtnTSMenuItContrast;
        private ToolStripMenuItem drDBtnTSMenuItBlur;
        private ToolStripMenuItem drDBtnTSMenuItDeformations;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem drDBtnTSMenuItRotates;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuRotBy270;
        private ToolStripMenuItem toolStripMenuRotBy180;
        private ToolStripTextBox toolStripTextBoxRotateOn;
        private ToolStripMenuItem drDBtnTSMenuItMirror;
        private ToolStripMenuItem MirrorVertically;
        private ToolStripMenuItem ToolStripMenuHoris;
        private ToolStripButton tsButtonCursor;
        private ToolStripButton tsBtnFill;
        private ToolStripButton tsBtnPipette;
        private ToolStripButton tsButtonFraming;
        private ToolStripButton tsBtnEraser;
        private ToolStripButton tsText;
        private ToolStripMenuItem toolStripMenuSaveAll;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ToolStripMenuItem toolStripMenuInversion;
        private ToolStripMenuItem toolStripMenuSepia;
        private ToolStripMenuItem toolStripMenuNoize;
        private ToolStripMenuItem tsBtnMenuItemEllipceFill;
        private ToolStripMenuItem tsBtnMenuItemRectFill;
        private ToolStripMenuItem tsBtnMenuItemCircle;
        private ToolStripMenuItem toolStripMenuSquare;
        private ToolStripMenuItem tsBtnMenuItemCircleFill;
        private ToolStripMenuItem toolStripMenuSquareFill;
        private Timer timerIsToSave;
    }
}

