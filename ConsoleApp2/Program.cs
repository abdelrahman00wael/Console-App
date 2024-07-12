using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        int Ssn;
        String Name;
        int Age;
        String phone;
        public Student(int id, String name, int age, String Phone)
        {
            Ssn = id;
            Name = name;
            Age = age;
            phone = Phone;
        }
        public void GetStud()
        {
            Console.WriteLine($"{Name} {Ssn} {Age} {phone}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            //task 1
            Console.Write("Plese Enter Num :");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{num}*{i} ={num * i} ");
            }



            //task 2
            Console.Write("Please Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            
            Console.Write("Please Enter name: ");
            string name = Console.ReadLine();

            int age;
            do
            {
                Console.Write("Please Enter Age: ");
                age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    Console.WriteLine("Please Enter Age Greater Than 0");
                }
            } while (age <= 0);

            Console.WriteLine($"ID: {id} Name: {name} Age: {age}");

            //task 3
            Student student = new Student(1,"Abdelrahman", 20, "01287994064");
            student.GetStud();


        }
    }
}