﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Pie_Graphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //label4.Text=MousePosition.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            float r1, r2, r3, total;

            r1 = int.Parse(textBox1.Text);
            r2 = int.Parse(textBox2.Text);
            r3 = int.Parse(textBox3.Text);

            total = r1 + r2 + r3;

            float pr1, pr2, pr3;
            pr1 = (r1 / total) * 360;
            pr2 = (r2 / total) * 360;
            pr3 = (r3 / total) * 360;

            Pen p = new Pen(Form1.DefaultBackColor);

            if (checkBox1.Checked == true)
            {
                p.Color = Color.Black;
                p.Width = 4;
                
                              
            }
                    else{
                p.Color = Form1.DefaultBackColor;
                p.Width = 4;
            }


            Graphics g = this.CreateGraphics();

            Rectangle rec = new Rectangle(button1.Location.X + button1.Size.Width + 20, 20, 250, 250);

            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.White);
            Brush b3 = new SolidBrush(Color.Turquoise);

            g.Clear(Form1.DefaultBackColor);
            
            
            g.DrawPie(p, rec, 0, pr1);
            g.FillPie(b1, rec, 0, pr1);

            g.DrawPie(p, rec, pr1, pr2);
            g.FillPie(b2, rec, pr1, pr2);

            g.DrawPie(p, rec, pr1 + pr2, pr3);
            g.FillPie(b3, rec, pr1 + pr2, pr3);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
