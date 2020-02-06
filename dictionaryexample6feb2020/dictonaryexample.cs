using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryexample6feb
{
    public class customer
    {
        public string custid { get; set; }
        public string custname { get; set; }
        public int salary { get; set; }
        public string dob { get; set; }
    }
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            List<customer> customers = new List<customer>();
            customer c1 = new customer { custid = "2016cse347", custname = "dinesh", salary = 4000, dob = "29/12/1999" };
            customer c2 = new customer { custid = "2016cse452", custname = "baiju", salary = 40000, dob = "28/11/1999" };
            customer c3 = new customer { custid = "2016cse324", custname = "suresh", salary = 47000, dob = "27/10/1998" };
            customer c4 = new customer { custid = "2016cse4522", custname = "manas", salary = 45000, dob = "26/18/1994" };
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            foreach(customer obj in customers)
            {
                log.Info(obj.custid+" "+obj.custname+" "+obj.salary+" "+obj.dob);
            }
            Console.ReadLine();


        }
    }
}
