using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestRedactor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pictureBox0.Width, pictureBox0.Height);
            gra = Graphics.FromImage(bm);
            gra.Clear(Color.Transparent);
            pictureBox0.Image = bm;
        }
        Bitmap bm;
        Graphics gra;
        bool isMouseDown = false;
        Point px, py;
        int thickness = 1;
        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);

        enum Tools { Cursor, Pencil, Erase, Ellipce, Rectangle, Line, Pipette, Fill, };
        Tools currentTool = 0;
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color newColor;

        private void tsBtnBrush_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Pencil;
        }

        private void tsBtnPen_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Pencil;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if (currentTool == Tools.Pencil)
                {
                    px = e.Location;
                    gra.DrawLine(pen, px, py);
                    py = px;
                }
                if (currentTool == Tools.Erase)
                {
                    px = e.Location;
                    gra.DrawLine(erase, px, py);
                    py = px;
                }

            }
            pictureBox0.Refresh();  //move out from collection 
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void tsBtnEraser_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Erase;
        }

        private void tsBtnMenuItemEllipce_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Ellipce;
        }

        private void tsBtnMenuItemLine_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Line;
        }

        private void tsBtnMenuItemRect_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Rectangle;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gra.Clear(Color.White);
            pictureBox0.Image = bm;             //from collections
            currentTool = Tools.Cursor;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pictureBox0.Width, pictureBox0.Height), bm.PixelFormat);//from collections
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bm = new Bitmap(ofd.FileName);
                    pictureBox0.Image = bm;         //from collection
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsBtnFill_Click(object sender, EventArgs e)
        {
            currentTool = Tools.Fill;
        }
        // метод для поиска старого цвета до заливки формы новым цветом
        void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color newColor)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, newColor);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_col)
        {
            Color old_col = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_col);
            if (old_col == new_col)
                return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_col, new_col);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_col, new_col);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_col, new_col);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_col, new_col);
                }
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentTool == Tools.Fill)
            {
                Point point = SetPoint(pictureBox0, e.Location);        // collection
                Fill(bm, point.X, point.Y, newColor);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (currentTool == Tools.Pipette)
            {
                Point pt = SetPoint(pictureBox0, pictureBox0.Location);   // косяк
                tsBtnPipette.BackColor = ((Bitmap)tsBtnPipette.Image).GetPixel(pt.X, pt.Y);
                newColor = tsBtnPipette.BackColor;
                pen.Color = tsBtnPipette.BackColor;
            }
        }
        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Width / pb.Width;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            sX = x - cX;
            sY = y - cY;

            if (currentTool == Tools.Ellipce)
            {
                gra.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (currentTool == Tools.Rectangle)
            {
                gra.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (currentTool == Tools.Line)
            {
                gra.DrawLine(pen, cX, cY, x, y);
            }
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
        }

        

        //https://www.youtube.com/watch?v=no0K2Mf1nG8
        private PictureBox GetPictureBox() 
        {
            PictureBox pb = null;
            TabPage tp = tabControlPage.SelectedTab;

            if (tp != null)
            {
                pb = tp.Controls[0] as PictureBox;
            }

            return pb;
        }
        List<Bitmap> bitmaps = new List<Bitmap>();
        
        void AddBitmaps(int height, int width)
        {
            bitmaps.Add(new Bitmap(height, width));
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Nameless");   

            PictureBox pb = new PictureBox();       
            //pb.Dock = DockStyle.Fill;               

            //this.tabPage1.Controls.Add(this.pb);
            tp.Location = new System.Drawing.Point(4, 24);
            tp.Name = "tabPage1";
            tp.Padding = new System.Windows.Forms.Padding(3);
            tp.Size = new System.Drawing.Size(744, 373);
            tp.TabIndex = 0;
            tp.Text = "tabPage1";
            tp.UseVisualStyleBackColor = true;
            //
            pb.Location = new System.Drawing.Point(42, 38);
            pb.Name = "pb1";
            pb.Size = new System.Drawing.Size(621, 232);
            pb.TabIndex = 0;
            pb.TabStop = false;
            //pb.MouseDown += new System.Windows.Forms.MouseEventHandler(pb_MouseDown);
            //pb.MouseMove += new System.Windows.Forms.MouseEventHandler(pb_MouseMove);
            //pb.MouseUp += new System.Windows.Forms.MouseEventHandler(pb_MouseUp);

            tp.Controls.Add(pb);                    //создание новой вкладки с объектом PictureBox
            tabControlPage.TabPages.Add(tp);
            //SetSize();
        }
        #region Old
        ///// //////////////////////////// painting

        //class ArrayPoints // вынести в отдельный файл
        //{
        //    int index = 0;
        //    Point[] points;

        //    public ArrayPoints(int size)
        //    {
        //        if (size <= 0)
        //            size = 2;
        //        points = new Point[size];
        //    }   
        //    public void SetPoint(int x, int y)
        //    {
        //        if (index >= points.Length)
        //            index = 0;
        //        points[index] = new Point(x, y);
        //        index++;
        //    }
        //    public void ResetPointIndex()
        //    {
        //        index = 0;
        //    }
        //    public int GetCountPoints()
        //    {
        //        return index;
        //    }
        //    public Point[] GetPoints()
        //    {
        //        return points;
        //    }
        //}
        ////.........................
        //ArrayPoints arrayPoints = new ArrayPoints(2);
        
        //Bitmap map = new Bitmap(100, 100);
        
        //Graphics graphics;
        //Pen pen = new Pen(Color.Black, 3f);
        //void SetSize()
        //{
        //    Rectangle rectangle = Screen.PrimaryScreen.Bounds;  // установить(изменить) размер изображения!!!
        //    map = new Bitmap(rectangle.Width, rectangle.Height);
        //    graphics = Graphics.FromImage(map);
        //    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        //    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        //}
        //bool isMousePressed = false;
        //private void pb_MouseDown(object sender, MouseEventArgs e)
        //{
        //    isMousePressed = true;
        //}

        //private void pb_MouseUp(object sender, MouseEventArgs e)
        //{
        //    isMousePressed = false;
        //    arrayPoints.ResetPointIndex();
        //}

        //private void pb_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (!isMousePressed)
        //        return;
        //    arrayPoints.SetPoint(e.X, e.Y);
        //    if (arrayPoints.GetCountPoints() >= 2)
        //    {
        //        graphics.DrawLines(pen, arrayPoints.GetPoints());
        //        GetPictureBox().Image = map;
        //        arrayPoints.SetPoint(e.X, e.Y);
        //    }
        //}

        //private void pb2_MouseDown(object sender, MouseEventArgs e)
        //{

        //}

        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        //// здесь прикрутить к меню open,save etc.
        ////https://www.youtube.com/watch?v=dfeaEaO1mvw&list=PLS1QulWo1RIZrmdggzEKbhnfvCMHtT-sA&index=67

        //// добавление кнопки закрыть вкладку:
        //// https://social.technet.microsoft.com/wiki/contents/articles/50957.c-winform-tabcontrol-with-add-and-close-button.aspx
        //// https://foxlearn.com/windows-forms/add-close-button-to-tab-control-in-csharp-471.html
        //// добавление close() tab правой кнопкой мыши:
        //// https://www.youtube.com/watch?v=DJu2ivQFooc
        #endregion
    }
}
