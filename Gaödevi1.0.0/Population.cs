using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaödevi1._0._0
{
    
        public class Population
        {
            public List<Individual> Individuals { get; private set; }
            private static Random rand = new Random();

            public Population(int size)
            {
                Individuals = new List<Individual>();
                for (int i = 0; i < size; i++)
                {
                    Individuals.Add(Individual.RandomIndividual());
                }
            }

            // Turnuva Seçimi
            public Individual TournamentSelection()
            {
                int tournamentSize = 3;
                List<Individual> selected = new List<Individual>();

                for (int i = 0; i < tournamentSize; i++)
                {
                    selected.Add(Individuals[rand.Next(Individuals.Count)]);
                }

                return selected.OrderBy(ind => ind.Fitness).First();
            }

            // Çaprazlama (Crossover)
            public (Individual, Individual) Crossover(Individual parent1, Individual parent2, double crossoverRate)
            {
                if (rand.NextDouble() < crossoverRate)
                {
                    double newX = (parent1.X + parent2.X) / 2;
                    double newY = (parent1.Y + parent2.Y) / 2;
                    return (new Individual(newX, newY), new Individual(newY, newX));
                }
                return (parent1, parent2);
            }

            // Mutasyon (Mutation)
            public void Mutate(Individual individual, double mutationRate)
            {
                if (rand.NextDouble() < mutationRate)
                {
                    individual.X += (rand.NextDouble() * 0.1) - 0.05;  // Küçük bir değişim
                    individual.Y += (rand.NextDouble() * 0.1) - 0.05;
                    individual.CalculateFitness();
                }
            }

        // Yeni jenerasyon üretme
        public Population GenerateNextGeneration(double crossoverRate, double mutationRate, double elitismRate)
        {
            List<Individual> newIndividuals = new List<Individual>();

            // Seçkin bireyleri doğrudan yeni nesle aktar
            int eliteCount = (int)(Individuals.Count * elitismRate);
            var elites = Individuals.OrderBy(ind => ind.Fitness).Take(eliteCount).ToList();
            newIndividuals.AddRange(elites);

            // Geri kalan popülasyonu üret
            while (newIndividuals.Count < Individuals.Count)
            {
                Individual parent1 = TournamentSelection();
                Individual parent2 = TournamentSelection();

                var (child1, child2) = Crossover(parent1, parent2, crossoverRate);
                Mutate(child1, mutationRate);
                Mutate(child2, mutationRate);

                newIndividuals.Add(child1);
                if (newIndividuals.Count < Individuals.Count)
                    newIndividuals.Add(child2);
            }

            return new Population(newIndividuals.Count) { Individuals = newIndividuals };
        }

        // En iyi bireyi döndür
        public Individual GetBestIndividual()
            {
                return Individuals.OrderBy(ind => ind.Fitness).First();
            }
        }
    }

