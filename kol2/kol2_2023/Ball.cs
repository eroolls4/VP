using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol2_2023
{

    [Serializable]
    public class Ball
    {
        public Color Color { get; set; } = Color.Red;
        public int Radius { get; set; } = 25;


        public Point Center { get; set; }

        public bool isSaved { get; set; } =false;
        public bool isMarkedForDeletion { get; set; } = false;


        public Ball(Point center)
        {
            Center = center;
        }


        public void Draw(Graphics g)
        {

            if (isSaved)
            {
                Pen pen = new Pen(Color.Yellow, 9);
                g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                pen.Dispose();
            }

            if (isMarkedForDeletion)
            {
                Pen pen = new Pen(Color.Black, 9);
                g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                pen.Dispose();
            }


            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            brush.Dispose();
        }

        public bool isHit(Point point)
        {
            return Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) <= Radius;
        }

        public bool isOverlap(Ball ball)
        {
            return Math.Sqrt(Math.Pow(Center.X - ball.Center.X, 2) + Math.Pow(Center.Y - ball.Center.Y, 2)) <= (Radius + ball.Radius);
        }
    }
}
