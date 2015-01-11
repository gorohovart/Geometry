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
        private Geometry.Point A;
        private Geometry.Point B;
        private Geometry.Point C;
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            var rnd = new System.Random();
            

            A = new Geometry.Point(Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox2.Text));
            B = new Geometry.Point(Convert.ToSingle(textBox3.Text), Convert.ToSingle(textBox4.Text));
            C = new Geometry.Point(Convert.ToSingle(textBox5.Text), Convert.ToSingle(textBox6.Text));

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
        }

    }
}
