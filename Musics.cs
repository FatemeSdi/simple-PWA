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
using WMPLib;

namespace Relaxation
{
    public partial class Musics : Form
    {
        WMPLib.WindowsMediaPlayer Mymusic = new WMPLib.WindowsMediaPlayer();
        public Musics()
        {
            InitializeComponent();
        }
        private void Musics_Load(object sender, EventArgs e)
        {
            Mymusic.controls.play();
            Mymusic.controls.stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Best Relax Music 10.mp3";
            Mymusic.controls.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Best Relax Music 10.mp3";
            Mymusic.controls.stop();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Sunshine Through The Trees.mp3";
            Mymusic.controls.play();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Sunshine Through The Trees.mp3";
            Mymusic.controls.stop();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Raphael Novarina 11.mp3";
            Mymusic.controls.play();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Raphael Novarina 11.mp3";
            Mymusic.controls.stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Best Relax Music 10.mp3";
            Mymusic.controls.play();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Raphael Novarina 11.mp3";
            Mymusic.controls.play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Raphael Novarina 11.mp3";
            Mymusic.controls.stop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Sunshine Through The Trees.mp3";
            Mymusic.controls.stop();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Sunshine Through The Trees.mp3";
            Mymusic.controls.play();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Mymusic.URL = "Sunshine Through The Trees.mp3";
            Mymusic.controls.stop();
        }
    }
}
