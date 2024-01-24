using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>() //объявляем список с начальными значениями
                                                  //в скобках можно указать ёмкость списка
            {
                 "Ильдина",
                 "Влад",
                 "Софа",
                 "Полина",
                 "Юра",
                 "Эдуард",
                 "Дима",
                 "Маша"
            };
            Console.WriteLine("Вывод на консоль:");
            foreach (string s in name) //перебираем список
            {
                Console.WriteLine(s); //выводим на консоль
            }
            Console.WriteLine();

            //Добавление
            name.Add("Лариса"); //добавление значения
            name.AddRange(new[] { "Алина", "Марина", "Богдан", "Миша" }); //добавление массива

            // также можно было бы добавить другой список
            // name.AddRange(new List<string>(){ "Ирина", "Гриша", "Вика", "Женя"});
            Console.WriteLine("Добавление новых элементов:");
            foreach (string s in name) //перебираем список
            {
                Console.WriteLine(s); //выводим на консоль
            }
            Console.WriteLine();

            //Добавление элемента на определённую позицию
            name.Insert(3, "Ваня"); // указывается позиция и значение

            //также можно добавть массив на определённую позицию
            //name.InsertRange(1, new string[] { "Тимур", "Даша" }); // вставляем массив с индекса 1
            Console.WriteLine("Добавление на определённую позицию:");
            foreach (string s in name) //перебираем список
            {
                Console.WriteLine(s); //выводим на консоль
            }
            Console.WriteLine();

            //Удаление
            //Удаляем элемент по индексу
            string del = name[8]; //выбираем определённый элемент, для того чтобы потом вывести его на консоль
            name.RemoveAt(8);//удаляем по индексу
            Console.WriteLine("Удаление элементов из списка:");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Удалённое значение под индексом 8 = {del}");

            Console.WriteLine();
            //Удаляем элемент по значению
            Console.WriteLine("Удаляем по значению:");
            name.Remove("Влад");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }
    }
}
