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

namespace BestRedactor.Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox.Image = bm;

        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_Color;


        private void btn_Rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            index = 5;  
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox.Image = bm;
            index = 0;
        }

        private void btn_SetColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_Color = cd.Color;
            
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }
        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Width / pb.Width;
            return new Point((int)(pt.X*pX),(int)(pt.Y*pY));
        }
        private void btn_pipette_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (index == 6)
            {
                Point pt = SetPoint(pictureBox, pictureBox.Location);   // косяк
                btn_pipette.BackColor = ((Bitmap)btn_pipette.Image).GetPixel(pt.X, pt.Y);
                new_Color = btn_pipette.BackColor;
                p.Color = btn_pipette.BackColor;
            }
        }

        // метод для поиска старого цвета до заливки формы новым цветом
        void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
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
            while(pixel.Count > 0)
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
            if (index == 7)
            {
                Point point = SetPoint(pictureBox, e.Location);
                Fill(bm, point.X, point.Y, new_Color);
            }
        }

        private void btn_Fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pictureBox.Width, pictureBox.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bm = new Bitmap(ofd.FileName);
                    pictureBox.Image = bm;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Ellipce_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }

            }
            pictureBox.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void btn_Pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_Eareser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }


    }
}
