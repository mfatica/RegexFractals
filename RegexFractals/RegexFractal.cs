using System.Drawing;
using System.Text.RegularExpressions;

namespace RegexFractals
{
    class RegexFractal
    {
        private int _size;
        private string _ex;

        private Bitmap _image;
        private Color _color;
        private Regex _regex;

        public RegexFractal(string ex, int size, Color color)
        {
            _size = size;
            _ex = ex;

            _regex = new Regex(_ex);
            _color = color;
        }

        public Image Image
        {
            get
            {
                if (_image == null)
                {
                    _image = new Bitmap(_size, _size);
                    draw("", 0, _size - 1, 0, _size - 1);
                }

                return _image;
            }

            private set { }
        }

        private void draw(string pixel, int xmin, int xmax, int ymin, int ymax)
        {
            int xmid = (xmin + xmax) / 2;
            int ymid = (ymin + ymax) / 2;

            if (xmin == xmax)
            {
                Match match = _regex.Match(pixel);
                if(match.Success)
                {
                    float groupLength = 0;
                    foreach (Group group in match.Groups) groupLength += group.Length;

                    Color groupColor = CalculateGroupColor(groupLength / pixel.Length);
                    _image.SetPixel(xmin, ymin, groupColor);
                }
            }
            else
            {
                draw(pixel + "1", xmid + 1, xmax, ymid + 1, ymax);
                draw(pixel + "2", xmin, xmid, ymid + 1, ymax);
                draw(pixel + "3", xmin, xmid, ymin, ymid);
                draw(pixel + "4", xmid + 1, xmax, ymin, ymid);
            }
        }

        private Color CalculateGroupColor(float coefficient)
        {
            int _r = (int)(_color.R * coefficient) % (_color.R - 1);
            int _g = (int)(_color.G * coefficient) % (_color.G - 1);
            int _b = (int)(_color.B * coefficient) % (_color.B - 1);

            return Color.FromArgb(_r, _g, _b);
        }
    }
}
