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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1.url = "";
            btn_cancion1.Visible = false;
            btn_pausa2.Visible = false;
            btn_play2.Visible = false;
            lbl_Rpd.Visible = false;

            btn_cancion1.Visible = false;
            btn_cancion2.Visible = false;
            btn_cancion3.Visible = false;
            btn_cancion4.Visible = false;
            btn_cancion5.Visible = false;
            btn_cancion6.Visible = false;

        }

        int indice;
        
        String buscar;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Rpd.Visible = true;
            lbl_1.Text = listBox1.SelectedItem.ToString();
            indice = listBox1.SelectedIndex;
            Class1.indicee = indice;
            btn_pausa2.Visible = true;

            switch (indice)
            {
                case 0:
                    //Para cambiar la url de Windows media player
                    Class1.url = "C:\\Users\\nivec\\Downloads\\maluma.mp4";
                    Class1.video = Convert.ToString(indice);
                    
                    //Codigo para portada de canción
                    btn_cancion1.Visible = true;
                    btn_cancion2.Visible = false;
                    btn_cancion3.Visible = false;
                    btn_cancion4.Visible = false;
                    btn_cancion5.Visible = false;
                    btn_cancion6.Visible = false;

                    break;
                case 2:
                    Class1.video = Convert.ToString(indice);
                    Class1.url = "C:\\Users\\nivec\\Downloads\\can.mp4";
                    btn_cancion1.Visible = false;
                    btn_cancion2.Visible = true;
                    btn_cancion3.Visible = false;
                    btn_cancion4.Visible = false;
                    btn_cancion5.Visible = false;
                    btn_cancion6.Visible = false;
                    break;
                case 4:
                    Class1.url = "C:\\Users\\nivec\\Downloads\\perfect.mp4";
                    Class1.video = Convert.ToString(indice);
                    btn_cancion1.Visible = false;
                    btn_cancion2.Visible = false;
                    btn_cancion3.Visible = true;
                    btn_cancion4.Visible = false;
                    btn_cancion5.Visible = false;
                    btn_cancion6.Visible = false;
                    break;
                case 6:
                    Class1.video = Convert.ToString(indice);
                    Class1.url = "C:\\Users\\nivec\\Downloads\\me niego.mp4";
                    btn_cancion1.Visible = false;
                    btn_cancion2.Visible = false;
                    btn_cancion3.Visible = false;
                    btn_cancion4.Visible = true;
                    btn_cancion5.Visible = false;
                    btn_cancion6.Visible = false;
                    break;
                case 8:
                    Class1.video = Convert.ToString(indice);
                    Class1.url = "C:\\Users\\nivec\\Downloads\\the rose.mp4";
                    btn_cancion1.Visible = false;
                    btn_cancion2.Visible = false;
                    btn_cancion3.Visible = false;
                    btn_cancion4.Visible = false;
                    btn_cancion5.Visible = true;
                    btn_cancion6.Visible = false;
                    break;
                case 10:
                    Class1.video = Convert.ToString(indice);
                    Class1.url = "C:\\Users\\nivec\\Downloads\\me soltaste.mp4";
                    btn_cancion1.Visible = false;
                    btn_cancion2.Visible = false;
                    btn_cancion3.Visible = false;
                    btn_cancion4.Visible = false;
                    btn_cancion5.Visible = false;
                    btn_cancion6.Visible = true;
                    break;
                default:
                    break;
            }

            Class1.repro.Close();
            Class1.repro = new Form2();
            Class1.repro.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            indice = listBox1.FindString(buscar);
            if (indice==-1)
            {
                lbl_1.Text = "El elemento no fue encontrado";
            }
            else
            {
            lbl_1.Text = Convert.ToString(indice);
            listBox1.SetSelected(indice, true);
            }
            

        }

        private void lbl_1_Click(object sender, EventArgs e)
        {

        }

        private void txb_Busc_TextChanged(object sender, EventArgs e)
        {
           
            buscar = txb_Busc.Text;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancion1_Click(object sender, EventArgs e)
        {
            Class1.repro.Visible = true;
        }

        private void btn_pausa_Click(object sender, EventArgs e)
        {
            Class1.repro.axWindowsMediaPlayer1.Ctlcontrols.pause();
            btn_pausa2.Visible = false;
            btn_play2.Visible = true;

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Class1.repro.axWindowsMediaPlayer1.Ctlcontrols.play();
            btn_pausa2.Visible = true;
            btn_play2.Visible = false;
            
        }

        private void btn_cancion6_Click(object sender, EventArgs e)
        {
            Class1.repro.Visible = true;
            //btn_cancion2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Captura));
        }

        private void btn_cancion5_Click(object sender, EventArgs e)
        {
            Class1.repro.Visible = true;
        }

        private void btn_cancion4_Click(object sender, EventArgs e)
        {
            Class1.repro.Visible = true;
        }

        private void btn_cancion3_Click(object sender, EventArgs e)
        {
            Class1.repro.Visible = true;
        }

        private void btn_cancion2_Click(object sender, EventArgs e)
        {
            Class1.repro.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
