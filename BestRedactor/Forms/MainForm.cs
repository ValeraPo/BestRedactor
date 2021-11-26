using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            SetSize();
        }
        //https://www.youtube.com/watch?v=no0K2Mf1nG8
        private PictureBox GetPictureBox() // здесь прикрутить Bitmap
        {
            PictureBox pb = null;
            TabPage tp = tabControlPage.SelectedTab;

            if (tp != null)
            {
                pb = tp.Controls[0] as PictureBox;
            }

            return pb;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Nameless");   //поменять название созданного файла, если необходимо

            PictureBox pb = new PictureBox();       //создание объекта PictureBox, который позволяет рисовать
            pb.Dock = DockStyle.Fill;               //свойство заполнения = полностью 

            tp.Controls.Add(pb);                    //создание новой вкладки с объектом PictureBox
            tabControlPage.TabPages.Add(tp);
        }

        /// //////////////////////////// painting

        class ArrayPoints
        {
            int index = 0;
            Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0)
                    size = 2;
                points = new Point[size];
            }   // вынести в отдельный класс
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                    index = 0;
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPointIndex()
            {
                index = 0;
            }
            public int GetCountPoints()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }
        //.........................
        ArrayPoints arrayPoints = new ArrayPoints(2);
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);
        void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;  // установить(изменить) размер изображения!!!
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        bool isMousePressed = false;
        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePressed = true;
        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
            arrayPoints.ResetPointIndex();
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMousePressed)
                return;
            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                pb.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }
        // здесь прикрутить к меню open,save etc.
        //https://www.youtube.com/watch?v=dfeaEaO1mvw&list=PLS1QulWo1RIZrmdggzEKbhnfvCMHtT-sA&index=67

        // добавление кнопки закрыть вкладку:
        // https://social.technet.microsoft.com/wiki/contents/articles/50957.c-winform-tabcontrol-with-add-and-close-button.aspx
        // https://foxlearn.com/windows-forms/add-close-button-to-tab-control-in-csharp-471.html
        // добавление close() tab правой кнопкой мыши:
        // https://www.youtube.com/watch?v=DJu2ivQFooc

    }
}
