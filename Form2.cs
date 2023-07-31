using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using System.IO;
using DinoHunter.GameGL;

namespace DinoHunter
{
    public partial class Form2 : Form
    {
        List<Enemy> ghost = new List<Enemy>();
        GameRyanPlayer ryan;
        Horizontal_insect h;
        Vertical_insect v;
        Random_insect r;
        GameGrid grid;

        GameDinoPlayer dino;
        GameDinoPlayer hero;


        int score = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            ArrowKeyMovement();
            BulletMovement();
            GameResult();
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                dino.move(GameDirection.Left);

            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                dino.move(GameDirection.Right);

            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                dino.move(GameDirection.Up);

            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                dino.move(GameDirection.Down);

            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {

                AddBullet();
            }
           
               foreach (Enemy i in ghost)
               {
                   i.MoveGhost(grid);

               }
            score = Game.ReturnScore();
                lblScore.Text = score.ToString();

                if (score >= 200)
                {
                    GameLoop.Enabled = false;
                    MessageBox.Show("You Win");
                }
                if (!Game.GetFlag())
                {
                    GameLoop.Enabled = false;
                    MessageBox.Show("You Loose");
                }

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("D:\\OOP\\GameProjectDinoHunter\\DinoHunter\\DinoHunter\\bin\\Debug\\nMaze.txt", 23, 69);
            Image pacManImage = Game.getGameObjectImage('P');

            GameCell startCell = grid.getCell(4, 8);
            GameCell cell1 = grid.getCell(2, 20);
            GameCell cell2 = grid.getCell(4, 14);
            GameCell cell3 = grid.getCell(18, 3);


            dino = new GameDinoPlayer(pacManImage, startCell);

            h = new Horizontal_insect(Properties.Resources.macharr, cell1, GameObjectType.ENEMY, GameDirection.Left);
            v = new Vertical_insect(Properties.Resources.ladybug, cell2, GameObjectType.ENEMY, GameDirection.Up);
            r = new Random_insect(Properties.Resources.YellowMachar, cell3, GameObjectType.ENEMY, GameDirection.Up);

            ghost.Add(h);
            ghost.Add(v);
            ghost.Add(r);
            printMaze(grid);
        }

        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);

                }

            }
        }
        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

































        // FOR big Player MOvement

        bool right, left, up,down,space;

        void GameResult()
        {
            foreach(Control j in this.Controls)
            {
                foreach(Control i in this.Controls )
                {
                    if(j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                               // i.Top = -100;
                               // i.Visible = false;
                                i.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        void AddBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resources.firey;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = Player.Left + 48;
           // bullet.Left = Player.Left ;
            bullet.Top = Player.Top - 30;
           // bullet.Top = Player.Top ;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
       
        void BulletMovement()
        {
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if(x.Top<100)
                    {
                        this.Controls.Remove(x);
                    }

                }
            }
        }
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        void ArrowKeyMovement()
        {
            if(right == true)
            {
                if(Player.Left<425)
                {
                    Player.Left += 30;
                }
                
            }
            if(left== true)
            {
                if(Player.Left>10)
                {
                    Player.Left -= 20;
                }
            }
           /* if(up == true)
            {
                
            }*/
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if(e.KeyCode == Keys.Space)
            {
                space = true;
                AddBullet();
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if(e.KeyCode == Keys.Down)
            {
                down = false;
            }
            if(e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }
    }
}
