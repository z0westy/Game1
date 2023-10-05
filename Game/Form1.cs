using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {

            InitializeComponent();



        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {



            int speed = 10;

            int formHeight = this.Height; // Высота окна
            int formWidth = this.Width; // Длина окна

            int background_x = background.Location.X;  // x верхнего и нижнего левого угла фона
            int player_x = player.Location.X; // x верхнего и нижнего левого угла игрока
            int background_x2 = background.Location.X+4000; // // x верхнего и нижнего правого угла фона
            int player_x2 = player.Location.X+74; // x верхнего и нижнего левого угла игрока
            int background_y = background.Location.Y; // y верхнего левого и правого угла фона
            int player_y = player.Location.Y;  // y верхнего левого и правого угла игрока
            int background_y2 = background.Location.Y+4000; // y нижнего левого и правого угла фона
            int player_y2 = player.Location.Y + 108; // y нижнего левого и правого угла игрока

            int player_xc = player.Location.Y + 37; // центральный x игрока
            int player_yc = player.Location.Y + 54; // центральный y игрока



            if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && (player_y > background_y) )
            {
                if ((player.Location.Y + 54 >= background.Location.Y + 5 + this.Height / 2) && (player.Location.Y + 54 <= background.Location.Y + 4000 - this.Height / 2))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        timer.Start();
                        background.Top += 1;
                    }
                    timer.Stop();
                }
                else if ((player.Location.Y + 54 > background.Location.Y + 4000 - this.Height / 2) || (player.Location.Y + 54 < background.Location.Y + 5 + this.Height / 2))
                {

                    for (int i = 0; i< 10; i++)
                    {
                        timer.Start();
                        if ((player.Location.Y + 54 > background.Location.Y + 4000 - this.Height / 2) || (player.Location.Y + 54 < background.Location.Y + 5 + this.Height / 2))
                            player.Top -= 1;
                    }
                    
                }
                
            }
                
   
            if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && (player_y2 < background_y2))
            {
                label1.Text = Convert.ToString(player.Location.Y + 54);
                label2.Text = Convert.ToString(background.Location.Y + this.Height / 2);
                label3.Text = Convert.ToString(background.Location.Y + 4000 - this.Height / 2);

                if ((player.Location.Y + 54 >= background.Location.Y + this.Height / 2) && (player.Location.Y + 54 <= background.Location.Y + 4000 - 5 - this.Height / 2))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        timer.Start();
                        background.Top -= 1;
                    }
                    timer.Stop();
                }
                else if ((player.Location.Y + 54 > background.Location.Y + 4000 - 5 - this.Height / 2) || (player.Location.Y + 54 < background.Location.Y + this.Height / 2))
                {

                    for (int i = 0; i < 10; i++)
                    {
                        timer.Start();
                        if ((player.Location.Y + 54 > background.Location.Y + 4000 - 5 - this.Height / 2) || (player.Location.Y + 54 < background.Location.Y + this.Height / 2))
                            player.Top += 1;
                    }
                    timer.Stop();
                }


            }

            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && (player_x > background_x))
            {
                label1.Text = Convert.ToString(player.Location.X + 37);
                label2.Text = Convert.ToString(background.Location.X + this.Width / 2);
                label3.Text = Convert.ToString(background.Location.X + 4000 - this.Width / 2);
                if ((player.Location.X + 37 >= background.Location.X + 5 + this.Width/2) && (player.Location.X + 37 <= background.Location.X + 4000 - this.Width / 2))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        timer.Start();
                            background.Left += 1;

                    }
                    timer.Stop();
                }
                else if ((player.Location.X + 37 < background.Location.X + 5 + this.Width / 2) || (player.Location.X + 37 > background.Location.X + 4000 - this.Width / 2))
                    for (int i = 0; i < 10; i++)
                    {
                        timer.Start();
                        if ((player.Location.X + 37 < background.Location.X +5 + this.Width / 2) || (player.Location.X + 37 > background.Location.X + 4000 - this.Width / 2))
                            player.Left -= 1;
                    }
                    timer.Stop();

            }


            if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && (player_x2 < background_x2))
            {
                label1.Text = Convert.ToString(player.Location.X + 37);
                label2.Text = Convert.ToString(background.Location.X + this.Width / 2);
                label3.Text = Convert.ToString(background.Location.X + 4000 - this.Width / 2);
                if ((player.Location.X + 37 >= background.Location.X + this.Width / 2) && (player.Location.X + 37 <= background.Location.X + 4000 - 5 - this.Width / 2))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        timer.Start();
                        background.Left -= 1;

                    }
                    timer.Stop();
                }
                else if ((player.Location.X + 37 < background.Location.X + this.Width / 2) || (player.Location.X + 37 > background.Location.X + 4000 -5  - this.Width / 2))
                    for (int i = 0; i < 10; i++)
                    {
                        timer.Start();
                        if ((player.Location.X + 37 < background.Location.X + this.Width / 2) || (player.Location.X + 37 > background.Location.X + 4000 - 5 - this.Width / 2))
                            player.Left += 1;
                    }
                timer.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();

        }
    }
}
