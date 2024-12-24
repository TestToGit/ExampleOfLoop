using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfLoop
{
    public delegate void display();
    public delegate void calculation(int Num1 ,  int Num2); 
    class Program
    {
      public static void Addition(int Num1 , int Num2)
        {
            int result = Num1 + Num2;
            Console .WriteLine(result);
        }
        public static void Substraction(int Num1, int Num2)
        {
            int result = Num1 - Num2;
            Console.WriteLine(result);
        }
        public static void Multiply(int Num1, int Num2)
        {
            int result = Num1 * Num2;
            Console.WriteLine(result);
        }
        public static void division(int Num1, int Num2)
        {
            int result = Num1/Num2;
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
           calculation c1 = new calculation(Multiply);
            c1(10, 20);
            c1 += Substraction;  
            Console.WriteLine("Substraction");
            c1 += Multiply;
            Console.WriteLine("Multiply");
            c1 += division;
            Console.WriteLine("division");







            //p1.Add();
            //Program.Add(Id:1,Name:"sarvesh");
            Console.ReadLine();

            //Console.WriteLine("How many number you store in Array");
            //int num = int.Parse(Console.ReadLine());
            //int[] numbers = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("Enter Data on Location :" +i);
            //    int data = int.Parse(Console.ReadLine());
            //    numbers[i] = data;

            //}
            //Console.WriteLine("....your Data.....");
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
