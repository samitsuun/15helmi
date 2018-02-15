using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace WpfApp1
{
    class periCanvas : Canvas  // peri luokka canvas
    {
        double x = 200;
        double y = 200;
        //korvaa metodi OnRender
        protected override void OnRender(DrawingContext dc)
        {

            Pen pen = new Pen();
            pen.Brush = Brushes.Red;
            Brush brush = Brushes.DarkGray;
            Point point = new Point(x, y);

            Rect rect = new Rect(0, 0, Width, Height);
            dc.DrawRectangle(Brushes.Cyan, null, rect);

            dc.DrawEllipse(brush, pen, new Point(x, y), 100, 100);
            dc.DrawEllipse(brush, pen, new Point(Width-x, y), 100, 100);
        }

        public void SetXY(double x, double y)
        {
            this.x = x;
            this.y = y;
            InvalidateVisual();
        }
    }
}
