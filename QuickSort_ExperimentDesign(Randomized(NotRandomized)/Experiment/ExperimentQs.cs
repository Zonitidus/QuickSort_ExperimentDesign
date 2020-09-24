using QuickSort_ExperimentDesign_Randomized_NotRandomized_.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuickSort_ExperimentDesign_Randomized_NotRandomized_.Experiment
{
    public class ExperimentQs
    {

        private const String TYPE_NONDESCENDENT = "ND";
        private const String TYPE_NONASCENDENT = "NA";
        private const String TYPE_RANDOM = "RA";

        private QuickSort<Int32> sorter;
        private Randomized_QS<Int32> sorterR;

        private Dictionary<String, List<double>> timesQS;
        private Dictionary<String, List<double>> timesRandomQS;


        public ExperimentQs() {

            this.sorter = new QuickSort<Int32>();
            this.sorterR = new Randomized_QS<Int32>();

            this.timesQS = new Dictionary<string, List<double>>();
            this.timesRandomQS = new Dictionary<string, List<double>>();
        }

        public void startExperiment() { 

            for(int i = 0; i < 1000; i++)
            {
                initExperimentNonRandomizedQS(TYPE_NONDESCENDENT, orderedNonDescendent(10), orderedNonDescendent(100), orderedNonDescendent(1000), orderedNonDescendent(10000)/*, orderedNonDescendent(100000)*/);
                initExperimentNonRandomizedQS(TYPE_NONASCENDENT, orderedNonAscendent(10), orderedNonAscendent(100), orderedNonAscendent(1000), orderedNonAscendent(10000)/*, orderedNonAscendent(100000)*/);
                initExperimentNonRandomizedQS(TYPE_RANDOM, noOrder(10), noOrder(100), noOrder(1000), noOrder(10000)/*, noOrder(100000)*/);


                initExperimentRandomizedQS(TYPE_NONDESCENDENT, orderedNonDescendent(10), orderedNonDescendent(100), orderedNonDescendent(1000), orderedNonDescendent(10000)/*, orderedNonDescendent(100000)*/);
                initExperimentRandomizedQS(TYPE_NONASCENDENT, orderedNonAscendent(10), orderedNonAscendent(100), orderedNonAscendent(1000), orderedNonAscendent(10000)/*, orderedNonAscendent(100000)*/);
                initExperimentRandomizedQS(TYPE_RANDOM, noOrder(10), noOrder(100), noOrder(1000), noOrder(10000)/*, noOrder(100000)*/);

            }
            convertToCSV();
        }

        public void convertToCSV()
        {
            String csvTimesQS = String.Join(
                Environment.NewLine,
                timesQS.Select(d => $"{d.Key};{string.Join(";", d.Value)}")
            );
            System.IO.File.WriteAllText("../../TimesCSV/timesQS.csv", csvTimesQS);

            String csvTimesRandomQS = String.Join(
                Environment.NewLine,
                timesRandomQS.Select(d => $"{d.Key};{string.Join(";", d.Value)}")
            );
            System.IO.File.WriteAllText("../../TimesCSV/timesRandomQS.csv", csvTimesRandomQS);
        }

        private void initExperimentNonRandomizedQS(String type, Int32[] array10, Int32[] array100, Int32[] array1000, Int32[] array10000/*, Int32[] array100000*/)
        {

            Console.WriteLine(array10.Length + "\n" + array100.Length + "\n" + array1000.Length + "\n" + array10000.Length);

            Console.WriteLine(array10[2] + "\n" + array100[2] + "\n" + array1000[2] + "\n" + array10000[2]);


            //10
            String Key10 = "10"+ type;
            TimeSpan watchI10 = new TimeSpan(DateTime.Now.Ticks);
            sorter.QuickSortAlgorithm(array10, 0, array10.Length-1);
            TimeSpan watchF10 = new TimeSpan(DateTime.Now.Ticks);
            double time10ND = watchF10.Subtract(watchI10).TotalMilliseconds;
            if (!timesQS.ContainsKey(Key10))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time10ND);
                timesQS.Add(Key10, tempList);
            }
            else {
                timesQS[Key10].Add(time10ND);
            }


            //100
            String Key100 = "100" + type;
            TimeSpan watchI100 = new TimeSpan(DateTime.Now.Ticks);
            sorter.QuickSortAlgorithm(array100, 0, array100.Length - 1);
            TimeSpan watchF100 = new TimeSpan(DateTime.Now.Ticks);
            double time100ND = watchF100.Subtract(watchI100).TotalMilliseconds;
            if (!timesQS.ContainsKey(Key100))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time100ND);
                timesQS.Add(Key100, tempList);
            }
            else
            {
                timesQS[Key100].Add(time100ND);
            }




            //1000
            String Key1000 = "1000" + type;
            TimeSpan watchI1000 = new TimeSpan(DateTime.Now.Ticks);
            sorter.QuickSortAlgorithm(array1000, 0, array1000.Length - 1);
            TimeSpan watchF1000 = new TimeSpan(DateTime.Now.Ticks);
            double time1000ND = watchF1000.Subtract(watchI1000).TotalMilliseconds;
            if (!timesQS.ContainsKey(Key1000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time1000ND);
                timesQS.Add(Key1000, tempList);
            }
            else
            {
                timesQS[Key1000].Add(time1000ND);
            }


            //10000
            String Key10000 = "10000" + type;
            TimeSpan watchI10000 = new TimeSpan(DateTime.Now.Ticks);
            sorter.QuickSortAlgorithm(array10000, 0, array10000.Length - 1);
            TimeSpan watchF10000 = new TimeSpan(DateTime.Now.Ticks);
            double time10000ND = watchF10000.Subtract(watchI10000).TotalMilliseconds;
            if (!timesQS.ContainsKey(Key10000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time10000ND);
                timesQS.Add(Key10000, tempList);
            }
            else
            {
                timesQS[Key10000].Add(time10000ND);
            }




            //100000
           /* String Key100000 = "100000" + type;
            TimeSpan watchI100000 = new TimeSpan(DateTime.Now.Ticks);
            sorter.QuickSortAlgorithm(array100000, 0, array100000.Length - 1);
            TimeSpan watchF100000 = new TimeSpan(DateTime.Now.Ticks);
            double time100000ND = watchF100000.Subtract(watchI100000).TotalMilliseconds;
            if (!timesQS.ContainsKey(Key100000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time100000ND);
                timesQS.Add(Key100000, tempList);
            }
            else
            {
                timesQS[Key100000].Add(time100000ND);
            }*/

        }

        private void initExperimentRandomizedQS(String type, Int32[] array10, Int32[] array100, Int32[] array1000, Int32[] array10000/*, Int32[] array100000*/)
        {

            Console.WriteLine(array10.Length + "\n" + array100.Length + "\n" + array1000.Length + "\n" + array10000.Length);

            //10
            String Key10 = "10" + type;
            TimeSpan watchI10 = new TimeSpan(DateTime.Now.Ticks);
            sorterR.RandomizedQSAlgorithm(array10, 0, array10.Length-1);
            TimeSpan watchF10 = new TimeSpan(DateTime.Now.Ticks);
            double time10ND = watchF10.Subtract(watchI10).TotalMilliseconds;
            if (!timesRandomQS.ContainsKey(Key10))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time10ND);
                timesRandomQS.Add(Key10, tempList);
            }
            else
            {
                timesRandomQS[Key10].Add(time10ND);
            }


            //100
            String Key100 = "100" + type;
            TimeSpan watchI100 = new TimeSpan(DateTime.Now.Ticks);
            sorterR.RandomizedQSAlgorithm(array100, 0, array100.Length - 1);
            TimeSpan watchF100 = new TimeSpan(DateTime.Now.Ticks);
            double time100ND = watchF100.Subtract(watchI100).TotalMilliseconds;
            if (!timesRandomQS.ContainsKey(Key100))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time100ND);
                timesRandomQS.Add(Key100, tempList);
            }
            else
            {
                timesRandomQS[Key100].Add(time100ND);
            }




            //1000
            String Key1000 = "1000" + type;
            TimeSpan watchI1000 = new TimeSpan(DateTime.Now.Ticks);
            sorterR.RandomizedQSAlgorithm(array1000, 0, array1000.Length - 1);
            TimeSpan watchF1000 = new TimeSpan(DateTime.Now.Ticks);
            double time1000ND = watchF1000.Subtract(watchI1000).TotalMilliseconds;
            if (!timesRandomQS.ContainsKey(Key1000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time1000ND);
                timesRandomQS.Add(Key1000, tempList);
            }
            else
            {
                timesRandomQS[Key1000].Add(time1000ND);
            }


            //10000
            String Key10000 = "10000" + type;
            TimeSpan watchI10000 = new TimeSpan(DateTime.Now.Ticks);
            sorterR.RandomizedQSAlgorithm(array10000, 0, array10000.Length - 1);
            TimeSpan watchF10000 = new TimeSpan(DateTime.Now.Ticks);
            double time10000ND = watchF10000.Subtract(watchI10000).TotalMilliseconds;
            if (!timesRandomQS.ContainsKey(Key10000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time10000ND);
                timesRandomQS.Add(Key10000, tempList);
            }
            else
            {
                timesRandomQS[Key10000].Add(time10000ND);
            }




            //100000
            /*String Key100000 = "100000" + type;
            TimeSpan watchI100000 = new TimeSpan(DateTime.Now.Ticks);
            sorterR.RandomizedQSAlgorithm(array100000, 0, array100000.Length - 1);
            TimeSpan watchF100000 = new TimeSpan(DateTime.Now.Ticks);
            double time100000ND = watchF100000.Subtract(watchI100000).TotalMilliseconds;
            if (!timesRandomQS.ContainsKey(Key100000))
            {
                List<double> tempList = new List<double>();
                tempList.Add(time100000ND);
                timesRandomQS.Add(Key100000, tempList);
            }
            else
            {
                timesRandomQS[Key100000].Add(time100000ND);
            }*/

        }


        private Int32[] arrayGenerator(int size)
        {
            Random random = new Random();
            Int32[] array = new Int32[size];

            for(int i = 0; i < size; i++)
            {
                Int32 tempRan = random.Next(1, 10000000);

                array[i] = tempRan;
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
