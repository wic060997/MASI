using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Uniterm
{

    public class MyDrawing
    {

        #region Fields

        public static Pen pen
        {
            get
            {
                return new Pen(Brushes.SteelBlue, (int)Math.Log(fontsize, 3));
            }
        }

        private static Brush br = Brushes.White;

        public static FontFamily fontFamily = new FontFamily("Arial");

        public static /*double*/ Int32 fontsize = 12;

        public static string zA, zB, zOp;

        public static string eA, eB, eC;

        public static char oper = ' ';


        public static int FS = 12;

        public static int endPointY;

        public DrawingContext dc;
        #endregion

        #region Initalizers

        public MyDrawing(DrawingContext drawingContext)
        {
            dc = drawingContext;
            endPointY = 0;
        }

        #endregion

        #region Public Methods

        public void Redraw()
        {
            if (oper != ' ')
            {
                endPointY = 0;
                DrawSwitched(new Point(20, endPointY + 30));
            }
            else
            {
                if (String.IsNullOrEmpty(eA) != true)
                {
                    DrawElim(new Point(30, endPointY + 30));
                }
                if (String.IsNullOrEmpty(zA) != true)
                {
                    drawZrow(new Point(30, endPointY + 30));
                }
            }
        }

        public static void ClearAll()
        {
            zA = zB = zOp = "";
            eA = eB = eC = "";
            oper = ' ';
        }
        /*
        public void DrawSek(Point pt)
        {
            if (zA == "" || zOp == "") return;
            int len = GetTextLength(zA + zOp + zB);

            DrawText(pt, zA + zOp + zB);
            DrawBezier(new Point(pt.X, pt.Y - 1), len);
        }
        */

        public bool drawZrow(Point pt)
        {
            if (zA == null || zOp == null) return false;
            if (zA == "" || zOp == "") return false;

            int h = GetTextHeight("test");

            string text = zA + Environment.NewLine.ToString()
                + zOp + Environment.NewLine.ToString()
                + zB;

            double len = GetTextHeight(text) + 2;

            DrawText(new Point(pt.X + 2, pt.Y), text);
            DrawVerZrow(pt, (int)len);
            return true;
        }

        public bool DrawElim(Point pt)
        {
            if (eA == null || eB == null || eC == null ) return false;
            if (eA == "" || eB == "" || eC == "") return false;

            Point p2 = new Point(pt.X + 2, pt.Y);
            string text = eA + Environment.NewLine.ToString() + ";" + Environment.NewLine.ToString() +
                eB + Environment.NewLine.ToString() +
                ";" + Environment.NewLine.ToString() + eC;

            double l = GetTextHeight(text) + 2;

            DrawText(p2, text);
            DrawVert(pt, (int)l);

            return true;
        }

        public void DrawSwitched(Point pt)
        {
            string textZrow = zA + Environment.NewLine.ToString()
                + zOp + Environment.NewLine.ToString()
                + zB;

            int lenght = GetTextHeight(textZrow);

            if (oper == 'A')
            {
                drawZrow(new Point(pt.X + 5, pt.Y + 3));
                int lenghtT = GetTextHeight(zA + Environment.NewLine.ToString()
                + zOp + Environment.NewLine.ToString()
                + zB);

                DrawText(new Point(pt.X + 5, pt.X + lenghtT + (fontsize / 3) + 10), ";" + Environment.NewLine.ToString() +
                eB + Environment.NewLine.ToString() +
                ";" + Environment.NewLine.ToString() + eC);

                lenght += GetTextHeight(zA + Environment.NewLine.ToString()
                + zOp + Environment.NewLine.ToString()
                + zB) + (int)(fontsize / 3) * 5 - 5;
            }
            if (oper == 'B')
            {
                DrawText(new Point(pt.X + 5, pt.Y), eA + Environment.NewLine.ToString() + ";");
                drawZrow(new Point(pt.X + 5, pt.Y + GetTextHeight(eA + Environment.NewLine.ToString() + ";") + (fontsize / 3)));

                lenght += GetTextHeight(zA + Environment.NewLine.ToString()
                    + zOp + Environment.NewLine.ToString()
                    + zB) + (int)(fontsize / 3) * 5 - 5;

                int dl = GetTextHeight(eA + Environment.NewLine.ToString() + ";") + (fontsize / 3) + GetTextHeight(zA + Environment.NewLine.ToString()
                    + zOp + Environment.NewLine.ToString()
                    + zB);
                DrawText(new Point(pt.X + 5, pt.Y + dl), ";" + Environment.NewLine.ToString() + eC);
            }
            if (oper == 'C')
            {
                DrawText(new Point(pt.X + 5, pt.Y), eA + Environment.NewLine.ToString() + ";" + Environment.NewLine.ToString() + eB + Environment.NewLine.ToString() + ";");
                int dl = GetTextHeight(eA + Environment.NewLine.ToString() + ";" + Environment.NewLine.ToString() + eB + Environment.NewLine.ToString() + ";");
                drawZrow(new Point(pt.X + 5, pt.Y + dl + (fontsize / 3)));
                lenght += GetTextHeight(zA + Environment.NewLine.ToString()
                    + zOp + Environment.NewLine.ToString()
                    + zB) + (int)(fontsize / 3) * 5;
            }

            DrawVert(pt, lenght + (fontsize / 3) + 5);
        }
        #endregion

        #region Private Methods

        private void DrawVert(Point pt, int length)
        {
            //linia pionowa
            dc.DrawLine(pen, pt, new Point { X = pt.X, Y = pt.Y + length });
            double b = (Math.Sqrt(length) / 2) + 2;

            //linia pozioma górna
            dc.DrawLine(pen, new Point(pt.X - (b / 2), pt.Y), new Point(pt.X + (b / 2), pt.Y));
            //linia pozioma dolnia
            dc.DrawLine(pen, new Point(pt.X - (b / 2), pt.Y + length), new Point(pt.X + (b / 2), pt.Y + length));

            endPointY = endPointY + (int)pt.Y + length;
        }

        private void DrawVerZrow(Point pt, int lenght)
        {
            double b = Math.Sqrt(lenght) + 2;

            //linia pionowa
            dc.DrawLine(pen, new Point(pt.X, pt.Y), new Point(pt.X, pt.Y + lenght));

            //linia pozioma gorna
            dc.DrawLine(pen, new Point(pt.X, pt.Y), new Point(pt.X + b, pt.Y));
            //linia pozioma dolna
            dc.DrawLine(pen, new Point(pt.X, pt.Y + lenght), new Point(pt.X + b, pt.Y + lenght));

            endPointY = endPointY + (int)pt.Y + lenght;
        }

        private void DrawBezier(Point p0, int length)
        {
            Point start = p0;
            Point p1 = new Point(), p2 = new Point(), p3 = new Point();

            p3.Y = p0.Y;
            p3.X = p0.X + length;

            int b = (int)Math.Sqrt(length) + 2;

            p1.X = p0.X + (int)(length * 0.25);
            p1.Y = p0.Y - b;

            p2.X = p0.X + (int)(length * 0.75);
            p2.Y = p0.Y - b;

            foreach (Point pt in GetBezierPoints(p0, p1, p2, p3))
            {
                dc.DrawLine(pen, start, pt);
                start = pt;
            }
        }

        private void DrawText(Point point, string text)
        {
            dc.DrawText(GetFormattedText(text), point);
        }

        public int GetTextHeight(string text)
        {
            return (int)GetFormattedText(text).Height;
        }

        private int GetTextLength(string text)
        {
            return (int)GetFormattedText(text).Width;
        }

        private IEnumerable<Point> GetBezierPoints(Point A, Point B, Point C, Point D)
        {
            List<Point> points = new List<Point>();

            for (double t = 0.0d; t <= 1.0; t += 1.0 / 500)
            {
                double tbs = Math.Pow(t, 2);
                double tbc = Math.Pow(t, 3);
                double tas = Math.Pow((1 - t), 2);
                double tac = Math.Pow((1 - t), 3);

                points.Add(new Point
                {
                    X = +tac * A.X
                        + 3 * t * tas * B.X
                        + 3 * tbs * (1 - t) * C.X
                        + tbc * D.X,
                    Y = +tac * A.Y
                        + 3 * t * tas * B.Y
                        + 3 * tbs * (1 - t) * C.Y
                        + tbc * D.Y
                });
            }

            return points;
        }

        private FormattedText GetFormattedText(string text)
        {
            FontStyle style = FontStyles.Normal;

            style = FontStyles.Normal;
            Typeface typeface = new Typeface(fontFamily, style, FontWeights.Light, FontStretches.Medium);

            FormattedText formattedText = new FormattedText(text,
                System.Globalization.CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                typeface, fontsize, Brushes.Black);

            formattedText.TextAlignment = TextAlignment.Left;

            return formattedText;
        }

        #endregion
    }
}
