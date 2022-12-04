using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    class Bezier_dogrusu
    {
        private static float X3(float t, float x_0, float x_1)
        {
            return (float)(
                x_0 * Math.Pow((1 - t), 1) +
                x_1 * Math.Pow(t, 1)
            );
        }
        private static float Y3(float t, float y_0, float y_1)
        {
            return (float)(
                y_0 * Math.Pow((1 - t), 1) +
                y_1 * Math.Pow(t, 1)
            );
        }

        public static void Bezier_Ciz(Graphics g, Pen kalem, float dt, PointF n_0, PointF n_1)
        {
            float t, x_0, y_0, x_1, y_1;
            t = 0.0f;
            x_1 = X3(t, n_0.X, n_1.X);
            y_1 = Y3(t, n_0.Y, n_1.Y);
            t += dt;

            while (t < 1.0)
            {
                x_0 = x_1;
                y_0 = y_1;
                x_1 = X3(t, n_0.X, n_1.X);
                y_1 = Y3(t, n_0.Y, n_1.Y);
                g.DrawLine(kalem, x_0, y_0, x_1, y_1);
                t += dt;
            }

            t = 1.0f;
            x_0 = x_1;
            y_0 = y_1;
            x_1 = X3(t, n_0.X, n_1.X);
            y_1 = Y3(t, n_0.Y, n_1.Y);
            g.DrawLine(kalem, x_0, y_0, x_1, y_1);

        }
    }
}
