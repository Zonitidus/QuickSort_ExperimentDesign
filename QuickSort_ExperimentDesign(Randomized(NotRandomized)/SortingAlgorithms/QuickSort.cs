using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_ExperimentDesign_Randomized_NotRandomized_.SortingAlgorithms
{
    public class QuickSort<T> where T : IComparable<T>
    {

        public QuickSort(){
            


        }

        public void QuickSortAlgorithm(T[] array, int p, int r) {

            if (p < r) {

                int q = this.Partition(array, p, r);
                QuickSortAlgorithm(array,p, q-1);
                QuickSortAlgorithm(array, q+1, r);
            }
        
        }

        public int Partition(T[] array, int p, int r) {

            T aux = array[r];
            int i = p - 1;

            for (int j = p; j <= r-1; j++) {
                if (array[j].CompareTo(aux) <= 0) {

                    i += 1;

                    T aux1 = array[i];
                    T aux2 = array[j];

                    array[i] = aux2;
                    array[j] = aux1;

                }
            }

            T aux3 = array[i + 1];
            T aux4 = array[r];

            array[i + 1] = aux4;
            array[r] = aux3;

            return i+1;
        }

    }
}
