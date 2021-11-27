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
            pb.Dock = DockStyle.Fill;               //свойство заполнения полностью 

            tp.Controls.Add(pb);                    //создание новой вкладки с объектом PictureBox
            tabControlPage.TabPages.Add(tp);
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
