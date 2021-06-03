using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection
{

    class Class1
    {
        public List<long> objects = new List<long>();
        private int number;
        private bool flag;
        public Class1(int Num, bool Flag)
        {
            this.number = Num;
            this.flag = Flag;
            for (int i = 0; i < 10000; i++) objects.Add(i);
        }
        ~Class1() { if (flag) Console.Write(number + " "); }
    }
}
