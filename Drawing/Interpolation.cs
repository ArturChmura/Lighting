using _5__GK_lab2.Models;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        public float[] Cartesian2barycentric(int x, int y, Vertex[] vertices)
        {
            float y2y3 = vertices[1].Y - vertices[2].Y,
                  x3x2 = vertices[2].X - vertices[1].X,
                  x1x3 = vertices[0].X - vertices[2].X,
                  y1y3 = vertices[0].Y - vertices[2].Y,
                  y3y1 = vertices[2].Y - vertices[0].Y,
                  xx3 = x - vertices[2].X,
                  yy3 = y - vertices[2].Y;

            float d = (y2y3 * x1x3) + (x3x2 * y1y3),
                  lambda1 = ((y2y3 * xx3) + (x3x2 * yy3)) / d,
                  lambda2 = ((y3y1 * xx3) + (x1x3 * yy3)) / d;

            return new float[]
            {
                lambda1,
                lambda2,
                1 - lambda1 - lambda2,
            };
        }
    }
}
