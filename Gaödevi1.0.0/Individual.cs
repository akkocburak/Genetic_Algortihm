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
                Fitness = term1 + term2 + term3;//amaç fonksiyonu numaramın sonu 9 olduğu için bu fonksiyonu kullandım
            }


            // Rastgele birey üretme fonksiyonu -10<x,y<10 aralığında 
            public static Individual RandomIndividual()
            {
            double x = rand.NextDouble() * 20 - 10; // -10 ile 10 arasında rastgele x
            double y = rand.NextDouble() * 20 - 10; // -10 ile 10 arasında rastgele y
            return new Individual(x, y);
            }
        

    }
}


