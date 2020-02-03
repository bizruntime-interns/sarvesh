using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack();
            Console.WriteLine("enter the size of the stack");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the elements to be pushed");
            for(int i=0; i < size; i++)
            {
                obj.Push(Console.ReadLine());
            }
            Console.WriteLine("these items are pushed");
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("the no of items in stack is :{0} ", obj.Count);
            while (obj.Count > 0)
            {
                Console.WriteLine(obj.Pop());
            }
            Console.WriteLine("items in the stack are: {0} ",obj.Count);
            Console.ReadKey();
        }
    }
}
