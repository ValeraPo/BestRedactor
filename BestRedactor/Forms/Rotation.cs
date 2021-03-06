using System;
using System.Windows.Forms;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Forms
{
    public partial class Rotation : Form
    {
        public Rotation(IPicture picture, MainForm mainForm)
        {
            InitializeComponent();
            _picture = (Picture)picture;
            _main = mainForm;
            _num = 0;
        }
        public Rotation()
        {
            InitializeComponent();
        }
        private readonly Picture _picture;
        private readonly MainForm _main;
        private int _num;
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text is null or "0")
                Close();
            _num = int.Parse(maskedTextBox.Text);
            if (!radioButRight.Checked)
            {
                _num = -_num;
            }
            _picture.Bitmap = Logics.Rotation.PictureRotationBy(_picture.Bitmap, _num);
            _main.RefreshAndSize();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
