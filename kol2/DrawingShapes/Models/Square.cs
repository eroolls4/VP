using DrawingShapes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    public class Square : Shape
    {
        public Square(Color color, Point point, int size) : base(color, point, size)
        {
        }

        public override void Draw(Graphics g)
        {
            if (isSelected)
            {
                Pen p = new Pen(Color.Yellow, 3);
                g.DrawRectangle(p, this.Point.X - Size / 2, this.Point.Y - Size / 2, Size, Size);
                p.Dispose();

            }

            Brush b = new SolidBrush(color);
            g.FillRectangle(b, this.Point.X - Size / 2, this.Point.Y - Size / 2, Size, Size);
            b.Dispose();
        }

        public override bool isHit(Point point)
        {
            Rectangle r = new Rectangle(this.Point.X - Size / 2, this.Point.Y - Size / 2, Size, Size);
            return r.Contains(point);
        }
    }
}
