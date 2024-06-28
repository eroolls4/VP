using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLYING_BALLS
{
    public class Scene
    {
        public List<Ball> Balls { get; set; } = new List<Ball>();
        public static Random Random = new Random();

        public int WindowHeight { get; set; }
        public int WindowWidth { get; set; }


        public int hits { get; set; } = 0;
        public int misses { get; set; } = 0;



        public Scene(int windowHeight, int windowWidth)
        {
            Balls = new List<Ball>();
            WindowHeight = windowHeight;
            WindowWidth = windowWidth;
        }

        public void addBall()
        {                                               //najlevo
            Balls.Add(new Ball(new System.Drawing.Point(-Ball.RADIUS,
                                                        Random.Next(2 * Ball.RADIUS, WindowHeight - 2 * Ball.RADIUS))));
        }


        public void Move()
        {
            foreach (Ball b in Balls)
            {
                //samo x 
                b.Move(5, 0);
            }

            for (int i = 0; i < Balls.Count; i++)
            {
                if (Balls[i].Center.X - Ball.RADIUS > WindowWidth)
                {
                    Balls[i].stateOfBall -= 1;
                }
            }


            for (int i = 0; i < Balls.Count; i++)
            {
           
                if (Balls[i].stateOfBall == -1)
                {
                    ++misses;
                    Balls.RemoveAt(i);
                }
            }

        }


        public void Draw(Graphics g)
        {
            foreach(Ball b in Balls)
            {
                b.draw(g);
            }

        }

        public void Hit(Point location)
        {
            foreach (Ball b in Balls)
            {
                b.isHit(location);
            }


            for(int i=0; i<Balls.Count; i++)
            {
                if (Balls[i].stateOfBall == 3)
                {
                    Balls.RemoveAt(i);
                    ++hits;
                }

            }
        }
    }
}
