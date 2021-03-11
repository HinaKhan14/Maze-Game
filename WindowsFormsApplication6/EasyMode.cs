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
    public partial class EasyMode : Form
    {
        public EasyMode()
        {
            InitializeComponent();
            // InitializeComponent();

            graphics = panel1.CreateGraphics();
        }

        Point startingPoint = new Point();
        Point endingPoint = new Point();

        Graphics graphics;

        Pen manualSolutionPen = new Pen(Color.Red, 4);

        bool isLevel1, isLevel2, isLevel3, isLevel4, isLevel5, isLevel6;
        bool isRight = true, isLeft = false;

        public void Maze(int lines)
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

            int row = 0;
            int col = 0;
            bool allVisited = false;
            int Axis;
            int xAxis = 0;
            int yAxis = 0;
            int height = ((panel1.Height) / lines) - 2;
            int width = (panel1.Width) / lines - 2;
            int rowpre = 0;
            int colpre = 0;
            int countForStack = 1;

            for (int i = 0; countForStack != (lines * lines); i++)
            {

                array[0, 0] = 1;


                while (row == 0 && col == 0 && row < lines - 1 && col < lines - 1)
                {
                    gr.FillRectangle(myBrush1, new Rectangle(xAxis, yAxis, width, height));

                    if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        break;
                    }
                }
                while (row == 0 && col != 0)
                {
                    if (array[row, col - 1] != 1)
                    {
                        yAxis = yAxis - (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        array[row, col - 1] = 1;
                        myStackForRow.Push(row);
                        col--;
                        myStackForCol.Push(col);
                        break;
                    }
                    else if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);
                        break;
                    }
                    else if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                        break;
                    }
                    allVisited = true;
                    if (allVisited)
                    {
                        rowpre = row;
                        colpre = col;
                        row = myStackForRow.Pop();
                        col = myStackForCol.Pop();
                        Axis = checkForVisited(row, col, array, myBrush1, xAxis, yAxis, height, width, lines, rowpre, colpre);
                        countForStack++;
                        if ((rowpre < row || rowpre < row) && colpre == col)
                        {
                            xAxis = Axis;
                        }
                        else if (rowpre == row && colpre > col)
                        {
                            yAxis = Axis;
                        }

                    }
                    break;
                }

                while (row > 0 && col > 0)
                {
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {

                        xAxis = xAxis + (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);
                        break;
                    }
                    else if (array[row - 1, col] != 1)
                    {
                        xAxis = xAxis - (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 3, yAxis + 2, width + 3, height - 2));
                        array[row - 1, col] = 1;
                        myStackForCol.Push(col);
                        row--;
                        myStackForRow.Push(row);
                        break;
                    }
                    else if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis - 10, width - 2, height + 10));
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                        break;
                    }
                    else if (array[row, col - 1] != 1)
                    {
                        yAxis = yAxis - (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 2, yAxis + 3, width - 2, height + 4));
                        array[row, col - 1] = 1;
                        myStackForRow.Push(row);
                        col--;
                        myStackForCol.Push(col);
                        break;
                    }
                    allVisited = true;
                    if (allVisited)
                    {
                        rowpre = row;
                        colpre = col;
                        row = myStackForRow.Pop();
                        col = myStackForCol.Pop();

                        Axis = checkForVisited(row, col, array, myBrush1, xAxis, yAxis, height, width, lines, rowpre, colpre);
                        countForStack++;
                        if ((rowpre < row || rowpre > row) && colpre == col)
                        {
                            xAxis = Axis;
                        }
                        else if (rowpre == row && colpre > col)
                        {
                            yAxis = Axis;
                        }

                    }
                    break;

                }

                while (col == 0 && row != 0)
                {
                    if (row < lines - 1 && array[row + 1, col] != 1)
                    {
                        xAxis = xAxis + (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis - 3, yAxis + 2, width + 3, height - 2));
                        array[row + 1, col] = 1;
                        myStackForCol.Push(col);
                        row++;
                        myStackForRow.Push(row);
                        break;
                    }
                    else if (array[row - 1, col] != 1)
                    {
                        xAxis = xAxis - (panel1.Width / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis + 3, yAxis + 2, width + 3, height - 2));
                        array[row - 1, col] = 1;
                        myStackForCol.Push(col);
                        row--;
                        myStackForRow.Push(row);
                        break;
                    }
                    else if (col < lines - 1 && array[row, col + 1] != 1)
                    {
                        yAxis = yAxis + (panel1.Height / lines);
                        gr.FillRectangle(myBrush1, new Rectangle(xAxis, yAxis - 10, width, height + 10));
                        array[row, col + 1] = 1;
                        myStackForRow.Push(row);
                        col++;
                        myStackForCol.Push(col);
                        break;
                    }
                    allVisited = true;
                    if (allVisited)
                    {
                        rowpre = row;
                        colpre = col;
                        row = myStackForRow.Pop();
                        col = myStackForCol.Pop();

                        Axis = checkForVisited(row, col, array, myBrush1, xAxis, yAxis, height, width, lines, rowpre, colpre);
                        countForStack++;
                        if ((rowpre < row || rowpre < row) && colpre == col)
                        {
                            xAxis = Axis;
                        }
                        else if (rowpre == row && colpre > col)
                        {
                            yAxis = Axis;
                        }

                    }
                    break;
                }


            }
        }

        public int checkForVisited(int row, int col, int[,] array, SolidBrush myBrush2, int xAxis, int yAxis, int height, int width, int lines, int rowpre, int colpre)
        {
            Graphics gr = panel1.CreateGraphics();

            if (rowpre < row && colpre == col)
            {
                xAxis = xAxis + (panel1.Width / lines);
                return xAxis;

            }
            else if (rowpre > row && colpre == col)
            {
                xAxis = xAxis - (panel1.Width / lines);
                return xAxis;
            }
            else if (rowpre == row && colpre > col)
            {
                yAxis = yAxis - (panel1.Height / lines);

                return yAxis;
            }
            else if (rowpre == row && colpre < col)
            {
                yAxis = yAxis - (panel1.Height / lines);

                return yAxis;
            }

            return 0;
        }

        private void level1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            button_sound.Play();
            isLevel1 = true;
            isLevel2 = false;
            isLevel3 = false;
            isLevel4 = false;
            isLevel5 = false;
            isLevel6 = false;

            Maze(4);
        }

        private void clear_screen_Click(object sender, EventArgs e)
        {
            SoundPlayer clear_sc_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\clear_screen_sound.wav");
            clear_sc_sound.Play();
            panel1.Invalidate();
        
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            button_sound.Play();
            Form4 back = new Form4();
            this.Hide();
            back.Show();
        }

        private void level2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            button_sound.Play();
            isLevel1 = false;
            isLevel2 = true;
            isLevel3 = false;
            isLevel4 = false;
            isLevel5 = false;
            isLevel6 = false;

            Maze(5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            button_sound.Play();
            isLevel1 = false;
            isLevel2 = false;
            isLevel3 = true;
            isLevel4 = false;
            isLevel5 = false;
            isLevel6 = false;

            Maze(6);
        }

        private void Level4_Click(object sender, EventArgs e)
        {
            SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            button_sound.Play();
            isLevel1 = false;
            isLevel2 = false;
            isLevel3 = false;
            isLevel4 = true;
            isLevel5 = false;
            isLevel6 = false;

            Maze(7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            button_sound.Play();
            isLevel1 = false;
            isLevel2 = false;
            isLevel3 = false;
            isLevel4 = false;
            isLevel5 = true;
            isLevel6 = false;

            Maze(8);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startingPoint = e.Location;
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                endingPoint = e.Location;
                Graphics g = this.CreateGraphics();
                g.DrawLine(manualSolutionPen, startingPoint, endingPoint);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            button_sound.Play();
            isLevel1 = false;
            isLevel2 = false;
            isLevel3 = false;
            isLevel4 = false;
            isLevel5 = false;
            isLevel6 = true;

            Maze(10);
        }

        private void EasyMode_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isLevel1)
            {
                drawDown(new Point(50, 0), 1100, 200);
            }
            else if (isLevel2)
            {
                drawDown(new Point(50, 0), 1100, 160);
            }
            else if (isLevel3)
            {
                drawDown(new Point(50, 0), 1100, 130);
            }
            else if (isLevel4)
            {
                drawDown(new Point(50, 0), 1200, 100);
            }
            else if (isLevel5)
            {
                drawDown(new Point(50, 0), 1200, 85);
            }
            else if (isLevel6)
            {
                drawDown(new Point(50, 0), 1200, 70);
            }
        }

        private void drawDown(Point startPoint, int xToChange, int yToChange)
        {
            Point endPoint = new Point(startPoint.X, startPoint.Y + yToChange);
            graphics.DrawLine(manualSolutionPen, startPoint, endPoint);

            if (isRight)
            {
                isRight = false;
                isLeft = true;
                drawRight(endPoint, xToChange, yToChange);
            }
            else if (isLeft)
            {
                isRight = true;
                isLeft = false;
                drawLeft(endPoint, xToChange, yToChange);
            }

        }

        private void drawRight(Point startPoint, int xToChange, int yToChange)
        {
            Point endPoint = new Point(startPoint.X + xToChange, startPoint.Y);

            graphics.DrawLine(manualSolutionPen, startPoint, endPoint);

            drawDown(endPoint, xToChange, yToChange);
        }

        private void drawLeft(Point startPoint, int xToChange, int yToChange)
        {
            Point endPoint = new Point(startPoint.X - xToChange, startPoint.Y);

            graphics.DrawLine(manualSolutionPen, startPoint, endPoint);

            drawDown(endPoint, xToChange, yToChange);

        }
    }

}