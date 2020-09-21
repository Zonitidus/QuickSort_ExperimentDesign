using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_ExperimentDesign_Randomized_NotRandomized_.SortingAlgorithms
{
    class Randomized_QS<T> where T : IComparable<T>
    {
        public void RandomizedQSAlgorithm(T[] a, int p, int r)
        {
            if (p < r)
            {
                int q = RandParti(a,p,r);
                RandomizedQSAlgorithm(a, p, q - 1);
                RandomizedQSAlgorithm(a, q + 1, r);

            }
        }

        public int RandParti(T[] a, int p, int r)
        {
            Random rnd = new Random();
            int i = rnd.Next(p, r);
            T a1 = a[i];
            T a2 = a[r];

            a[i] = a2;
            a[r] = a1;
            return Partition(a, p, r);
        }

        public int Partition(T[] a, int p, int r)
        {

            T aux = a[r];
            int i = p - 1;

            for (int j = p; j <= r - 1; j++)
            {
                if (a[j].CompareTo(aux) <= 0)
                {

                    i += 1;

                    T aux1 = a[i];
                    T aux2 = a[j];

                    a[i] = aux2;
                    a[j] = aux1;

                }
            }

            T aux3 = a[i + 1];
            T aux4 = a[r];

            a[i + 1] = aux4;
            a[r] = aux3;

            return i + 1;
        }
    }
}
