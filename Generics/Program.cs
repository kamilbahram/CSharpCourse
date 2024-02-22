using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics");

            MyGeneric<string> myList = new MyGeneric<string>();
            MyGeneric<int> myList2 = new MyGeneric<int>();

            myList2.Add(145);
            myList2.Add(2); 
            myList2.Add(378);

            myList.Add("kamil");
            myList.Add("canan");
            myList.Add("zlatan");

            Console.WriteLine(myList.GetType());
            Console.WriteLine(myList._array[0]);
            
            Console.WriteLine("isimler");
            foreach (var item in myList._array)
                Console.WriteLine(item);
            foreach (var item in myList2._array)
                Console.WriteLine(item);
            
            Console.WriteLine(myList.Count);
            
            Console.ReadLine(); 
        }
    }
    class MyGeneric<T>
    {
        public T[] _array { get; set; }
        public T[] _tempArray { get; set; }
        public MyGeneric()
        {   
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; 
            }
            _array[_array.Length -1] = item;
        }
        private int count;

        public int Count
        {
            get { return _array.Length; }
            set { count = value; }
        }

    }
}
