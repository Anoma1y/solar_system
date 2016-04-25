using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
namespace WindowsFormsApplication1
{

    class Space
    {
        private Graphics graphics;
        private Start sun;
        private Start earth;
        private Start moon;
        private Start merk;
        private Start venera;
        private Start saturn;
        private Start uran;
        private Start yupiter;
        private Start pluton;
        private Start mars;
        private Start neptun;
        private Point center;
        private Point screenCenter;
        private bool isMoving=false ;
        private double d_angle = 2 * 3.14 * 1 / 360;//перевод градусов в радианы
        private double angle;

        public Space(Graphics graphics, Point screenCenter)
        {
            this.graphics = graphics;
            this.screenCenter = screenCenter;
            this.sun = new Sun(screenCenter, screenCenter, 40, 10, graphics, Color.Yellow);
            this.merk = new Merk(new Point(screenCenter.X , screenCenter.Y), screenCenter, 5, 10, graphics, Color.White);
            this.venera = new Venera(new Point(screenCenter.X , screenCenter.Y), screenCenter, 5, 1, graphics, Color.Red);
            this.earth = new Earth(new Point(screenCenter.X , screenCenter.Y), screenCenter, 5, 0, graphics, Color.Green);
            this.moon = new Moon(new Point(earth.center.X, earth.center.Y), earth.center, 3, 10, graphics, Color.White);
            this.mars = new Mars(new Point(screenCenter.X , screenCenter.Y), screenCenter,5, 1, graphics, Color.Red);
            this.yupiter = new Yupiter(new Point(screenCenter.X, screenCenter.Y), screenCenter, 20, 1, graphics, Color.Red);
            this.saturn = new Saturn(new Point(screenCenter.X , screenCenter.Y), screenCenter, 17, 1, graphics, Color.Red);
            this.uran = new Uran(new Point(screenCenter.X , screenCenter.Y), screenCenter, 8, 1, graphics, Color.Yellow);
            this.neptun = new Neptun(new Point(screenCenter.X , screenCenter.Y), screenCenter, 7, 1, graphics, Color.Red);
            this.pluton = new Pluton(new Point(screenCenter.X , screenCenter.Y), screenCenter, 4, 1, graphics, Color.Red);
            this.angle = d_angle;

        }
       public void draw(bool isMoving)
        {
            this.IsMoving = isMoving;
            ThreadStart threadStart = new ThreadStart(threadDraw);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }
        public void drawBg()
        {
                  graphics.Clear(Color.Black); //обновление и закраска черным цветом
        }
      public void OnPaint() 
        {
            int b1 = 70, a1 = 70;
            int b2 = 100, a2 = 100;
            int b3 = 130, a3 = 130;
            int b4 = 150, a4 = 150;
            int b5 = 200, a5 = 200;
            int b6 = 250, a6 = 250;
            int b7 = 290, a7 = 290;
            int b8 = 330, a8 = 330;
            int b9 = 370, a9 = 370;
            center = new Point(1378 / 2, 798 / 2);
            Pen myPen = new Pen(Color.Green);
            graphics.DrawEllipse(myPen, Rectangle.FromLTRB(center.X - b1, center.Y - a1, center.X + b1, center.Y + a1));
            graphics.DrawEllipse(myPen, Rectangle.FromLTRB(center.X - b2, center.Y - a2, center.X + b2, center.Y + a2));
            graphics.DrawEllipse(myPen, Rectangle.FromLTRB(center.X - b3, center.Y - a3, center.X + b3, center.Y + a3));
            graphics.DrawEllipse(myPen, Rectangle.FromLTRB(center.X - b4, center.Y - a4, center.X + b4, center.Y + a4));
            graphics.DrawEllipse(myPen, Rectangle.FromLTRB(center.X - b5, center.Y - a5, center.X + b5, center.Y + a5));
            graphics.DrawEllipse(myPen, Rectangle.FromLTRB(center.X - b6, center.Y - a6, center.X + b6, center.Y + a6));
            graphics.DrawEllipse(myPen, Rectangle.FromLTRB(center.X - b7, center.Y - a7, center.X + b7, center.Y + a7));
            graphics.DrawEllipse(myPen, Rectangle.FromLTRB(center.X - b8, center.Y - a8, center.X + b8, center.Y + a8));
            graphics.DrawEllipse(myPen, Rectangle.FromLTRB(center.X - b9, center.Y - a9, center.X + b9, center.Y + a9));
                
        }
        private void threadDraw()
        {
            int dx_merk = 70;
            int dx_venera = 100;
            int dx_earth = 130;  
            int dx_moon = 12;
            int dx_mars = 150;
            int dx_yupiter = 200;
            int dx_saturn = 250;
            int dx_uran = 290;
            int dx_neptun = 330;
            int dx_pluton = 370;
            while (true)
            {
                drawBg();
                OnPaint();
                sun.draw();
                merk.draw();
                merk.center.X = screenCenter.X + (int)(dx_merk * Math.Cos(angle * 0.00000630296));
                merk.center.Y = screenCenter.Y + (int)(dx_merk * Math.Sin(angle * 0.00000630296));
                venera.draw();
                venera.center.X = screenCenter.X + (int)(dx_venera * Math.Cos(angle * 0.00000337310));
                venera.center.Y = screenCenter.Y + (int)(dx_venera * Math.Sin(angle * 0.00000337310));
                earth.draw();
                moon.movingCenter = earth.center;
                earth.center.X = screenCenter.X + (int)(dx_earth * Math.Cos(angle * 0.00000243986));
                earth.center.Y = screenCenter.Y + (int)(dx_earth * Math.Sin(angle * 0.00000243986));
                moon.draw();
                moon.center.X = earth.center.X + (int)(dx_moon * Math.Cos(-angle * 0.00002927832));
                moon.center.Y = earth.center.Y + (int)(dx_moon * Math.Sin(-angle * 0.00002927832));
                mars.draw();
                mars.center.X = screenCenter.X + (int)(dx_mars * Math.Cos(angle * 0.00000160127));
                mars.center.Y = screenCenter.Y + (int)(dx_mars * Math.Sin(angle * 0.00000160127));
                yupiter.draw();
                yupiter.center.X = screenCenter.X + (int)(dx_yupiter * Math.Cos(angle * 0.00000046882));
                yupiter.center.Y = screenCenter.Y + (int)(dx_yupiter * Math.Sin(angle * 0.00000046882));
                saturn.draw();
                saturn.center.X = screenCenter.X + (int)(dx_saturn * Math.Cos(angle * 0.00000025463));
                saturn.center.Y = screenCenter.Y + (int)(dx_saturn * Math.Sin(angle * 0.00000025463));
                uran.draw();
                uran.center.X = screenCenter.X + (int)(dx_uran * Math.Cos(angle * 0.00000012688));
                uran.center.Y = screenCenter.Y + (int)(dx_uran * Math.Sin(angle * 0.00000012688));
                neptun.draw();
                neptun.center.X = screenCenter.X + (int)(dx_neptun * Math.Cos(angle * 0.00000008104));
                neptun.center.Y = screenCenter.Y + (int)(dx_neptun * Math.Sin(angle * 0.00000008104));
                pluton.draw();
                pluton.center.X = screenCenter.X + (int)(dx_pluton * Math.Cos(angle * 0.00000006180));
                pluton.center.Y = screenCenter.Y + (int)(dx_pluton * Math.Sin(angle * 0.00000006180));
                angle -= d_angle;
                Thread.Sleep(10);
                   if (!IsMoving)
                break;
               }
        }
        public bool IsMoving
        {

            get { return isMoving; }
            set { isMoving = value; }
        }

        public double D_angle
        {
            get { return d_angle; }
            set { d_angle = value; }
        }   
    }
}
