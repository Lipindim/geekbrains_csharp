using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Helpers
{
    public static class ExtraMath
    {
        public static int GetGreatestCommonDevisor(int a, int b)
        {
            int calcValue = Math.Abs(a);
            while (calcValue > 0)
            {
                if (a % calcValue == 0 && b % calcValue == 0)
                    return calcValue;
                calcValue--;
            }

            return 1;
        }
    }
}
