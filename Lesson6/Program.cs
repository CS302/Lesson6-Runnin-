using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num1 = 100;
            int num2 = 200;

            num1 = num2;

            num2 = 300;
            Console.WriteLine(num1);
            Console.WriteLine(num2);*/

            /*Point p1 = new Point(100);
            Point p2 = new Point(200);
            p1 = p2;
            p2.x = 300;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);*/

            /*int a = 100;
            int b = 200;
            Switch(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);*/

            /*int[] mass = new int[5] { 1, 2, 3, 4, 5 };
            mass = DoubleMass(mass); //1 2 3 4 5 1 2 3 4 5
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[i]);
            }*/

            /*int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(number,2));*/ //number*number

            int number;

            bool flag = int.TryParse(Console.ReadLine(), out number);
            if (!flag)
                Console.WriteLine("Введено не число! поробуйте еще раз.");
            else
                Console.WriteLine(Math.Pow(number, 2));

            int[,] array = { {1, 2, 3, 4, 5}, {1,2,3,4,5} };

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.WriteLine(array[i, j]);

            Console.ReadLine();
        }

        private static int[] DoubleMass(int[] mass)
        {
            int[] newMass = new int[2 * mass.GetLength(0)];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                newMass[i] = mass[i];
                newMass[i + mass.GetLength(0)] = mass[i];
            }
            return newMass;
        }

        /*private static void DoubleMass(ref int[] mass)
        {
            int[] newMass = new int[2 * mass.GetLength(0)];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                newMass[i] = mass[i];
                newMass[i + mass.GetLength(0)] = mass[i];
            }
            mass = newMass;
        }*/

        private static void Switch(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }

    class Point
    {
        public int x;
        public Point(int x)
        {
            this.x = x;
        }
    }
}
