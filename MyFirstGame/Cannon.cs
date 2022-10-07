using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    public class Cannon
    {
        public float Angle;
        public float Length;

        public float FirePower;

        public Cannon(float angle, float length, float firePower)
        {
            Angle = angle;
            Length = length;
            FirePower = firePower;
        }

        public void Draw(Graphics g, int ySize)
        {
            int x0 = 0;
            int y0 = ySize;
            int x1 = (int)(Length * Math.Cos(Angle));
            int y1 = ySize - (int)(Length * Math.Sin(Angle));


            g.DrawLine(Pens.Black, x0,y0, x1, y1 );
        }
    }
}
