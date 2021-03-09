using System;

namespace _5__GK_lab2.Models
{
    public class Grid
    {
        public Grid()
        {
        }

        public Grid(int n, int m, int width, int height)
        {
            if (n <= 0 || m <= 0 || width <= 0 || height <= 0)
            {
                throw new ArgumentException("values have to be positive numbers");
            }

            this.Vertices = new Vertex[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    this.Vertices[i, j] = new Vertex();
                }
            }

            for (int j = 0; j < m; j++)
            {
                int x = j * (width - 1) / (m - 1);
                for (int i = 0; i < n; i++)
                {
                    this.Vertices[i, j].X = x;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int y = i * (height - 1) / (n - 1);
                for (int j = 0; j < m; j++)
                {
                    this.Vertices[i, j].Y = y;
                }
            }

            this.Triangles = new Polygon[(n - 1) * (m - 1) * 2];
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    this.Triangles[((m - 1) * 2 * i) + (2 * j)] = new Polygon(this.Vertices[i, j], this.Vertices[i, j + 1], this.Vertices[i + 1, j]);
                    this.Triangles[((m - 1) * 2 * i) + (2 * j) + 1] = new Polygon(this.Vertices[i, j + 1], this.Vertices[i + 1, j], this.Vertices[i + 1, j + 1]);
                }
            }
        }

        public Vertex[,] Vertices { get; set; }

        public Polygon[] Triangles { get; set; }
    }
}
