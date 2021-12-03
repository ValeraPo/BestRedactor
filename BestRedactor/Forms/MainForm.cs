using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using BestRedactor.Enums;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Settings.OpenedTabs    = 0;
            tsBtn_color1.BackColor = Settings.LastUseColor;
            _pen.StartCap          = LineCap.Round;
            _pen.EndCap            = LineCap.Round;
            _erase.StartCap        = LineCap.Round;
            _erase.EndCap          = LineCap.Round;
            Settings.FailClose     = true;
        }

        private          Graphics      _gra;
        private          bool          _isMouseDown;
        private          Point         _px, _py;
        private          Pen           _pen      = new(Settings.LastUseColor, Settings.LastUseSize);
        private readonly Pen           _erase    = new(Color.White, 10);
        private          List<Picture> _pictures = new();
        private readonly ColorDialog   _cd       = new();
        private          bool          _isClickedColor; //добавить к логике выбора цвета
        private          int           _x, _y, _sX, _sY, _cX, _cY;
        private          Tools         _currentTool = 0;
        public           Filters       _selectedFilter;
        private          Picture       _picture => _pictures[tabControlPage.SelectedIndex];
        private          PictureBox    _pb      => (PictureBox)tabControlPage.SelectedTab?.Controls[0];


        private void tsBtnBrush_Click(object sender, EventArgs e) =>               _currentTool = Tools.Pencil;
        private void tsBtnPen_Click(object sender, EventArgs e) =>                 _currentTool = Tools.Pencil;
        private void tsBtnEraser_Click(object sender, EventArgs e) =>              _currentTool = Tools.Erase;
        private void tsBtnMenuItemEllipce_Click(object sender, EventArgs e) =>     _currentTool = Tools.Ellipce;
        private void tsBtnMenuItemLine_Click(object sender, EventArgs e) =>        _currentTool = Tools.Line;
        private void tsBtnMenuItemRect_Click(object sender, EventArgs e) =>        _currentTool = Tools.Rectangle;
        private void tsBtnFill_Click(object sender, EventArgs e) =>                _currentTool = Tools.Fill;
        private void tsButtonCursor_Click(object sender, EventArgs e) =>           _currentTool = Tools.Cursor;
        private void tsBtnPipette_Click(object sender, EventArgs e) =>             _currentTool = Tools.Pipette;
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


        private void timerAutoSave_Tick(object sender, EventArgs e) => AutoSave.Backup(_pictures);
        private void toolStripMenuItem1_Click(object sender, EventArgs e) => FileManagerL.Save(_picture);
        private void SaveAll(object sander, EventArgs e) => FileManagerL.SaveAll(_pictures);
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
                MessageBox.Show(ex.Message, @"Невозможно открыть файл из буфера обмена!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = @"Jpeg(*.jpeg)|*.jpeg|Jpg(*.jpg)|*.jpg|Gif(*.gif)|*.gif|Icon(*.icon)|*.icon|Png(*.png)|*.png|Bmp(*.bmp)|*.bmp|Emf(*.emf)|*.emf|Exif(*.exif)|*.exif|Tiff(*.tiff)|*.tiff|Wmf(*.wmf)|*.wmf|Memorybmp(*.memorybmp)|*.memorybpmp";
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
                MessageBox.Show(ex.Message, @"Невозможно сохранить текущий файл!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var ofd = new OpenFileDialog();
            ofd.Filter = @"Image Files(*.bmp;*.jpeg;*.jpg;*.gif;*.png;*.icon;*.emf;*.exif;*.tiff;*.wmf;*.memorybpmp)|*.bmp;*.jpeg;*.jpg;*.gif;*.png;*.icon;*.emf;*.exif;*.tiff;*.wmf;*.memorybpmp";
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
                MessageBox.Show(ex.Message, @"Невозможно открыть выбранный файл!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddNewTabPages(IPicture picture)
        {
            var    tp = new TabPage(picture.FileName);
            var pb = new PictureBox();

            tp.BorderStyle             = BorderStyle.Fixed3D;
            tp.Location                = new Point(0, 0);
            tp.ForeColor               = SystemColors.ControlText;
            tp.Name                    = $"tabPage{Settings.OpenedTabs}";
            tp.Padding                 = new Padding(3);
            tp.Size                    = new Size(picture.Bitmap.Width, picture.Bitmap.Height);
            tp.TabIndex                = Settings.OpenedTabs;
            tp.UseVisualStyleBackColor = true;
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
            tabControlPage.SelectedTab = tp;
            tabControlPage.Size = new Size(_picture.Bitmap.Width + 12, _picture.Bitmap.Height + 32);
            Settings.OpenedTabs += 1;

            lblPictureSize.Text = $@"{picture.Bitmap.Width} x {picture.Bitmap.Height}";
        }



        // метод для поиска старого цвета до заливки формы новым цветом
        private static void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            var cx = bm.GetPixel(x, y);
            if (cx != oldColor)
                return;
            sp.Push(new Point(x, y));
            bm.SetPixel(x, y, newColor);
        }
        public static void Fill(Bitmap bm, int x, int y, Color newCol)
        {
            var oldCol = bm.GetPixel(x, y);
            var pixel = new Stack<Point>();
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



        private void drDBtnTSMenuItIncreaseContrast_Click(object sender, EventArgs e) => new FiltersForm(_picture, this, Filters.Contrast).ShowDialog();
        private void drDBtnTSMenuItBlur_Click(object sender, EventArgs e)
        {
            _picture.Bitmap = Precision.Blur(_picture.Bitmap);
            RefreshAndPbImage();
        }
        private void drDBtnTSMenuItBright_Click(object sender, EventArgs e) => new FiltersForm(_picture, this, Filters.Brightness).ShowDialog();
        private void drDBtnTSMenuItColors_Click(object sender, EventArgs e) => new ColorsForm(_picture, this).ShowDialog();
        public void RefreshAndSize()
        {
            _pb.Size = new Size(_picture.Bitmap.Width, _picture.Bitmap.Height);
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


        private void tsBtn_color1_DoubleClick(object sender, EventArgs e)
        {
            _cd.ShowDialog();
            if (_cd.ShowDialog() != DialogResult.OK)
                return;
            Settings.LastUseColor = _cd.Color;
            _pen                  = new Pen(Settings.LastUseColor, Settings.LastUseSize);
        }
        private void tsBtn_color1_Click(object sender, EventArgs e)
        {

            //if (isClickedColor)

            if (_cd.ShowDialog() != DialogResult.OK)
                return;
            Settings.LastUseColor  = _cd.Color;
            _pen.Color             = Settings.LastUseColor;
            tsBtn_color1.BackColor = Settings.LastUseColor;

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.FailClose = false;
            Close();
        } 
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            if (trackBarZoom.Value > 49)
            {
                _pb.Image = ZoomImage(_pb.Image, trackBarZoom.Value);
                lblZoom.Text = $@"{trackBarZoom.Value} %";
            }
        }
        private static Image ZoomImage(Image orig, float percent)
        {
            // Ширина и высота результирующего изображения
            var w           = orig.Width * percent / 100;
            var h           = orig.Height * percent / 100;
            var scaledImage = new Bitmap((int)w, (int)h);
            // DPI результирующего изображения
            scaledImage.SetResolution(orig.HorizontalResolution, orig.VerticalResolution);
            // Часть исходного изображения, для которой меняем масштаб.
            // В данном случае — всё изображение
            var src = new Rectangle(0, 0, orig.Width, orig.Height);
            // Часть изображения, которую будем рисовать
            // В данном случае — всё изображение
            var dest = new RectangleF(0, 0, w, h);
            // Прорисовка с изменённым масштабом
            using var g = Graphics.FromImage(scaledImage);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(orig, dest, src, GraphicsUnit.Pixel);
            
            return scaledImage;
        }
        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            trackBarZoom_Scroll(null, null);
            trackBarZoom.Value -= 25;
        }
        private void btnZoomPlus_Click(object sender, EventArgs e)
        {
            trackBarZoom_Scroll(null, null);
            trackBarZoom.Value += 25;
        }


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
            _pb.Image = Rotation.VerticalReflection(_picture.Bitmap);
            Refresh();
        }
        private void ToolStripMenuHoris_Click(object sender, EventArgs e)
        {
            _pb.Image = Rotation.HorizontalReflection(_picture.Bitmap);
            Refresh();
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            _pb.Image = Rotation.PictureRotationBy(_picture.Bitmap, 90);
            RefreshAndSize();
        }
        private void toolStripMenuRotBy270_Click(object sender, EventArgs e)
        {
            _pb.Image = Rotation.PictureRotationBy(_picture.Bitmap, 270);
            RefreshAndSize();
        }
        private void toolStripMenuRotBy180_Click(object sender, EventArgs e)
        {
            _pb.Image = Rotation.PictureRotationBy(_picture.Bitmap, 180);
            RefreshAndSize();
        }

        

        private void PbPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            if (!_isMouseDown)
                return;
            
            switch (_currentTool)
            {
                case Tools.Line:
                    g.DrawLine(_pen, _cX, _cY, _x, _y);
                    break;
                
                
                case Tools.Ellipce:
                    g.DrawEllipse(_pen, _cX, _cY, _sX, _sY);
                    break;
                case Tools.EllipceFill:
                    g.FillEllipse(new SolidBrush(Settings.LastUseColor),_cX, _cY, _sX, _sY);
                    break;
                
                
                case Tools.Rectangle when _sX > 0 && _sY > 0:
                    g.DrawRectangle(_pen, _cX, _cY, _sX, _sY);
                    break;
                case Tools.Rectangle when _sX < 0 && _sY > 0:
                    g.DrawRectangle(_pen, _cX + _sX, _cY, Math.Abs(_sX), _sY);
                    break;
                case Tools.Rectangle when _sX > 0 && _sY < 0:
                    g.DrawRectangle(_pen, _cX, _cY + _sY, _sX, Math.Abs(_sY));
                    break;
                case Tools.Rectangle when _sX < 0 && _sY < 0:
                    g.DrawRectangle(_pen, _cX + _sX, _cY + _sY, Math.Abs(_sX), Math.Abs(_sY));
                    break;
                case Tools.RectangleFill when _sX > 0 && _sY > 0:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, _sY);
                    break;
                case Tools.RectangleFill when _sX < 0 && _sY > 0:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), _cX + _sX, _cY, Math.Abs(_sX), _sY);
                    break;
                case Tools.RectangleFill when _sX > 0 && _sY < 0:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), _cX, _cY + _sY, _sX, Math.Abs(_sY));
                    break;
                case Tools.RectangleFill when _sX < 0 && _sY < 0:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), _cX + _sX, _cY + _sY, Math.Abs(_sX), Math.Abs(_sY));
                    break;
                

                case Tools.Circle:
                    if (Math.Abs(_sX) > Math.Abs(_sY))
                    {
                        switch (_sX)
                        {
                            case > 0 when _sY > 0:
                            case < 0 when _sY < 0:
                                g.DrawEllipse(_pen, _cX, _cY, _sX, _sX);
                                break;
                            case > 0 when _sY<0:
                                g.DrawEllipse(_pen, _cX, _cY, _sX, -_sX);
                                break;
                            default:
                                g.DrawEllipse(_pen, _cX, _cY, _sX, -_sX);
                                break;
                        }
                    }
                    else
                    {
                        switch (_sX)
                        {
                            case > 0 when _sY > 0:
                            case < 0 when _sY < 0:
                                g.DrawEllipse(_pen, _cX, _cY, _sY, _sY);
                                break;
                            case > 0 when _sY < 0:
                                g.DrawEllipse(_pen, _cX, _cY, -_sY, _sY);
                                break;
                            default:
                                g.DrawEllipse(_pen, _cX, _cY, -_sY, _sY);
                                break;
                        }
                    }
                    break;
                case Tools.CircleFill:
                    if (Math.Abs(_sX) > Math.Abs(_sY))
                    {
                        switch (_sX)
                        {
                            case > 0 when _sY > 0:
                            case < 0 when _sY < 0:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, _sX);
                                break;
                            case > 0 when _sY < 0:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, -_sX);
                                break;
                            default:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, -_sX);
                                break;
                        }
                    }
                    else
                    {
                        switch (_sX)
                        {
                            case > 0 when _sY > 0:
                            case < 0 when _sY < 0:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sY, _sY);
                                break;
                            case > 0 when _sY < 0:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, -_sY, _sY);
                                break;
                            default:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, -_sY, _sY);
                                break;
                        }
                    }
                    break;
                
                
                //квадрат рисуется только в 1 сторону
                case Tools.Square when _sX > 0 && _sY > 0 && _sX > _sY:
                    g.DrawRectangle(_pen, _cX, _cY, _sX, _sX);
                    break;
                case Tools.Square when _sX > 0 && _sY > 0 && _sX < _sY:
                    g.DrawRectangle(_pen, _cX, _cY, _sY, _sY);
                    break;
                /*case Tools.Square when _sX < 0 && _sY > 0 && Math.Abs(_sX) > Math.Abs(_sY):
                    g.DrawRectangle(_pen, _cX + _sX, _cY, Math.Abs(_sX), Math.Abs(_sX));
                    break;
                case Tools.Square when _sX < 0 && _sY > 0 && Math.Abs(_sX) < Math.Abs(_sY):
                    g.DrawRectangle(_pen, _cX + _sX, _cY, _sY, _sY);
                    break;
                case Tools.Square when _sX > 0 && _sY < 0 && Math.Abs(_sX) > Math.Abs(_sY):
                    g.DrawRectangle(_pen, _cX, _cY + _sY, _sX, _sX);
                    break;
                case Tools.Square when _sX > 0 && _sY < 0 && Math.Abs(_sX) < Math.Abs(_sY):
                    g.DrawRectangle(_pen, _cX, _cY + _sY, _sY, _sY);
                    break;
                case Tools.Square when _sX < 0 && _sY < 0 && Math.Abs(_sX) > Math.Abs(_sY):
                    g.DrawRectangle(_pen, _cX + _sX, _cY + _sY, Math.Abs(_sX), Math.Abs(_sX));
                    break;
                case Tools.Square when _sX < 0 && _sY < 0 && Math.Abs(_sX) < Math.Abs(_sY):
                    g.DrawRectangle(_pen, _cX + _sX, _cY + _sY, Math.Abs(_sY), Math.Abs(_sY));
                    break;*/
                case Tools.SquareFill when _sX > 0 && _sY > 0 && _sX > _sY:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, _sX);
                    break;
                case Tools.SquareFill when _sX > 0 && _sY > 0 && _sX < _sY:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sY, _sY);
                    break;

                default: return;
            }
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

            _pb.Refresh(); //move out from collection 
            _x  = e.X;
            _y  = e.Y;
            _sX = e.X - _cX;
            _sY = e.Y - _cY;
            lblCursorPos.Text = $@"{e.Location.X},{e.Location.Y}";   //отображение позиции курсора
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;

            _sX = _x - _cX;
            _sY = _y - _cY;

            switch (_currentTool)
            {
                case Tools.Line:
                    _gra.DrawLine(_pen, _cX, _cY, _x, _y);
                    break;
                case Tools.Ellipce:
                    _gra.DrawEllipse(_pen, _cX, _cY, _sX, _sY);
                    break;
                case Tools.EllipceFill:
                    _gra.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX,_cY,_sX,_sY);
                    break;
                case Tools.Rectangle:
                {
                    if (_sX < 0)
                    {
                        _cX += _sX;
                        _sX =  Math.Abs(_sX);
                    }
                    if (_sY<0)
                    {
                        _cY += _sY;
                        _sY =  Math.Abs(_sY);
                    }
                    
                    _gra.DrawRectangle(_pen, _cX, _cY, _sX, _sY);
                    break;
                }
                case Tools.RectangleFill:
                {
                    if (_sX < 0)
                    {
                        _cX += _sX;
                        _sX =  Math.Abs(_sX);
                    }

                    if (_sY < 0)
                    {
                        _cY += _sY;
                        _sY =  Math.Abs(_sY);
                    }

                    _gra.FillRectangle(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, _sY);
                    break;
                }
                case Tools.Circle when Math.Abs(_sX) > Math.Abs(_sY):
                    switch (_sX)
                    {
                        case > 0 when _sY > 0:
                        case < 0 when _sY < 0:
                            _gra.DrawEllipse(_pen, _cX, _cY, _sX, _sX);
                            break;
                        case > 0 when _sY < 0:
                            _gra.DrawEllipse(_pen, _cX, _cY, _sX, -_sX);
                            break;
                        default:
                            _gra.DrawEllipse(_pen, _cX, _cY, _sX, -_sX);
                            break;
                    }

                    break;
                case Tools.Circle:
                    switch (_sX)
                    {
                        case > 0 when _sY > 0:
                        case < 0 when _sY < 0:
                            _gra.DrawEllipse(_pen, _cX, _cY, _sY, _sY);
                            break;
                        case > 0 when _sY < 0:
                            _gra.DrawEllipse(_pen, _cX, _cY, -_sY, _sY);
                            break;
                        default:
                            _gra.DrawEllipse(_pen, _cX, _cY, -_sY, _sY);
                            break;
                    }

                    break;
                case Tools.CircleFill when Math.Abs(_sX) > Math.Abs(_sY):
                    switch (_sX)
                    {
                        case > 0 when _sY > 0:
                        case < 0 when _sY < 0:
                            _gra.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, _sX);
                            break;
                        case > 0 when _sY < 0:
                            _gra.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, -_sX);
                            break;
                        default:
                            _gra.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, -_sX);
                            break;
                    }

                    break;
                case Tools.CircleFill:
                    switch (_sX)
                    {
                        case > 0 when _sY > 0:
                        case < 0 when _sY < 0:
                            _gra.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sY, _sY);
                            break;
                        case > 0 when _sY < 0:
                            _gra.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, -_sY, _sY);
                            break;
                        default:
                            _gra.FillEllipse(new SolidBrush(Settings.LastUseColor), _cX, _cY, -_sY, _sY);
                            break;
                    }

                    break;
                //квадрат рисуется только в 1 сторону
                /*if (_sX < 0)
                {
                    _cX += Math.Abs(_sX) > Math.Abs(_sY)? _sX : _sY;
                    _sX =  Math.Abs(_sX) > Math.Abs(_sY)? Math.Abs(_sX) : Math.Abs(_sY);
                }
                if (_sY < 0)
                {
                    _cY += Math.Abs(_sY) > Math.Abs(_sX)? _sY : _sX;
                    _sY =  Math.Abs(_sX) > Math.Abs(_sY)? Math.Abs(_sX) : Math.Abs(_sY);
                }*/
                case Tools.Square when _sX > _sY:
                    _gra.DrawRectangle(_pen, _cX, _cY, _sX, _sX);
                    break;
                case Tools.Square:
                    _gra.DrawRectangle(_pen, _cX, _cY, _sY, _sY);
                    break;
                case Tools.SquareFill when _sX > _sY:
                    _gra.FillRectangle(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sX, _sX);
                    break;
                case Tools.SquareFill:
                    _gra.FillRectangle(new SolidBrush(Settings.LastUseColor), _cX, _cY, _sY, _sY);
                    break;
            }
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            _py = e.Location;
            _cX = e.X;
            _cY = e.Y;
        }
        
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pictures.Add(new Picture(new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)));
            AddNewTabPages(_pictures[^1]);
            Refresh();
        }
        private void tabControlPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
