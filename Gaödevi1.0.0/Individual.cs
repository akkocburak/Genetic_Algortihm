using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gaödevi1._0._0
{
    

    
        public class Individual
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Fitness { get; private set; }

            private static Random rand = new Random();

            public Individual(double x, double y)
            {
                X = x;
                Y = y;
                CalculateFitness();
            }

            public void CalculateFitness()
            {
                double term1 = Math.Pow(Math.Sin(3 * Math.PI * X), 2);
                double term2 = Math.Pow(X - 1, 2) * (1 + Math.Pow(Math.Sin(3 * Math.PI * Y), 2));
                double term3 = Math.Pow(Y - 1, 2) * (1 + Math.Pow(Math.Sin(2 * Math.PI * Y), 2));
                Fitness = term1 + term2 + term3;
            }


            // Rastgele birey üretme fonksiyonu
            public static Individual RandomIndividual()
            {
                double x = rand.NextDouble() * 2 - 1;  // [-1, 1] aralığında x
                double y = rand.NextDouble() * 2 - 1;  // [-1, 1] aralığında y
                return new Individual(x, y);
            }
        

    }
}


