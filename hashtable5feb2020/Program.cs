using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasttable5feb
{
    class Program
    {
        private static readonly log4net.ILog log =
           log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Hashtable data = new Hashtable();
            log.Info("enter size");
            var size = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i < size; i++)
            {
                log.Info("enter key");
                var key1 =Console.ReadLine();
                log.Info("enter respected value");
                var value = Console.ReadLine();
                data.Add(key1, value);
            }
            log.Info("what you want to know in the given data enter");
            foreach(object Key in data.Keys)
            {
                log.Info(Key);
            }
            var key = Console.ReadLine();
            log.Info("your result is : {0} ");
            log.Info(data[key]);
            log.Info("anything you want to change press 1 for update or press 0 for terminate");
            var enter = Console.ReadLine();
            while (true)
            {
                if (enter == "1")
                {
                    log.Info("anything you want to update");
                    var change = Console.ReadLine();
                    log.Info("enter the changed data");
                    data[change] = Console.ReadLine();
                    log.Info(data[change]);
                    log.Info("enter '1' for any further update or press '0' for terminate process");
                    enter = Console.ReadLine();
                }
                else if (enter == "0")
                {
                    log.Info("process have been terminated");
                    break;
                }
                else
                {
                    log.Info("you entered wrong value please check and press '1' for update and '0' for terminate process");
                    enter = Console.ReadLine();
                }
            }
            log.Info("the data after updation is: ");

            foreach (KeyValuePair<string,string> item in data)
            {
                log.InfoFormat("key:{0}, value:{1}", item.Key, item.Value);
            }
            Console.ReadLine();

        }
    }
}
