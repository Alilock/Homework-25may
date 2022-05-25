using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktorial(a));

            

            

        }

        static int isOdd(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }

        static int CountOfNum(int[] numbers, int num)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    count++;
                }
            }
            return count;
        }

        static bool HasNum(int[] numbers, int num)
        {
            bool check = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    check = true;
                    return check;
                }
            }
            return check;

        }
        static int AverageOfPoint(int[] points)
        {
            int sum = 0;
            int average;

            for (int i = 0; i < points.Length; i++)
            {
                sum += points[i];
            }

            average = sum / points.Length;
            return average;
        }

        static bool NameFinder(string[] list, string name)
        {
            bool check = false;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == name)
                {
                    check = true;
                    break;
                }

            }
            return check;
        }

        static int Faktorial(int n)
        {
            int fakt = 1;
            for (int i = 1; i <= n; i++)
            {
                fakt = fakt * i;
            }
            return fakt;
        }
    }
    



}


