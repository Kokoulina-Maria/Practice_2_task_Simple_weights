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
        static int ChooseMinPrime(int number)
        {//функция, отыскивающая минимальное простое число, большее данного не простого
            for (int i = number + 1; i <= 500009; i++)//перебираем числа от исходного до максимального возможного простого
            {
                if (PrimeNumber(i)) return i;//как только встречаем простое число, возвращаем его
            }
            return 0;//для того, чтобы не подчеркивали. Такой вариант невозможен, так как 500009 - простое
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());//считываем N
            if (PrimeNumber(N))//если N простое
            {
                for (int i = 1; i <(N+1) / 2; i++)//выводим его слагаемые (1 и N-1, 2 и N-2... до середины)
                    Console.WriteLine(i + " " + (N - i));
            }
            else//Если N не простое
            {
                while (N > 0)//выполняем действия до тех пор, пока не дойдем до начала числового ряда, то есть до тех пор, пока N не станет равным 0
                {
                    int MinPrime = ChooseMinPrime(N);//находим минимальное простое, большее данного числа
                    for (int i = MinPrime - N; i <= MinPrime / 2; i++)//выводим слагаемые MinPrime, начиная с MinPrime-N и N, и так далее (MinPrime-N+1 и N-1... до середины MinPrime)
                        Console.WriteLine(i + " " + (MinPrime - i));
                    N = MinPrime - N - 1;//теперь нужно составить пары из оставшихся чисел, меньших MinPrime-N
                }               
            }
            Console.ReadLine();
        }
    }
}
