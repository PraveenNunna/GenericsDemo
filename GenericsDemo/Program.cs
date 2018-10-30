using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.DebugFormat("fdsfdsfsf {0}", "Hi");
            Console.WriteLine();
            new UsingGenericList().AddItemToList();
            Console.ReadKey();
        }
    }
}
