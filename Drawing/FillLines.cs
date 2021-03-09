using System;
using System.Drawing;
using System.Numerics;
using _5__GK_lab2.BitMapExtensions;
using _5__GK_lab2.Models;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        public void FillHorizontalLineDirect(DirectBitmap bitmap, int y, int x1, int x2)
        {
            for (int i = x1 + 1; i <= x2; i++)
            {
                Vector3 vecN = Vector3.Normalize(this.getVecN(i, y));
                Vector3 vecIo = this.getVecIo(i, y);
                Vector3 vecL = Vector3.Normalize(this.getVecL(i, y));
                Vector3 vecR = (vecN * 2 * Vector3.Dot(vecN, vecL)) - vecL;

                float lNCos = this.CosVectors(vecL, vecN);
                float vRmPow = this.Pow(this.CosVectors(this.vecV, vecR), this.m);

                int r = this.GetColor(this.kd, this.vecIl.X, vecIo.X, lNCos, this.ks, vRmPow);
                int g = this.GetColor(this.kd, this.vecIl.Y, vecIo.Y, lNCos, this.ks, vRmPow);
                int b = this.GetColor(this.kd, this.vecIl.Z, vecIo.Z, lNCos, this.ks, vRmPow);

                (r, g, b) = this.NarrowColors(r, g, b);

                bitmap.SetPixel(i, y, Color.FromArgb(r, g, b));
            }
        }

        public void FillHorizontalLineInterpolate(DirectBitmap bitmap, int y, int x1, int x2, Color[] verticesColors, Vertex[] vertices)
        {
            for (int x = x1 + 1; x <= x2; x++)
            {
                float[] t = this.Cartesian2barycentric(x, y, vertices);

                int r = (int)Math.Floor((verticesColors[0].R * t[0]) + (verticesColors[1].R * t[1]) + (verticesColors[2].R * t[2]));
                int g = (int)Math.Floor((verticesColors[0].G * t[0]) + (verticesColors[1].G * t[1]) + (verticesColors[2].G * t[2]));
                int b = (int)Math.Floor((verticesColors[0].B * t[0]) + (verticesColors[1].B * t[1]) + (verticesColors[2].B * t[2]));

                (r, g, b) = this.NarrowColors(r, g, b);

                bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
            }
        }

        private (int, int, int) NarrowColors(int r, int g, int b)
        {
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;

            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;

            return (r, g, b);
        }
    }
}
