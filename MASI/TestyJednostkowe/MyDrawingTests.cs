using System;
using System.Windows.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniterm;
using System.Windows;

namespace TestyJednostkowe
{
    [TestClass()]
    public class MyDrawingTests
    {
        [TestMethod()]
        public void DrawZrowSignTest()
        {
            DrawingVisual dv = new DrawingVisual();
            using (DrawingContext dc = dv.RenderOpen())
            {
                MyDrawing md = new MyDrawing(dc);
                Assert.IsFalse(md.drawZrow(new Point(30, 22)));
                dc.Close();
            }
        }

        [TestMethod()]
        public void DrawElimSignTest()
        {
            DrawingVisual dv = new DrawingVisual();
            using (DrawingContext dc = dv.RenderOpen())
            {
                MyDrawing md = new MyDrawing(dc);
                Assert.IsFalse(md.DrawElim(new Point(30, 22)));
                dc.Close();
            }
        }

        [TestMethod()]
        public void GetTextHeightTest()
        {
            DrawingVisual dv = new DrawingVisual();
            using (DrawingContext dc = dv.RenderOpen())
            {
                MyDrawing md = new MyDrawing(dc);

                Assert.AreEqual(md.GetTextHeight("test"), 13);
                dc.Close();
            }
        }
    }
}
