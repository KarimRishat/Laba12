#define DEBUG_ACCOUNT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            //task14.1
            BankAccount account = new BankAccount(1, 1215015m);
            account.DumpToScreen();
            //task14.2
            Ratio r1 = new Ratio(4, 3);
            Ratio r2 = new Ratio(3, 4);
            Type t = typeof(Ratio);
            object[] attrs = t.GetCustomAttributes(false);
            Console.WriteLine("\nTask14.2");
            foreach (DeveloperInfoAttribute attr in attrs)
            {
                Console.WriteLine(attr.ToString());
            }
            //task14.3
            t = typeof(Building);
            attrs = t.GetCustomAttributes(false);
            Console.WriteLine("\nTask14.3");
            foreach (OrganizationInfoAttribute attr in attrs)
            {
                Console.WriteLine(attr.ToString());
            }
            Console.ReadKey();
        }
    }
}
