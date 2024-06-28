using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kol2_2023
{
    public partial class Form1 : Form
    {

        public Scene scene { get; set; }

        bool gameStarted = false;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
        }



        private void handlePaint(object sender, PaintEventArgs e)
        {
            scene.draw(e.Graphics);
        }

        private void handleMouseClick(object sender, MouseEventArgs e)
        {

            if (gameStarted)
            {
                scene.markSaved(e.Location);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    scene.addBall(new Ball(e.Location));
                }
            }
            Invalidate();
        }

        private void handleStartLabel(object sender, EventArgs e)
        {
            timer1.Start();
            gameStarted = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.pickRandomBallForDeletion();
            ssPoints.Text = $"POINTS :{scene.Points}";
            if (scene.isGameOver())
            {
                timer1.Stop();
                scene.pickRandomBallForDeletion();
                Invalidate();
                if (MessageBox.Show("GAME OVER", "GAME ENDED", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gameStarted = false;
                    scene = new Scene();
                    ssPoints.Text = $"POINTS :{scene.Points}";
                }
                else
                {
                    this.Close();
                }
            }
            Invalidate();
        }




        void saveFile(String path)
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, scene);
            fileStream.Close();
        }

        void loadFromFile(String path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = formatter.Deserialize(fileStream) as Scene;
            fileStream.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK) { 
                saveFile(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadFromFile(openFileDialog.FileName);
            }
        }
    }
}
