using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("enter the size of the table");
            int size = Convert.ToInt32(Console.ReadLine());
            
            
            for(int i=0; i <size; i++)
            {
                Console.WriteLine("enter key");
                var x = Console.ReadLine();
                Console.WriteLine("enter value");
                var y = Console.ReadLine();
                ht.Add(x, y);
            }
            foreach(var item in ht)
            {
                Console.WriteLine("key values are {0} {1}",item.Key,item.Value);
            }
            Console.ReadLine();
        }
    }
}
