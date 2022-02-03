using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{ 
    internal class GenericClass<T>
    {
        public T[] array;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericClass{T}"/> class.
        /// </summary>
        /// <param name="array">The array.</param>
        public GenericClass(T[] array)
        {
            this.array = array;
        }
        public void ToPrint()
        {
            Console.WriteLine("Using Generic class to print Array Element");
            foreach (var item in array)
                Console.WriteLine("Element in Array: " + item);
        }
    }
}
  
