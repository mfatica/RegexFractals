using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexFractals
{
    public partial class RegexFractalGenForm : Form
    {
        public RegexFractalGenForm()
        {
            InitializeComponent();
        }

        private void FractalColor_Click(object sender, EventArgs e)
        {
            ColorPicker.Color = FractalColor.BackColor;

            if (ColorPicker.ShowDialog() == DialogResult.OK)
                FractalColor.BackColor = ColorPicker.Color;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            RegexFractal rf = new RegexFractal(FractalRegex.Text, int.Parse(FractalSize.Text), FractalColor.BackColor);
            ImageDisplayBox.Image = rf.Image;
        }
    }
}
