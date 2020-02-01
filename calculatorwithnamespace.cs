using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace first
{
    public class operations
    {
     public void add(int x,int y)
        {
            int z = x + y;
            Console.WriteLine(z);
            Console.ReadLine();
        }   
    }
}
namespace second
{
    class operations
    {
        public void sub(int x, int y)
        {
            int z = x - y;
            Console.WriteLine(z);
        }
    }
}

namespace third
{
    class operations
    {
        public void mul(int x, int y)
        {
            int z = x * y;
            Console.WriteLine(z);
        }
    }
}
namespace last

{
    class logic
    {
       public  logic(int x,int y)
        {
            Console.WriteLine("enter operations");
           
            string dfg = Console.ReadLine();
            done(dfg,x,y);
        }
       
        
       
        public void done(string dfg,int x,int y)
        {
            first.operations abc = new first.operations();
            second.operations pqr = new second.operations();
            third.operations wxy = new third.operations();
            if (dfg == "+")
            {
                abc.add(x,y);
            }
            else if(dfg == "-")
            {
                pqr.sub(x, y);
            }
            else if (dfg == "*")
            {
                wxy.mul(x, y);
            }
        }
    }
   
}




namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first no");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second no");
            int y = Convert.ToInt32(Console.ReadLine());
            last.logic abc = new last.logic(x,y);
            Console.ReadKey();
          
        }
    }
}
