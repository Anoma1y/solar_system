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

namespace WindowsFormsApplication1
{
    class Neptun : Start
    {
    
        public Neptun(Point center, Point movingCenter, int radius, int movingRadius, Graphics graphics, Color bgColor)
        {
            this.center = center;
            this.movingCenter = movingCenter;
            this.radius = radius;
            this.movingRadius = movingRadius;
            this.graphics = graphics;
            this.bgcolor = bgColor;

        }

        public override void draw()
        {
            graphics.FillPie(new SolidBrush(bgcolor), center.X - radius, center.Y - radius, 2 * radius, 2 * radius, 0, 360);
        }
    }
}
