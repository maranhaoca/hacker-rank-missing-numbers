using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'missingNumbers' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY arr
         *  2. INTEGER_ARRAY brr
         */

        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            List<int> miss = new List<int>();
            List<int> bDist = new List<int>();
            bDist = brr.Distinct().ToList();

            foreach (var item in bDist)
            {
                int countA =  arr.Where(el => el == item).Count();
                int countB =  brr.Where(el => el == item).Count();
                if (countA != countB)
                {
                    miss.Add(item);
                }
            }
            miss.Sort();

            return miss;
        }
    }
}