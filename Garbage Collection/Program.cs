using System;

namespace Garbage_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"Создан элемент {i}, удалён: ");
                Class1 obj = new Class1(i, true);
                GC.WaitForPendingFinalizers();
                Console.WriteLine();
            }
            
            CheckTime(100000);
        }
        private static void CheckTime(int n)
        {
            Class1[] classes = new Class1[n];
            for (int i = 0; i < classes.Length; i++) classes[i] = (new Class1(i, false));
            classes = null;
            DateTime begin = DateTime.Now;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            DateTime end = DateTime.Now;
            var delta = end - begin; 
            Console.WriteLine();
            Console.WriteLine($"Сборка мусора работала {delta.TotalMilliseconds + " милисекунд"} с {n} объектами"  );
        }
    }
}
