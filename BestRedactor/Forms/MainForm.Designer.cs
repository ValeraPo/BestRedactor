
using System;
using System.ComponentModel;
using System.Drawing;
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
            this.newToolStrSave = new System.Windows.Forms.ToolStripMenuItem();
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
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBnW = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSepia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInvers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNoise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemColors = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBright = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem90 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem270 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem180 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFree = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMirror = new System.Windows.Forms.ToolStripMenuItem();
            this.поВертикалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГоризонталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblCursorPos = new System.Windows.Forms.Label();
            this.lblPictureSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripTools = new System.Windows.Forms.ToolStrip();
            this.tsBtn_color1 = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_color2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnPen = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBrush = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPipette = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFill = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEraser = new System.Windows.Forms.ToolStripButton();
            this.tsSplitButtonShape = new System.Windows.Forms.ToolStripSplitButton();
            this.tsBtnMenuItemLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemDashLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemEllipce = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemRect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemCircleFill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemEllipceFill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSquareFill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMenuItemRectFill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonCursor = new System.Windows.Forms.ToolStripButton();
            this.tsText = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSelection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDropDownFilters = new System.Windows.Forms.ToolStripDropDownButton();
            this.drDBtnTSMenuItDiscolor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSepia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuInversion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.drDBtnTSMenuItSharpness = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuNoize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.drDBtnTSMenuItColors = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItBright = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.drDBtnTSMenuItRotates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRotBy270 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRotBy180 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxRotateOn = new System.Windows.Forms.ToolStripMenuItem();
            this.drDBtnTSMenuItMirror = new System.Windows.Forms.ToolStripMenuItem();
            this.MirrorVertically = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuHoris = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonFraming = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.timerIsToSave = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.editToolStripMenuItem,
            this.изображениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStrSave,
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
            // newToolStrSave
            // 
            this.newToolStrSave.Name = "newToolStrSave";
            this.newToolStrSave.Size = new System.Drawing.Size(180, 22);
            this.newToolStrSave.Text = "Создать";
            this.newToolStrSave.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Сохранить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuSaveAll
            // 
            this.toolStripMenuSaveAll.Name = "toolStripMenuSaveAll";
            this.toolStripMenuSaveAll.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuSaveAll.Text = "Сохранить всё";
            this.toolStripMenuSaveAll.Click += new System.EventHandler(this.SaveAll);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Сохранить как";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
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
            // изображениеToolStripMenuItem
            // 
            this.изображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBnW,
            this.ToolStripMenuItemSepia,
            this.ToolStripMenuItemInvers,
            this.toolStripSeparator9,
            this.ToolStripMenuItemSharp,
            this.ToolStripMenuItemBlur,
            this.ToolStripMenuItemNoise,
            this.toolStripSeparator10,
            this.ToolStripMenuItemColors,
            this.ToolStripMenuItemBright,
            this.ToolStripMenuItemContrast,
            this.toolStripSeparator11,
            this.ToolStripMenuItemRotate,
            this.ToolStripMenuItemMirror});
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            this.изображениеToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.изображениеToolStripMenuItem.Text = "Изображение";
            // 
            // ToolStripMenuItemBnW
            // 
            this.ToolStripMenuItemBnW.Name = "ToolStripMenuItemBnW";
            this.ToolStripMenuItemBnW.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemBnW.Text = "Обесцветить";
            this.ToolStripMenuItemBnW.Click += new System.EventHandler(this.drDBtnTSMenuItDiscolor_Click);
            // 
            // ToolStripMenuItemSepia
            // 
            this.ToolStripMenuItemSepia.Name = "ToolStripMenuItemSepia";
            this.ToolStripMenuItemSepia.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemSepia.Text = "Сепия";
            this.ToolStripMenuItemSepia.Click += new System.EventHandler(this.toolStripMenuSepia_Click);
            // 
            // ToolStripMenuItemInvers
            // 
            this.ToolStripMenuItemInvers.Name = "ToolStripMenuItemInvers";
            this.ToolStripMenuItemInvers.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemInvers.Text = "Инверсия";
            this.ToolStripMenuItemInvers.Click += new System.EventHandler(this.toolStripMenuInversion_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(211, 6);
            // 
            // ToolStripMenuItemSharp
            // 
            this.ToolStripMenuItemSharp.Name = "ToolStripMenuItemSharp";
            this.ToolStripMenuItemSharp.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemSharp.Text = "Повысить резкость";
            this.ToolStripMenuItemSharp.Click += new System.EventHandler(this.drDBtnTSMenuItSharpness_Click);
            // 
            // ToolStripMenuItemBlur
            // 
            this.ToolStripMenuItemBlur.Name = "ToolStripMenuItemBlur";
            this.ToolStripMenuItemBlur.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemBlur.Text = "Размытие";
            this.ToolStripMenuItemBlur.Click += new System.EventHandler(this.drDBtnTSMenuItBlur_Click);
            // 
            // ToolStripMenuItemNoise
            // 
            this.ToolStripMenuItemNoise.Name = "ToolStripMenuItemNoise";
            this.ToolStripMenuItemNoise.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemNoise.Text = "Шум";
            this.ToolStripMenuItemNoise.Click += new System.EventHandler(this.toolStripMenuNoize_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(211, 6);
            // 
            // ToolStripMenuItemColors
            // 
            this.ToolStripMenuItemColors.Name = "ToolStripMenuItemColors";
            this.ToolStripMenuItemColors.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemColors.Text = "Цвета";
            this.ToolStripMenuItemColors.Click += new System.EventHandler(this.drDBtnTSMenuItColors_Click);
            // 
            // ToolStripMenuItemBright
            // 
            this.ToolStripMenuItemBright.Name = "ToolStripMenuItemBright";
            this.ToolStripMenuItemBright.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemBright.Text = "Яркость";
            this.ToolStripMenuItemBright.Click += new System.EventHandler(this.drDBtnTSMenuItBright_Click);
            // 
            // ToolStripMenuItemContrast
            // 
            this.ToolStripMenuItemContrast.Name = "ToolStripMenuItemContrast";
            this.ToolStripMenuItemContrast.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemContrast.Text = "Контраст";
            this.ToolStripMenuItemContrast.Click += new System.EventHandler(this.drDBtnTSMenuItIncreaseContrast_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(211, 6);
            // 
            // ToolStripMenuItemRotate
            // 
            this.ToolStripMenuItemRotate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem90,
            this.toolStripMenuItem270,
            this.toolStripMenuItem180,
            this.ToolStripMenuItemFree});
            this.ToolStripMenuItemRotate.Name = "ToolStripMenuItemRotate";
            this.ToolStripMenuItemRotate.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemRotate.Text = "Поворот";
            // 
            // toolStripMenuItem90
            // 
            this.toolStripMenuItem90.Name = "toolStripMenuItem90";
            this.toolStripMenuItem90.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem90.Text = "90° по ч.с.";
            this.toolStripMenuItem90.Click += new System.EventHandler(this.toolStripMenuRotBy90_Click);
            // 
            // toolStripMenuItem270
            // 
            this.toolStripMenuItem270.Name = "toolStripMenuItem270";
            this.toolStripMenuItem270.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem270.Text = "90° против ч.с.";
            this.toolStripMenuItem270.Click += new System.EventHandler(this.toolStripMenuRotBy270_Click);
            // 
            // toolStripMenuItem180
            // 
            this.toolStripMenuItem180.Name = "toolStripMenuItem180";
            this.toolStripMenuItem180.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem180.Text = "180°";
            this.toolStripMenuItem180.Click += new System.EventHandler(this.toolStripMenuRotBy180_Click);
            // 
            // ToolStripMenuItemFree
            // 
            this.ToolStripMenuItemFree.Name = "ToolStripMenuItemFree";
            this.ToolStripMenuItemFree.Size = new System.Drawing.Size(147, 22);
            this.ToolStripMenuItemFree.Text = "Произвольно";
            this.ToolStripMenuItemFree.Click += new System.EventHandler(this.toolStripTextBoxRotateOn_Click);
            // 
            // ToolStripMenuItemMirror
            // 
            this.ToolStripMenuItemMirror.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВертикалиToolStripMenuItem,
            this.поГоризонталиToolStripMenuItem});
            this.ToolStripMenuItemMirror.Name = "ToolStripMenuItemMirror";
            this.ToolStripMenuItemMirror.Size = new System.Drawing.Size(214, 22);
            this.ToolStripMenuItemMirror.Text = "Зеркальное отображение";
            // 
            // поВертикалиToolStripMenuItem
            // 
            this.поВертикалиToolStripMenuItem.Name = "поВертикалиToolStripMenuItem";
            this.поВертикалиToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.поВертикалиToolStripMenuItem.Text = "По вертикали";
            this.поВертикалиToolStripMenuItem.Click += new System.EventHandler(this.MirrorVertically_Click);
            // 
            // поГоризонталиToolStripMenuItem
            // 
            this.поГоризонталиToolStripMenuItem.Name = "поГоризонталиToolStripMenuItem";
            this.поГоризонталиToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.поГоризонталиToolStripMenuItem.Text = "По горизонтали";
            this.поГоризонталиToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuHoris_Click);
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
            this.timerAutoSave.Interval = 180000;
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
            this.tabControlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPage.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlPage.Location = new System.Drawing.Point(0, 0);
            this.tabControlPage.Name = "tabControlPage";
            this.tabControlPage.SelectedIndex = 0;
            this.tabControlPage.Size = new System.Drawing.Size(1338, 666);
            this.tabControlPage.TabIndex = 2;
            this.tabControlPage.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControlPage.SelectedIndexChanged += new System.EventHandler(this.tabControlPage_SelectedIndexChanged);
            this.tabControlPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // tabPage1
            // 
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPictureSize);
            this.panel1.Controls.Add(this.lblCursorPos);
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
            this.toolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStripTools);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1370, 691);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripTools
            // 
            this.toolStripTools.AllowItemReorder = true;
            this.toolStripTools.AllowMerge = false;
            this.toolStripTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripTools.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTools.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_color1,
            this.tsBtn_color2,
            this.toolStripSeparator12,
            this.tsBtnPen,
            this.tsBtnBrush,
            this.tsBtnPipette,
            this.tsBtnFill,
            this.tsBtnEraser,
            this.tsSplitButtonShape,
            this.toolStripSeparator13,
            this.tsButtonCursor,
            this.tsText,
            this.tsBtnSelection,
            this.toolStripSeparator15,
            this.tsDropDownFilters,
            this.toolStripSeparator14,
            this.tsButtonFraming});
            this.toolStripTools.Location = new System.Drawing.Point(0, 0);
            this.toolStripTools.Name = "toolStripTools";
            this.toolStripTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripTools.Size = new System.Drawing.Size(32, 666);
            this.toolStripTools.Stretch = true;
            this.toolStripTools.TabIndex = 4;
            this.toolStripTools.Text = "tools";
            // 
            // tsBtn_color1
            // 
            this.tsBtn_color1.AutoSize = false;
            this.tsBtn_color1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsBtn_color1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_color1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
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
            this.tsBtn_color2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtn_color2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_color2.Name = "tsBtn_color2";
            this.tsBtn_color2.Size = new System.Drawing.Size(20, 20);
            this.tsBtn_color2.Text = "цвет2";
            this.tsBtn_color2.ToolTipText = "цвет 2";
            this.tsBtn_color2.Click += new System.EventHandler(this.tsBtn_color2_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(30, 6);
            // 
            // tsBtnPen
            // 
            this.tsBtnPen.AutoSize = false;
            this.tsBtnPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPen.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPen.Image")));
            this.tsBtnPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPen.Name = "tsBtnPen";
            this.tsBtnPen.Size = new System.Drawing.Size(25, 25);
            this.tsBtnPen.Text = "toolStripButton5";
            this.tsBtnPen.ToolTipText = "Карандаш";
            this.tsBtnPen.Click += new System.EventHandler(this.tsBtnPen_Click);
            // 
            // tsBtnBrush
            // 
            this.tsBtnBrush.AutoSize = false;
            this.tsBtnBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBrush.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBrush.Image")));
            this.tsBtnBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBrush.Name = "tsBtnBrush";
            this.tsBtnBrush.Size = new System.Drawing.Size(25, 25);
            this.tsBtnBrush.Text = "кисть";
            this.tsBtnBrush.ToolTipText = "Кисть";
            this.tsBtnBrush.Click += new System.EventHandler(this.tsBtnBrush_Click);
            // 
            // tsBtnPipette
            // 
            this.tsBtnPipette.AutoSize = false;
            this.tsBtnPipette.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPipette.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPipette.Image")));
            this.tsBtnPipette.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPipette.Name = "tsBtnPipette";
            this.tsBtnPipette.Size = new System.Drawing.Size(25, 25);
            this.tsBtnPipette.Text = "пипетка";
            this.tsBtnPipette.ToolTipText = "Пипетка";
            this.tsBtnPipette.Click += new System.EventHandler(this.tsBtnPipette_Click);
            // 
            // tsBtnFill
            // 
            this.tsBtnFill.AutoSize = false;
            this.tsBtnFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFill.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFill.Image")));
            this.tsBtnFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFill.Name = "tsBtnFill";
            this.tsBtnFill.Size = new System.Drawing.Size(25, 25);
            this.tsBtnFill.Text = "заливка";
            this.tsBtnFill.ToolTipText = "Заливка";
            this.tsBtnFill.Click += new System.EventHandler(this.tsBtnFill_Click);
            // 
            // tsBtnEraser
            // 
            this.tsBtnEraser.AutoSize = false;
            this.tsBtnEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnEraser.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEraser.Image")));
            this.tsBtnEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEraser.Name = "tsBtnEraser";
            this.tsBtnEraser.Size = new System.Drawing.Size(25, 25);
            this.tsBtnEraser.Text = "резинка";
            this.tsBtnEraser.ToolTipText = "Резинка";
            this.tsBtnEraser.Click += new System.EventHandler(this.tsBtnEraser_Click);
            // 
            // tsSplitButtonShape
            // 
            this.tsSplitButtonShape.AutoSize = false;
            this.tsSplitButtonShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSplitButtonShape.DropDownButtonWidth = 7;
            this.tsSplitButtonShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnMenuItemLine,
            this.tsBtnMenuItemDashLine,
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
            this.tsSplitButtonShape.Size = new System.Drawing.Size(30, 25);
            this.tsSplitButtonShape.Text = "Фигуры";
            this.tsSplitButtonShape.ButtonClick += new System.EventHandler(this.tsSplitButtonShape_ButtonClick);
            // 
            // tsBtnMenuItemLine
            // 
            this.tsBtnMenuItemLine.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMenuItemLine.Image")));
            this.tsBtnMenuItemLine.Name = "tsBtnMenuItemLine";
            this.tsBtnMenuItemLine.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemLine.Text = "Линия";
            this.tsBtnMenuItemLine.Click += new System.EventHandler(this.tsBtnMenuItemLine_Click);
            // 
            // tsBtnMenuItemDashLine
            // 
            this.tsBtnMenuItemDashLine.Name = "tsBtnMenuItemDashLine";
            this.tsBtnMenuItemDashLine.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemDashLine.Text = "Пунктирная линия";
            this.tsBtnMenuItemDashLine.Click += new System.EventHandler(this.tsBtnMenuItemDashLine_Click);
            // 
            // tsBtnMenuItemCircle
            // 
            this.tsBtnMenuItemCircle.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMenuItemCircle.Image")));
            this.tsBtnMenuItemCircle.Name = "tsBtnMenuItemCircle";
            this.tsBtnMenuItemCircle.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemCircle.Text = "Окружность";
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
            this.toolStripMenuSquare.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuSquare.Image")));
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
            this.tsBtnMenuItemRect.Text = "Прямоугольник";
            this.tsBtnMenuItemRect.Click += new System.EventHandler(this.tsBtnMenuItemRect_Click);
            // 
            // tsBtnMenuItemCircleFill
            // 
            this.tsBtnMenuItemCircleFill.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMenuItemCircleFill.Image")));
            this.tsBtnMenuItemCircleFill.Name = "tsBtnMenuItemCircleFill";
            this.tsBtnMenuItemCircleFill.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemCircleFill.Text = "Залитый круг";
            this.tsBtnMenuItemCircleFill.Click += new System.EventHandler(this.tsBtnMenuItemCircleFill_Click);
            // 
            // tsBtnMenuItemEllipceFill
            // 
            this.tsBtnMenuItemEllipceFill.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMenuItemEllipceFill.Image")));
            this.tsBtnMenuItemEllipceFill.Name = "tsBtnMenuItemEllipceFill";
            this.tsBtnMenuItemEllipceFill.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemEllipceFill.Text = "Залитый эликс";
            this.tsBtnMenuItemEllipceFill.Click += new System.EventHandler(this.tsBtnMenuItemEllipceFill_Click);
            // 
            // toolStripMenuSquareFill
            // 
            this.toolStripMenuSquareFill.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuSquareFill.Image")));
            this.toolStripMenuSquareFill.Name = "toolStripMenuSquareFill";
            this.toolStripMenuSquareFill.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuSquareFill.Text = "Залитый квадрат";
            this.toolStripMenuSquareFill.Click += new System.EventHandler(this.toolStripMenuSquareFill_Click);
            // 
            // tsBtnMenuItemRectFill
            // 
            this.tsBtnMenuItemRectFill.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMenuItemRectFill.Image")));
            this.tsBtnMenuItemRectFill.Name = "tsBtnMenuItemRectFill";
            this.tsBtnMenuItemRectFill.Size = new System.Drawing.Size(212, 22);
            this.tsBtnMenuItemRectFill.Text = "Залитый прямоугольник";
            this.tsBtnMenuItemRectFill.Click += new System.EventHandler(this.tsBtnMenuItemRectFill_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(30, 6);
            // 
            // tsButtonCursor
            // 
            this.tsButtonCursor.AutoSize = false;
            this.tsButtonCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonCursor.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonCursor.Image")));
            this.tsButtonCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonCursor.Name = "tsButtonCursor";
            this.tsButtonCursor.Size = new System.Drawing.Size(25, 25);
            this.tsButtonCursor.Text = "курсор";
            this.tsButtonCursor.ToolTipText = "Указатель";
            this.tsButtonCursor.Click += new System.EventHandler(this.tsButtonCursor_Click);
            // 
            // tsText
            // 
            this.tsText.AutoSize = false;
            this.tsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsText.Image = ((System.Drawing.Image)(resources.GetObject("tsText.Image")));
            this.tsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsText.Name = "tsText";
            this.tsText.Size = new System.Drawing.Size(25, 25);
            this.tsText.Text = "текст";
            this.tsText.ToolTipText = "Написать текст";
            this.tsText.Click += new System.EventHandler(this.tsText_Click);
            // 
            // tsBtnSelection
            // 
            this.tsBtnSelection.AutoSize = false;
            this.tsBtnSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSelection.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSelection.Image")));
            this.tsBtnSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSelection.Name = "tsBtnSelection";
            this.tsBtnSelection.Size = new System.Drawing.Size(25, 25);
            this.tsBtnSelection.Text = "кадрирование";
            this.tsBtnSelection.ToolTipText = "Выделение";
            this.tsBtnSelection.Click += new System.EventHandler(this.tsBtnSelection_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(30, 6);
            // 
            // tsDropDownFilters
            // 
            this.tsDropDownFilters.AutoSize = false;
            this.tsDropDownFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDropDownFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drDBtnTSMenuItDiscolor,
            this.toolStripMenuSepia,
            this.toolStripMenuInversion,
            this.toolStripSeparator8,
            this.drDBtnTSMenuItSharpness,
            this.drDBtnTSMenuItBlur,
            this.toolStripMenuNoize,
            this.toolStripSeparator7,
            this.drDBtnTSMenuItColors,
            this.drDBtnTSMenuItBright,
            this.drDBtnTSMenuItContrast,
            this.toolStripSeparator6,
            this.drDBtnTSMenuItRotates,
            this.drDBtnTSMenuItMirror});
            this.tsDropDownFilters.Image = ((System.Drawing.Image)(resources.GetObject("tsDropDownFilters.Image")));
            this.tsDropDownFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropDownFilters.Name = "tsDropDownFilters";
            this.tsDropDownFilters.Size = new System.Drawing.Size(31, 25);
            this.tsDropDownFilters.Text = "Фильтры";
            // 
            // drDBtnTSMenuItDiscolor
            // 
            this.drDBtnTSMenuItDiscolor.Name = "drDBtnTSMenuItDiscolor";
            this.drDBtnTSMenuItDiscolor.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItDiscolor.Text = "Обесцветить";
            this.drDBtnTSMenuItDiscolor.Click += new System.EventHandler(this.drDBtnTSMenuItDiscolor_Click);
            // 
            // toolStripMenuSepia
            // 
            this.toolStripMenuSepia.Name = "toolStripMenuSepia";
            this.toolStripMenuSepia.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuSepia.Text = "Сепия";
            this.toolStripMenuSepia.Click += new System.EventHandler(this.toolStripMenuSepia_Click);
            // 
            // toolStripMenuInversion
            // 
            this.toolStripMenuInversion.Name = "toolStripMenuInversion";
            this.toolStripMenuInversion.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuInversion.Text = "Инверсия";
            this.toolStripMenuInversion.Click += new System.EventHandler(this.toolStripMenuInversion_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(211, 6);
            // 
            // drDBtnTSMenuItSharpness
            // 
            this.drDBtnTSMenuItSharpness.Name = "drDBtnTSMenuItSharpness";
            this.drDBtnTSMenuItSharpness.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItSharpness.Text = "Повысить резкость";
            this.drDBtnTSMenuItSharpness.Click += new System.EventHandler(this.drDBtnTSMenuItSharpness_Click);
            // 
            // drDBtnTSMenuItBlur
            // 
            this.drDBtnTSMenuItBlur.Name = "drDBtnTSMenuItBlur";
            this.drDBtnTSMenuItBlur.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItBlur.Text = "Размытие";
            this.drDBtnTSMenuItBlur.Click += new System.EventHandler(this.drDBtnTSMenuItBlur_Click);
            // 
            // toolStripMenuNoize
            // 
            this.toolStripMenuNoize.Name = "toolStripMenuNoize";
            this.toolStripMenuNoize.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuNoize.Text = "Шум";
            this.toolStripMenuNoize.Click += new System.EventHandler(this.toolStripMenuNoize_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(211, 6);
            // 
            // drDBtnTSMenuItColors
            // 
            this.drDBtnTSMenuItColors.Name = "drDBtnTSMenuItColors";
            this.drDBtnTSMenuItColors.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItColors.Text = "Цвета";
            this.drDBtnTSMenuItColors.Click += new System.EventHandler(this.drDBtnTSMenuItColors_Click);
            // 
            // drDBtnTSMenuItBright
            // 
            this.drDBtnTSMenuItBright.Name = "drDBtnTSMenuItBright";
            this.drDBtnTSMenuItBright.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItBright.Text = "Яркость";
            this.drDBtnTSMenuItBright.Click += new System.EventHandler(this.drDBtnTSMenuItBright_Click);
            // 
            // drDBtnTSMenuItContrast
            // 
            this.drDBtnTSMenuItContrast.Name = "drDBtnTSMenuItContrast";
            this.drDBtnTSMenuItContrast.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItContrast.Text = "Контраст";
            this.drDBtnTSMenuItContrast.Click += new System.EventHandler(this.drDBtnTSMenuItIncreaseContrast_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(211, 6);
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
            this.drDBtnTSMenuItRotates.Text = "Поворот";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem5.Text = "90° по ч.с.";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuRotBy90_Click);
            // 
            // toolStripMenuRotBy270
            // 
            this.toolStripMenuRotBy270.Name = "toolStripMenuRotBy270";
            this.toolStripMenuRotBy270.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuRotBy270.Text = "90° против ч.с.";
            this.toolStripMenuRotBy270.Click += new System.EventHandler(this.toolStripMenuRotBy270_Click);
            // 
            // toolStripMenuRotBy180
            // 
            this.toolStripMenuRotBy180.Name = "toolStripMenuRotBy180";
            this.toolStripMenuRotBy180.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuRotBy180.Text = "180°";
            this.toolStripMenuRotBy180.Click += new System.EventHandler(this.toolStripMenuRotBy180_Click);
            // 
            // toolStripTextBoxRotateOn
            // 
            this.toolStripTextBoxRotateOn.Name = "toolStripTextBoxRotateOn";
            this.toolStripTextBoxRotateOn.Size = new System.Drawing.Size(147, 22);
            this.toolStripTextBoxRotateOn.Text = "Произвольно";
            this.toolStripTextBoxRotateOn.Click += new System.EventHandler(this.toolStripTextBoxRotateOn_Click);
            // 
            // drDBtnTSMenuItMirror
            // 
            this.drDBtnTSMenuItMirror.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MirrorVertically,
            this.ToolStripMenuHoris});
            this.drDBtnTSMenuItMirror.Name = "drDBtnTSMenuItMirror";
            this.drDBtnTSMenuItMirror.Size = new System.Drawing.Size(214, 22);
            this.drDBtnTSMenuItMirror.Text = "Зеркальное отображение";
            // 
            // MirrorVertically
            // 
            this.MirrorVertically.Name = "MirrorVertically";
            this.MirrorVertically.Size = new System.Drawing.Size(161, 22);
            this.MirrorVertically.Text = "По вертикали";
            this.MirrorVertically.Click += new System.EventHandler(this.MirrorVertically_Click);
            // 
            // ToolStripMenuHoris
            // 
            this.ToolStripMenuHoris.Name = "ToolStripMenuHoris";
            this.ToolStripMenuHoris.Size = new System.Drawing.Size(161, 22);
            this.ToolStripMenuHoris.Text = "По горизонтали";
            this.ToolStripMenuHoris.Click += new System.EventHandler(this.ToolStripMenuHoris_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(30, 6);
            // 
            // tsButtonFraming
            // 
            this.tsButtonFraming.AutoSize = false;
            this.tsButtonFraming.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonFraming.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonFraming.Image")));
            this.tsButtonFraming.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonFraming.Name = "tsButtonFraming";
            this.tsButtonFraming.Size = new System.Drawing.Size(25, 25);
            this.tsButtonFraming.Text = "кадрирование";
            this.tsButtonFraming.ToolTipText = "Обрезка";
            this.tsButtonFraming.Click += new System.EventHandler(this.tsButtonFraming_Click);
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
            this.timerIsToSave.Interval = 30000;
            this.timerIsToSave.Tick += new System.EventHandler(this.timerIsToSave_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.MinimumSize = new System.Drawing.Size(420, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "The Best Redactor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
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
            this.KeyPreview =  true;
            this.KeyDown    += KeyPress;

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStrSave;
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
        private Timer timerAutoSave;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private TabControl tabControlPage;
        private TabPage tabPage1;
        public PictureBox pictureBox;
        private Label lblCursorPos;
        private Label lblPictureSize;
        private Panel panel1;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStripTools;
        private ToolStripButton tsBtn_color1;
        private ToolStripButton tsBtn_color2;
        internal ToolStripButton tsBtnBrush;
        internal ToolStripButton tsBtnPen;
        internal ToolStripSplitButton tsSplitButtonShape;
        internal ToolStripMenuItem tsBtnMenuItemLine;
        internal ToolStripMenuItem tsBtnMenuItemEllipce;
        internal ToolStripMenuItem tsBtnMenuItemRect;
        private ToolStripDropDownButton tsDropDownFilters;
        private ToolStripMenuItem drDBtnTSMenuItDiscolor;
        private ToolStripMenuItem drDBtnTSMenuItColors;
        private ToolStripMenuItem drDBtnTSMenuItSharpness;
        private ToolStripMenuItem drDBtnTSMenuItBright;
        private ToolStripMenuItem drDBtnTSMenuItContrast;
        private ToolStripMenuItem drDBtnTSMenuItBlur;
        private ToolStripMenuItem drDBtnTSMenuItRotates;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuRotBy270;
        private ToolStripMenuItem toolStripMenuRotBy180;
        private ToolStripMenuItem drDBtnTSMenuItMirror;
        private ToolStripMenuItem MirrorVertically;
        private ToolStripMenuItem ToolStripMenuHoris;
        internal ToolStripButton tsButtonCursor;
        internal ToolStripButton tsBtnFill;
        internal ToolStripButton tsBtnPipette;
        internal ToolStripButton tsButtonFraming;
        internal ToolStripButton tsBtnEraser;
        internal ToolStripButton tsText;
        private ToolStripMenuItem toolStripMenuSaveAll;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ToolStripMenuItem toolStripMenuInversion;
        private ToolStripMenuItem toolStripMenuSepia;
        private ToolStripMenuItem toolStripMenuNoize;
        internal ToolStripMenuItem tsBtnMenuItemEllipceFill;
        internal ToolStripMenuItem tsBtnMenuItemRectFill;
        internal ToolStripMenuItem tsBtnMenuItemCircle;
        internal ToolStripMenuItem toolStripMenuSquare;
        internal ToolStripMenuItem tsBtnMenuItemCircleFill;
        internal ToolStripMenuItem toolStripMenuSquareFill;
        private Timer timerIsToSave;
        private ToolStripMenuItem toolStripTextBoxRotateOn;
        private ToolStripMenuItem изображениеToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem ToolStripMenuItemBnW;
        private ToolStripMenuItem ToolStripMenuItemSepia;
        private ToolStripMenuItem ToolStripMenuItemInvers;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem ToolStripMenuItemSharp;
        private ToolStripMenuItem ToolStripMenuItemBlur;
        private ToolStripMenuItem ToolStripMenuItemNoise;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem ToolStripMenuItemColors;
        private ToolStripMenuItem ToolStripMenuItemBright;
        private ToolStripMenuItem ToolStripMenuItemContrast;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem ToolStripMenuItemRotate;
        private ToolStripMenuItem toolStripMenuItem90;
        private ToolStripMenuItem toolStripMenuItem270;
        private ToolStripMenuItem toolStripMenuItem180;
        private ToolStripMenuItem ToolStripMenuItemFree;
        private ToolStripMenuItem ToolStripMenuItemMirror;
        private ToolStripMenuItem поВертикалиToolStripMenuItem;
        private ToolStripMenuItem поГоризонталиToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripButton tsBtnSelection;
        internal ToolStripMenuItem tsBtnMenuItemDashLine;
        private ToolStripSeparator toolStripSeparator15;
    }
}

