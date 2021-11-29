using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BestRedactor.Logics;

namespace BestRedactor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
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
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Nameless");   //поменять название созданного файла, если необходимо

            PictureBox pb = new PictureBox();       //создание объекта PictureBox, который позволяет рисовать
            //pb.Dock = DockStyle.Fill;               //свойство заполнения = полностью 

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
            pb.MouseDown += new System.Windows.Forms.MouseEventHandler(pb_MouseDown);
            pb.MouseMove += new System.Windows.Forms.MouseEventHandler(pb_MouseMove);
            pb.MouseUp += new System.Windows.Forms.MouseEventHandler(pb_MouseUp);

            tp.Controls.Add(pb);                    //создание новой вкладки с объектом PictureBox
            tabControlPage.TabPages.Add(tp);
            SetSize();
        }

        /// //////////////////////////// painting

        class ArrayPoints // вынести в отдельный файл
        {
            int index = 0;
            Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0)
                    size = 2;
                points = new Point[size];
            }   
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
        List<Bitmap> bitmap;//
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
                GetPictureBox().Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }

        private void pb2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void timerAutoSave_Tick(object sender, EventArgs e)
        {
            List<Picture> openTabs = new(); //передать лист открытых вкладок
            AutoSave.Backup(openTabs);
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
