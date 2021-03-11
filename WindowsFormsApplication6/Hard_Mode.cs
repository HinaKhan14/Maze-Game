using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication6
{
    public partial class Hard_Mode : Form
    {
        public Hard_Mode()
        {
            InitializeComponent();
            
            Change_maze1.Hide();
            button1.Hide();
            change_maze2.Hide();
            change_maze4.Hide();
            change_maze3.Hide();
            change_maze5.Hide();
            change_maze6.Hide();
        }

        public void GenerateMaze(int lines, int r1, int r2)
        {
            Stack<int> myStackForRow = new Stack<int>();
            Stack<int> myStackForCol = new Stack<int>();
            Graphics gr = panel1.CreateGraphics();
            Pen mypen = new Pen(Brushes.Blue, 4);
            SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.White);

            int[,] array = new int[lines, lines];

            float x = 0f;
            float y = 0f;
            float xSpace = panel1.Width / lines;
            float ySpace = panel1.Height / lines;
            //vertical lines
            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(mypen, x, y, x, ySpace * lines);
                x += xSpace;
            }
            //horizontal lines
            x = 0f;
            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(mypen, x, y, xSpace * lines, y);
                y += ySpace;
            }

            int row = r1;
            int col = r2;
            bool allVisited = false;
            int Axis;
            int xAxis;
            int yAxis;
            int height = ((panel1.Height) / lines) - 2;
            int width = (panel1.Width) / lines - 2;
            int rowpre = 0;
            int colpre = 0;
            int countForStack = 1;
            int pw;
            int ph;
            pw = panel1.Width / lines;
            ph = panel1.Height / lines;
            xAxis = pw * (r1);
            yAxis = ph * (r2);
            gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis + 2, width - 2, height - 2));
            for (int i = 0; countForStack != (lines * lines); i++)
            {
                allVisited = true;
                array[r1, r2] = 1;

                while (row == 0 && col == 0 && ((col < lines - 1 && array[row, col + 1] != 1) || (row < lines - 1 && array[row + 1, col] != 1)))
                {
                    if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                    }
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                    }
                    allVisited = false;
                    break;

                }
                while (row == 0 && col != 0 && (array[row, col - 1] != 1 || (row < lines - 1 && array[row + 1, col] != 1) || (col < lines - 1 && array[row, col + 1] != 1)))
                {
                    if (array[row, col - 1] != 1)
                    {
                        yAxis = yAxis - (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 5, width - 2, height + 10));
                        array[row, col - 1] = 1;
                        myStackForRow.Push(row);
                        col--;
                        myStackForCol.Push(col);

                    }
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);
                    }
                    if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                    }
                    allVisited = false;
                    break;
                }

                while (row > 0 && col > 0 && ((col < lines - 1 && array[row, col + 1] != 1) || (row < lines - 1 && array[row + 1, col] != 1) || (array[row - 1, col] != 1) || (array[row, col - 1] != 1)))
                {
                    if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                    }
                    if (array[row - 1, col] != 1)
                    {
                        xAxis = xAxis - (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 3, yAxis + 2, width + 3, height - 2));
                        array[row - 1, col] = 1;
                        myStackForCol.Push(col);
                        row--;
                        myStackForRow.Push(row);

                    }
                    if (array[row, col - 1] != 1)
                    {
                        yAxis = yAxis - (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis + 3, width - 2, height + 4));
                        array[row, col - 1] = 1;
                        myStackForRow.Push(row);
                        col--;
                        myStackForCol.Push(col);
                    }
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);

                    }
                    allVisited = false;
                    break;

                }

                while (col == 0 && row != 0 && ((row < lines - 1 && array[row + 1, col] != 1) || (array[row - 1, col] != 1) || (col < lines - 1 && array[row, col + 1] != 1)))
                {
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);

                    }
                    if (array[row - 1, col] != 1)
                    {
                        xAxis = xAxis - (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 3, yAxis + 3, width + 3, height - 3));
                        array[row - 1, col] = 1;
                        myStackForCol.Push(col);
                        row--;
                        myStackForRow.Push(row);

                    }
                    if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                    }
                    allVisited = false;
                    break;
                }
                if (allVisited)
                {
                    rowpre = row;
                    colpre = col;
                    row = myStackForRow.Pop();
                    col = myStackForCol.Pop();
                    if ((row < lines - 1 && array[row + 1, col] != 1) || ((row - 1) >= 0 && array[row - 1, col] != 1) || (col < lines - 1 && array[row, col + 1] != 1) || (col - 1 >= 0 && array[row, col - 1] != 1))
                    {
                        myStackForRow.Push(row);
                        myStackForCol.Push(col);
                    }
                    Axis = checkForVisited(row, col, array, myBrush1, xAxis, yAxis, height, width, lines, rowpre, colpre);
                    countForStack++;
                    if ((rowpre < row || rowpre > row) && (colpre == col || colpre > col))
                    {
                        xAxis = Axis;
                    }
                    else if ((rowpre == row && colpre > col) || (rowpre == row && colpre < col))
                    {
                        yAxis = Axis;
                    }

                }


            }
        }

        public int RandomNumber1(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public int RandomNumber2(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public int checkForVisited(int row, int col, int[,] array, SolidBrush myBrush2, int xAxis, int yAxis, int height, int width, int lines, int rowpre, int colpre)
        {
            Graphics gr = panel1.CreateGraphics();
        again:
            if (rowpre == row - 1 && colpre == col)
            {
                xAxis = xAxis + (panel1.Width / lines);
                return xAxis;

            }
            else if (rowpre == row + 1 && colpre == col)
            {
                xAxis = xAxis - (panel1.Width / lines);
                return xAxis;
            }
            else if (rowpre == row && colpre == col + 1)
            {
                yAxis = yAxis - (panel1.Height / lines);

                return yAxis;
            }
            else if (rowpre == row && colpre == col - 1)
            {
                yAxis = yAxis + (panel1.Height / lines);

                return yAxis;
            }
            else if (rowpre > row && colpre == col)
            {
                xAxis = xAxis - (panel1.Width / lines);
                rowpre--;
                goto again;
            }
            else if (rowpre < row && colpre == col)
            {
                xAxis = xAxis + (panel1.Width / lines);
                rowpre++;
                goto again;
            }
            else if (rowpre == row && colpre > col)
            {
                yAxis = yAxis - (panel1.Height / lines);
                colpre--;
                goto again;
            }
            else if (rowpre == row && colpre < col)
            {
                yAxis = yAxis + (panel1.Height / lines);
                colpre++;
                goto again;
            }


            return 0;
        }

        int level;                   
        int randm1;                
        int randm2;
        private void level1_Click_1(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            level = 1;
            GenerateMaze(10, 5, 3);
            randm1 = 5;
            randm2 = 3;
            level2.Hide();
            level3.Hide();
            level4.Hide();
            level5.Hide();
            level6.Hide();
            level1.Hide();
            button1.Show();
            Change_maze1.Show();
            change_maze2.Hide();
            change_maze4.Hide();
            change_maze3.Hide();
            change_maze5.Hide();
            change_maze6.Hide();
        }

        private void level2_Click_1(object sender, EventArgs e)
        {
            // SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            level = 2;
            GenerateMaze(11, 5, 5);
            randm1 = 5;
            randm2 = 5;
            level1.Hide();
            level3.Hide();
            level4.Hide();
            level5.Hide();
            level6.Hide();
            level2.Hide();
            change_maze2.Show();
            button1.Show();
            Change_maze1.Hide();
            change_maze3.Hide();
            change_maze4.Hide();
            change_maze5.Hide();
            change_maze6.Hide();
        }

        private void level3_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            level = 3;
            GenerateMaze(12, 1, 7);
            randm1 = 1;
            randm2 = 7;
            level2.Hide();
            level1.Hide();
            level4.Hide();
            level5.Hide();
            level6.Hide();
            level3.Hide();
            button1.Show();
            Change_maze1.Hide();
            change_maze2.Hide();
            change_maze3.Show();
            change_maze4.Hide();
            change_maze5.Hide();
            change_maze6.Hide();
        }

   

    
      
        private void level4_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            level = 4;
            GenerateMaze(13, 1, 7);
            randm1 = 1;
            randm2 = 7;
            level2.Hide();
            level3.Hide();
            level4.Hide();
            level5.Hide();
            level6.Hide();
            level1.Hide();
            button1.Show();
            Change_maze1.Hide();
            change_maze2.Hide();
            change_maze3.Hide();
            change_maze4.Show();
            change_maze5.Hide();
            change_maze6.Hide();
        }

        private void level5_Click(object sender, EventArgs e)
        {
            //    SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //    button_sound.Play();
            level = 5;
            GenerateMaze(14, 1, 7);
            randm1 = 1;
            randm2 = 7;
            level2.Hide();
            level1.Hide();
            level4.Hide();
            level5.Hide();
            level6.Hide();
            level3.Hide();
            button1.Show();
            Change_maze1.Hide();
            change_maze2.Hide();
            change_maze3.Hide();
            change_maze4.Hide();
            change_maze5.Show();
            change_maze6.Hide();
        }

        private void level6_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            level = 6;
            GenerateMaze(15, 3, 5);
            randm1 = 3;
            randm2 = 5;
            level2.Hide();
            level1.Hide();
            level4.Hide();
            level5.Hide();
            level6.Hide();
            level3.Hide();
            button1.Show();
            Change_maze1.Hide();
            change_maze2.Hide();
            change_maze3.Hide();
            change_maze4.Hide();
            change_maze5.Hide();
            change_maze6.Show();
        }

        private void change_maze5_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            int rand1 = RandomNumber1(0, 14);
            int rand2 = RandomNumber2(0, 14);
            randm1 = rand1;
            randm2 = rand2;
            GenerateMaze(14, rand1, rand2);
        }

        private void Change_maze1_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            int rand1 = RandomNumber1(0, 10);
            int rand2 = RandomNumber2(0, 10);
            randm1 = rand1;
            randm2 = rand2;
            GenerateMaze(10, rand1, rand2);
        
        }

        private void change_maze2_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            int rand1 = RandomNumber1(0, 11);
            int rand2 = RandomNumber2(0, 11);
            randm1 = rand1;
            randm2 = rand2;
            GenerateMaze(11, rand1, rand2);
        }

        private void change_maze3_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            int rand1 = RandomNumber1(0, 12);
            int rand2 = RandomNumber2(0, 12);
            randm1 = rand1;
            randm2 = rand2;
            GenerateMaze(12, rand1, rand2);
        }

        private void change_maze4_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            int rand1 = RandomNumber1(0, 13);
            int rand2 = RandomNumber2(0, 13);
            randm1 = rand1;
            randm2 = rand2;
            GenerateMaze(13, rand1, rand2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            int rand1 = RandomNumber1(0, 15);
            int rand2 = RandomNumber2(0, 15);
            randm1 = rand1;
            randm2 = rand2;
            GenerateMaze(15, rand1, rand2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            label2.Invalidate();
            rectangleShape1.Invalidate();
            level2.Show();
            level1.Show();
            level4.Show();
            level5.Show();
            level6.Show();
            level3.Show();
            button1.Hide();
           // panel1.Invalidate();
           Change_maze1.Hide();
            change_maze2.Hide();
            change_maze3.Hide();
            change_maze4.Hide();
            change_maze5.Hide();
            change_maze6.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            Form4 back = new Form4();
            this.Hide();
            back.Show();
        }

        private void Clear_screen_Click_1(object sender, EventArgs e)
        {
            //SoundPlayer clear_sc_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\clear_screen_sound.wav");
            //clear_sc_sound.Play();
            panel1.Invalidate();
            //label6.Invalidate();
        }
        int duration;
        private void button8_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            timer1.Enabled = true;
            timer1.Start();
            if (level == 1)
            {
                duration = 30;
                SolveMaze(10, randm1, randm2);
            }
            else if (level == 2)
            {
                duration = 40;
                SolveMaze(11, randm1, randm2);

            }
            else if (level == 3)
            {
                duration = 50;
                SolveMaze(12, randm1, randm2);
            }
            else if (level == 4)
            {
                duration = 60;
                SolveMaze(13, randm1, randm2);
            }
            else if (level == 5)
            {
                duration = 70;
                SolveMaze(14, randm1, randm2);
            }
            else if (level == 6)
            {
                duration = 80;
                SolveMaze(15, randm1, randm2);
            }
        }
        public void SolveMaze(int lines, int r1, int r2)
        {
            movetostart();
            Stack<int> myStackForRow = new Stack<int>();
            Stack<int> myStackForCol = new Stack<int>();
            Graphics gr = panel1.CreateGraphics();
            Pen mypen = new Pen(Brushes.Blue, 4);
            SolidBrush myBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            this.panel1.Controls.Add(this.label2);
            this.label2.MouseEnter += new System.EventHandler(this.Hit_wall);
            this.label2.Controls.Add(this.Start);
            this.label2.Controls.Add(this.goal);
            int[,] array = new int[lines, lines];


            int row = r1;
            int col = r2;
            bool allVisited = false;
            int Axis;
            int xAxis;
            int yAxis;
            int height = ((panel1.Height) / lines) - 2;
            int width = (panel1.Width) / lines - 2;
            int rowpre = 0;
            int colpre = 0;
            int countForStack = 1;
            int pw;
            int ph;
            pw = panel1.Width / lines;
            ph = panel1.Height / lines;
            xAxis = pw * (r1);
            yAxis = ph * (r2);
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.Location = new System.Drawing.Point(xAxis + 2, yAxis + 2);
            this.rectangleShape1.Size = new System.Drawing.Size(width - 2, height - 2);

           // gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis + 2, width - 2, height - 2));
            for (int i = 0; countForStack != (lines * lines); i++)
            {
                allVisited = true;
                array[r1, r2] = 1;

                while (row == 0 && col == 0 && ((col < lines - 1 && array[row, col + 1] != 1) || (row < lines - 1 && array[row + 1, col] != 1)))
                {
                    if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis + 2, yAxis -10);
                        this.rectangleShape1.Size = new System.Drawing.Size(width - 2, height +10);

                        // gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                    }
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis -3, yAxis + 2);
                        this.rectangleShape1.Size = new System.Drawing.Size(width +3, height - 2);

                        // gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                    }
                    allVisited = false;
                    break;

                }
                while (row == 0 && col != 0 && (array[row, col - 1] != 1 || (row < lines - 1 && array[row + 1, col] != 1) || (col < lines - 1 && array[row, col + 1] != 1)))
                {
                    if (array[row, col - 1] != 1)
                    {
                        yAxis = yAxis - (panel1.Height / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis +2, yAxis -5);
                        this.rectangleShape1.Size = new System.Drawing.Size(width -2, height +10);


                      //  gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 5, width - 2, height + 10));
                        array[row, col - 1] = 1;
                        myStackForRow.Push(row);
                        col--;
                        myStackForCol.Push(col);

                    }
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis - 3, yAxis + 2);
                        this.rectangleShape1.Size = new System.Drawing.Size(width + 3, height - 2);

                       // gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);
                    }
                    if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis +2, yAxis -10);
                        this.rectangleShape1.Size = new System.Drawing.Size(width -2, height +10);

                       // gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                    }
                    allVisited = false;
                    break;
                }

                while (row > 0 && col > 0 && ((col < lines - 1 && array[row, col + 1] != 1) || (row < lines - 1 && array[row + 1, col] != 1) || (array[row - 1, col] != 1) || (array[row, col - 1] != 1)))
                {
                    if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis +2, yAxis -10);
                        this.rectangleShape1.Size = new System.Drawing.Size(width -2, height +10);

                      //  gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                    }
                    if (array[row - 1, col] != 1)
                    {
                        xAxis = xAxis - (panel1.Width / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis + 3, yAxis + 2);
                        this.rectangleShape1.Size = new System.Drawing.Size(width + 3, height - 2);

                      //  gr.FillRectangle(myBrush1, new Rectangle(xAxis + 3, yAxis + 2, width + 3, height - 2));
                        array[row - 1, col] = 1;
                        myStackForCol.Push(col);
                        row--;
                        myStackForRow.Push(row);

                    }
                    if (array[row, col - 1] != 1)
                    {
                        yAxis = yAxis - (panel1.Height / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis +2, yAxis + 3);
                        this.rectangleShape1.Size = new System.Drawing.Size(width -2 ,height +4);

                      //  gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis + 3, width - 2, height + 4));
                        array[row, col - 1] = 1;
                        myStackForRow.Push(row);
                        col--;
                        myStackForCol.Push(col);
                    }
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis - 3, yAxis + 2);
                        this.rectangleShape1.Size = new System.Drawing.Size(width + 3, height - 2);

                        //gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);

                    }
                    allVisited = false;
                    break;

                }

                while (col == 0 && row != 0 && ((row < lines - 1 && array[row + 1, col] != 1) || (array[row - 1, col] != 1) || (col < lines - 1 && array[row, col + 1] != 1)))
                {
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis - 3, yAxis + 2);
                        this.rectangleShape1.Size = new System.Drawing.Size(width + 3, height - 2);

                       // gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);

                    }
                    if (array[row - 1, col] != 1)
                    {
                        xAxis = xAxis - (panel1.Width / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis + 3, yAxis + 3);
                        this.rectangleShape1.Size = new System.Drawing.Size(width + 3, height - 3);

                     //   gr.FillRectangle(myBrush1, new Rectangle(xAxis + 3, yAxis + 3, width + 3, height - 3));
                        array[row - 1, col] = 1;
                        myStackForCol.Push(col);
                        row--;
                        myStackForRow.Push(row);

                    }
                    if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
                        this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
                        this.rectangleShape1.BackColor = System.Drawing.Color.White;
                        this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                        this.rectangleShape1.BorderColor = System.Drawing.Color.White;
                        this.rectangleShape1.Location = new System.Drawing.Point(xAxis +2, yAxis-10);
                        this.rectangleShape1.Size = new System.Drawing.Size(width -2, height +10);

                       // gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                    }
                    allVisited = false;
                    break;
                }
                if (allVisited)
                {
                    rowpre = row;
                    colpre = col;
                    row = myStackForRow.Pop();
                    col = myStackForCol.Pop();
                    if ((row < lines - 1 && array[row + 1, col] != 1) || ((row - 1) >= 0 && array[row - 1, col] != 1) || (col < lines - 1 && array[row, col + 1] != 1) || (col - 1 >= 0 && array[row, col - 1] != 1))
                    {
                        myStackForRow.Push(row);
                        myStackForCol.Push(col);
                    }
                    Axis = checkForVisited(row, col, array, myBrush1, xAxis, yAxis, height, width, lines, rowpre, colpre);
                    countForStack++;
                    if ((rowpre < row || rowpre > row) && (colpre == col || colpre > col))
                    {
                        xAxis = Axis;
                    }
                    else if ((rowpre == row && colpre > col) || (rowpre == row && colpre < col))
                    {
                        yAxis = Axis;
                    }

                }
                this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                this.Start.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.Start.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Start.Location = new System.Drawing.Point(15, 0);
                this.Start.Name = "label3";
                this.Start.Size = new System.Drawing.Size(100, 38);
                this.Start.TabIndex = 1;
                this.Start.Text = "START";
                this.Start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                // 
                // goal
                // 
                this.goal.AutoSize = true;
                this.goal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                this.goal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.goal.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.goal.Location = new System.Drawing.Point(1233, 565);
                this.goal.Name = "label4";
                this.goal.Size = new System.Drawing.Size(85, 35);
                this.goal.TabIndex = 2;
                this.goal.Text = "GOAL";
                this.goal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            }
        }
        private void movetostart()
        {
            Point startingpoint = panel1.Location;
            startingpoint.Offset(20, 30);
            Cursor.Position = PointToScreen(startingpoint);
        }
        private void Hit_wall(object sender, EventArgs e)
        {
            //MessageBox.Show("You Hit wall");
            movetostart();
        }
        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
        private void finish_point(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("you won");

        }
       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            duration--;
            textBox1.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's Up :(");
            }

        }
    }
}

