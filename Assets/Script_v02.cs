using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //int a = 5;
        //int a = 7;
        //int b = 7;
        //int c = 10;
        //if(a < b) 
        //if (a < b && c >b)
        //if (b > a)

        //{
        //Console.WriteLine($"����� {b} ������ ����� {a}");
        //Console.WriteLine($"����� {c} ������ ���� ����� ");
        //    Console.WriteLine($"����� {b} ������ ����� {a}");
        //}
        //else if (b < a)
        //{
        //    Console.WriteLine($"����� {b} ������ ����� {a}");
        //}
        //else
        //{
        //    Console.WriteLine($"����� {b} ����� ����� {a}");
        //}


        //for (int i = 1; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //int i=0;
        //while (i <= 10)
        //{
        //    i++;
        //    Console.WriteLine(i);

        //������


        //int[] numbers = new int[5];
        //int[] numbers2 = {5, 6, 7, 8, 9};
        //numbers2[4] = 15;

        //Console.WriteLine(numbers2[3]);
        //Console.WriteLine(numbers2[4]);

        //������


        //void Helloworld()
        //{
        //    Console.WriteLine("Hello World");
        //}
        //Helloworld();
        //Helloworld();

        //��������� ������


        //void Helloworld()
        //{
        //    Console.WriteLine("Hello World");
        //}
        //void Sum(int a, int b)
        //{
        //    int sum = a + b;
        //    Console.WriteLine(sum);
        //}
        //Sum(7, 8);


        //�������

        // void Helloworld()
        // {
        //     Console.WriteLine("Hello World");
        // }
        // void Sum(int a, int b)
        // {
        //     int sum = a + b;
        //     Console.WriteLine(sum);
        // }
        //void  Human (string name, int age)
        // {
        //     Console.WriteLine($"{name} {age}");
        // }
        // Human("�������", 42);


        //������

        class House
        {
            public string street;
            public int number;

            public void Print()
            {
                Console.WriteLine($"{street}, {number}");
            }
        }
        static void Main(string[] args)
        {
            House tower = new House();
            tower.street = "����������";
            tower.number = 50;

            tower.Print();
        }
    }
}
