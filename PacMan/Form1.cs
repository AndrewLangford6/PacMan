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

namespace PacMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Pen bPen = new Pen(Color.Blue, 10);
            Pen yPen = new Pen(Color.Yellow, 1);


            SoundPlayer player = new SoundPlayer(Properties.Resources.p);
            player.Play();
            this.Refresh();

            for (float i = 1; i <= 50; i=i+5)
            {
                //   SoundPlayer player = new SoundPlayer(Properties.Resources.p);
                //   player.Play();
                //   this.Refresh();
                //   g.DrawPie(yPen, 100, 100, 50, 50, 30, 300);
                g.FillPie(drawBrush,i + 100, 100, 50, 50, 30, 300);
                Thread.Sleep(100);
                this.Refresh();

                g.FillEllipse(drawBrush, i + 100, 100, 50, 50);
                Thread.Sleep(100);
                this.Refresh();
            }

            for (float y = 1; y <= 50; y++)
            {
                //  SoundPlayer player = new SoundPlayer(Properties.Resources.p);
                // player.Play();
                //  this.Refresh();

                g.FillPie(drawBrush, 351, y + y + y + y + y + 100, 50, 50, 120, 300);
                Thread.Sleep(100);
                this.Refresh();

                g.FillEllipse(drawBrush, 351, y + y + y + y + y + 100, 50, 50);
                Thread.Sleep(100);
                this.Refresh();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
