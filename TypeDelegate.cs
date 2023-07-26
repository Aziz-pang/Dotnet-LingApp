using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingApp
{
    internal class TypeDelegate
    {
        public static void MainRun()
        {
            D1 d = F1;
            F1();

            Add num = Add;
            Console.WriteLine(num(1, 2));
            Action<string> f2 = str => Console.WriteLine(str);
            f2("good");

            ListWhere();
        }
        static void ListWhere()
        {
            int[] nums = new int[] { 2, 3, 4, 5, 1, 5, 2, 3, 4, 5 };
            // IEnumerable 的扩展语法
            IEnumerable<int> result = nums.Where(x => x > 2);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        static void F1()
        {
            Console.WriteLine("f1");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
    delegate void D1();
    delegate int Add(int x, int y);
}
