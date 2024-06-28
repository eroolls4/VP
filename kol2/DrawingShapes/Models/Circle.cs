using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes.Models
{
    public class Circle : Shape
    {
        public Circle(Color color, Point point, int size) : base(color, point, size)
        {
        }

        public override void Draw(Graphics g)
        {

            if(isSelected)
            {
                Pen p = new Pen(Color.Yellow, 3);
                g.DrawEllipse(p, this.Point.X - Size, this.Point.Y - Size, 2 * Size, 2 * Size);
                p.Dispose();

            }

            Brush b = new SolidBrush(this.color);
            g.FillEllipse(b, this.Point.X - Size, this.Point.Y - Size, 2 * Size, 2 * Size);
            b.Dispose();
        }

        public override bool isHit(Point point)
        {
          return  Math.Sqrt(Math.Pow(this.Point.X - point.X, 2) + Math.Pow(this.Point.Y - point.Y, 2)) <= Size;
        }
    }
}
