using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _5__GK_lab2
{
    public class GetOutBubbleVecNClass
    {
        private Func<int, int, Vector3> getOutBubbleVecN;

        public Func<int, int, Vector3> GetOutBubbleVecN
        {
            set { this.getOutBubbleVecN = value; }
        }

        public Vector3 GetVec(int x, int y)
        {
            return this.getOutBubbleVecN(x, y);
        }
    }
}
