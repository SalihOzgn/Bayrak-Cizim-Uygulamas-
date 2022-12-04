using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;


public class Class1
{
	public Class1()
	{
        private static float X(float t, float x_0, float x_1, float x_2, float x_3)
        {
            return (float)(
                x_0 * Math.Pow((1 - t), 3) +
                x_1 * 3 * t * Math.Pow((1 - t), 2) +
                x_2 * 3 * Math.Pow(t, 2) * (1 - t) +
                x_3 * Math.Pow(t, 3)
            );
        }
        private static float Y(float t, float y_0, float y_1, float y_2, float y_3)
        {
            return (float)(
                y_0 * Math.Pow((1 - t), 3) +
                y_1 * 3 * t * Math.Pow((1 - t), 2) +
                y_2 * 3 * Math.Pow(t, 2) * (1 - t) +
                y_3 * Math.Pow(t, 3)
            );
        }
    }
}
