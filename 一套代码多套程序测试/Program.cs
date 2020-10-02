using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一套代码多套程序测试
{
    class Program
    {
        static void Main(string[] args)
        {
#if ACAD||DEBUG
            global::System.Console.WriteLine("This is AutoCAD!!!");
#elif BCAD
            global::System.Console.WriteLine("This is BricsCAD!!!");
#else
            global::System.Console.WriteLine("This is GstarCAD!!!");
#endif
            Console.ReadKey();
        }
    }
}
