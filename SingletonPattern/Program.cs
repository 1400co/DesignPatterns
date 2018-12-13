using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Pattern example by 1400.");

            Singleton.Instance.Show();
            Singleton.Instance.Show();

            Console.ReadKey();

        }
    }
}
