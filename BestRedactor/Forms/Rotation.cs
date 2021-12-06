using BestRedactor.Interface;
using BestRedactor.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private Picture _picture;
        private MainForm _main;
        private int _num;
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text == null || maskedTextBox.Text == "0")
                this.Close();
            _num = int.Parse(maskedTextBox.Text);
            if (!radioButRight.Checked)
            {
                _num = -_num;
            }
            _picture.Bitmap = Logics.Rotation.PictureRotationBy(_picture.Bitmap, _num);
            _main.RefreshAndSize();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
