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
        //TODO Иконки нормальные
        //TODO Сделать форму для поворота на произвольный угол
        //TODO Починить Zoom/сделать ползунки для пролистывания слишком больших изображений
        //TODO Бекап сессии(восстановление из бекапа)
        //TODO Кадрирование
        //TODO Горячие клавиши
        //TODO Починить квадрат


        //TODO Добавить историю(когда-то потом)
        public MainForm()
        {
            InitializeComponent();
            Settings.OpenedTabs    = 0;
            tsBtn_color1.BackColor = Settings.LastUseColor;
            _pen.StartCap          = LineCap.Round;
            _pen.EndCap            = LineCap.Round;
            _erase.StartCap        = LineCap.Round;
            _erase.EndCap          = LineCap.Round;
            if (Settings.FailClose)
            {
                var result = MessageBox.Show("Восстановить предыдущую сессию?",
                    "Backup",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                    //  для восстановления сессии
                    Refresh();
            }
            else
                Settings.FailClose = true;
        }

        private          Graphics      _gra;
        private          bool          _isMouseDown;
        private          Point         _px, _py;
        private          Pen           _pen      = new(Settings.LastUseColor, Settings.LastUseSize);
        private readonly Pen           _erase    = new(Color.White, 10);
        private          List<Picture> _pictures = new();
        private readonly ColorDialog   _cd       = new();
        private          bool          _isClickedColor1;
        private          bool          _isClickedColor2;
        private          bool          _isSaved;
        private          int           _x, _y, _sX, _sY, _cX, _cY;
        private          Tools         _currentTool = 0;
        private          Tools         _lastFigure  = 0;
        public           Filters       _selectedFilter;
        private          Picture       _picture => _pictures[tabControlPage.SelectedIndex];
        private          PictureBox    _pb      => (PictureBox)tabControlPage.SelectedTab?.Controls[0];


        private void tsButtonCursor_Click(object sender, EventArgs e)
        {
            _currentTool = Tools.Cursor;
            //
            tsButtonCursor.Checked = true;
            tsButtonCursor.CheckOnClick = true;
        }
        private void tsBtnBrush_Click(object sender, EventArgs e) =>               _currentTool = Tools.Pencil;
        private void tsBtnPen_Click(object sender, EventArgs e) =>                 _currentTool = Tools.Pencil;
        private void tsBtnEraser_Click(object sender, EventArgs e) =>              _currentTool = Tools.Erase;
        private void tsBtnFill_Click(object sender, EventArgs e) =>                _currentTool = Tools.Fill;
        private void tsBtnPipette_Click(object sender, EventArgs e) =>             _currentTool = Tools.Pipette;
        private void tsBtnMenuItemEllipce_Click(object sender, EventArgs e) =>     _currentTool = Tools.Ellipce;
        private void tsBtnMenuItemLine_Click(object sender, EventArgs e) =>        _currentTool = Tools.Line;
        private void tsBtnMenuItemRect_Click(object sender, EventArgs e) =>        _currentTool = Tools.Rectangle;
        private void tsBtnMenuItemCircle_Click(object sender, EventArgs e) =>      _currentTool = Tools.Circle;
        private void tsBtnMenuItemCircleFill_Click(object sender, EventArgs e) =>  _currentTool = Tools.CircleFill;
        private void tsBtnMenuItemEllipceFill_Click(object sender, EventArgs e) => _currentTool = Tools.EllipceFill;
        private void tsBtnMenuItemRectFill_Click(object sender, EventArgs e) =>    _currentTool = Tools.RectangleFill;
        private void toolStripMenuSquare_Click(object sender, EventArgs e) =>      _currentTool = Tools.Square;
        private void toolStripMenuSquareFill_Click(object sender, EventArgs e) =>  _currentTool = Tools.SquareFill;


        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gra.Clear(Color.Transparent);
            _currentTool = Tools.Cursor;
        }


        private void timerAutoSave_Tick(object sender, EventArgs e)
        {
            AutoSave.Backup(_pictures);
            var i = 0;
            foreach (TabPage elem in tabControlPage.TabPages)
            {
                elem.Text = _pictures[i].FileName;
                i++;
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
                @"Jpeg(*.jpeg)|*.jpeg|Jpg(*.jpg)|*.jpg|Gif(*.gif)|*.gif|Icon(*.icon)|*.icon|Png(*.png)|*.png|Bmp(*.bmp)|*.bmp|Emf(*.emf)|*.emf|Exif(*.exif)|*.exif|Tiff(*.tiff)|*.tiff|Wmf(*.wmf)|*.wmf|Memorybmp(*.memorybmp)|*.memorybpmp";
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
                @"Image Files(*.bmp;*.jpeg;*.jpg;*.gif;*.png;*.icon;*.emf;*.exif;*.tiff;*.wmf;*.memorybpmp)|*.bmp;*.jpeg;*.jpg;*.gif;*.png;*.icon;*.emf;*.exif;*.tiff;*.wmf;*.memorybpmp";
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

            tp.BorderStyle             = BorderStyle.Fixed3D;
            tp.Location                = new Point(0, 0);
            tp.ForeColor               = SystemColors.ControlText;
            tp.Name                    = $"tabPage{Settings.OpenedTabs}";
            tp.Padding                 = new Padding(3);
            tp.Size                    = new Size(picture.Bitmap.Width, picture.Bitmap.Height);
            tp.TabIndex                = Settings.OpenedTabs;
            tp.UseVisualStyleBackColor = true;
            tp.AutoScroll = true;
            
            //
            pb.SizeMode   =  PictureBoxSizeMode.Zoom;
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
            

            tp.Controls.Add(pb); //создание новой вкладки с объектом PictureBox
            tabControlPage.TabPages.Add(tp);
            tabControlPage.SelectedTab =  tp;
            tabControlPage.Size        =  new Size(_picture.Bitmap.Width + 12, _picture.Bitmap.Height + 32);
            Settings.OpenedTabs        += 1;

            lblPictureSize.Text = $@"{picture.Bitmap.Width} x {picture.Bitmap.Height}";
        }


        // метод для поиска старого цвета до заливки формы новым цветом
        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            var cx = bm.GetPixel(x, y);
            if (cx != oldColor)
                return;
            sp.Push(new Point(x, y));
            bm.SetPixel(x, y, newColor);
        }
        private void Fill(Bitmap bm, int x, int y, Color newCol)
        {
            var oldCol = bm.GetPixel(x, y);
            var pixel  = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, newCol);
            if (oldCol.ToArgb() == newCol.ToArgb())
                return;
            while (pixel.Count > 0)
            {
                var pt = pixel.Pop();
                if (pt.X <= 0 || pt.Y <= 0 || pt.X >= bm.Width - 1 || pt.Y >= bm.Height - 1)
                    continue;
                Validate(bm, pixel, pt.X - 1, pt.Y, oldCol, newCol);
                Validate(bm, pixel, pt.X, pt.Y - 1, oldCol, newCol);
                Validate(bm, pixel, pt.X + 1, pt.Y, oldCol, newCol);
                Validate(bm, pixel, pt.X, pt.Y + 1, oldCol, newCol);
            }
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
        public new void Refresh()
        {
            tabControlPage.Size = new Size(_picture.Bitmap.Width + 12, _picture.Bitmap.Height + 32);
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
                _pen.Color             = tsBtn_color1.BackColor;
                Settings.LastUseColor  = tsBtn_color1.BackColor;
                _isClickedColor1       = false;
                _isClickedColor2       = false;
            }
            else
            {
                _pen.Color            = tsBtn_color1.BackColor;
                Settings.LastUseColor = tsBtn_color1.BackColor;
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
                _pen.Color             = tsBtn_color2.BackColor;
                Settings.LastUseColor  = tsBtn_color2.BackColor;
                _isClickedColor2       = false;
                _isClickedColor1       = false;
            }
            else
            {
                _pen.Color            = tsBtn_color2.BackColor;
                Settings.LastUseColor = tsBtn_color2.BackColor;
                _isClickedColor2      = true;
                _isClickedColor1      = false;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.FailClose = false;
            var result = MessageBox.Show("Сохранить все открытые вкладки?",
                "Save All",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                FileManagerL.SaveAll(_pictures);
            Close();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.FailClose)
            {
                var result = MessageBox.Show("Сохранить перед закрытием?",
                    "Save All",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    if (!_isSaved)
                    {
                        FileManagerL.Save(_picture);
                        _isSaved = true; //TODO не забыть спросить про поле в IPicture
                    }
                }
            }

            if (!_pictures.Remove(_picture))
                return;
            tabControlPage.TabPages.Remove(tabControlPage.SelectedTab);
            tabControlPage.Refresh();
            Settings.OpenedTabs -= 1;
        }
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (_currentTool == Tools.Fill)
                Fill(_picture.Bitmap, e.X, e.Y, Settings.LastUseColor);
            if (_currentTool != Tools.Pipette)
                return;
            Settings.LastUseColor  = _picture.Bitmap.GetPixel(e.X, e.Y);
            _pen.Color             = Settings.LastUseColor;
            tsBtn_color1.BackColor = Settings.LastUseColor;
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


        private void tsSplitButtonShape_ButtonClick(object sender, EventArgs e)
        {
            _currentTool = _lastFigure;
        }

        private void toolStripTextBoxRotateOn_Click(object sender, EventArgs e)
        {
            new Rotation(_picture, this).ShowDialog();
            _pb.Image = _picture.Bitmap;
        }

        private void PbPaint(object sender, PaintEventArgs e)
        {
            if (!_isMouseDown)
                return;
            DrawingFigures.DrawAFigure(e.Graphics, _currentTool, _pen, _cX, _cY, _sX, _sY, _x, _y);
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                switch (_currentTool)
                {
                    case Tools.Pencil:
                        _px = e.Location;
                        _gra.DrawLine(_pen, _px, _py);
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
            lblCursorPos.Text = $@"{e.Location.X},{e.Location.Y}"; //отображение позиции курсора
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;

            _sX = _x - _cX;
            _sY = _y - _cY;

            DrawingFigures.DrawAFigure(_gra, _currentTool, _pen, _cX, _cY, _sX, _sY, _x, _y);
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            _py          = e.Location;
            _cX          = e.X;
            _cY          = e.Y;
            if ((int)_currentTool > 5)
                _lastFigure = _currentTool;
            //изменение иконки
            switch (_currentTool)
            {
                case Tools.Line:
                    tsSplitButtonShape.Image = tsBtnMenuItemLine.Image;
                    break;
                case Tools.Ellipce:
                    tsSplitButtonShape.Image = tsBtnMenuItemEllipce.Image;
                    break;
                case Tools.EllipceFill:
                    tsSplitButtonShape.Image = tsBtnMenuItemEllipceFill.Image;
                    break;
                case Tools.Rectangle:
                    tsSplitButtonShape.Image = tsBtnMenuItemRect.Image;
                    break;
                case Tools.RectangleFill:
                    tsSplitButtonShape.Image = tsBtnMenuItemRectFill.Image;
                    break;
                case Tools.Circle:
                    tsSplitButtonShape.Image = tsBtnMenuItemCircle.Image;
                    break;
                case Tools.CircleFill:
                    tsSplitButtonShape.Image = tsBtnMenuItemCircleFill.Image;
                    break;
                case Tools.Square:
                    tsSplitButtonShape.Image = toolStripMenuSquare.Image;
                    break;
                case Tools.SquareFill:
                    tsSplitButtonShape.Image = toolStripMenuSquareFill.Image;
                    break;
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pictures.Add(new Picture(new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb)));
            AddNewTabPages(_pictures[^1]);
            Refresh();
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