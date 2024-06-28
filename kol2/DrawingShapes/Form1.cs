using DrawingShapes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingShapes
{
    public partial class Form1 : Form
    {
        public string shapeType { get; set; } = "CIRCLE";
        public Scene scene { get; set; }



        public Form1()
        {
            InitializeComponent();
            scene=new Scene();
        }

        private void sQUAREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cIRCLEToolStripMenuItem.Checked = false;
            sQUAREToolStripMenuItem.Checked = true;
            shapeType = "SQUARE";
        }

        private void cIRCLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cIRCLEToolStripMenuItem.Checked = true;
            sQUAREToolStripMenuItem.Checked = false;
            shapeType = "CIRCLE";
        }

        private void handleMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  //left click
            {
                if (shapeType.Equals("CIRCLE"))
                {
                    scene.addShape(new Circle(Color.Red, e.Location, 20));
                }
                else
                {
                    scene.addShape(new Square(Color.Red, e.Location, 40));
                }
            }
            else  //right click
            {
                scene.Hit(e.Location);   
            }
            Invalidate();
        }

        private void handlePaint(object sender, PaintEventArgs e)
        {
            scene.draw(e.Graphics);
        }
    }
}
