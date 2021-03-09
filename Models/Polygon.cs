namespace _5__GK_lab2.Models
{
    public class Polygon
    {
        public Polygon()
        {
        }

        public Polygon(params Vertex[] vertices)
        {
            this.Vertices = vertices;
        }

        public Vertex[] Vertices { get; set; }
    }
}
