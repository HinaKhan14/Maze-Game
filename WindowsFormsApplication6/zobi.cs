using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        Point location = Point.Empty;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.PreviewKeyDown += panel_keyDown;
            
            
            
           // pictureBox1.Image = new Bitmap(@"C:\Desktop\images.jpg");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void picturebox1_mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location = new Point(e.X, e.Y);
            }
            
        }

        private void picturebox1_mouseMove(object sender, MouseEventArgs e)
        {
            if (location != Point.Empty)
            {
                Point newlocation = this.pictureBox1.Location;
                
                newlocation.X += e.X - location.X;
                newlocation.Y += e.Y - location.Y;
                this.pictureBox1.Location = newlocation;
            }
            // Picture box Top is 0 or greater
            // If PictureBox1.Left < 0 Then PictureBox1.Location = New Point(0, PictureBox1.Top)
            if (pictureBox1.Left<0)
            {
                pictureBox1.Location = new Point(0, pictureBox1.Top);
            }
            // Picture box Left is 0 or greater
            // If PictureBox1.Top < 0 Then PictureBox1.Location = New Point(PictureBox1.Left, 0)
            if (pictureBox1.Top<0)
            {
                pictureBox1.Location = new Point(pictureBox1.Left, 0);
            }
            //Picture box Top + Height is less than or equal to form Height
            /* If (PictureBox1.Left + PictureBox1.Width) > Me.Width
             Then PictureBox1.Location = New Point(Me.width - PictureBox1.Width, PictureBox1.Top)*/
            if (pictureBox1.Left + pictureBox1.Width>Width)
            {
                pictureBox1.Location = new Point(Width - pictureBox1.Width, pictureBox1.Top);
            }
            //Picture box Left +Width is less than or equal to form Width
            /*If (PictureBox1.Top + PictureBox1.Height) > Me.Height
             Then PictureBox1.Location = New Point(PictureBox1.Left, Me.Height - PictureBox1.Height)*/
            if (pictureBox1.Top + pictureBox1.Height>Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Left, Height - pictureBox1.Height);
            }
            if(pictureBox1.Bounds.IntersectsWith(label1.Bounds))
            {
                pictureBox1.Top = 10;
                pictureBox1.Left = 10;
            }
        }

        private void picturebox1_mouseUp(object sender, MouseEventArgs e)
        {
            location = Point.Empty;
        }

        private void hit_wall(object sender, EventArgs e)
        {
            MessageBox.Show("Oops!you hit wall");
           
        }

        private void finish(object sender, EventArgs e)
        {
            if (pictureBox1.Bounds.IntersectsWith(label5.Bounds))
            {
                
                MessageBox.Show("you won");
                this.Close();
            }
        }

        private void panel_keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.D) x += 10;
            else if (e.KeyCode == Keys.A) x -= 10;
            else if (e.KeyCode == Keys.W) y -= 10;
            else if (e.KeyCode == Keys.S) y += 10;

            pictureBox1.Location = new Point(x, y);
            // Picture box Top is 0 or greater
            // If PictureBox1.Left < 0 Then PictureBox1.Location = New Point(0, PictureBox1.Top)
            if (pictureBox1.Left < 0)
            {
                pictureBox1.Location = new Point(0, pictureBox1.Top);
            }
            // Picture box Left is 0 or greater
            // If PictureBox1.Top < 0 Then PictureBox1.Location = New Point(PictureBox1.Left, 0)
            if (pictureBox1.Top < 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Left, 0);
            }
            //Picture box Top + Height is less than or equal to form Height
            /* If (PictureBox1.Left + PictureBox1.Width) > Me.Width
             Then PictureBox1.Location = New Point(Me.width - PictureBox1.Width, PictureBox1.Top)*/
            if (pictureBox1.Left + pictureBox1.Width > Width)
            {
                pictureBox1.Location = new Point(Width - pictureBox1.Width, pictureBox1.Top);
            }
            //Picture box Left +Width is less than or equal to form Width
            /*If (PictureBox1.Top + PictureBox1.Height) > Me.Height
             Then PictureBox1.Location = New Point(PictureBox1.Left, Me.Height - PictureBox1.Height)*/
            if (pictureBox1.Top + pictureBox1.Height > Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Left, Height - pictureBox1.Height);
            }
            if (pictureBox1.Bounds.IntersectsWith(label1.Bounds))
            {
                pictureBox1.Top = 10;
                pictureBox1.Left = 10;
            }

        }
    }
}
