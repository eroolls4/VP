using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLYING_BALLS
{
    public partial class Form1 : Form
    {
        Scene scene { get; set; }


        public int timerTicks { get; set; } = 0;
        public bool gameStarted { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene(this.Height, this.Width);

            timer1.Interval = 100;
            timer1.Start();
            DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++timerTicks;
            if (timerTicks % 10 == 0)
            {
                scene.addBall();
            }
            updateStatusLabels();
            scene.Move();
            Invalidate();
        }

        private void updateStatusLabels()
        {
            ssHits.Text = $"HITS : {scene.hits}";
            ssMisses.Text = $"MISSES : {scene.misses}";
        }

        private void handlePaint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void handleResize(object sender, EventArgs e)
        {
            scene.WindowHeight = this.Height;
            scene.WindowWidth = this.Width;
        }

        private void handleMouseClick(object sender, MouseEventArgs e)
        {
            scene.Hit(e.Location);
        }

        private void pAUSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStarted= !gameStarted;
            if (gameStarted)
            {
                timer1.Start();
                pauseButton.Text = "STOPP";
            }
            else
            {
                timer1.Stop();
                pauseButton.Text = "GOO GOOO GOOO";
            }
        }
    }
}
