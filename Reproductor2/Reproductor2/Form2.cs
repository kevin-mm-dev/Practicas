using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            switch (Class1.indicee)
            {
                case 0:
                    lbl_titulo.Text = "Bella                               Wolfine y Maluma ";
                    break;

                case 2:
                    lbl_titulo.Text = "Can't stop the feeling                    Justin Timberlake";
                    break;
                case 4:
                    lbl_titulo.Text = "Perfect                           Ed Shared ft. Beyoncé ";
                    break;

                case 6:
                    lbl_titulo.Text = "Me niego                     Reik, Ozuna, Wisin";
                    break;
                case 8:
                    lbl_titulo.Text = "The rose                       Bette Midler  ";
                    break;

                case 10:
                    lbl_titulo.Text = "Me soltaste                          Jesse & Joy";
                    break;
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Class1.url;
        } 

        void repPlay()
        {

            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.repro.Close();
            
        }
        
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
            
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Class1.repro.Visible = false;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            btn_pause.Visible = true;
            btn_play.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            btn_pause.Visible = false;
            btn_play.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            //axWindowsMediaPlayer1.currentMedia.durationString();
            //trackBar1.Value = axWindowsMediaPlayer1.Ctlcontrols.();

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            //trackBar1.Value = axWindowsMediaPlayer1.settings.volumen();
        }

        private void btn_adelantar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void btn_atrasar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_pause.Visible = false;
            btn_play.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

    }
}
