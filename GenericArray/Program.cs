using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericArray<int> array = new GenericArray<int>();
            array.Add(1);
            array.Add(2);
            array.Add(3);

            PrintElement(array, 0);
            PrintElement(array, 1);
            PrintElement(array, 2);

            Console.WriteLine("We are removing element at index 1");
            array.Remove(1);

            PrintElement(array, 0);
            PrintElement(array, 1);
        }
        static void PrintElement<T>(GenericArray<T> array, int index)
        {
            try
            {
                Console.WriteLine($"Element at index {index}: {array.GetElement(index)}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class GenericArray<T>
    {
        private List<T> items;
        public GenericArray()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Remove(int ind)
        {
            if (ind >= 0 && ind < items.Count)
            {
                items.RemoveAt(ind);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }
        public T GetElement(int ind)
        {
            if (ind >= 0 && ind < items.Count)
            {
                return items[ind];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }
}
