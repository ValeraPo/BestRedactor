using System;
using System.Windows.Forms;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Forms
{
    delegate IPicture FilterDel(IPicture image, int poz, int lenght);
    public partial class FiltersForm : Form
    {
        public FiltersForm(IPicture picture, MainForm mainForm, MainForm.Filters filters)
        {
            InitializeComponent();
            pictureBox.Image = Logics.Resize.Resizing(picture, (picture.Bitmap.Width > 1024 || picture.Bitmap.Height > 768) ? 0.3 : 1);
            this.Text = $"{pictureBox.Image.Width} || {pictureBox.Image.Height} || {picture.Bitmap.Width} || {picture.Bitmap.Height}";
            _picture = (Picture)picture;
            _main = mainForm;
            
            switch (filters)
            {
                case MainForm.Filters.Blur:
                    label.Text = "Размытие";
                    _fd = Logics.Precision.Blur;
                    break;
                case MainForm.Filters.Brightness:
                    label.Text = "Яркость";
                    _fd = Logics.Intensity.Brightness;
                    break;
                case MainForm.Filters.Contrast:
                    label.Text = "Контраст";
                    _fd = Logics.Intensity.Contrast;
                    break;
            }
        }
        private Picture _picture;
        private MainForm _main;
        int _poz; 
        int _lenght;
        FilterDel _fd;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _fd(_picture, trackBar.Value, 100);
            _main.Refresh();
            Close();
        }
    }
}
