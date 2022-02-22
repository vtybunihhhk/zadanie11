using System;

namespace minNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] myarray = new int[num];
            Console.WriteLine("Введите элементы массива (через Enter):");
            // заполнение массива вводом с клавиатуры
            for (int i = 0; i < num; i++)
            {
                
                    myarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            

            // поиск минимального элемента
            int min = myarray[0];

            for (int i = 0; i < num; i++)
            {
                
                
                    if (min > myarray[i])
                        min = myarray[i];
                
            }
            Console.WriteLine("Минимальный элемент:" + min);
            Console.ReadLine();

        }
    }
}
