using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
      internal class GenericsClassTwo<T,E>
    {
    
    /* In this Generic Class
     * using 2 Types place holder
     * T and E
     * place Holder name can be AnyThing.
     */
        public T[] array;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericClass{T}"/> class.
        /// </summary>
        /// <param name="array">The array.</param>
        public GenericsClassTwo(T[] array)
        {
            this.array = array;
        }
        public void ToPrint()
        {
            Console.WriteLine("Using Generic class to print Array Element");
            foreach (var item in array)
                Console.WriteLine("Element in Array: " + item);
        }
        //Method for 2nd Type PlaceHolder.
        public static void Value(E item)
        {
            Console.WriteLine(item);
        }
    }
}
   
  
  
