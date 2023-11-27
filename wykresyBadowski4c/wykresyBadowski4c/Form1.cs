using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wykresyBadowski4c
{
    public partial class Form1 : Form
    {
        int A = 0;
        int B = 0;
        bool test = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void wykres_Paint(object sender, PaintEventArgs e)
        {
            Graphics gdi = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            Pen pNew = new Pen(Color.Gray, 1);
            Point p1 = new Point(0, 200);
            Point p2 = new Point(400, 200);
            Point p3 = new Point(200, 0);
            Point p4 = new Point(200, 400);
            gdi.DrawLine(p, p1, p2);
            gdi.DrawLine(p, p3, p4);
            int i = 0;
            while (i <= 400)
            {
                gdi.DrawLine(pNew, i - 1, -1, i - 1, 399);
                gdi.DrawLine(pNew, 0, i, 400, i);
                if (i == 0)
                {
                    gdi.DrawLine(p, i + 1, 190, i + 1, 210);
                    gdi.DrawLine(p, 190, i + 1, 210, i + 1);
                    gdi.DrawLine(pNew, i, 0, i, 400);
                    gdi.DrawLine(p, 200, 0, 200, 0);
                }
                else if (i > 0 && i < 400)
                {
                    gdi.DrawLine(p, i, 190, i, 210);
                    gdi.DrawLine(p, 190, i, 210, i);
                }
                else if (i == 400)
                {
                    gdi.DrawLine(p, i + 1, 191, i + 1, 211);
                    gdi.DrawLine(pNew, -1, i - 1, 399, i - 1);
                    gdi.DrawLine(p, 189, i - 1, 209, i - 1);
                }
                i += 40;
                gdi.DrawLine(p, 390, 185, 400, 200);
                gdi.DrawLine(p, 390, 215, 400, 200);
                gdi.DrawLine(p, 215, 10, 200, 0);
                gdi.DrawLine(p, 185, 10, 200, 0);
            }
            if(test)
            {
                int xM5 = -5; // wspolrzedna x dla punktu x = -5 to 0, nwm co trzeba zrobic z y jeszcze
                int x5 = 5;// dla 5 jest to 400, jeden "krok" jest co 40 px
                int yxM5 = (A * xM5 + B) * 40; // dla xM5 = -5, A = 2 i B = 4, yxM5 = -6, czyli * 40 = -240 - wspolrzedna y to 440
                int yx5 = (A * x5 + B) * 40; // dla x5 = 5, A = 2 i B = 4, yx5 = 14, czyli * 40 = 560 - wspolrzedna y to -360
                yxM5 = yxM5 * (-1) + 200;
                yx5 = yx5 * (-1) + 200;
                Point start = new Point(0, yxM5);
                Point end = new Point(400, yx5);
                gdi.DrawLine(new Pen(Color.Red, 2), start, end);
                //mZerowe.Text = yx5 + " + " + yxM5;
            }
        }
        // https://itecnote.com/tecnote/c-button-click-eventargs-e-information/
        private void wykres_MouseMove(object sender, MouseEventArgs e)
        {
            //mZerowe.Text = "X: " + e.X + " Y: " + e.Y;
        }

        private void rysuj_Click(object sender, EventArgs e)
        {
            if (a.Text == null || a.Text == "" || b.Text == null || b.Text == "")
            {
                return;
            }
            try
            {
                A = Convert.ToInt32(a.Text);
                B = Convert.ToInt32(b.Text);
            } catch
            {
                mZerowe.Text = "Wprowadź liczbę całkowitą";
                return;
            }
            double aa = Convert.ToInt32(a.Text);
            double bb = Convert.ToInt32(b.Text);
            if (A > 0)
            {
                monotonicznosc.Text = "Monotoniczność: funkcja rosnąca";
            }
            else if (A < 0)
            {
                monotonicznosc.Text = "Monotoniczność: funkcja malejąca";
            }
            else
            {
                monotonicznosc.Text = "Monotoniczność: funkcja stała";
            }
            if(A == 0)
            {
                string miejsce0 = "Brak";
                mZerowe.Text = "Miejsce zerowe: " + miejsce0;
            } else
            {
                double miejsce0 = (-bb / aa);
                mZerowe.Text = "Miejsce zerowe: " + miejsce0;
            }
            //-----------------------------------------------------------------------------//
            test = true;
            wykres.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e) { }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //mZerowe.Text = "X: " + e.X + " Y: " + e.Y;
        }
    }
}
