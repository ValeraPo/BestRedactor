using System;
using BestRedactor.Logics;
using System.Windows.Forms;

namespace BestRedactor.Forms
{
    public partial class BrushSize : Form
    {
        public BrushSize()
        {
            InitializeComponent();
            textBoxSize.Text = $"{(int)Settings.LastUseSize}";
        }
        
        private void trackBarBrushSize_Scroll(object sender, EventArgs e)
        {
            textBoxSize.Text = $"{trackBarBrushSize.Value}";
            Settings.LastUseSize = float.Parse(textBoxSize.Text);
        }

        private void textBoxSize_KeyDown(object sender, KeyEventArgs e)
        {
            int val;
            if (e.KeyCode == Keys.Enter && int.TryParse(textBoxSize.Text, out val))
            {
                trackBarBrushSize.Value = val;
                trackBarBrushSize_Scroll(null, null);
            }
        }
    }
}
