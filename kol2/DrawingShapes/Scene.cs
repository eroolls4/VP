using DrawingShapes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    public class Scene
    {
        public List<Shape> Shapes { get; set; } = new List<Shape>();

        public Shape selectedShape { get; set; } = null;

        public Scene() { Shapes = new List<Shape>(); }

        public void addShape(Shape s)
        {
            Shapes.Add(s);
        }

        public void draw(Graphics g)
        {
            foreach (Shape s in Shapes)
            {
                s.Draw(g);
            }
        }

        public void Hit(Point location)
        {
            foreach (var item in Shapes)
            {
                if (item.isHit(location))
                {
                    if(selectedShape == null)
                    {
                        selectedShape = item;
                        item.isSelected = !item.isSelected;
                    }
                    else
                    {
                        selectedShape.isSelected = false;
                        selectedShape = item;
                        selectedShape.isSelected = true;
                    }
                }
            }
        }
    }
}
