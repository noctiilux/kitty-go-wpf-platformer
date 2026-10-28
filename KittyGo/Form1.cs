using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KittyGo
{
    public partial class Form1 : Form
    {
        // направление движения и состояние игрока
        bool goLeft, goRight, jumping, isGameOver;
        bool hasKey = false;

        // скорости и сила прыжка
        int jumpSpeed = 10;
        int force = 8;
        int score = 0;
        int playerSpeed = 10;
        int backgroundSpeed = 8;

        // начальные положения всех элементов (нужны для перезапуска игры)
        private readonly Dictionary<Control, Point> startPositions = new Dictionary<Control, Point>();

        public Form1()
        {
            InitializeComponent();

            foreach (Control x in this.Controls)
            {
                startPositions[x] = x.Location;
            }

            RestartGame();
        }

        // основная логика игры, вызывается таймером
        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            player.Top += jumpSpeed;

            // движение игрока влево / вправо
            if (goLeft == true && player.Left > 100)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left + (player.Width + 100) < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }

            // движение фона и игровых объектов
            if (goLeft == true && background.Left < 0)
            {
                background.Left += backgroundSpeed;
                MoveGameElements("forward");
            }
            if (goRight == true && background.Left > this.ClientSize.Width - background.Width)
            {
                background.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            // прыжок и гравитация (Приложение 6)
            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            // перебираем копию списка: BringToFront меняет порядок элементов во время цикла
            foreach (Control x in this.Controls.Cast<Control>().ToArray())
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    // Приложение 7
                    if (player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                    x.BringToFront();
                }

                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    // Приложение 8
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score += 1;
                    }
                }
            }

            // ключ, дверь, падение (Приложение 9)
            if (player.Bounds.IntersectsWith(key.Bounds) && key.Visible == true)
            {
                key.Visible = false;
                hasKey = true;
            }

            if (player.Bounds.IntersectsWith(door.Bounds) && hasKey == true)
            {
                door.Image = Properties.Resources.door_open;
                GameTimer.Stop();
                isGameOver = true;
                MessageBox.Show("Well done, your Journey is complete! " + Environment.NewLine + "Click OK to play again");
                RestartGame();
            }

            if (player.Top + player.Height > this.ClientSize.Height)
            {
                GameTimer.Stop();
                isGameOver = true;
                MessageBox.Show("You Died!" + Environment.NewLine + "Click OK to play again");
                RestartGame();
            }
        }

        // нажатие клавиш (Приложение 4)
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        // отпускание клавиш (Приложение 5)
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }
        }

        // сдвиг платформ, монет, ключа и двери вместе с фоном
        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && ((string)x.Tag == "platform" || (string)x.Tag == "coin"
                    || (string)x.Tag == "door" || (string)x.Tag == "key"))
                {
                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }
                    if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
            }
        }

        // начать игру заново
        private void RestartGame()
        {
            GameTimer.Stop();

            goLeft = false;
            goRight = false;
            jumping = false;
            isGameOver = false;
            hasKey = false;

            jumpSpeed = 10;
            force = 8;
            score = 0;

            txtScore.Text = "Score: " + score;

            // возвращаем все объекты на начальные места
            foreach (KeyValuePair<Control, Point> item in startPositions)
            {
                item.Key.Location = item.Value;

                if (item.Key is PictureBox && ((string)item.Key.Tag == "coin" || (string)item.Key.Tag == "key"))
                {
                    item.Key.Visible = true;
                }
            }

            door.Image = Properties.Resources.door_closed;

            GameTimer.Start();
        }
    }
}
