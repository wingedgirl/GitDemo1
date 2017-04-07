using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入Y/N：");
            string fiels = Console.ReadLine();
            if(fiels=="Y")
            {
                Console.WriteLine("你同意了使用github");
            }
            else
            {
                Console.WriteLine("你否决了！");
            }


            Console.ReadKey();
        }
    }
}
