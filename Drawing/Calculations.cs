using System.Numerics;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private int GetColor(float kd, float light, float objectColor, float cosLN, float ks, float powVRm)
        {
            return (int)(255 * ((kd * light * objectColor * cosLN) + (ks * light * objectColor * powVRm)));
        }

        private float Pow(float x, int y)
        {
            float r = 1.0f;
            for (int i = 0; i < y; i++)
            {
                r *= x;
            }

            return r;
        }

        private float CosVectors(Vector3 a, Vector3 b)
        {
            return Vector3.Dot(a, b) / (a.Length() * b.Length());
        }
    }
}
