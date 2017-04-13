using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UVRGvaja2
{
    public partial class Form1 : Form
    {
        const int POZ = 1;
        const int NEG = -1;
        const int KOL = 0;
        List<PointF> pts;
        List<PointF> hull = new List<PointF>();
        Graphics g;
        SolidBrush brush = new SolidBrush(Color.IndianRed);
        Pen hullPen = new Pen(Color.SpringGreen);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int numOfPts;
            if (!string.IsNullOrEmpty(tbNumPts.Text))
            {
                numOfPts = int.Parse(tbNumPts.Text);
                pts = new List<PointF>();
                pts.Clear();
                pictureBox1.Refresh();
                DateTime start = DateTime.Now;
                if (rbNormal.Checked)
                {
                    normalDistribution(numOfPts);
                    DateTime end = DateTime.Now;
                    TimeSpan time = end - start;
                    tbTime.Text += "Cas risanja tock: " + time.Milliseconds + "ms.\r\n";
                }
                else if (rbEqual.Checked)
                {
                    equalDistribution(numOfPts);
                    DateTime end = DateTime.Now;
                    TimeSpan time = end - start;
                    tbTime.Text += "Cas risanja tock: " + time.Milliseconds + "ms.\r\n";
                }
                else
                {
                    MessageBox.Show("Izberite kaksno razdelitev tock zelite!");
                }
            }
            else
            {
                MessageBox.Show("Vnesi stevilo tock!");
            }

        }
        private void normalDistribution(int num)
        {
            g = Graphics.FromHwnd(pictureBox1.Handle);
            Random rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                double x = rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble();
                x /= 4;
                double y = rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble();
                y /= 4;
                PointF point = new PointF((float)(x * 600), (float)(y * 600));
                pts.Add(point);
                g.FillRectangle(brush, pts[i].X, pts[i].Y, 3, 3);
            }
            g.Dispose();
        }
        private void equalDistribution(int num)
        {
            g = Graphics.FromHwnd(pictureBox1.Handle);
            Random rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();
                PointF point = new PointF((float)(x * 500) + 50, (float)(y * 500) + 50);
                pts.Add(point);
                g.FillRectangle(brush, pts[i].X, pts[i].Y, 3, 3);
            }
            g.Dispose();
        }

        private void jarvisMarch()
        {
            DateTime start = DateTime.Now;
            if (pts.Count < 3)
            {
                MessageBox.Show("Vnesiti morate vsaj 3 tocke!");
            }
            else
            {
                g = Graphics.FromHwnd(pictureBox1.Handle);
                hull.Clear();
                PointF maxYpoint = pts[0];
                PointF minYpoint = pts[0];
                PointF maxAnglePoint;
                PointF minAnglePoint;
                for (int i = 0; i < pts.Count; i++)
                {
                    if (pts[i].Y > maxYpoint.Y)
                    {
                        maxYpoint = pts[i];
                    }
                    if (pts[i].Y < minYpoint.Y)
                    {
                        minYpoint = pts[i];
                    }
                }
                hull.Add(minYpoint);
                PointF tempPoint = minYpoint;
                while (tempPoint != maxYpoint)
                {
                    maxAnglePoint = tempPoint;
                    for (int i = 0; i < pts.Count; i++)
                    {
                        if ((findAngle(tempPoint, maxAnglePoint) < findAngle(tempPoint, pts[i]) && (!hull.Contains(pts[i]) || pts[i] == maxYpoint)) && findAngle(tempPoint, pts[i]) <= 270)
                        {
                            maxAnglePoint = pts[i];
                        }
                    }
                    g.DrawLine(hullPen, tempPoint, maxAnglePoint);
                    tempPoint = maxAnglePoint;
                    hull.Add(tempPoint);

                }
                tempPoint = minYpoint;
                while (tempPoint != maxYpoint)
                {
                    minAnglePoint = maxYpoint;
                    for (int i = 0; i < pts.Count; i++)
                    {
                        if (findAngle(tempPoint, minAnglePoint) > findAngle(tempPoint, pts[i]) && (!hull.Contains(pts[i]) || pts[i] == maxYpoint) && findAngle(tempPoint, pts[i]) >= 90)
                        {
                            minAnglePoint = pts[i];
                        }
                    }
                    g.DrawLine(hullPen, tempPoint, minAnglePoint);
                    tempPoint = minAnglePoint;
                    if (tempPoint == maxYpoint)
                    {
                        break;
                    }
                    else
                        hull.Add(tempPoint);
                }
            }
            g.Dispose();
            DateTime end = DateTime.Now;
            TimeSpan time = end - start;
            tbTime.Text += "Jarvisov obhod: " + time.Milliseconds + "ms.\r\n";
        }
        private void grahamScan()
        {
            if (pts.Count < 3)
            {
                MessageBox.Show("Vnesiti morate vsaj 3 tocke!");
            }
            else
            {
                hull.Clear();
                DateTime start = DateTime.Now;
                g = Graphics.FromHwnd(pictureBox1.Handle);
                PointF temp = new PointF(pts[0].X, pts[0].Y);
                int indeks = 0;
                for (int i = 0; i < pts.Count; i++)
                {
                    if (pts[i].Y < temp.Y)
                    {
                        temp = pts[i];
                        indeks = i;
                    }
                    else if (pts[i].Y == temp.Y)
                    {
                        if (pts[i].X < temp.X)
                        {
                            temp = pts[i];
                            indeks = i;
                        }
                    }
                }
                double[] angles = new double[pts.Count];
                angles[indeks] = -1;
                for (int i = 0; i < pts.Count; i++)
                {
                    if (i == indeks)
                        continue;
                    angles[i] = grahamKot(i, indeks);
                }
                PointF[] ptsArray = pts.ToArray();
                Array.Sort(angles, ptsArray);
                pts = new List<PointF>(ptsArray);
                List<double> angleList = new List<double>(angles);
                for (int i = pts.Count - 1; i > 0; i--)
                {
                    if (angleList[i] == angleList[i - 1])
                    {
                        if (razdalja(pts[i], pts[0]) < razdalja(pts[i - 1], pts[0]))
                        {
                            pts.RemoveAt(i);
                            angleList.RemoveAt(i);
                        }
                        else
                        {
                            pts.RemoveAt(i - 1);
                            angleList.RemoveAt(i - 1);
                        }
                    }
                }
                pts.Insert(0, pts[pts.Count - 1]);
                int p = 1;
                for (int i = 2; i < pts.Count; i++)
                {
                    while (orientacija(pts[p - 1], pts[p], pts[i]) <= KOL)
                    {
                        if (p > 1)
                            p--;
                        else if (i == pts.Count)
                            break;
                        else
                            i++;
                    }
                    p++;
                    PointF tempPoint = pts[i];
                    pts[i] = pts[p];
                    pts[p] = tempPoint;
                }
                for (int i = 0; i < p; i++)
                {
                    hull.Add(pts[i]);
                }
                for (int i = 0; i < p - 1; i++)
                {
                    g.DrawLine(hullPen, hull[i], hull[i + 1]);
                }
                g.DrawLine(hullPen, hull[0], hull[p - 1]);

                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                tbTime.Text += "Graham: " + time.Milliseconds + "ms.\r\n";
                g.Dispose();
            }
        }


        private void btnHull_Click(object sender, EventArgs e)
        {
            if (rbJarvis.Checked)
            {
                jarvisMarch();
            }
            if (rbGraham.Checked)
            {
                grahamScan();
            }
        }
        double findAngle(PointF a, PointF b)
        {
            float vector1 = b.X - a.X;
            float vector2 = b.Y - a.Y;

            if (Math.Abs(vector1) < 0.0001 && Math.Abs(vector2) < 0.0001)
                return 0;

            double angle = Math.Atan(vector2 / vector1) * 180.0 / 3.141592;
            if (vector1 >= 0 && vector2 >= 0)
                angle = 90 + angle;
            else if (vector1 >= 0 && vector2 < 0)
                angle = 90 + angle;
            else if (vector1 < 0 && vector2 > 0)
                angle = 270 + angle;
            else if (vector1 < 0 && vector2 <= 0)
                angle = 270 + angle;
            return angle;

        }
        int orientacija(PointF p, PointF p1, PointF p2)
        {
            float produkt = (p1.X - p.X) * (p2.Y - p.Y) - (p1.Y - p.Y) * (p2.X - p.X); //(p1- p)x(p2 - p)
            if (Math.Abs(produkt) < 0.0001) return KOL;
            return produkt > 0.0001 ? POZ : NEG;
        }
        double grahamKot(int x, int start)
        {
            PointF temp = new PointF(pts[x].X - pts[start].X, pts[x].Y - pts[start].Y);
            return Math.Acos(temp.X / Math.Sqrt(temp.X * temp.X + temp.Y * temp.Y));
        }
        double razdalja(PointF p1, PointF p2)
        {
            double distance = 0;
            distance = (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
            distance = Math.Sqrt(Math.Abs(distance));
            return distance;
        }
    }
}
