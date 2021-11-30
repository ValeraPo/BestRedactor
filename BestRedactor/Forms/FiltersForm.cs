using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            pictureBox.Image = picture.Bitmap;
            this.Text = $"{pictureBox.Image.Width} || {pictureBox.Image.Height} || {picture.Bitmap.Width} || {picture.Bitmap.Height}";
            _picture = (Picture)picture;
            _main = mainForm;
        }
        private Picture _picture;
        private MainForm _main;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // код для обработки
            //MainForm = this.pictureBox.Image;
            _main.Refresh();
            this.Close();
        }
    }
}
