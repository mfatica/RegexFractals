using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace RegexFractals
{
     class MandelbrotFractal
     {
          float _epsilon;
          int _maxIterations;
          int _maxColors;

          Bitmap _bitmap;
          Graphics _graphics;
          SolidBrush _brush;

          public MandelbrotFractal(float epsilon, int iterations, int colors, int size)
          {
               _epsilon = epsilon;
               _maxIterations = iterations;
               _maxColors = colors;

               _bitmap = new Bitmap(size, size);
               _graphics = Graphics.FromImage(_bitmap);
               _brush = new SolidBrush(Color.Black);
          }

          public Image Image
          {
               get
               {
                    Generate();
                    return _bitmap;
               }

               private set { }
          }

          private void Generate()
          {
               Complex z;
               Complex c;
               int iterations;
               float _x, _y;

               for(_x = 0; _x <= _bitmap.Width; _x+= _epsilon)
               {
                    for (_y = 0; _y <= _bitmap.Height; _y += _epsilon)
                    {
                         iterations = 0;
                         c = new Complex(_x, _y);
                         z = new Complex(0, 0);
                         while(Complex.Abs(z) < 2 && iterations < _maxIterations)
                         {
                              z = z * z + c;
                              iterations++;
                         }
                         _brush.Color = Color.FromArgb(_maxColors % _maxIterations);
                         _graphics.FillRectangle(_brush, _x, _y, _epsilon, _epsilon);
                    }
               }
          }
     }
}
