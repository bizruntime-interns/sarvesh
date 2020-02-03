using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace araaylist
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add(2);
            obj.Add("three");
            obj.Add(4);
            for(int i = 0; i < obj.Count; i++)
            {
                Console.WriteLine(obj[i]);
            }
            Console.ReadLine();

        }
    }
}
