using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Сапарб
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите сообщение:");
            string input = Console.ReadLine();
            Console.WriteLine("Введите максимальное количество букв (n):");
            if (!int.TryParse(Console.ReadLine(), out int maxLength))
            {
                Console.WriteLine("Введите корректное число.");
                return;
            }
            PrintWordsWithMaxLength(input, maxLength);
            Console.ReadKey();
        }

        static void PrintWordsWithMaxLength(string input, int maxLength)
        {
            var words = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var filteredWords = words.Where(word => word.Length <= maxLength);
            Console.WriteLine($"Слова с не более чем {maxLength} буквами: {string.Join(", ", filteredWords)}");
        }



    }
}


