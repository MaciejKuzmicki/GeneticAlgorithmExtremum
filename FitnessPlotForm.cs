using OxyPlot.WindowsForms;
using OxyPlot;
namespace GeneticAlg
{
    public class FitnessPlotForm : Form
    {
        public FitnessPlotForm(PlotModel plotModel)
        {
            var plotView = new PlotView { Model = plotModel };
            this.Controls.Add(plotView);
            plotView.Dock = DockStyle.Fill;
            this.Width = 1200;
            this.Height = 800;
            this.Text = "Wykres funkcji przystosowania";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
