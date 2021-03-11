using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication6
{
    public partial class Form6 : Form
    {
        public Form6()     //thread is a small set of execution
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //SoundPlayer mainbg_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\blue.wav");
            //mainbg_sound.Play();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SoundPlayer sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\exit-sound.wav");
            //sound.Play();

            DialogResult message = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);

           //SoundPlayer mainbg_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\blue.wav");
           // mainbg_sound.Play();

            if (message == DialogResult.No)
            {
                //SoundPlayer soundd = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\exit-sound.wav");
                //soundd.Play();
            }
           
            if (message == DialogResult.Yes)
            {
                Application.Exit();
            }
           
          //  mainbg_sound.Play();
            
            
        }

       

        private void START_Click(object sender, EventArgs e)
        {
           

            timerforlevel.Start();
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();

            //SoundPlayer mainbg_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\blue.wav");
            //mainbg_sound.Play();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            Form2 group = new Form2();
            group.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();

            Form3 help = new Form3();
            help.Show();
            
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timerforlevel_Tick(object sender, EventArgs e)
        {

            progressBarLevel.Increment(1);
            if(progressBarLevel.Value==100)
            {
                timerforlevel.Stop();
                this.Hide();
               
                Form4 level = new Form4();
                level.Show();

            }
        }

        private void progressBarLevel_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    
      
    }
}
