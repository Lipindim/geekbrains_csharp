using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Helpers
{
    public static class Randomizer
    {
        public static Random random = new Random();
        public static double GenerateRandomDouble(double maxValue, int decimalPoints = 2)
        {
            double randomDouble = random.NextDouble() * maxValue;
            randomDouble = Math.Round(randomDouble, decimalPoints);
            return randomDouble;
        }
    }
}
