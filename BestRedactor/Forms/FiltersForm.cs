using System;
using System.Drawing;
using System.Windows.Forms;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Forms
{
    internal delegate Bitmap FilterDel(Bitmap image, int poz);
    public sealed partial class FiltersForm : Form
    {
        public FiltersForm(IPicture picture, MainForm mainForm, MainForm.Filters filters)
        {
            InitializeComponent();
            _preView = Logics.Resize.Resizing(picture.Bitmap, (picture.Bitmap.Width > 1024 || picture.Bitmap.Height > 768)? 0.3 : 1);
            pictureBox.Image = _preView;
            Text = $"{pictureBox.Image.Width}X{pictureBox.Image.Height} || {picture.Bitmap.Width}X{picture.Bitmap.Height}";
            _picture = (Picture)picture;
            _main = mainForm;
            
            switch (filters)
            {
                case MainForm.Filters.Brightness:
                    label.Text = "Яркость";
                    _fd = Intensity.Brightness;
                    break;
                case MainForm.Filters.Contrast:
                    label.Text = "Контраст";
                    _fd = Intensity.Contrast;
                    break;
            }
        }
        private Picture _picture;
        private MainForm _main;
        private int _poz;
        private int _lenght;
        private FilterDel _fd;
        private Bitmap _preView;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _fd(_picture.Bitmap, trackBar.Value);
            _main.RefreshAndPbImage();
            Close();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            pictureBox.Image = _fd(_preView, trackBar.Value);
        }
    }
}
