using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {


            //-Layihe ise dusdukde sizden adlarin sayini istesin. Daha sonra o say qeder adlari daxil edin.
            // Daha sonra axtardiginiz adi istesin, onu da daxil etdikden sonra siyahida olub olmadigini qaytarsin

            Console.Write("Adlarin sayini daxil edin: ");
            int count = int.Parse(Console.ReadLine());


            string[] nameList = new string[count];

            for (int i = 0; i < nameList.Length; i++)
            {
                Console.Write($"{i + 1}. Adi daxil edin: ");

                nameList[i] = Console.ReadLine();
            }

            Console.Write("Axtardiginiz adi daxil edin: ");
            bool check = false;
            string wantedName = Console.ReadLine();

            for (int j = 0; j < nameList.Length; j++)
            {
                if (nameList[j] == wantedName)
                {
                    check = true;

                    break;
                }
            }
            Console.WriteLine(check);

        }


        #region dersde yazdiglarimiz
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
        #endregion



        //Verilmis adlar siyahisinda(string array) nece adin uzunlugunun 5-den boyuk oldugunu tapan proqram

        static int CountOf5(string[] names)
        {
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 5)
                {
                    count++;
                }

            }
            return count;
        }

        // Verilmis ededler siyahisindaki cut ededlerden ibraret yeni bir array qaytaran method.
        // Misalcun gonderilmis ededler siyahisinda {1,3,4,5,6} deyerleri varsa method geriye {4,6} deyerlerinden ibaret bir array qaytarmalidir
        //yaza bilmedim
        static void OddFinder(int[] numbers)
        {
            int[] nums = { 2, 3, 4, 6 };
            int count = 0;
            int[] oddNums = new int[count];
            int a = -1;
            for (int i = 0; i < nums.Length; i++)
            {




                if (nums[i] % 2 == 0)
                {
                    count++;
                    oddNums = new int[count];

                    a++;

                    oddnums[a] = nums[i];

                }







            }

            foreach (var num in oddNums)
            {
                Console.WriteLine(num);
            }





        }

    }



}










