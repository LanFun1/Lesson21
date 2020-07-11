using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение, которое вы хотите вывести на экран.");
            string codMessage = Console.ReadLine();
            Console.Write("Введите количество выводимых сообщений:");
            int amountMessages = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<amountMessages;i++)
            {
                Console.WriteLine(codMessage);
            }
        }
    }
}
