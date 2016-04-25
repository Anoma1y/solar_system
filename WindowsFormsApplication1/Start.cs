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
    class Start
    {
        public Point center;          //   
        public Point movingCenter;    //  
        public int radius;            //  
        public int movingRadius;      //  
        public Graphics graphics;      //  
        public Color bgcolor;          //  

        public virtual void draw()
        {

        }
    }
}
