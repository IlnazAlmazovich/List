using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполнить List случайными числами.
            //Затем пользователь вводит случайное число, определить есть ли элемент с таким индексом и вывести его на консоль, затем удалить данный элемент

            List<int> list = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                list.Add(rand.Next(1, 100));
            }

            Console.WriteLine("Исходный список:");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Введите индекс:");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < list.Count)
            {
                Console.WriteLine($"Элемент с индексом {index} равен: {list[index]}");
                list.RemoveAt(index);
                Console.WriteLine($"Элемент {list[index]} удален");
                Console.WriteLine();
                Console.WriteLine("Список после удаления:");

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Элемент с таким индексом не найден");
            }

            Console.ReadKey();
        }
    }
}
