using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        int obstaclesSpeed = 7;
        int gravity = 14;
        int sсore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Land_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TopObstacle_Click(object sender, EventArgs e)
        {

        }

        private void TimerGameEvent(object sender, EventArgs e)
        {
            mybird.Top += gravity;
            bottomObstacle.Left -= obstaclesSpeed;
            topObstacle.Left -= obstaclesSpeed;
            textScore.Text = "Счёт:"+ sсore; 

            if (bottomObstacle.Left < -140)
            {
                bottomObstacle.Left = 850;
                sсore+=1;
            }

            if (topObstacle.Left < -150)
            {
                topObstacle.Left = 750;
                sсore+=1;
            }
            
            if (mybird.Bounds.IntersectsWith(bottomObstacle.Bounds) || mybird.Bounds.IntersectsWith(topObstacle.Bounds) || mybird.Bounds.IntersectsWith(land.Bounds) || mybird.Top < -25)          
                EndOfTheGame();
            
            if (sсore > 5)        
                obstaclesSpeed = 17;
            
        }

        private void KeysGameDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -14;  
        }

        private void KeysGameUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)          
                gravity = 14;
        }

        private void EndOfTheGame()
        {
            timerGame.Stop();
            textScore.Text += "   Игра окончена!";
        }
    }
}
