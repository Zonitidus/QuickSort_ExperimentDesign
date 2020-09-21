using QuickSort_ExperimentDesign_Randomized_NotRandomized_.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_ExperimentDesign_Randomized_NotRandomized_.Experiment
{
    class Experiment
    {
        private QuickSort<Int32> sorter;
        private Randomized_QS<Int32> sorterR;

        private Int32[] tenDataItems;
        private Int32[] oneHundredDataItems;
        private Int32[] oneThousandDataItems;
        private Int32[] tenThousandDataItems;
        private Int32[] oneHundredThousandItems;

        public Experiment() {
            this.tenDataItems = new Int32[10];
            this.oneHundredDataItems = new Int32[100];
            this.oneThousandDataItems = new Int32[1000];
            this.tenThousandDataItems = new Int32[10000];
            this.oneHundredThousandItems = new Int32[100000];
            initArrays();
        }

        public void initArrays() {

            for (int i = 0; i < tenDataItems.Length; i++) { 
                
            }
        }

    }
}
