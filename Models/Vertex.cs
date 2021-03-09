using System;
using System.Drawing;

namespace _5__GK_lab2.Models
{
    public class Vertex
    {
        private const float Radius = 5.0f;

        public Vertex()
        {
        }

        public Vertex(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public bool Contains(Point p)
        {
            double distance = Math.Sqrt(((this.X - p.X) * (this.X - p.X)) + ((this.Y - p.Y) * (this.Y - p.Y)));
            return distance <= Radius;
        }

        public void Move(int dx, int dy)
        {
            this.X += dx;
            this.Y += dy;
        }

        public void Move(Point p)
        {
            this.X += p.X;
            this.Y += p.Y;
        }
    }
}
