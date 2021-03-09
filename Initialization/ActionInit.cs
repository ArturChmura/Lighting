using System;
using System.Drawing;
using System.Numerics;
using _5__GK_lab2.BitMapExtensions;
using _5__GK_lab2.Models;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void InitActions()
        {
            this.getVecIo = (int x, int y) => this.constVecIo;
            this.getOutBubbleVecN = new GetOutBubbleVecNClass
            {
                GetOutBubbleVecN = (int x, int y) => this.constN,
            };
            this.getVecN = this.getOutBubbleVecN.GetVec;
            this.getVecL = (int x, int y) => this.constVecL;

            this.fillPolygonActionDirect = (DirectBitmap bitmap, Polygon polygon) => this.FillPolygon(bitmap, polygon, this.FillHorizontalLineDirect);

            this.fillPolygonActionInterpolate = (DirectBitmap bitmap, Polygon polygon) =>
            {
                Color[] verticesColors = new Color[polygon.Vertices.Length];
                for (int i = 0; i < polygon.Vertices.Length; i++)
                {
                    int x = (int)polygon.Vertices[i].X;
                    int y = (int)polygon.Vertices[i].Y;
                    Vector3 vecN = Vector3.Normalize(this.getVecN(x, y));
                    Vector3 vecIo = this.getVecIo(x, y);
                    Vector3 vecL = Vector3.Normalize(this.getVecL(x, y));
                    Vector3 vecR = (vecN * 2 * Vector3.Dot(vecN, vecL)) - vecL;

                    float lNCos = this.CosVectors(vecL, vecN);
                    float vRmPow = this.Pow(this.CosVectors(this.vecV, vecR), this.m);

                    int r = this.GetColor(this.kd, this.vecIl.X, vecIo.X, lNCos, this.ks, vRmPow);
                    int g = this.GetColor(this.kd, this.vecIl.Y, vecIo.Y, lNCos, this.ks, vRmPow);
                    int b = this.GetColor(this.kd, this.vecIl.Z, vecIo.Z, lNCos, this.ks, vRmPow);

                    r = r < 0 ? 0 : r;
                    g = g < 0 ? 0 : g;
                    b = b < 0 ? 0 : b;

                    r = r > 255 ? 255 : r;
                    g = g > 255 ? 255 : g;
                    b = b > 255 ? 255 : b;

                    verticesColors[i] = Color.FromArgb(r, g, b);
                }

                void fillHorizontalLine(DirectBitmap bitmap, int y, int x1, int x2)
                {
                    this.FillHorizontalLineInterpolate(bitmap, y, x1, x2, verticesColors, polygon.Vertices);
                }

                this.FillPolygon(bitmap, polygon, fillHorizontalLine);
            };

            this.fillPolygon = this.interpolationCheckBox.Checked ? this.fillPolygonActionInterpolate : this.fillPolygonActionDirect;
            this.getBubbleVecN = (int x, int y) =>
            {
                Point m = this.lastMouseLocation;
                double distanceSquared = ((x - m.X) * (x - m.X)) + ((y - m.Y) * (y - m.Y));
                if (distanceSquared < this.bubbleRadious * this.bubbleRadious)
                {
                    double distance = Math.Sqrt(distanceSquared);
                    double z = this.bubbleRadious * (1 - (distance / this.bubbleRadious * (distance / this.bubbleRadious)));
                    return new Vector3(x - m.X, y - m.Y, (float)z);
                }
                else
                {
                    return this.getOutBubbleVecN.GetVec(x, y);
                }
            };
        }
    }
}
