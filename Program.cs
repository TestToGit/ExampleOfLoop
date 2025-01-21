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
        private string EmpName;
        private int EmpAge;

        public void setEmpName(string Name)
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is Empty");
            }
            else
            {
                this.EmpName = Name;
            }

        }
        public void GetEmpName()
        {
            Console.WriteLine("Employee Name is : " + this.EmpName);
        }
        public void SetEmpAge(int Age)
        {
            if (Age < 18)
            {
                Console.WriteLine("Age is less than 18");
            }
            else
            {
                this.EmpAge = Age;
            }
        }
        public void GetEmpAge()
        {
            if (EmpAge < 18)
            {

            }
            else
            {
                Console.WriteLine("Employee Age is : " + this.EmpAge);
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.setEmpName("Sarvesh");
            p1.GetEmpName();
            p1.SetEmpAge(25);
            p1.GetEmpAge();
            Class3 c3 = new Class3();
            c3.Substract(40, 20);
            // Load TestBranch4

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
