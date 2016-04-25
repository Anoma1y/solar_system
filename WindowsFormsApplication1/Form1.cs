using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        private Space space;  
        private bool isMoving = false;
        private Point screenCenter;
        private double i = 1;
        private Point center;

           /////////////////////////
            public Form1()
        {
               InitializeComponent();
               space = new Space(this.pictureBox1.CreateGraphics(), new Point(this.pictureBox1.Width / 2, this.pictureBox1.Height / 2));
           //  DoubleBuffered = true; 
           //  pictureBox1.Refresh();
               space.drawBg();
        }
    
        
          private void button1_Click(object sender, EventArgs e)
        {

            if (!isMoving)
                isMoving = true;
            space.draw(isMoving);
                        

            label1.Text = "?" + i + "*X";
            
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            space.IsMoving = false;
            isMoving = false;
            label1.Text = "..."; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (isMoving)
            {
                i = i * 2;
                space.D_angle = 2.0 * space.D_angle;
                label1.Text = "?" + i + "*X";
            }
            else
            {
                label1.Text = "...";
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          if (isMoving)  
            {  
                i = i / 2.0;  
                space.D_angle = space.D_angle / 2.0;  
                label1.Text = "?" + i + "*X";  
            }  
            else {  
                label1.Text = "...";  
            }  
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
