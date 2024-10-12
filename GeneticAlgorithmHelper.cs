namespace GeneticAlg
{
    public static class GeneticAlgorithmHelper
    {
        static Random rand = new Random();

        public static List<int> InitializePopulation(int populationSize, int minValue, int maxValue)
        {
            List<int> population = new List<int>();
            for (int i = 0; i < populationSize; i++)
            {
                population.Add(rand.Next(minValue, maxValue + 1));
            }
            return population;
        }

        public static int RouletteSelection(List<int> population, List<double> fitness)
        {
            double totalFitness = fitness.Sum();
            double pick = rand.NextDouble() * totalFitness;
            double current = 0;

            for (int i = 0; i < population.Count; i++)
            {
                current += fitness[i];
                if (current >= pick)
                    return population[i];
            }
            return population[0]; 
        }

        public static Tuple<int, int> Crossover(int parent1, int parent2, double crossoverRate, int minValue, int maxValue)
        {
            if (rand.NextDouble() < crossoverRate)
            {
                int crossoverPoint = rand.Next(0, 32);
                int mask = (1 << crossoverPoint) - 1;
                int child1 = (parent1 & mask) | (parent2 & ~mask);
                int child2 = (parent2 & mask) | (parent1 & ~mask);

                child1 = Math.Max(minValue, Math.Min(maxValue, child1));
                child2 = Math.Max(minValue, Math.Min(maxValue, child2));

                return new Tuple<int, int>(child1, child2);
            }
            else
            {
                return new Tuple<int, int>(parent1, parent2);
            }
        }

        public static void Mutate(ref int individual, double mutationRate, int minValue, int maxValue)
        {
            if (rand.NextDouble() < mutationRate)
            {
                int mutationPoint = rand.Next(0, 32);
                individual ^= (1 << mutationPoint);

                individual = Math.Max(minValue, Math.Min(maxValue, individual));
            }
        }

        public static List<int> NextGeneration(List<int> population, double crossoverRate, double mutationRate, int minValue, int maxValue, Func<int, double> fitnessFunction)
        {
            List<double> fitness = population.Select(x => fitnessFunction(x)).ToList();
            List<int> newPopulation = new List<int>();

            while (newPopulation.Count < population.Count)
            {
                int parent1 = RouletteSelection(population, fitness);
                int parent2 = RouletteSelection(population, fitness);

                var (child1, child2) = Crossover(parent1, parent2, crossoverRate, minValue, maxValue);
                Mutate(ref child1, mutationRate, minValue, maxValue);
                Mutate(ref child2, mutationRate, minValue, maxValue);

                newPopulation.Add(child1);
                if (newPopulation.Count < population.Count)
                    newPopulation.Add(child2);
            }
            return newPopulation;
        }
    }

}
