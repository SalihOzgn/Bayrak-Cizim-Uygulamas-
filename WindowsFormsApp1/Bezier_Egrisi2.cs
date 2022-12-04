using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    class Bezier_Egrisi2
    {
        private static float X2(float t, float x_0, float x_1, float x_2)
        {
            return (float)(
                x_0 * Math.Pow((1 - t), 2) +
                x_1 * 2 * t * Math.Pow((1 - t), 1) +
                x_2 * Math.Pow(t, 2)
            );
        }
        private static float Y2(float t, float y_0, float y_1, float y_2)
        {
            return (float)(
                y_0 * Math.Pow((1 - t), 2) +
                y_1 * 2 * t * Math.Pow((1 - t), 1) +
                y_2 * Math.Pow(t, 2)
            );
        }

        public static void Bezier_Ciz2(Graphics g, Pen kalem, float dt, PointF n_0, PointF n_1, PointF n_2)
        {
            float t, x_0, y_0, x_1, y_1;
            t = 0.0f;
            x_1 = X2(t, n_0.X, n_1.X, n_2.X);
            y_1 = Y2(t, n_0.Y, n_1.Y, n_2.Y);
            t += dt;

            while (t < 1.0)
            {
                x_0 = x_1;
                y_0 = y_1;
                x_1 = X2(t, n_0.X, n_1.X, n_2.X);
                y_1 = Y2(t, n_0.Y, n_1.Y, n_2.Y);
                g.DrawLine(kalem, x_0, y_0, x_1, y_1);
                t += dt;
            }

            t = 1.0f;
            x_0 = x_1;
            y_0 = y_1;
            x_1 = X2(t, n_0.X, n_1.X, n_2.X);
            y_1 = Y2(t, n_0.Y, n_1.Y, n_2.Y);
            g.DrawLine(kalem, x_0, y_0, x_1, y_1);

        }
    }
}
   