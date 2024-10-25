using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_379
{
    class Q2
    {
        public int MinMovesToCaptureTheQueen(int a, int b, int c, int d, int e, int f)
        {
            int rookMoves;
            int bishopMoves = Math.Abs(c - e) == Math.Abs(d - f) ? 1 : 2;

            if (a == e || b == f)
            {
                rookMoves = 1;

                //rook被擋住
                if (a == c && a == e)
                    if ((d - b) * (d - f) < 0)
                        rookMoves += 1;
                    else if (b == d && b == f)
                        if ((c - a) * (c - e) < 0)
                            rookMoves += 1;
            }
            else
                rookMoves = 2;

            


            //bishop被擋住
            if (((c % 2 == 0) ^ (d % 2 == 0)) == ((e % 2 == 0) ^ (f % 2 == 0)))
            {
                if (((e == 1 && f == 1) && (a == 2 && b == 2)) || ((e == 8 && f == 1) && (a == 7 && b == 2)) || ((e == 1 && f == 8) && (a == 2 && b == 7)) || ((e == 8 && f == 8) && (a == 7 && b == 7)))
                    return rookMoves;

                if ((b - f) != 0 && (d - f) != 0)
                {
                    double slope1 = ((double)(a - e) / (double)(b - f));
                    double slope2 = ((double)(c - e) / (double)(d - f));
                    if (slope1 == slope2)
                        if (Math.Abs(a - e) < Math.Abs(c - e))
                            bishopMoves += 2;
                }
                    

                return Math.Min(rookMoves, bishopMoves);
            }
            else
                return rookMoves;

        }
    }
}
