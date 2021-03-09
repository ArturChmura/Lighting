using System;
using System.Collections.Generic;
using _5__GK_lab2.BitMapExtensions;
using _5__GK_lab2.Models;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        public void FillPolygon(DirectBitmap bitmap, Polygon polygon, Action<DirectBitmap, int, int, int> fillHorizontalLine)
        {
            int NextIndex(int index) => index == polygon.Vertices.Length - 1 ? 0 : index + 1;
            int PrevIndex(int index) => index == 0 ? polygon.Vertices.Length - 1 : index - 1;

            static float Cotangent(Vertex first, Vertex second) => (second.Y - first.Y) != 0 ? (float)(second.X - first.X) / (float)(second.Y - first.Y) : float.PositiveInfinity;

            int[] indexes = new int[polygon.Vertices.Length];
            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = i;
            }

            Vertex[] sortedVertices = (Vertex[])polygon.Vertices.Clone();
            Array.Sort(sortedVertices, indexes, Comparer<Vertex>.Create((a, b) => a.Y.CompareTo(b.Y)));
            int yMin = (int)polygon.Vertices[indexes[0]].Y;
            int yMax = (int)polygon.Vertices[indexes[^1]].Y;

            List<AETElement> activeEdgesTable = new List<AETElement>();
            int vertexIndex = 0;

            for (int y = yMin; y <= yMax; y++)
            {
                if (sortedVertices[vertexIndex].Y == y - 1)
                {
                    activeEdgesTable.RemoveAll(a => a.YMax == y - 1);
                }

                while (sortedVertices[vertexIndex].Y == y - 1)
                {
                    Vertex vertex = sortedVertices[vertexIndex];
                    Vertex prev = polygon.Vertices[PrevIndex(indexes[vertexIndex])];
                    Vertex next = polygon.Vertices[NextIndex(indexes[vertexIndex])];

                    if (next.Y >= y - 1)
                    {
                        float cotan = Cotangent(vertex, next);
                        activeEdgesTable.Add(new AETElement() { X = (int)(vertex.X + cotan), YMax = (int)next.Y, CoTan = cotan });
                    }

                    if (prev.Y >= y - 1)
                    {
                        float cotan = Cotangent(vertex, prev);
                        activeEdgesTable.Add(new AETElement() { X = (int)(vertex.X + cotan), YMax = (int)prev.Y, CoTan = cotan });
                    }

                    vertexIndex++;
                }

                activeEdgesTable.Sort((a, b) => a.X.CompareTo(b.X));

                for (int i = 0; i < activeEdgesTable.Count - 1; i += 2)
                {
                    fillHorizontalLine(bitmap, y, (int)activeEdgesTable[i].X, (int)activeEdgesTable[i + 1].X);
                }

                for (int i = 0; i < activeEdgesTable.Count; i++)
                {
                    activeEdgesTable[i] = new AETElement() { CoTan = activeEdgesTable[i].CoTan, X = activeEdgesTable[i].X + activeEdgesTable[i].CoTan, YMax = activeEdgesTable[i].YMax };
                }
            }
        }
    }
}
