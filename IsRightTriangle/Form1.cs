using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace IsRightTriangle
{
    public partial class Form1 : Form
    {
        private Point A;
        private Point B;
        private Point C;
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            var rnd = new System.Random();


            A = new Point(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            B = new Point(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            C = new Point(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));

            var res = Geometry.Checker(A, B, C);

            if (res)
            {
                label7.Text = "Triangle is right.";
                label7.BackColor = Color.Green;
            }
            else
            {
                label7.Text = "Triangle is not right.";
                label7.BackColor = Color.Red;
            }
            this.Invalidate();
        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if ((A != null) && (B != null) && (C != null))
            {
                //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                e.Graphics.DrawLine(new Pen(Color.Red), A, B);
                e.Graphics.DrawLine(new Pen(Color.Red), A, C);
                e.Graphics.DrawLine(new Pen(Color.Red), B, C);
            }
        }
    }
}
