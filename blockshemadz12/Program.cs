using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blockshemadz12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ToDo()
            {
                bool res = false;
                int[] Mas = new int[4];
                Mas[0] = 10;
                Mas[1] = 11;
                Mas[2] = 12;
                Mas[3] = 3;

                int n = Mas.Length;

                for (int i = 0; i < n; i++)
                {
                    if (Mas[i] == i)

                        res = true;
                }
                return res;
            }
            ToDo();
        }
    }
}
