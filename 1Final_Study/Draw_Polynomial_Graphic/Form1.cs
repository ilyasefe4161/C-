﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Draw_Polynomial_Graphic
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int step = 10;
        
       
        private void drawAxis(PictureBox pb)
        {
            //create a pen object and setting the color and width for the pen
            Pen p = new Pen(Color.Blue, 1);
            //refresh the picture box
            pb.Refresh();
            //create a new Bitmap object
            Bitmap map = (Bitmap)pb.Image;
            //create a graphics object
            Graphics g = Graphics.FromImage(map);

            int h = pictureBox2.Height;
            int w = pictureBox2.Width;

            //draw x axis from 0 and width
            g.DrawLine(p, 0, h/2, w, h / 2);
            //draw y axis from 0 and height
            g.DrawLine(p, w/2, 0, w/2, h);

            p.Color = Color.Red;

            
            
            for(int i=w/2, j = w / 2; i<=w;i=i+step, j=j-step)
            {
                g.DrawLine(p, i, -3+ h / 2, i, 3+ h / 2);
                g.DrawLine(p, j, -2 + h / 2, j, 2 + h / 2);
            }

            for (int i = h / 2, j = h / 2; i <= h; i = i + step, j = j - step)
            {
                g.DrawLine(p,  -3 + w / 2, i, 3 + w / 2, i);
                g.DrawLine(p, -3 + w / 2, j, 3 + w / 2, j);

            }


            pb.Image = map;
            //dispose pen and graphics object
            p.Dispose();
            g.Dispose();

        }

        private void drawEquationGraphic(PictureBox pb)
        {
            float a, b, c, s, e;
            // read coefficients and range
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            c = float.Parse(textBox3.Text);
            s = float.Parse(textBox4.Text);
            e = float.Parse(textBox5.Text);

            int h = pictureBox2.Height;
            int w = pictureBox2.Width;

            
            
            //offset values
            float ox = w / 2; //origin of x axis
            float oy = h / 2; //origin of y axis

            float value, x1, y1, x2, y2;
            x1 = s*step + ox;

            value = a * s * s + b * s + c;
            y1 = oy - value-step;
            Pen p = new Pen(Color.Chocolate, 2);
            Bitmap map = (Bitmap)pb.Image;
            Graphics g = Graphics.FromImage(map);
           
            

            for (float i=s;i<=e;i=i+1)
            {
                
                x2 = i*step + ox;
                value = a * i * i + b * i + c;
                
                
                y2 = oy - value - step;

                g.DrawLine(p, x1, y1, x2, y2);
                System.Threading.Thread.Sleep(100);
                pictureBox2.Refresh();
                x1 = x2;
                y1 = y2;
            }
            //dispose pen and graphics object
            p.Dispose();
            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            drawAxis(pictureBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.Dispose();
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            drawAxis(pictureBox2);
            drawEquationGraphic(pictureBox2);
        }
    }
}
