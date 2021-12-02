using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Settings.OpenedTabs = 0;
            tsBtn_color1.BackColor = Settings.LastUseColor;
        }

        private Graphics _gra;
        private bool _isMouseDown;
        private Point _px, _py;
        private Pen _pen = new(Settings.LastUseColor, Settings.LastUseSize);
        private readonly Pen _erase = new(Color.Transparent, 10);
        private List<Picture> _pictures = new();
        private bool _isClickedColor;

        private enum Tools { Cursor, Pencil, Erase, Ellipce, Rectangle, Line, Pipette, Fill, Brush };
        private Tools _currentTool = 0;
        private int _x, _y, _sX, _sY, _cX, _cY;
        private ColorDialog _cd = new();
        

        private void tsBtnBrush_Click(object sender, EventArgs e) => _currentTool = Tools.Pencil;
        private void tsBtnPen_Click(object sender, EventArgs e) => _currentTool = Tools.Pencil;
        private void tsBtnEraser_Click(object sender, EventArgs e) => _currentTool = Tools.Erase;
        private void tsBtnMenuItemEllipce_Click(object sender, EventArgs e) => _currentTool = Tools.Ellipce;
        private void tsBtnMenuItemLine_Click(object sender, EventArgs e) => _currentTool = Tools.Line;
        private void tsBtnMenuItemRect_Click(object sender, EventArgs e) => _currentTool = Tools.Rectangle;
        private void tsBtnFill_Click(object sender, EventArgs e) => _currentTool = Tools.Fill;
        private void tsBtnPipette_Click(object sender, EventArgs e) => _currentTool = Tools.Pipette;
        
        
       
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gra.Clear(Color.Transparent);
            _currentTool = Tools.Cursor;
        }


        private void timerAutoSave_Tick(object sender, EventArgs e) => AutoSave.Backup(_pictures);
        private void toolStripMenuItem1_Click(object sender, EventArgs e) => FileManagerL.Save(_pictures[tabControlPage.SelectedIndex]);
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
            sfd.FilterIndex = _pictures[tabControlPage.SelectedIndex].ImageFormat.ToString().ToLower() switch
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
                _pictures[tabControlPage.SelectedIndex].ImageFormat = sfd.FilterIndex switch
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
                FileManagerL.SaveAs(_pictures[tabControlPage.SelectedIndex], sfd.FileName);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Невозможно открыть выбранный файл!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddNewTabPages(IPicture picture)
        {
            TabPage tp = new TabPage(picture.FileName);
            PictureBox pb = new PictureBox();

            tp.BorderStyle             = BorderStyle.Fixed3D;
            tp.Location                = new Point(0, 0);
            tp.ForeColor               = SystemColors.ControlText;
            tp.Name                    = $"tabPage{Settings.OpenedTabs}";
            tp.Padding                 = new Padding(3);
            tp.Size                    = new Size(picture.Bitmap.Width, picture.Bitmap.Height);
            tp.TabIndex                = Settings.OpenedTabs;
            tp.UseVisualStyleBackColor = true;
            //
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
            tabControlPage.Size = new Size(_pictures[tabControlPage.SelectedIndex].Bitmap.Width + 12,
                _pictures[tabControlPage.SelectedIndex].Bitmap.Height + 32);
            Settings.OpenedTabs += 1;
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
        public void Fill(Bitmap bm, int x, int y, Color newCol)
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

        
        
        private void drDBtnTSMenuItIncreaseContrast_Click(object sender, EventArgs e) => new FiltersForm(_pictures[tabControlPage.SelectedIndex], this).ShowDialog();
        private void drDBtnTSMenuItBlur_Click(object sender, EventArgs e) => new FiltersForm(_pictures[tabControlPage.SelectedIndex], this).ShowDialog();
        private void drDBtnTSMenuItBright_Click(object sender, EventArgs e) => new FiltersForm(_pictures[tabControlPage.SelectedIndex], this).ShowDialog();
        public void Refresh()
        {
            tabControlPage.SelectedTab.Controls[0].Refresh();
            _gra = Graphics.FromImage(_pictures[tabControlPage.SelectedIndex].Bitmap);
        }
        

        private void drDBtnTSMenuItColors_Click(object sender, EventArgs e)
        {
            ColorsForm cf = new ColorsForm(_pictures[tabControlPage.SelectedIndex], this);
            cf.ShowDialog();
            cf.pictureBox.Image = pictureBox.Image;
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
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void lblCursorPos_Click(object sender, EventArgs e)
        {

        }
        private void drDBtnTSMenuItSharpness_Click(object sender, EventArgs e)
        {

        }

        
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (_currentTool == Tools.Fill)
                Fill(_pictures[tabControlPage.SelectedIndex].Bitmap, e.X, e.Y, Settings.LastUseColor);
            if (_currentTool != Tools.Pipette)
                return;
            Settings.LastUseColor  = _pictures[tabControlPage.SelectedIndex].Bitmap.GetPixel(e.X, e.Y);
            _pen.Color             = Settings.LastUseColor;
            tsBtn_color1.BackColor = Settings.LastUseColor;
        }
        private void PbPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            if (!_isMouseDown)
                return;
            switch (_currentTool)
            {
                case Tools.Ellipce:
                    g.DrawEllipse(_pen, _cX, _cY, _sX, _sY);
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
                case Tools.Line:
                    g.DrawLine(_pen, _cX, _cY, _x, _y);
                    break;
            }
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {

            if (_isMouseDown)
            {
                if (_currentTool == Tools.Pencil)
                {
                    _px = e.Location;
                    _gra.DrawLine(_pen, _px, _py);
                    _py = _px;
                }

                if (_currentTool == Tools.Erase)
                {
                    _px = e.Location;
                    _gra.DrawLine(_erase, _px, _py);
                    _py = _px;
                }

            }

            tabControlPage.SelectedTab.Controls[0].Refresh(); //move out from collection 
            _x  = e.X;
            _y  = e.Y;
            _sX = e.X - _cX;
            _sY = e.Y - _cY;
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;

            _sX = _x - _cX;
            _sY = _y - _cY;

            if (_currentTool == Tools.Ellipce)
            {
                _gra.DrawEllipse(_pen, _cX, _cY, _sX, _sY);
            }
            if (_currentTool == Tools.Rectangle)
            {
                if (_sX < 0)
                {
                    _cX += _sX;
                    _sX = Math.Abs(_sX);
                }
                if (_sY<0)
                {
                    _cY += _sY;
                    _sY = Math.Abs(_sY);
                }
                    
                _gra.DrawRectangle(_pen, _cX, _cY, _sX, _sY);
            }
            if (_currentTool == Tools.Line)
            {
                _gra.DrawLine(_pen, _cX, _cY, _x, _y);
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
            tabControlPage.Size = new Size(_pictures[tabControlPage.SelectedIndex].Bitmap.Width + 12,
                _pictures[tabControlPage.SelectedIndex].Bitmap.Height + 32);
            tabControlPage.SelectedTab.Controls[0].Refresh();
            _gra = Graphics.FromImage(_pictures[tabControlPage.SelectedIndex].Bitmap);
        }
    }
}
