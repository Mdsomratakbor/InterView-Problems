using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView_Problems
{
  public class FourthProblems
    {
        public static int dbl_linear(int n)
        {

            var uArray=new int[n+1];
            uArray[0] = 1;
            int pt2 = 0, pt3 = 0;

            for (var i = 1; i <= n; i++)
            {
                uArray[i] = Math.Min(2 * uArray[pt2] + 1, 3 * uArray[pt3] + 1);

                if (uArray[i] == 2 * uArray[pt2] + 1) pt2++;
                if (uArray[i] == 3 * uArray[pt3] + 1) pt3++;
            }

            return uArray[n];

        }
    }
}
