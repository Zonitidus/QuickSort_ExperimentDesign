using QuickSort_ExperimentDesign_Randomized_NotRandomized_.Experiment;
using System.Windows.Forms;

namespace QuickSort_ExperimentDesign_Randomized_NotRandomized_
{
    public partial class QuickSortExperiment : Form
    {
        private ExperimentQs exp;

        public QuickSortExperiment()
        {
            InitializeComponent();
            this.exp = new ExperimentQs();
        }

        private void startBtn_Click(object sender, System.EventArgs e)
        {
            exp.startExperiment();
            MessageBox.Show("El experimento terminó exitosamente!", "Terminado");
        }
    }
}
