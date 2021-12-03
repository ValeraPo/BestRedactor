using System;
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
            pictureBox.Image = Logics.Resize.Resizing(picture, (picture.Bitmap.Width > 1024 || picture.Bitmap.Height > 768) ? 0.3 : 1);
            Text = $"{pictureBox.Image.Width}X{pictureBox.Image.Height} || {picture.Bitmap.Width}X{picture.Bitmap.Height}";
            _picture = (Picture)picture;
            _main    = mainForm;
        }
        private Picture  _picture;
        private MainForm _main;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            _main.Refresh();
            Close();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            Logics.ColorBalance.R(_picture, trackBarRed.Value, 200);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            Logics.ColorBalance.G(_picture, trackBarRed.Value, 200);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            Logics.ColorBalance.B(_picture, trackBarRed.Value, 200);
        }
    }
}
