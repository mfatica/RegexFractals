using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            MandelbrotFractal mbrot = new MandelbrotFractal(0.001f, 3, 256, 512);
            GenerateFractal.Text = "Processing. . .";
            GenerateFractal.Enabled = false;
            ImageDisplayBox.Image = mbrot.Image;
            GenerateFractal.Enabled = true;
            GenerateFractal.Text = "Generate";
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
             if(ImageDisplayBox.Image != null)
             {
                  SaveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|TIFF Image|*.tiff|All Files|*.*";
                  if (SaveDialog.ShowDialog() == DialogResult.OK)
                  {
                       ImageDisplayBox.Image.Save(SaveDialog.FileName, GetImageFormat(SaveDialog.FileName));
                  }
             }
        }

        private ImageFormat GetImageFormat(string filename)
        {
             filename = filename.Trim().ToLower();
             if (filename.Contains("png")) return ImageFormat.Png;
             if (filename.Contains("jpg") || filename.Contains("jpeg")) return ImageFormat.Jpeg;
             if (filename.Contains("bmp")) return ImageFormat.Bmp;
             if (filename.Contains("gif")) return ImageFormat.Gif;
             if (filename.Contains("tiff")) return ImageFormat.Tiff;

             return ImageFormat.Bmp;
        }

        private void StretchImage_CheckedChanged(object sender, EventArgs e)
        {
             if (StretchImage.Checked) ImageDisplayBox.SizeMode = PictureBoxSizeMode.StretchImage;
             if (!StretchImage.Checked) ImageDisplayBox.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
