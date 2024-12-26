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
    
    
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while(a <= 10)
            {
                Console.WriteLine("my data is :" + a);
                    a++;

            }
            Class2 p1 = new Class2();
            p1.Add();







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
