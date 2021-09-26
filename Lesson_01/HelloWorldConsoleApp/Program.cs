// Импорт сторонних пространств имён
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Пространство имён
/// Создание собственной библиотеки
/// </summary>
namespace HelloWorldConsoleApp
{
    /// <summary>
    /// Главная составляющая единица приложения - класс
    /// Подробности в Теме 7. Структуры и введение в ООП
    /// </summary>
    class Program
    {
        /// <summary>
        /// Код, который выполняется в первую очередь
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {

            //Задание 1
            Console.WriteLine("Hello World!!!");
            Console.ReadKey();

            //Задание 2
            Console.Write("\nHello");
            Console.Write(" World");
            Console.Write("!!!\n");

            ConsoleKey key;
            while (true)
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Enter)
                    break;
            }
            
        }
    }
}
