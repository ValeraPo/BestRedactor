using System;
using System.Drawing;
using System.Windows.Forms;
using BestRedactor.Enums;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Forms
{
    internal delegate Bitmap FilterDel(Bitmap image, int poz);
    public sealed partial class FiltersForm : Form
    {
        public FiltersForm(IPicture picture, MainForm mainForm, Filters filters)
        {
            InitializeComponent();
            _preView = Logics.Resize.Resizing(picture.Bitmap, (picture.Bitmap.Width > 1024 || picture.Bitmap.Height > 768)? 0.3 : 1);
            pictureBox.Image = _preView;
            _picture = picture;
            _main = mainForm;
            
            switch (filters)
            {
                case Filters.Brightness:
                    Text = @"Изменение яркости";
                    label.Text = @"Яркость";
                    _fd = Intensity.Brightness;
                    break;
                case Filters.Contrast:
                    Text = @"Изменение контраста";
                    label.Text = @"Контраст";
                    _fd = Intensity.Contrast;
                    break;
            }
        }
        private IPicture  _picture;
        private MainForm  _main;
        private FilterDel _fd;
        private Bitmap    _preView;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _main._history.Push(_picture.Bitmap);
            _picture.Bitmap = _fd(_picture.Bitmap, trackBar.Value);
            _main.RefreshAndPbImage();
            Close();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            labelValue.Text = $@"{trackBar.Value - 100}";
            pictureBox.Image = _fd(_preView, trackBar.Value);
            pictureBox.Refresh();
        }
    }
}
