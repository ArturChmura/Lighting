using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace _5__GK_lab2.BitMapExtensions
{
    public class DirectBitmap : IDisposable
    {
        public DirectBitmap(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.Bits = new int[width * height];
            this.BitsHandle = GCHandle.Alloc(this.Bits, GCHandleType.Pinned);
            this.Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, this.BitsHandle.AddrOfPinnedObject());
        }

        public DirectBitmap(string filename)
        {
            Bitmap bitmap = new Bitmap(filename);

            this.Width = bitmap.Width;
            this.Height = bitmap.Height;
            this.Bits = new int[this.Width * this.Height];
            this.BitsHandle = GCHandle.Alloc(this.Bits, GCHandleType.Pinned);
            this.Bitmap = new Bitmap(this.Width, this.Height, this.Width * 4, PixelFormat.Format32bppPArgb, this.BitsHandle.AddrOfPinnedObject());
            for (int i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    this.SetPixel(i, j, bitmap.GetPixel(i, j));
                }
            }
        }

        public DirectBitmap(string filename, int width, int height)
        {
            Bitmap bitmap = new Bitmap(filename);

            this.Width = width;
            this.Height = height;
            this.Bits = new int[width * height];
            this.BitsHandle = GCHandle.Alloc(this.Bits, GCHandleType.Pinned);
            this.Bitmap = new Bitmap(this.Width, this.Height, this.Width * 4, PixelFormat.Format32bppPArgb, this.BitsHandle.AddrOfPinnedObject());

            for (int i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    this.SetPixel(i, j, bitmap.GetPixel(i % bitmap.Width, j % bitmap.Height));
                }
            }
        }

        public Bitmap Bitmap { get; private set; }

        public int[] Bits { get; private set; }

        public bool Disposed { get; private set; }

        public int Height { get; private set; }

        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public void SetPixel(int x, int y, Color colour)
        {
            int index = x + (y * this.Width);
            int col = colour.ToArgb();

            this.Bits[index] = col;
        }

        public Color GetPixel(int x, int y)
        {
            int index = x + (y * this.Width);
            int col = this.Bits[index];
            Color result = Color.FromArgb(col);

            return result;
        }

        public void Dispose()
        {
            if (this.Disposed)
            {
                return;
            }

            this.Disposed = true;
            this.Bitmap.Dispose();
            this.BitsHandle.Free();
        }
    }
}
