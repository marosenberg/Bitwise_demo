using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Flags]
    public enum Days
    {
        Sunday = 0x0001,
        Monday = 0x0002,
        Tuesday = 0x0004,
        Wednesday = 0x0008,
        Thursday = 0x0010,
        Friday = 0x0020,
        Saturday = 0x0040
    }
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Days s = Days.Sunday;
            if (s == (Days.Sunday | Days.Saturday))
            {

            }
            Days d = Days.Sunday | Days.Saturday;
            Console.WriteLine(d.ToString("G"));
            Console.ReadKey();
        }
    }
}
