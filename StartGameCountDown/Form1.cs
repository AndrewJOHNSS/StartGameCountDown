using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace StartGameCountDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Game Start";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame.Text = "Loading Game";
            StartGame.ForeColor = Color.BlueViolet;
            BackColor = Color.Black;
            CountDown.ForeColor = Color.White;
            CountDown.Text = "3";
            SoundPlayer player = new SoundPlayer(Properties.Resources.Short_Beep_Tone);
            player.Play();

            this.Refresh();
            Thread.Sleep(1000);

            CountDown.Text = "2";
            player.Play();

            this.Refresh();
            Thread.Sleep(1000);

            CountDown.Text = "1";
            player.Play();

            this.Refresh();
            Thread.Sleep(1000);

            CountDown.Text = "GO!";
            StartGame.Text = "Play!";
            StartGame.ForeColor = Color.Aqua;

            BackColor = Color.DarkGray;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CountDown.ForeColor = Color.Black;

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
            

        }

       





    }
}
