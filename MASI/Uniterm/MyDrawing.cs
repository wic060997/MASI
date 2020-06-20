﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                    DrawElim(new Point(30, endPointY + 20));
                }
                if (String.IsNullOrEmpty(zA)!=true)
                {
                    drawZrow(new Point(30, endPointY + 20));
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
        public void drawZrow(Point pt)
        {
            if (zA == "" || zOp == "") return;
            string text = zA + Environment.NewLine.ToString()
                + zOp + Environment.NewLine.ToString()
                + zB + Environment.NewLine.ToString();

            double len = GetTextHeight(text) + 2;

            DrawText(pt, text);
            DrawVerZrow(pt, (int)len);
        }

        public void DrawElim(Point pt)
        {
            if (eA == "" || eB == "" || eC == "") return;

            Point p2 = new Point(pt.X + 2, pt.Y);
            string text = eA + Environment.NewLine.ToString() + ";" + Environment.NewLine.ToString() +
                eB + Environment.NewLine.ToString() +
                ";" + Environment.NewLine.ToString() + eC;

            double l = GetTextHeight(text) + 2;

            DrawText(p2 ,text);
            DrawVert(pt, (int)l);
        }

        public void DrawSwitched(Point pt)
        {
            if (zA == "" || zOp == "" || eA == "" || eB == "" || eC == "") return;


            string textElim = eA + Environment.NewLine.ToString() + ";" + Environment.NewLine.ToString() +
                eB + Environment.NewLine.ToString() +
                ";" + Environment.NewLine.ToString() + eC;

            int length = GetTextLength(textElim);

            zOp = " " + zOp + " ";

            if (oper == 'A')
            {
                DrawText(new Point(pt.X + length + (fontsize / 3), pt.Y + 3), zOp + zB);
                DrawElim(new Point(pt.X + (fontsize / 3), pt.Y + 3));
                length += GetTextLength(zOp + zB) + (int)(fontsize / 3);
            }
            if (oper == 'B')
            {
                DrawText(pt, zA + zOp);
                DrawElim(new Point(pt.X + GetTextLength(zA + zOp) + (fontsize / 3), pt.Y));
                length += GetTextLength(zA + zOp) + (int)(fontsize / 3);
            }
            zOp = Convert.ToString(zOp[1]);
            DrawBezier(pt, length + 5); //+5 poniewaz Kreska tyle zajmuje

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
            dc.DrawLine(pen, new Point(pt.X, pt.Y), new Point(pt.X+b, pt.Y));
            //linia pozioma dolna
            dc.DrawLine(pen, new Point(pt.X, pt.Y+lenght), new Point(pt.X+b, pt.Y + lenght));

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

        private int GetTextHeight(string text)
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
