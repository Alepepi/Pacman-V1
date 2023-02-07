namespace Pacman_V1
{
    public partial class Form1 : Form
    {

        bool goup, godown, goleft, goright, isGameOver;
        int score, playerSpeed, redGhostSpeed, yellowGhostSpeed, blueGhostSpeed, pinkGhostSpeed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                restartGame("Press 'Enter' to restart");
            }
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if (goleft == true)
            {
                pacman.Left -= playerSpeed;
               /*/ pacman.Image = Properties.Resources.;*/
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                /*/pacman.Image = Properties.Resources.Pacman;*/
            }
            if (godown == true)
            {
                pacman.Top -= playerSpeed;
                /*/pacman.Image = Properties.Resources.down;*/
            }
            if (goleft == true)
            {
                pacman.Top += playerSpeed;
                /*/pacman.Image = Properties.Resources.up;*/
            }

            if (pacman.Left < -10)
            {
                pacman.Left = 680;
            }
            if (pacman.Left < 680)
            {
                pacman.Left = -10;
            }

            if (pacman.Top < -10)
            {
                pacman.Top = 550;
            }
            if (pacman.Top < 550)
            {
                pacman.Top = 0;
            }

            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "coin" && x.Visible == true)
                {
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;
                        x.Visible = false;
                    }
                }

                if ((string)x.Tag == "wall")
                {
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver("You Lose!");
                    }

                    /*para colision en diagonal en X/if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                    {
                        pinkGhostX = -pinkGhostX;
                    }*/
                }

                if ((string)x.Tag == "ghost")
                {
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver("You Lose!");
                    }
                }

               /*/ redghost.left += redGhostSpeed;

                if (redghost.Bounds.IntersectsWith(wall.Bounds) || redghost.Bounds.IntersectsWith(wall.Bounds))
                {
                    redGhostSpeed = -redGhostSpeed;
                }

                orangeGhost.left -= yellowGhostSpeed;

                if (orangeGhost.Bounds.IntersectsWith(wall.Bounds) || orangeGhost.Bounds.IntersectsWith(wall.Bounds))
                {
                    yellowGhostSpeed = -yellowGhostSpeed;
                }

                pinkGhost.left -= pinkGhostSpeed;

                if (pinkGhost.Bounds.IntersectsWith(wall.Bounds) || pinkGhost.Bounds.IntersectsWith(wall.Bounds))
                {
                    pinkGhostSpeed = -pinkGhostSpeed;
                }

                blueGhost.left -= blueGhostSpeed;

                if (blueGhost.Bounds.IntersectsWith(wall.Bounds) || blueGhost.Bounds.IntersectsWith(wall.Bounds))
                {
                    blueGhostSpeed = -blueGhostSpeed;
                }*/

                if (score == 50)
                {
                    gameOver("You Win!");
                }
            }
        }
        private void restartGame(string message)
        {
            txtScore.Text = "Score: 0";
            score = 0;

            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            blueGhostSpeed = 5;
            pinkGhostSpeed = 5;
            playerSpeed = 8;

            isGameOver = false;

            pacman.Left = 66;
            pacman.Top = 86;

            redghost.Left = 0;
            redghost.Top = 0;

            blueGhost.Left = 0;
            blueGhost.Top = 0;

            pinkGhost.Left = 0;
            pinkGhost.Top = 0;

            orangeGhost.Left = 0;
            orangeGhost.Top = 0;

            TIMER.Start();

            txtScore.Text += Environment.NewLine + message;
        }

        private void gameOver(string message)
        {
            isGameOver = true;

            TIMER.Stop();

            txtScore.Text += "Score: " + score + Environment.NewLine + message;

        }
    } 
}