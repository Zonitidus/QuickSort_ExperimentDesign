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

        private const String TYPE_NONDESCENDENT = "ND";
        private const String TYPE_NONASCENDENT = "ND";
        private const String TYPE_RANDOM = "RA";

        private QuickSort<Int32> sorter;
        private Randomized_QS<Int32> sorterR;

        private Dictionary<String, List<double>> averageTimeQS;
        private Dictionary<String, List<double>> averageTimeRandomQS;


        public Experiment() {
            this.averageTimeQS = new Dictionary<string, List<double>>();
            this.averageTimeRandomQS = new Dictionary<string, List<double>>();
        }

        public void startExperiment() { 

            for(int i = 0; i < 1000; i++)
            {
                initExperimentNonRandomizedQS(TYPE_NONDESCENDENT, orderedNonDescendent(10), orderedNonDescendent(100), orderedNonDescendent(1000), orderedNonDescendent(10000), orderedNonDescendent(100000));
                initExperimentNonRandomizedQS(TYPE_NONASCENDENT, orderedNonAscendent(10), orderedNonAscendent(100), orderedNonAscendent(1000), orderedNonAscendent(10000), orderedNonAscendent(100000));
                initExperimentNonRandomizedQS(TYPE_RANDOM, noOrder(10), noOrder(100), noOrder(1000), noOrder(10000), noOrder(100000));


                initExperimentRandomizedQS(TYPE_NONDESCENDENT, orderedNonDescendent(10), orderedNonDescendent(100), orderedNonDescendent(1000), orderedNonDescendent(10000), orderedNonDescendent(100000));
                initExperimentRandomizedQS(TYPE_NONASCENDENT, orderedNonAscendent(10), orderedNonAscendent(100), orderedNonAscendent(1000), orderedNonAscendent(10000), orderedNonAscendent(100000));
                initExperimentRandomizedQS(TYPE_RANDOM, noOrder(10), noOrder(100), noOrder(1000), noOrder(10000), noOrder(100000));

            }
        }

        private void initExperimentNonRandomizedQS(String type, Int32[] array10, Int32[] array100, Int32[] array1000, Int32[] array10000, Int32[] array100000)
        {
            //10
            String Key10 = "10"+ type;
            var watch10 = System.Diagnostics.Stopwatch.StartNew();
            sorter.QuickSortAlgorithm(array10, 0, array10.Length-1);
            watch10.Stop();
            double time10ND = (double)watch10.ElapsedMilliseconds;
            if (!averageTimeQS.ContainsKey(Key10))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time10ND);
                averageTimeQS.Add(Key10, tempList);
            }
            else {
                averageTimeQS[Key10].Add(time10ND);
            }


            //100
            String Key100 = "100" + type;
            var watch100 = System.Diagnostics.Stopwatch.StartNew();
            sorter.QuickSortAlgorithm(array100, 0, array100.Length - 1);
            watch100.Stop();
            double time100ND = (double)watch100.ElapsedMilliseconds;
            if (!averageTimeQS.ContainsKey(Key100))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time100ND);
                averageTimeQS.Add(Key100, tempList);
            }
            else
            {
                averageTimeQS[Key100].Add(time100ND);
            }




            //1000
            String Key1000 = "1000" + type;
            var watch1000 = System.Diagnostics.Stopwatch.StartNew();
            sorter.QuickSortAlgorithm(array1000, 0, array1000.Length - 1);
            watch1000.Stop();
            double time1000ND = (double)watch1000.ElapsedMilliseconds;
            if (!averageTimeQS.ContainsKey(Key1000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time1000ND);
                averageTimeQS.Add(Key1000, tempList);
            }
            else
            {
                averageTimeQS[Key1000].Add(time1000ND);
            }


            //10000
            String Key10000 = "10000" + type;
            var watch10000 = System.Diagnostics.Stopwatch.StartNew();
            sorter.QuickSortAlgorithm(array10000, 0, array10000.Length - 1);
            watch10000.Stop();
            double time10000ND = (double)watch10000.ElapsedMilliseconds;
            if (!averageTimeQS.ContainsKey(Key10000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time10000ND);
                averageTimeQS.Add(Key10000, tempList);
            }
            else
            {
                averageTimeQS[Key10000].Add(time10000ND);
            }




            //100000
            String Key100000 = "100000" + type;
            var watch100000 = System.Diagnostics.Stopwatch.StartNew();
            sorter.QuickSortAlgorithm(array100000, 0, array100000.Length - 1);
            watch100000.Stop();
            double time100000ND = (double)watch100000.ElapsedMilliseconds;
            if (!averageTimeQS.ContainsKey(Key100000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time100000ND);
                averageTimeQS.Add(Key100000, tempList);
            }
            else
            {
                averageTimeQS[Key100000].Add(time100000ND);
            }

        }

        private void initExperimentRandomizedQS(String type, Int32[] array10, Int32[] array100, Int32[] array1000, Int32[] array10000, Int32[] array100000)
        {
            //10
            String Key10 = "10" + type;
            var watch10 = System.Diagnostics.Stopwatch.StartNew();
            sorterR.RandomizedQSAlgorithm(array10, 0, array10.Length-1);
            watch10.Stop();
            double time10ND = (double)watch10.ElapsedMilliseconds;
            if (!averageTimeRandomQS.ContainsKey(Key10))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time10ND);
                averageTimeRandomQS.Add(Key10, tempList);
            }
            else
            {
                averageTimeRandomQS[Key10].Add(time10ND);
            }


            //100
            String Key100 = "100" + type;
            var watch100 = System.Diagnostics.Stopwatch.StartNew();
            sorterR.RandomizedQSAlgorithm(array100, 0, array100.Length - 1);
            watch100.Stop();
            double time100ND = (double)watch100.ElapsedMilliseconds;
            if (!averageTimeRandomQS.ContainsKey(Key100))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time100ND);
                averageTimeRandomQS.Add(Key100, tempList);
            }
            else
            {
                averageTimeRandomQS[Key100].Add(time100ND);
            }




            //1000
            String Key1000 = "1000" + type;
            var watch1000 = System.Diagnostics.Stopwatch.StartNew();
            sorterR.RandomizedQSAlgorithm(array1000, 0, array1000.Length - 1);
            watch1000.Stop();
            double time1000ND = (double)watch1000.ElapsedMilliseconds;
            if (!averageTimeRandomQS.ContainsKey(Key1000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time1000ND);
                averageTimeRandomQS.Add(Key1000, tempList);
            }
            else
            {
                averageTimeRandomQS[Key1000].Add(time1000ND);
            }


            //10000
            String Key10000 = "10000" + type;
            var watch10000 = System.Diagnostics.Stopwatch.StartNew();
            sorterR.RandomizedQSAlgorithm(array10000, 0, array10000.Length - 1);
            watch10000.Stop();
            double time10000ND = (double)watch10000.ElapsedMilliseconds;
            if (!averageTimeRandomQS.ContainsKey(Key10000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time10000ND);
                averageTimeRandomQS.Add(Key10000, tempList);
            }
            else
            {
                averageTimeRandomQS[Key10000].Add(time10000ND);
            }




            //100000
            String Key100000 = "100000" + type;
            var watch100000 = System.Diagnostics.Stopwatch.StartNew();
            sorterR.RandomizedQSAlgorithm(array100000, 0, array100000.Length - 1);
            watch100000.Stop();
            double time100000ND = (double)watch100000.ElapsedMilliseconds;
            if (!averageTimeRandomQS.ContainsKey(Key100000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time100000ND);
                averageTimeRandomQS.Add(Key100000, tempList);
            }
            else
            {
                averageTimeRandomQS[Key100000].Add(time100000ND);
            }

        }


        private Int32[] arrayGenerator(int size)
        {
            Random random = new Random();
            Int32[] array = new Int32[size];

            for(int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10000000);
            }
            return array;
        }

        private Int32[] orderedNonDescendent(int size) {

            Int32[] temp = arrayGenerator(size);
            Array.Sort(temp);
            return temp;
        }

        private Int32[] orderedNonAscendent(int size)
        {
            Int32[] temp = arrayGenerator(size);
            Array.Sort(temp);
            Array.Reverse(temp);
            return temp;
        }

        private Int32[] noOrder(int size)
        {
            return arrayGenerator(size);
        }
    }
}
