using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using BestRedactor.Enums;
using BestRedactor.Forms.MethodsForEvents;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Forms
{
    public partial class MainForm : Form
    {       
        //TODO Крестики на TP

        //TODO Починить Zoom(удалить)
        //TODO Горячие клавиши
        //TODO Добавить историю(когда-то потом)
        public MainForm(List<Picture> pictures)
        {
            InitializeComponent();
            _pictures              = pictures;
            Settings.OpenedTabs    = 0;
            tsBtn_color1.BackColor = Settings.LastUseColor;
            _brush.StartCap        = LineCap.Round;
            _brush.EndCap          = LineCap.Round;
            _brush.DashPattern     = new[] { 5f, 5 };
            _erase.StartCap        = LineCap.Round;
            _erase.EndCap          = LineCap.Round;
            tsBtn_color1.Size      = _selectSizeColor;
            tsButtonCursor.Size    = _selectSizeTools;
            if (Settings.FailClose)
            {
                var result = MessageBox.Show(@"Восстановить предыдущую сессию?",
                    @"Backup",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    foreach (var picture in AutoSave.LoadsSession())
                    {
                        var elem = (Picture)picture;
                        _pictures.Add(elem);
                        AddNewTabPages(elem);
                    }

                    Refresh();
                }


                //TODO Выбор развёрнутой формы
                //TopMost = true;
            }
            else
                Settings.FailClose = true;
        }

        private           Graphics      _gra;
        private           Point         _px, _py;
        private           Pen           _brush     = new(Settings.LastUseColor, Settings.LastUseSize);
        private readonly  Pen           _erase     = new(Color.White, 10);
        private           Pen           _pencil    = new(Settings.LastUseColor, 1f);
        private readonly  ColorDialog   _cd        = new();
        private           BrushSize     _brushSize = new();
        private           List<Picture> _pictures;
        private           Rectangle     _rectangleTmp;
        private           Bitmap        _bitmapTmp;
        private           bool          _isMouseDown;
        private           bool          _isClickedColor1;
        private           bool          _isClickedColor2;
        private           bool          _isSaved;
        private           bool          _autoSaveTimer;
        private           int           _x, _y, _sX, _sY, _cX, _cY;
        private           Tools         _currentTool         = Tools.Cursor;
        private           Tools         _lastFigure          = Tools.Cursor;
        private readonly  Size          _selectSizeColor     = new(25, 25);
        private readonly  Size          _notSelectSizeColor  = new(20, 20);
        internal readonly Size          _selectSizeFigure    = new(35, 30);
        internal readonly Size          _notSelectSizeFigure = new(30, 25);
        internal readonly Size          _selectSizeTools     = new(30, 30);
        internal readonly Size          _notSelectSizeTools  = new(25, 25);
        internal          Picture       _picture => _pictures[tabControlPage.SelectedIndex];
        internal          PictureBox    _pb      => (PictureBox)tabControlPage.SelectedTab?.Controls[1];
        private           TextBox       _textBox => (TextBox)tabControlPage.SelectedTab.Controls[0];

        private void tsButtonCursor_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Cursor, ref _currentTool, this);
        private void tsBtnBrush_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Brush, ref _currentTool, this);
        private void tsBtnPen_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Pencil, ref _currentTool, this);
        private void tsBtnEraser_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Erase, ref _currentTool, this);
        private void tsBtnFill_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Fill, ref _currentTool, this);
        private void tsBtnPipette_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Pipette, ref _currentTool, this);
        private void tsText_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Text, ref _currentTool, this);
        private void tsBtnSelection_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Cropping, ref _currentTool, this);
        private void tsSplitButtonShape_ButtonClick(object sender, EventArgs e) =>
            Selection.DisableSelect(_lastFigure, ref _currentTool, this);
        private void tsBtnMenuItemLine_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Line, ref _currentTool, this);
        private void tsBtnMenuItemDashLine_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.DashLine, ref _currentTool, this);
        private void tsBtnMenuItemEllipce_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Ellipce, ref _currentTool, this);
        private void tsBtnMenuItemEllipceFill_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.EllipceFill, ref _currentTool, this);
        private void tsBtnMenuItemRect_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Rectangle, ref _currentTool, this);
        private void tsBtnMenuItemRectFill_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.RectangleFill, ref _currentTool, this);
        private void tsBtnMenuItemCircle_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Circle, ref _currentTool, this);
        private void tsBtnMenuItemCircleFill_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.CircleFill, ref _currentTool, this);
        private void toolStripMenuSquare_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.Square, ref _currentTool, this);
        private void toolStripMenuSquareFill_Click(object sender, EventArgs e) =>
            Selection.DisableSelect(Tools.SquareFill, ref _currentTool, this);
        private void tsButtonFraming_Click(object sender, EventArgs e)
        {
            _picture.Bitmap = Logics.Resize.Cropping(_picture.Bitmap, _rectangleTmp);
            _pb.Image       = _picture.Bitmap;
            RefreshAndSize();
            lblPictureSize.Text = $@"{_picture.Bitmap.Width} x {_picture.Bitmap.Height}";
        }
        


        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gra.Clear(Settings.LastUseColor);
            Selection.DisableSelect(Tools.Cursor, ref _currentTool, this);
        }


        private void timerAutoSave_Tick(object sender, EventArgs e)
        {
            if (_autoSaveTimer)
            {
                var i = 0;
                foreach (TabPage elem in tabControlPage.TabPages)
                {
                    elem.Text = _pictures[i].FileName;
                    i++;
                }

                timerAutoSave.Interval = 180000;
                _autoSaveTimer         = false;
            }
            else
            {
                AutoSave.Backup(_pictures);
                timerAutoSave.Interval = 5000;
                _autoSaveTimer         = true;
            }
        }
        private void timerIsToSave_Tick(object sender, EventArgs e)
        {
            Settings.FailClose = true;
            timerIsToSave.Stop();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) => FileManagerL.Save(_picture);
        private void SaveAll(object sander, EventArgs e)
        {
            FileManagerL.SaveAll(_pictures);
            Settings.FailClose = false;
            timerIsToSave.Start();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var openTabs = Settings.OpenedTabs;
                _pictures.Add((Picture)FileManagerL.LoadFromClipboard());
                AddNewTabPages(_pictures[openTabs]);
                tabControlPage.SelectedIndex = openTabs;
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Невозможно открыть файл из буфера обмена!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter =
                @"Jpeg(*.jpeg)|*.jpeg|Jpg(*.jpg)|*.jpg|Gif(*.gif)|*.gif|Icon(*.icon)|*.icon|Png(*.png)|*.png|Bmp(*.bmp)|*.bmp|Emf(*.emf)|*.emf|Exif(*.exif)|*.exif|Tiff(*.tiff)|*.tiff|Wmf(*.wmf)|*.wmf|Memorybmp(*.memorybmp)|*.memorybmp";
            sfd.FilterIndex = _picture.ImageFormat.ToString().ToLower() switch
            {
                "jpeg"      => 1,
                "gif"       => 3,
                "icon"      => 4,
                "png"       => 5,
                "bmp"       => 6,
                "emf"       => 7,
                "exif"      => 8,
                "tiff"      => 9,
                "wmf"       => 10,
                "memorybmp" => 11,
                _           => throw new AggregateException("Не поддерживаемый тип данных")
            };
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                _picture.ImageFormat = sfd.FilterIndex switch
                {
                    1  => ImageFormat.Jpeg,
                    2  => ImageFormat.Jpeg,
                    3  => ImageFormat.Gif,
                    4  => ImageFormat.Icon,
                    5  => ImageFormat.Png,
                    6  => ImageFormat.Bmp,
                    7  => ImageFormat.Emf,
                    8  => ImageFormat.Exif,
                    9  => ImageFormat.Tiff,
                    10 => ImageFormat.Wmf,
                    11 => ImageFormat.MemoryBmp,
                    _  => throw new AggregateException("Недоступный тип файла")
                };
                FileManagerL.SaveAs(_picture, sfd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Невозможно сохранить текущий файл!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter =
                @"Image Files(*.bmp;*.jpeg;*.jpg;*.gif;*.png;*.icon;*.emf;*.exif;*.tiff;*.wmf;*.memorybmp)|*.bmp;*.jpeg;*.jpg;*.gif;*.png;*.icon;*.emf;*.exif;*.tiff;*.wmf;*.memorybmp";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                _pictures.Add((Picture)FileManagerL.Load(ofd.FileName));
                AddNewTabPages(_pictures[Settings.OpenedTabs]);
                Refresh();
                lblPictureSize.Text = $@"{_pb.Image.Width} x {_pb.Image.Height}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Невозможно открыть выбранный файл!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void AddNewTabPages(IPicture picture)
        {
            var tp = new TabPage(picture.FileName);
            var pb = new PictureBox();
            var tb = new TextBox();
            //creation tabPage
            tp.Dock                    = DockStyle.Fill;
            tp.BorderStyle             = BorderStyle.Fixed3D;
            tp.Location                = new Point(0, 0);
            tp.ForeColor               = SystemColors.ControlText;
            tp.Name                    = $"tabPage{Settings.OpenedTabs}";
            tp.Padding                 = new Padding(3);
            tp.Size                    = new Size(picture.Bitmap.Width, picture.Bitmap.Height);
            tp.TabIndex                = Settings.OpenedTabs;
            tp.UseVisualStyleBackColor = true;
            tp.AutoScroll              = true;
            tp.BackColor               = SystemColors.Control;

            //creation pictureBox
            pb.Location   =  new Point(0, 0);
            pb.Name       =  $"pb{Settings.OpenedTabs}";
            pb.Size       =  new Size(picture.Bitmap.Width, picture.Bitmap.Height);
            pb.TabIndex   =  Settings.OpenedTabs;
            pb.TabStop    =  false;
            pb.Image      =  picture.Bitmap;
            pb.MouseClick += pictureBox_MouseClick;
            pb.MouseDown  += pictureBox_MouseDown;
            pb.MouseMove  += pictureBox_MouseMove;
            pb.MouseUp    += pictureBox_MouseUp;
            pb.Paint      += PbPaint;

            //creation textBox
            
            tb.Multiline   = true;
            tb.BorderStyle = BorderStyle.None;
            tb.Enabled = false;


            tp.Controls.Add(tb);
            //создание новой вкладки с объектом PictureBox
            tp.Controls.Add(pb);
           

            tabControlPage.TabPages.Add(tp);
            tabControlPage.SelectedTab =  tp;
            Settings.OpenedTabs        += 1;

            lblPictureSize.Text = $@"{picture.Bitmap.Width} x {picture.Bitmap.Height}";
        }
        private void drDBtnTSMenuItIncreaseContrast_Click(object sender, EventArgs e) =>
            new FiltersForm(_picture, this, Filters.Contrast).ShowDialog();
        private void drDBtnTSMenuItBlur_Click(object sender, EventArgs e)
        {
            _picture.Bitmap = Precision.Blur(_picture.Bitmap);
            RefreshAndPbImage();
        }
        private void drDBtnTSMenuItBright_Click(object sender, EventArgs e) =>
            new FiltersForm(_picture, this, Filters.Brightness).ShowDialog();
        private void drDBtnTSMenuItColors_Click(object sender, EventArgs e) =>
            new ColorsForm(_picture, this).ShowDialog();
        public void RefreshAndSize()
        {
            _pb.Size                        = new Size(_picture.Bitmap.Width, _picture.Bitmap.Height);
            tabControlPage.SelectedTab.Size = _pb.Size;
            Refresh();
        }
        public void RefreshAndPbImage()
        {
            _pb.Image = _picture.Bitmap;
            Refresh();
        }
        private new void Refresh()
        {
            if (Settings.OpenedTabs == 0)
                return;
            _pb.Refresh();
            _gra = Graphics.FromImage(_picture.Bitmap);
        }


        private void tsBtn_color1_Click(object sender, EventArgs e)
        {
            if (_isClickedColor1)
            {
                if (_cd.ShowDialog() != DialogResult.OK)
                    return;
                tsBtn_color1.BackColor = _cd.Color;
                _brush.Color           = tsBtn_color1.BackColor;
                _pencil.Color          = tsBtn_color1.BackColor;
                Settings.LastUseColor  = tsBtn_color1.BackColor;
                _isClickedColor1       = false;
                _isClickedColor2       = false;
            }
            else
            {
                _brush.Color          = tsBtn_color1.BackColor;
                _pencil.Color         = tsBtn_color1.BackColor;
                Settings.LastUseColor = tsBtn_color1.BackColor;
                tsBtn_color1.Size     = _selectSizeColor;
                tsBtn_color2.Size     = _notSelectSizeColor;
                _isClickedColor1      = true;
                _isClickedColor2      = false;
            }
        }
        private void tsBtn_color2_Click(object sender, EventArgs e)
        {
            if (_isClickedColor2)
            {
                if (_cd.ShowDialog() != DialogResult.OK)
                    return;
                tsBtn_color2.BackColor = _cd.Color;
                _brush.Color           = tsBtn_color2.BackColor;
                _pencil.Color          = tsBtn_color2.BackColor;
                Settings.LastUseColor  = tsBtn_color2.BackColor;
                _isClickedColor2       = false;
                _isClickedColor1       = false;
            }
            else
            {
                _brush.Color          = tsBtn_color2.BackColor;
                _pencil.Color         = tsBtn_color2.BackColor;
                Settings.LastUseColor = tsBtn_color2.BackColor;
                tsBtn_color1.Size     = _notSelectSizeColor;
                tsBtn_color2.Size     = _selectSizeColor;
                _isClickedColor2      = true;
                _isClickedColor1      = false;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.FailClose)
            {
                var result = MessageBox.Show(@"Сохранить перед закрытием?",
                    @"Save",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    if (!_isSaved)
                    {
                        FileManagerL.Save(_picture);
                        _isSaved = true;
                    }
                }
            }

            if (!_pictures.Remove(_picture))
                return;
            Settings.OpenedTabs -= 1;
            tabControlPage.TabPages.Remove(tabControlPage.SelectedTab);
            lblPictureSize.Text = string.Empty;
            tabControlPage.Refresh();
        }
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (_currentTool == Tools.Fill)
                Filling.Fill(_picture.Bitmap, e.X, e.Y, Settings.LastUseColor);
            if (_currentTool != Tools.Pipette)
                return;
            Settings.LastUseColor = _picture.Bitmap.GetPixel(e.X, e.Y);
            _brush.Color          = Settings.LastUseColor;
            _pencil.Color         = Settings.LastUseColor;
            if (tsBtn_color1.Size == _selectSizeColor)
                tsBtn_color1.BackColor = Settings.LastUseColor;
            else
                tsBtn_color2.BackColor = Settings.LastUseColor;
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.OpenedTabs == 0)
                return;
            Clipboard.SetImage(Logics.Resize.Cropping(_picture.Bitmap, _rectangleTmp));
        }


        // filters
        private void drDBtnTSMenuItSharpness_Click(object sender, EventArgs e)
        {
            _picture.Bitmap = Precision.Sharpness(_picture.Bitmap);
            RefreshAndPbImage();
        }
        private void drDBtnTSMenuItDiscolor_Click(object sender, EventArgs e)
        {
            _picture.Bitmap = ColorBalance.ToGrayScale(_picture.Bitmap);
            RefreshAndPbImage();
        }
        private void toolStripMenuInversion_Click(object sender, EventArgs e)
        {
            _picture.Bitmap = ColorBalance.IverseColor(_picture.Bitmap);
            RefreshAndPbImage();
        }
        private void toolStripMenuSepia_Click(object sender, EventArgs e)
        {
            _picture.Bitmap = ColorBalance.Sepia(_picture.Bitmap);
            RefreshAndPbImage();
        }
        private void toolStripMenuNoize_Click(object sender, EventArgs e)
        {
            _picture.Bitmap = Precision.Noise(_picture.Bitmap);
            RefreshAndPbImage();
        }
        private void MirrorVertically_Click(object sender, EventArgs e)
        {
            _pb.Image = Logics.Rotation.VerticalReflection(_picture.Bitmap);
            Refresh();
        }
        private void ToolStripMenuHoris_Click(object sender, EventArgs e)
        {
            _pb.Image = Logics.Rotation.HorizontalReflection(_picture.Bitmap);
            Refresh();
        }
        private void toolStripMenuRotBy90_Click(object sender, EventArgs e)
        {
            _pb.Image = Logics.Rotation.PictureRotationBy(_picture.Bitmap, 90);
            RefreshAndSize();
        }
        private void toolStripMenuRotBy270_Click(object sender, EventArgs e)
        {
            _pb.Image = Logics.Rotation.PictureRotationBy(_picture.Bitmap, 270);
            RefreshAndSize();
        }
        private void toolStripMenuRotBy180_Click(object sender, EventArgs e)
        {
            _pb.Image = Logics.Rotation.PictureRotationBy(_picture.Bitmap, 180);
            RefreshAndSize();
        }


        
        private void toolStripTextBoxRotateOn_Click(object sender, EventArgs e)
        {
            new Rotation(_picture, this).ShowDialog();
            _pb.Image           = _picture.Bitmap;
            lblPictureSize.Text = $@"{_picture.Bitmap.Width} x {_picture.Bitmap.Height}";
        }

        private void Crop(object sender, KeyEventArgs e)
        {
            if (_currentTool == Tools.Cropping && e.KeyCode == Keys.Enter && !_isMouseDown && Settings.OpenedTabs != 0)
            {
                _picture.Bitmap = Logics.Resize.Cropping(_picture.Bitmap, _rectangleTmp);
                _pb.Image       = _picture.Bitmap;
                RefreshAndSize();
                lblPictureSize.Text = $@"{_picture.Bitmap.Width} x {_picture.Bitmap.Height}";
            }

            if (_currentTool == Tools.Cropping && e.KeyCode == Keys.C && e.Control && !_isMouseDown &&
                Settings.OpenedTabs != 0)
            {
                Clipboard.SetImage(Logics.Resize.Cropping(_picture.Bitmap, _rectangleTmp));
            }

            if (_currentTool == Tools.Cropping && e.KeyCode == Keys.V && e.Control && !_isMouseDown &&
                Settings.OpenedTabs != 0) { pasteToolStripMenuItem_Click(null, null); }

            if (e.Control && e.KeyCode == Keys.S) { FileManagerL.Save(_picture); }

            if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.S) { SaveAll(null, null); }

            if (e.Control && e.Alt && e.KeyCode == Keys.S) { toolStripMenuItem2_Click(null, null); }

            if (_currentTool == Tools.Text && e.KeyCode == Keys.Enter && Settings.OpenedTabs != 0 && e.Control)
            {
                _gra.DrawString(_textBox.Text, _textBox.Font, new SolidBrush(Settings.LastUseColor), _textBox.Location);
                _textBox.Enabled = false;
                _textBox.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.FailClose = false;
            if (Settings.OpenedTabs == 0)
                return;
            var result = MessageBox.Show(@"Сохранить все открытые вкладки?",
                @"Save All",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                FileManagerL.SaveAll(_pictures);
        }


        private void PbPaint(object sender, PaintEventArgs e)
        {
            if (!_isMouseDown)
                return;
            DrawingFigures.DrawAFigure(e.Graphics, _currentTool, _brush, _cX, _cY, _sX, _sY, _x, _y);
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                switch (_currentTool)
                {
                    case Tools.Brush:
                        _px = e.Location;
                        _gra.DrawLine(_brush, _px, _py);
                        _py = _px;
                        break;
                    case Tools.Pencil:
                        _px = e.Location;
                        _gra.DrawLine(_pencil, _px, _py);
                        _py = _px;
                        break;
                    case Tools.Erase:
                        _px = e.Location;
                        _gra.DrawLine(_erase, _px, _py);
                        _py = _px;
                        break;
                }
            }

            //
            _pb.Refresh(); //move out from collection 
            _x                = e.X;
            _y                = e.Y;
            _sX               = e.X - _cX;
            _sY               = e.Y - _cY;
            lblCursorPos.Text = $@"{_x},{_y}"; //отображение позиции курсора
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;

            _sX = _x - _cX;
            _sY = _y - _cY;
            if (_currentTool == Tools.Cropping)
            {
                _bitmapTmp = (Bitmap)_picture.Bitmap.Clone();
                _gra       = Graphics.FromImage(_bitmapTmp);
                _pb.Image  = _bitmapTmp;
            }

            _rectangleTmp = DrawingFigures.DrawAFigure(_gra, _currentTool, _brush, _cX, _cY, _sX, _sY, _x, _y);
            if (_rectangleTmp.X < 0)
                _rectangleTmp.X = 0;
            if (_rectangleTmp.Y < 0)
                _rectangleTmp.Y = 0;
            if (_rectangleTmp.X + _rectangleTmp.Width > _pb.Width)
                _rectangleTmp.Width = _pb.Width - _rectangleTmp.X;
            if (_rectangleTmp.Y + _rectangleTmp.Height > _pb.Height)
                _rectangleTmp.Height = _pb.Height - _rectangleTmp.Y;
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {            
            _py          = e.Location;
            _cX          = e.X;
            _cY          = e.Y;
            switch (_currentTool)
            {
                case >= Tools.Line:
                    _lastFigure = _currentTool;
                    break;
                case Tools.Cropping:
                    _pb.Image = _picture.Bitmap;
                    break;
            }

            switch (e.Button)
            {
                case MouseButtons.Left:
                {
                    _isMouseDown       = true;
                    _brushSize.Visible = false;
                     _brush.Width       = Settings.LastUseSize;

                    if (_currentTool == Tools.Text)
                    {
                        _textBox.Location = new Point(_x - 5, _y - 8);
                        _textBox.BringToFront();
                        _textBox.Text        = "";
                        _textBox.Size        = new Size(600, 23);
                        _textBox.Enabled     = true;
                        _textBox.BorderStyle = BorderStyle.FixedSingle;
                        _textBox.Font        = DefaultFont;
                        _textBox.ForeColor   = Settings.LastUseColor;
                    }

                    break;
                }
                case MouseButtons.Right:
                {
                    switch (_currentTool)
                    {
                        case Tools.Brush or >= Tools.Line:
                            _brushSize.Show();
                            _brushSize.Location = new Point(_x + this.Location.X + 48, _y + this.Location.Y + 10);
                            break;
                        case Tools.Text:
                        {
                            FontDialog fDia = new();
                            if (fDia.ShowDialog() == DialogResult.OK)
                            {
                                _textBox.Font = fDia.Font;
                                _textBox.Size = new Size(600, (int)fDia.Font.Size * 2);
                                _textBox.Location = new Point(_textBox.Location.X,
                                    _textBox.Location.Y + 8 - _textBox.Size.Height / 2);
                            }

                            break;
                        }
                    }

                    break;
                }
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pictures.Add(new Picture(new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height,
                PixelFormat.Format32bppArgb)));
            AddNewTabPages(_pictures[^1]);
            Refresh();
            _gra.Clear(Color.White);
        }
        private void tabControlPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }


        //private void trackBarZoom_Scroll(object sender, EventArgs e)
        //{

        //    _pb.Width = _pb.Width * (trackBarZoom.Value / 100);
        //    _pb.Height = _pb.Height * (trackBarZoom.Value / 100);
        //    //Refresh();
        //}

        //private void btnZoomMinus_Click(object sender, EventArgs e)
        //{
        //    //trackBarZoom_Scroll(null, null);
        //    trackBarZoom.Value -= 25;
        //    _pb.Width = _pb.Width * (trackBarZoom.Value / 100);
        //    _pb.Height = _pb.Height * (trackBarZoom.Value / 100);
        //}
        //private void btnZoomPlus_Click(object sender, EventArgs e)
        //{
        //    //trackBarZoom_Scroll(null, null);
        //    trackBarZoom.Value += 25;
        //    _pb.Width = _pb.Width * (trackBarZoom.Value / 100);
        //    _pb.Height = _pb.Height * (trackBarZoom.Value / 100);
        //}
    }
}