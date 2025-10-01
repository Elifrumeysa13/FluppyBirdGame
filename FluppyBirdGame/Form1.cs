using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluppyBirdGame
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        private Timer gameTimer;
        private int playerSpeed = 0;
        private int gravity = 3;
        private int jumpForce = 21; // zıplama kuvveti
        private int pipeSpeed = 5;
        private int score = 0;
        public Form1()
        {
            InitializeComponent(); // önce tasarımı yükle

            this.KeyPreview = true;
            gameTimer = new Timer();
            gameTimer.Interval = 20; // yaklaşık 50 FPS
            gameTimer.Tick += GameTimer_Tick;

            // Oyunu başlat
            StartGame();
        }
          

        private void StartGame()
        {
            // Player başlangıç konumu
            player.Location = new Point(100, 300);

            // Boruların başlangıç konumu
            PictureBox[] pipeTop = { pipeTop1, pipeTop2, pipeTop3 };
            PictureBox[] pipeBottom = { pipeBottom1, pipeBottom2, pipeBottom3 };
            int[] startX = { 600, 900, 1200 };
            int gap = 200;
            int minHeight = 150;
            int maxHeight = 400;

            for (int i = 0; i < 3; i++)
            {
                pipeTop[i].Left = startX[i];
                pipeBottom[i].Left = startX[i];

                int minTopHeight = 120;
                int maxTopHeight = this.ClientSize.Height - gap - 50; // alt boru için minimum 50 px

                int topHeight = rnd.Next(minTopHeight, maxTopHeight);
                pipeTop[i].Height = topHeight;

                int bottomHeight = this.ClientSize.Height - topHeight - gap;
                pipeBottom[i].Height = bottomHeight;
                pipeBottom[i].Top = topHeight + gap;
            }



            // Hız ve skor sıfırla
            playerSpeed = 0;
            score = 0;

            // Timer’ı başlat
            gameTimer.Start();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Kuş hareketi (yerçekimi)
            playerSpeed += gravity;
            player.Top += playerSpeed;

            // Boruların hareketi
            PictureBox[] pipeTop = { pipeTop1, pipeTop2, pipeTop3 };
            PictureBox[] pipeBottom = { pipeBottom1, pipeBottom2, pipeBottom3 };

            for (int i = 0; i < 3; i++)
            {
                pipeTop[i].Left -= pipeSpeed;
                pipeBottom[i].Left -= pipeSpeed;


                if (pipeTop[i].Right < 0)
                {
                    pipeTop[i].Left = this.ClientSize.Width;
                    pipeBottom[i].Left = this.ClientSize.Width;

                    int gap = 250;
                    int minTopHeight = 120;
                    int maxTopHeight = this.ClientSize.Height - gap - 50;

                    int topHeight = rnd.Next(minTopHeight, maxTopHeight);
                    pipeTop[i].Height = topHeight;

                    int bottomHeight = this.ClientSize.Height - topHeight - gap;
                    pipeBottom[i].Height = bottomHeight;
                    pipeBottom[i].Top = topHeight + gap;

                    // Kuş boruyu geçtiyse skor artır
                    score++;
                    lblScore.Text = "Skor: " + score;
                }


                // Çarpışma kontrolü
                if (player.Bounds.IntersectsWith(pipeTop[i].Bounds) ||
                    player.Bounds.IntersectsWith(pipeBottom[i].Bounds))
                {
                    GameOver();
                }

                // Yerden veya üstten çıkarsa
                if (player.Top < 0 || player.Bottom > this.ClientSize.Height)
                {
                    GameOver();
                }
            }
        }
        
        private void GameOver()
        {
            gameTimer.Stop();
            MessageBox.Show("Game Over! Skor: " + score);
            StartGame();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                playerSpeed = -jumpForce;
        }





        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }

    

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
