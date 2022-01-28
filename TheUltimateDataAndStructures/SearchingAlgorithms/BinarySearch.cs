using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace TheUltimateDataAndStructures.SearchingAlgorithms
{
    public class BinarySearch
    {
        //funziona solo con array ordinati
        //quindi prima della ricerca occorre ordinare l'array
        //Time complexity O(log n)
        //Space complexity O(log n) in quanto l'allocazione dello spazio necessario
        //dipende da quanti cicli di ricorsione occorre fare.
        public int SearchRec(int[] Array,int Target,int Left,int Right)
        {
            //recupera l'item nel mezzo
            if (Right < Left)
                return -1;

            int middle = (Left + Right) / 2;
            int res = -1;
            //condizione di uscita, ritorna l'indice del valore trovato
            if (Target == Array[middle])
            {
              
                return middle;
            }
            else
            {
                if (Target < Array[middle])
                {
                    //prende la sezione di sinistra
                    //int middle2 = (0 + middle-1) / 2;
                    //chiama la ricorsiva
                  res= SearchRec(Array, Target, Left, middle - 1);
                }
                else
                {
                    //prende la sezione di destra
                    //int middle3 = (middle + 1 + Array.Length) / 2;
                    res = SearchRec(Array, Target, middle + 1, Right);
                    //chiama la ricorsiva

                }
            }

            return res;
        }

        public int SearchRec2(int[] Array, int Target)
        {
          return  SearchRec2(Array, Target, 0, Array.Length - 1);
        }

        //il codice seguente fa la stessa ricerca di sopra ma più sintetico
        private int SearchRec2(int[] Array, int Target, int Left, int Right)
        {
            //recupera l'item nel mezzo
            if (Right < Left)
                return -1;

            int middle = (Left + Right) / 2;
            //condizione di uscita, ritorna l'indice del valore trovato
            if (Target == Array[middle])
                return middle;

                if (Target < Array[middle])
                    //prende la sezione di sinistra
                    //chiama la ricorsiva
                return SearchRec2(Array, Target, Left, middle - 1);

                    //prende la sezione di destra
                return SearchRec2(Array, Target, middle + 1, Right);

        }

        public int SearchIter(int[] Array, int Target)
        {
            var left = 0;
            var right = Array.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (Target == Array[middle])
                    return middle;

                if (Target < Array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;

            }

            return -1;
        }
    }
}
