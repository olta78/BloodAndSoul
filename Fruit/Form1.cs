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

namespace Fruit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int MD = 5;
        public int ME = 9;
        public int SD = 5;
        public int SE = 9;

        private void playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Fruit.Properties.Resources.Sbor); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Count.Enabled = false;
            Count.Interval = 1000;
            MinDes.Text = MD.ToString();            
            MinEd.Text = ME.ToString();            
            SecDes.Text = SD.ToString();            
            SecEd.Text = SE.ToString();            
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            Count.Enabled = true;
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            Count.Enabled = false;
            MD = 5;
            ME = 9;
            SD = 5;
            SE = 9;
            MinDes.Text = MD.ToString();
            MinEd.Text = ME.ToString();
            SecDes.Text = SD.ToString();
            SecEd.Text = SE.ToString();
        }

        private void Count_Tick(object sender, EventArgs e)
        {
            SE = SE - 1;
            SecEd.Text = SE.ToString();
            if (SE < 0)
            {
                SE = 9;
                SD = SD - 1;
                SecEd.Text = SE.ToString();
                SecDes.Text = SD.ToString();
            }
            if (SD < 0)
            {
                SD = 5;
                ME = ME - 1;
                SecDes.Text = SD.ToString();
                MinEd.Text = ME.ToString();
            }
            if (ME < 0)
            {
                ME = 9;
                MD = MD - 1;
                MinEd.Text = ME.ToString();
                MinDes.Text = MD.ToString();
            }
            if ((MD == 0 && ME == 0) && (SD == 0 && SE == 0))
            {
                playaudio();
                Count.Enabled = false;
            }
        }
    }
}
