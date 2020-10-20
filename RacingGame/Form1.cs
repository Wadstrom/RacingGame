using System;
using System.Drawing;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gamespeed);
            enemy(gamespeed);
            GameOver();
            Coins(gamespeed);
            Points();
        }
        int x;
        Random r = new Random();
        void enemy(int speed)
        {
            if (Enemy1.Top >= 450)
            {
                x = r.Next(0, 200);
                Enemy1.Location = new Point(x, 0);
            }
            else
            {
                Enemy1.Top += speed;
            }
            if (Enemy2.Top >= 450)
            {
                x = r.Next(100, 220);
                Enemy2.Location = new Point(x, 0);
            }
            else
            {
                Enemy2.Top += speed;
            }
            if (Enemy3.Top >= 450)
            {
                x = r.Next(0, 100);
                Enemy3.Location = new Point(x, 0);
            }
            else
            {
                Enemy3.Top += speed;
            }
        }

        void Coins(int speed)
        {
            if (Coin1.Top >= 450)
            {
                x = r.Next(0, 200);
                Coin1.Location = new Point(x, 0);
            }
            else
            {
                Coin1.Top += speed;
            }
            if (Coin2.Top >= 450)
            {
                x = r.Next(0, 200);
                Coin2.Location = new Point(x, 0);
            }
            else
            {
                Coin2.Top += speed;
            }
            if (Coin3.Top >= 450)
            {
                x = r.Next(0, 200);
                Coin3.Location = new Point(x, 0);
            }
            else
            {
                Coin3.Top += speed;
            }
            if (Coin4.Top >= 450)
            {
                x = r.Next(0, 200);
                Coin4.Location = new Point(x, 0);
            }
            else
            {
                Coin4.Top += speed;
            }
        }


            void MoveLine(int speed)
            {
                if (pictureBox1.Top >= 450)
                {
                    pictureBox1.Top = 0;
                }
                else
                {
                    pictureBox1.Top += speed;
                }

                if (pictureBox2.Top >= 450)
                {
                    pictureBox2.Top = 0;
                }
                else
                {
                    pictureBox2.Top += speed;
                }

                if (pictureBox3.Top >= 450)
                {
                    pictureBox3.Top = 0;
                }
                else
                {
                    pictureBox3.Top += speed;
                }
                if (pictureBox6.Top >= 450)
                {
                    pictureBox6.Top = 0;
                }
                else
                {
                    pictureBox6.Top += speed;
                }


            }
        int CollectionCoins;
        void Points()
        {
            if (Car.Bounds.IntersectsWith(Coin1.Bounds))
            {
                CollectionCoins++;
                label1.Text = "Coins:" + CollectionCoins.ToString();
                x = r.Next(0, 200);
                Coin1.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(Coin2.Bounds))
            {
                CollectionCoins++;
                label1.Text = "Coins:" + CollectionCoins.ToString();
                x = r.Next(0, 200);
                Coin2.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(Coin3.Bounds))
            {
                CollectionCoins++;
                label1.Text = "Coins:" + CollectionCoins.ToString();
                x = r.Next(0, 200);
                Coin3.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(Coin4.Bounds))
            {
                CollectionCoins++;
                label1.Text = "Coins:" + CollectionCoins.ToString();
                x = r.Next(0, 200);
                Coin4.Location = new Point(x, 0);
            }
        }
        void GameOver()
            {
                if (Car.Bounds.IntersectsWith(Enemy1.Bounds))
                {
                    timer1.Enabled = false;
                    Over.Visible = true;
                }
                if (Car.Bounds.IntersectsWith(Enemy2.Bounds))
                {
                    timer1.Enabled = false;
                    Over.Visible = true;
                }
                if (Car.Bounds.IntersectsWith(Enemy3.Bounds))
                {
                    timer1.Enabled = false;
                    Over.Visible = true;
                }
            }

        public int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Car.Left > 0)
                    Car.Left += -10;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Car.Left < 220)
                    Car.Left += 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                    gamespeed++;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                    gamespeed--;
            }
        }


    }
}
