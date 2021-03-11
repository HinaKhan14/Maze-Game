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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();

            Medium_Mode MM = new Medium_Mode();
            MM.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();

            this.Close();
            Form6 mainPage = new Form6();
            mainPage.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();
            EasyMode EM = new EasyMode();
            EM.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SoundPlayer button_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\click.wav");
            //button_sound.Play();

            Hard_Mode HM = new Hard_Mode();
            HM.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //SoundPlayer levelbg_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\level.wav");
            //levelbg_sound.Play();
        }
    }
}
