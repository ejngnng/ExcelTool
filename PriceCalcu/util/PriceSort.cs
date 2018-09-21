using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalcu.util
{
    class PriceSort
    {
        private double[] price_array;
        public PriceSort(double[] price)
        {
            price_array = price;
            Array.Reverse(price_array);
        }

        public int getNumber(double value)
        {
            int res = 0;

            for(int i=0; i<price_array.Length; i++)
            {
                if(price_array[i] == value)
                {
                    res = (i + 1);
                    break;
                }
            }

            return res;
        }
    }
}
