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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer mainbg_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\blue.wav");
            mainbg_sound.Play();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SoundPlayer mainbg_sound = new SoundPlayer(@"C:\Users\Sara Siddiqui\Desktop\blue.wav");
            mainbg_sound.Play();
        }
    }
}
