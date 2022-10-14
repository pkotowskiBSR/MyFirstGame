using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    internal class Ball
    {
        public float X;
        public float Y;
        public float Vx;
        public float Vy;

        public Ball(float x, float y, float vx, float vy)
        {
            X = x;
            Y = y;
            Vx = vx;
            Vy = vy;
        }

        public void Update()
        {
            //Vx = Vx;
            Vy -= 0.01f;

            X += Vx;
            Y += Vy;
        }

        public void Draw(Graphics g, int YSize)
        {
            g.FillEllipse(Brushes.Red, X, YSize - Y, 10, 10);
        }

    }
}
