using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLYING_BALLS
{
    public class Ball
    {
        public static int RADIUS = 40;
        public static Random random = new Random();

        //0 -> crveno , 1 -> sino 2-> zeleno 3 -> za brishinje    -1 -> nadvor
        public int stateOfBall { get; set; }
        public Point Center { get; set; }

        public Ball(Point center)
        {
            Center = center;
            stateOfBall = random.Next(3);  // 0 ,1 ,2
        }


        public void draw(Graphics g)
        {
            Color color;
            switch (stateOfBall)
            {
                case 0: color = Color.Red; break;
                case 1: color = Color.Blue; break;
                default: color = Color.Green; break;
            }

            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            brush.Dispose();
        }


        public void Move(int dx, int dy)
        {
            Center = new Point(Center.X + dx, Center.Y + dy);
        }


        public bool isHit(Point point)
        {
          double distance=Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2));
            if(distance <=RADIUS)
            {
                stateOfBall++;
                return true;
            }
            return false;
        }



    }
}
