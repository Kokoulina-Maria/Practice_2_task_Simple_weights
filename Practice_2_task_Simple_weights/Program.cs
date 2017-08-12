using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2_task_Simple_weights
{
    class Program
    {
        static bool PrimeNumber(int number)
        {//функция, определяющая, является ли данное число простым
            for (int i=2; i<=Math.Sqrt(number); i++)//перебираем числа от 2 до корня из number
            {
                if (number % i == 0) return false;//если встрчаем число, на которое number делится, то возвращяем false
            }
            return true;//если не встречаем числа, на которое number делится, то возвращаем true
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());//считываем N
            if (PrimeNumber(N))//если N простое
            {
                for (int i = 1; i <(N+1) / 2; i++)//выводим его слагаемые (1 и N-1, 2 и N-2... до середины)
                    Console.WriteLine(i + " " + (N - i));
            }
            Console.ReadLine();
        }
    }
}
