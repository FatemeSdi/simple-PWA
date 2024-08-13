using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relaxation
{
    public partial class ASMR : Form
    {
        public ASMR()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string f = "G:\\Relaxation\\bin\\Debug\\10 Minutes Of Peaceful Forest Sounds For Meditation.mp4";
            axWindowsMediaPlayer1.URL = f;
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ASMR_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string b = "G:\\Relaxation\\bin\\Debug\\Rain Sounds ASMR - Heavy Rain on Window - 30 Minute Rain Sounds for Sleep, ADHD, Fall Asleep Fast.mp4";
            axWindowsMediaPlayer1.URL = b;
        }
    }
}
