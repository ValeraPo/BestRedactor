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
    public partial class ColorsForm : Form
    {
        public ColorsForm(IPicture picture, MainForm mainForm)
        {
            InitializeComponent();
            pictureBox.Image = picture.Bitmap;
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
            // код для обработки
            //MainForm = this.pictureBox.Image;
            _main.Refresh();
            Close();
        }
    }
}
