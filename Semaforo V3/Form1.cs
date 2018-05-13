using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Semaforo_V3
{
    public partial class Form1 : Form
    {
        public int color;
        public System.Drawing.Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            color = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawEmpty();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                label1.Text = DateTime.Now.ToShortTimeString(); // Rutina para visualizar la hora
            drawEmpty();
            switch (color) {
                case 0: graphics.FillEllipse(System.Drawing.Brushes.Red, 20, 20, 50, 50);
                    timer1.Interval = 5000;
                    color = 2;
                    break;
                case 1: graphics.FillEllipse(System.Drawing.Brushes.Yellow, 20, 70, 50, 50);
                    timer1.Interval = 2000;
                    color = 0;
                    break;
                case 2: graphics.FillEllipse(System.Drawing.Brushes.Green, 20, 120, 50, 50);
                    timer1.Interval = 3000;
                    color = 1;
                    break;   
            }
        }
        private void drawEmpty()
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(20, 20, 50, 150);
            graphics.DrawRectangle(System.Drawing.Pens.Black, rectangle);
            graphics.FillEllipse(System.Drawing.Brushes.Gray, 20, 20, 50, 50);
            graphics.DrawEllipse(System.Drawing.Pens.Black, 20, 20, 50, 50);
            graphics.FillEllipse(System.Drawing.Brushes.Gray, 20, 70, 50, 50);
            graphics.FillEllipse(System.Drawing.Brushes.Gray, 20, 120, 50, 50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
