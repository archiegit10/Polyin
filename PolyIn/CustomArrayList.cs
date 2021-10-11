using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyIn
{
    class CustomArrayList<T>
    {
        private T[] arr;
        public CustomArrayList(T[] values)
        {
            this.arr = values;
        }
        public void Add(T i)
        {
            // create new array with 1 more space for new value, copy over old values
            T[] newArr = new T[arr.Length + 1];
            arr.CopyTo(newArr, 0);
            // add new value to end of array
            newArr[newArr.Length - 1] = i;
            arr = newArr;
        }
        public void PrintValues()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        // Pop will remove the last element from the list and return it
        // - remember to make your array smaller after removing the element
        public T Pop()
        {
            T item = arr[arr.Length - 1];

            T[] newArr = new T[arr.Length - 1];

            for(int i = 0; i < arr.Length -1; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;

            return item;
        }
    }
}
