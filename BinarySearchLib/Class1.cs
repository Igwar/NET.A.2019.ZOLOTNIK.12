using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchLib
{
    public static class Searcher
    {
      

        /// <summary>
        ///  Searches a range of elements in a one-dimensional sorted array for a value, using
        ///  the specified System.Collections.Generic.IComparer generic interface.
        /// </summary>
        /// <typeparam name="T">  The type of the elements of the array. </typeparam>
        /// <param name="arr"> The sorted one-dimensional array to search. </param>
        /// <param name="index"> The starting index of the range to search. </param>
        /// <param name="count"> The length of the range to search. </param>
        /// <param name="item"> The object to search for. </param>
        /// <param name="comparer">  The System.Collections.Generic.IComparer implementation to use when comparing
        /// </param>

        public static int BinarySearch<T>(T[] arr, int index, int count, T item, IComparer<T> comparer)
        {


            if (arr == null)
                throw new ArgumentNullException(nameof(arr));
            if (index < 0)
                throw new ArgumentException("The index can't be less than zero.");
            if (count < 0)
                throw new ArgumentException("The count can't be less than zero.");
            if (arr.Length < index + count)
                throw new ArgumentException("The search area more than current area.");
            if (comparer == null)
            {
                comparer = (item is IComparable<T>)
                    ? Comparer<T>.Default
                    : throw new ArgumentException("The type must be IComparable or use IComparer<T> or Comparison<T>.");
            }



            int last = index + count;

            while (index < last)
            {
                int mid = index + (last - index) / 2;

                if (comparer.Compare(item, arr[mid]) <= 0)
                    last = mid;
                else
                    index = mid + 1;
            }

            if (arr[last].Equals(item))
                return last;

            return -1;


        }
        public static int BinarySearch<T>(T[] arr, int index, int count, T item, Comparison<T> delComparison) =>
            BinarySearch(arr, index, count, item, Comparer<T>.Create(delComparison));
    }

}
