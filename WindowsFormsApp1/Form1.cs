using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private PointF[] Noktalar = new PointF[4];
        private PointF[] Nok = new PointF[3];
        private PointF[] No = new PointF[2];
        private PointF[] D = new PointF[2];
        private PointF[] D1 = new PointF[2];
        private PointF[] D2 = new PointF[2];
        private PointF[] D3 = new PointF[2];
        private PointF[] D4 = new PointF[2];
        private PointF[] D5 = new PointF[2];
        private PointF[] D6 = new PointF[2];
        private PointF[] D7 = new PointF[2];
        private PointF[] D8 = new PointF[2];
        private PointF[] D9 = new PointF[2];
        private PointF[] D10 = new PointF[2];
        private PointF[] Noktalar1 = new PointF[4];
        private PointF[] Noktalar2 = new PointF[4];

        private void button1_Click(object sender, EventArgs e)
        {
            Noktalar[0].X = 130;
            Noktalar[0].Y = 175;
            Noktalar[1].X = 50;
            Noktalar[1].Y = 180;
            Noktalar[2].X = 50;
            Noktalar[2].Y = 100;
            Noktalar[3].X = 130;
            Noktalar[3].Y = 100;
            Nok[0].X = 130;
            Nok[0].Y = 175;
            Nok[1].X = 50;
            Nok[1].Y = 140;
            Nok[2].X = 130;
            Nok[2].Y = 100;
            No[0].X = 190;
            No[0].Y = 105;
            No[1].X = 180;
            No[1].Y = 125;
            D[0].X = 190;
            D[0].Y = 105;
            D[1].X = 200;
            D[1].Y = 125;
            D1[0].X = 180;
            D1[0].Y = 125;
            D1[1].X = 160;
            D1[1].Y = 125;
            D2[0].X = 160;
            D2[0].Y = 125;
            D2[1].X = 177;
            D2[1].Y = 140;
            D3[0].X = 200;
            D3[0].Y = 125;
            D3[1].X = 220;
            D3[1].Y = 125;
            D4[0].X = 220;
            D4[0].Y = 125;
            D4[1].X = 203;
            D4[1].Y = 140;
            D5[0].X = 203;
            D5[0].Y = 140;
            D5[1].X = 213;
            D5[1].Y = 158;
            D6[0].X = 213;
            D6[0].Y = 158;
            D6[1].X = 190;
            D6[1].Y = 145;
            D7[0].X = 190;
            D7[0].Y = 145;
            D7[1].X = 168;
            D7[1].Y = 158;
            D8[0].X = 177;
            D8[0].Y = 140;
            D8[1].X = 168;
            D8[1].Y = 158;
            D9[0].X = 10;
            D9[0].Y = 50;
            D9[1].X = 10;
            D9[1].Y = 230;
            D10[0].X = 330;
            D10[0].Y = 50;
            D10[1].X = 330;
            D10[1].Y = 230;
            Noktalar1[0].X = 10;
            Noktalar1[0].Y = 50;
            Noktalar1[1].X = 155;
            Noktalar1[1].Y = 0;
            Noktalar1[2].X = 155;
            Noktalar1[2].Y = 80;
            Noktalar1[3].X = 330;
            Noktalar1[3].Y = 50;
            Noktalar2[0].X = 10;
            Noktalar2[0].Y = 230;
            Noktalar2[1].X = 155;
            Noktalar2[1].Y = 180;
            Noktalar2[2].X = 155;
            Noktalar2[2].Y = 260;
            Noktalar2[3].X = 330;
            Noktalar2[3].Y = 230;

            Cizim.Invalidate();

        }
        
       
        private void Cizim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Cizim.BackColor);
           
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);
            Bezier_Egrisi2.Bezier_Ciz2(e.Graphics, Pens.Red, 0.1f,
                Nok[0], Nok[1], Nok[2]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                No[0], No[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D[0], D[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D1[0], D1[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D2[0], D2[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D3[0], D3[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D4[0], D4[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D5[0], D5[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D6[0], D6[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D7[0], D7[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D8[0], D8[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D9[0], D9[1]);
            Bezier_dogrusu.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                D10[0], D10[1]);
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                Noktalar1[0], Noktalar1[1], Noktalar1[2], Noktalar1[3]);
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.1f,
                Noktalar2[0], Noktalar2[1], Noktalar2[2], Noktalar2[3]);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Noktalar[0].X = 0;
            Noktalar[0].Y = 0;
            Noktalar[1].X = 0;
            Noktalar[1].Y = 0;
            Noktalar[2].X = 0;
            Noktalar[2].Y = 0;
            Noktalar[3].X = 0;
            Noktalar[3].Y = 0;
            Nok[0].X = 0;
            Nok[0].Y = 0;
            Nok[1].X = 0;
            Nok[1].Y = 0;
            Nok[2].X = 0;
            Nok[2].Y = 0;
            No[0].X = 0;
            No[0].Y = 0;
            No[1].X = 0;
            No[1].Y = 0;
            D[0].X = 0;
            D[0].Y = 0;
            D[1].X = 0;
            D[1].Y = 0;
            D1[0].X = 0;
            D1[0].Y = 0;
            D1[1].X = 0;
            D1[1].Y = 0;
            D2[0].X = 0;
            D2[0].Y = 0;
            D2[1].X = 0;
            D2[1].Y = 0;
            D3[0].X = 0;
            D3[0].Y = 0;
            D3[1].X = 0;
            D3[1].Y = 0;
            D4[0].X = 0;
            D4[0].Y = 0;
            D4[1].X = 0;
            D4[1].Y = 0;
            D5[0].X = 0;
            D5[0].Y = 0;
            D5[1].X = 0;
            D5[1].Y = 0;
            D6[0].X = 0;
            D6[0].Y = 0;
            D6[1].X = 0;
            D6[1].Y = 0;
            D7[0].X = 0;
            D7[0].Y = 0;
            D7[1].X = 0;
            D7[1].Y = 0;
            D8[0].X = 0;
            D8[0].Y = 0;
            D8[1].X = 0;
            D8[1].Y = 0;
            D9[0].X = 0;
            D9[0].Y = 0;
            D9[1].X = 0;
            D9[1].Y = 0;
            D10[0].X = 0;
            D10[0].Y = 0;
            D10[1].X = 0;
            D10[1].Y = 0;
            Noktalar1[0].X = 0;
            Noktalar1[0].Y = 0;
            Noktalar1[1].X = 0;
            Noktalar1[1].Y = 0;
            Noktalar1[2].X = 0;
            Noktalar1[2].Y = 0;
            Noktalar1[3].X = 0;
            Noktalar1[3].Y = 0;
            Noktalar2[0].X = 0;
            Noktalar2[0].Y = 0;
            Noktalar2[1].X = 0;
            Noktalar2[1].Y = 0;
            Noktalar2[2].X = 0;
            Noktalar2[2].Y = 0;
            Noktalar2[3].X = 0;
            Noktalar2[3].Y = 0;

            Cizim.Invalidate();
        }
    }
}