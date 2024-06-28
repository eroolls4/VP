using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes.Models
{
    public abstract class Shape
    {
        public Color color { get; set; }
        public Point Point { get; set; } //(x,y)
        public int Size { get; set; }   //radius -> circle , side -> rectangle
        public bool isSelected { get; set; } = false;

        protected Shape(Color color, Point point, int size)
        {
            this.color = color;
            Point = point;
            Size = size;
        }

        public abstract void Draw(Graphics g);
        public abstract bool isHit(Point point);



    }
}
