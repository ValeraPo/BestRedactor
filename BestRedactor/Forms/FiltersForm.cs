using System;
using System.Windows.Forms;
using BestRedactor.Interface;
using BestRedactor.Logics;

namespace BestRedactor.Forms
{
    public partial class FiltersForm : Form
    {
        public FiltersForm(IPicture picture, MainForm mainForm)
        {
            InitializeComponent();
            pictureBox.Image = Logics.Resize.Resizing(picture, 0.3);
            this.Text = $"{pictureBox.Image.Width} || {pictureBox.Image.Height} || {picture.Bitmap.Width} || {picture.Bitmap.Height}";
            _picture = (Picture)picture;
            _main = mainForm;
        }
        private Picture _picture;
        private MainForm _main;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // код для обработки
            //MainForm = this.pictureBox.Image;
            _main.Refresh();
            Close();
        }
    }
}
