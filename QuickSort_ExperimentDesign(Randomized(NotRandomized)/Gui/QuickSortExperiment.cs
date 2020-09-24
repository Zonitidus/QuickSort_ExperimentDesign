using QuickSort_ExperimentDesign_Randomized_NotRandomized_.Experiment;
using System.Threading;
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
            Thread t = new Thread(new ThreadStart(thread), 1000000);
            t.Start();
        }

        public void thread() {
            exp.startExperiment();
            MessageBox.Show("El experimento terminó exitosamente!", "Terminado");
        }
    }
}
