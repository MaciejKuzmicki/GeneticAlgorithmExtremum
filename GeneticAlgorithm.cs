using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace GeneticAlg
{
    public static class GeneticAlgorithm
    {
        static double FitnessFunction(int x)
        {
            return - 0.2 *x * x + 6 * x + 7; // -1 ... 31
        }

        static void PlotFitnessFunction(int minValue, int maxValue)
        {
            var plotModel = new PlotModel { Title = "Funkcja Przystosowania" };
            var lineSeries = new LineSeries { Title = "Funkcja Przystosowania", Color = OxyColors.Blue };

            for (int x = minValue; x <= maxValue; x++)
            {
                double y = FitnessFunction(x);
                lineSeries.Points.Add(new DataPoint(x, y));
            }

            plotModel.Series.Add(lineSeries);

            var form = new FitnessPlotForm(plotModel);
            form.Show();
        }

        static void PlotResults(List<double> bestFitnessHistory, List<double> avgFitnessHistory, List<double> worstFitnessHistory, double bestFitness)
        {
            var plotModel = new PlotModel { Title =  $"Ekstremum funkcji: {bestFitness}" };

            var bestSeries = new LineSeries { Title = "Best Fitness", Color = OxyColors.Red };
            var avgSeries = new LineSeries { Title = "Average Fitness", Color = OxyColors.Blue };
            var worstSeries = new LineSeries { Title = "Worst Fitness", Color = OxyColors.Green };

            for (int i = 0; i < bestFitnessHistory.Count; i++)
            {
                bestSeries.Points.Add(new DataPoint(i, bestFitnessHistory[i]));
                avgSeries.Points.Add(new DataPoint(i, avgFitnessHistory[i]));
                worstSeries.Points.Add(new DataPoint(i, worstFitnessHistory[i]));
            }

            plotModel.Series.Add(bestSeries);
            plotModel.Series.Add(avgSeries);
            plotModel.Series.Add(worstSeries);


            var form = new Form
            {
                Width = 1200,
                Height = 900,
                Text = "Wykres postępu przystosowania"
            };
            var plotView = new PlotView { Model = plotModel };

            form.Controls.Add(plotView);
            plotView.Dock = DockStyle.Fill;

            form.ShowDialog();
        }

        public static void Run(int populationSize, int generations, double crossoverRate, double mutationRate, int minValue, int maxValue)
        {
            List<int> population = GeneticAlgorithmHelper.InitializePopulation(populationSize, minValue, maxValue);

            List<double> bestFitnessHistory = new List<double>();
            List<double> avgFitnessHistory = new List<double>();
            List<double> worstFitnessHistory = new List<double>();

            for (int generation = 0; generation < generations; generation++)
            {
                List<double> fitness = population.Select(x => FitnessFunction(x)).ToList();
                double bestFitness = fitness.Max();
                double avgFitness = fitness.Average();
                double worstFitness = fitness.Min();

                bestFitnessHistory.Add(bestFitness);
                avgFitnessHistory.Add(avgFitness);
                worstFitnessHistory.Add(worstFitness);


                population = GeneticAlgorithmHelper.NextGeneration(population, crossoverRate, mutationRate, minValue, maxValue, FitnessFunction);
            }

            int bestIndividual = population.OrderByDescending(x => FitnessFunction(x)).First();
            double bestFitnessValue = FitnessFunction(bestIndividual);

            PlotFitnessFunction(minValue, maxValue);

            PlotResults(bestFitnessHistory, avgFitnessHistory, worstFitnessHistory, bestFitnessValue);
        }
    }
}
