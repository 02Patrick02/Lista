using System;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            
           for(int i = 0; i < 100; i++)
            {
                list.add(i);
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
