namespace GeneticAlg
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

	private void btnRun_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPopulationSize.Text, out int populationSize) &&
                int.TryParse(txtGenerations.Text, out int generations) &&
                double.TryParse(txtCrossoverRate.Text, out double crossoverRate) &&
                double.TryParse(txtMutationRate.Text, out double mutationRate) &&
                int.TryParse(txtMinValue.Text, out int minValue) &&
                int.TryParse(txtMaxValue.Text, out int maxValue))
            {
                this.Hide(); // Hide input form while running
                GeneticAlgorithm.Run(populationSize, generations, crossoverRate, mutationRate, minValue, maxValue);
                this.Close();
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić poprawne wartości.");
            }
        }
    }
}
