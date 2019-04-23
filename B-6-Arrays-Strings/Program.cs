using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Work6();
            //B6P36();
            //B6P56();  //Begin B6-P5/6. CutString. вариант первый
            B6P562(); //B6-P5/6. CutString. вариант второй
            //B6P66();  //B6-P6/6. ReplaceInPoem
            Console.ReadLine();
        }

        public static void Work6()
        {
            int[,] mass = new int[3, 4];
            initmass(mass);
            Console.WriteLine();
            printmass(mass);

        }

        private static void printmass(int[,] mass)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{mass[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static Random r = new Random();
        private static void initmass(int[,] mass)
        {
            for (int i = 0; i < 3; i++)
            {
                int max = mass[i, 0];
                for (int j = 0; j < 3; j++)
                {
                    mass[i, j] = r.Next(10);
                    if (max < mass[i, j])
                    {
                        max = mass[i, j];
                    }
                }
                Console.WriteLine($"max= {max} ");
            }
        }

        public static void B6P36()
        {
            int[] mass1 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"введите {i}-й элемент массива:");
                mass1[i] = Convert.ToInt16(Console.ReadLine());
            }
            //B6P361(mass1); //Bubble sort
            B6P362(mass1); //Insertion sort
        }

        //Bubble sort
        private static void B6P361(int[] mass1)
        {
            int temp;
            for (int i = 0; i < mass1.Length; i++)
            {
                for (int j = 0; j < mass1.Length - 1; j++)
                {
                    if (mass1[j] > mass1[j + 1])
                    {
                        temp = mass1[j + 1];
                        mass1[j + 1] = mass1[j];
                        mass1[j] = temp;
                    }
                }
            }

            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write($"{mass1[i]} ");
            }
        }
        //End Bubble sort

        //Insertion sort
        private static void B6P362(int[] mass1)
        {
            int temp;
            for (int i = 1; i < mass1.Length; i++)
            {
                temp = mass1[i];
                int j = i - 1;
                while (j >= 0 && mass1[j] > temp)
                {
                    mass1[j + 1] = mass1[j];
                    mass1[j] = temp;
                    j--;
                }
            }

            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write($"{mass1[i]} ");
            }
        }
        //End Insertion sort

        private static void B6P363(int[] mass1)
        {



        }


        private static void B6P364(int[] mass1)
        {



        }

        private static void Pyatnashki()
        {

        }


        //Begin B6-P5/6. CutString. вариант первый
        private static void B6P56()
        {
            Console.WriteLine("Введите строку");
            //string mysug = Console.ReadLine();
            StringBuilder mysug = new StringBuilder(Console.ReadLine());
            int length = mysug.Length;
            Console.WriteLine($"длинна строки {length}");
            if (length > 13)
            {
                mysug.Remove(13, mysug.Length - 13);
                mysug.Append('.', 3);
                Console.WriteLine(mysug);
                Console.WriteLine($"длинна строки {length}");
            }
        }
        //End Begin B6-P5/6. CutString. вариант первый

        //Begin B6-P5/6. CutString. вариант второй 
        private static void B6P562()
        {
            Console.WriteLine("Введите предложение");
            string mysug = Console.ReadLine();
            int length = mysug.Length;
            string mystr = mysug.Remove(13);
            string str = mystr + "...";
            int length1 = str.Length;
            Console.WriteLine(str);
        }
        //End B6-P5/6. CutString. вариант второй 

        //Begin B6-P6/6. ReplaceInPoem
        private static void B6P66()
        {
            Console.WriteLine("Введите стих");
            //string mysug = Console.ReadLine();
            string mysug = "Leaves are floating; softly down;Some are red and;some are brown; The wind goes «swish»; through the air;When you look back;there are no leaves there;";
            Console.WriteLine(mysug);
            string fomstr = mysug.Replace("o", "a").Replace("l", "ly").Replace("t", "TT");
            Console.WriteLine(fomstr);
            string[] substr = fomstr.Split(';');
            for (int i = 0; i < substr.Length; i++)
            {
                Console.WriteLine(substr[i].Trim());
            }
        }
        //Begin B6-P6/6. ReplaceInPoem
    }
}
