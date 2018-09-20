using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalcu.util
{
    class CondicationFanbiOne
    {
        private double price;
        private double price_average = 0;
        private double price_rate = 0;

        public CondicationFanbiOne(double price)
        {
            this.price = price;
        }

        public void setAverage(double value)
        {
            this.price_average = value;
        }

        public void setRate(double value)
        {
            this.price_rate = value;
        }

        public double getResult()
        {
            double avg = price_average * price_rate / 100;
            Console.WriteLine("price_average: {0}", price_average);
            Console.WriteLine("get result avg: {0}", avg);
            if(this.price > avg)
            {
                return (100 * (avg / price));
            }
            else
            {
                return 100;
            }
        }
    }
}
