using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol2_2023
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls { get; set; } = new List<Ball>();
        public int Points { get; set; } = 0;
        public Ball ballToDelete {  get; set; }   = null;


        Random Random { get; set; }


        public Scene() { Random = new Random(); }


        public void addBall(Ball b)
        {
            foreach (Ball b2 in Balls)
            {
                if (b2.isOverlap(b))
                {
                    return;
                }
            }

            Balls.Add(b);
        }


        public bool isGameOver()
        {

            foreach (Ball b in Balls)
            {
                if (!b.isSaved)
                {
                    return false;
                }
            }
            return true;
        }


        public void draw(Graphics g)
        {
            Balls.ForEach(ball =>
            {
                ball.Draw(g);
            });

        }

        internal void markSaved(Point location)
        {
            foreach (var item in Balls)
            {
                if (item.isHit(location) && !item.isMarkedForDeletion)
                {
                    item.isSaved = true;
                    Points += 5;
                    return;
                }
            }
        }

        internal void pickRandomBallForDeletion()
        {
            if (ballToDelete != null)
            {
                Balls.Remove(ballToDelete);
            }


            if(Balls.Count > 0 && !isGameOver())
            {
                List<int> indexes = new List<int>();
                for (int i = 0; i < Balls.Count; i++)
                {

                    if (!Balls.ElementAt(i).isSaved && !Balls.ElementAt(i).isMarkedForDeletion)
                    {
                        indexes.Add(i);
                    }
                }

                int randomIndex = indexes[Random.Next(0, indexes.Count)];
                Ball selected = Balls[randomIndex];
                selected.isMarkedForDeletion = true;
                ballToDelete = selected;
                Points -= 10;
            }
        }
    }
}
