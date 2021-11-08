using System;
using System.Collections.Generic;

namespace OrnekGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();
            isimler.Add("hacı");


            MyList <string> isimler2 = new MyList <string>();
            isimler2.Add("Ömer");



        }
    }
    class Mylist<T>
    {
        T[] _array;
        T[] _tempArray;


        public Mylist()
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
            _array[_array.Length - 1] = item;
        }
        private int myVar;

        public int count
        {
            get { return _array.Length; }
        
        }

    }
}
