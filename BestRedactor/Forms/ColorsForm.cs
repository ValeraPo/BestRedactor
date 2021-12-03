using System;
using System.Drawing;
using System.Windows.Forms;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Forms
{
    public partial class ColorsForm : Form
    {
        public ColorsForm(IPicture picture, MainForm mainForm)
        {
            InitializeComponent();
            _preView = Logics.Resize.Resizing(picture.Bitmap, (picture.Bitmap.Width > 1024 || picture.Bitmap.Height > 768) ? 0.3 : 1);
            pictureBox.Image = _preView;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Text = $"{pictureBox.Image.Width}X{pictureBox.Image.Height} || {picture.Bitmap.Width}X{picture.Bitmap.Height}";
            _picture = (Picture)picture;
            _main    = mainForm;
        }
        private Picture  _picture;
        private MainForm _main;
        private Bitmap _preView;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Общим метод для цветокора
            _main.Refresh();
            Close();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            pictureBox.Image = ColorBalance.R(_preView, trackBarRed.Value);
            pictureBox.Refresh();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            pictureBox.Image = ColorBalance.G(_preView, trackBarRed.Value);
            pictureBox.Refresh();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            pictureBox.Image = ColorBalance.B(_preView, trackBarRed.Value);
            pictureBox.Refresh();
        }
    }
}
