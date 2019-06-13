using System;

namespace Tema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercitiul1();
            //Exercitiul2();
            //Exercitiul3();
            //Exercitiul4();
            //Exercitiul5a();
            //Exercitiul5b();
              Exercitiul6();
            Exercitiul7();
            Exercitiul8();
            Exercitiul9();
            // Exercitiul10();
            Exercitiul11();
            Exercitiul12();
            Exercitiul13();
            Exercitiul14();




        }
        public static void Exercitiul1()
        {
            Console.WriteLine("1. Write a program that reads from the console three numbers of type int and prints their sum.");
            Console.Write("First number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result is {0}", a + b + c);
        }

        public static void Exercitiul2()
        {
            Console.WriteLine("2. Write a program that reads five numbers from the console and prints the greatest of them.");
            Console.Write("Enter first number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int e = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int f = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int g = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int h = Int32.Parse(Console.ReadLine());

            if (d > e && d > f && d > g && d > h) Console.WriteLine("{0} is the biggest.", d);
            else if (e > d && e > f && e > g && e > h) Console.WriteLine("{0} is the biggest.", e);
            else if (f > d && f > e && f > g && f > h) Console.WriteLine("{0} is the biggest.", f);
            else if (g > d && g > e && g > f && g > h) Console.WriteLine("{0} is the biggest.", g);
            else if (h > d && h > e && h > f && h > g) Console.WriteLine("{0} is the biggest.", h);
            else Console.WriteLine("There isn't a biggest number.");
        }

        public static void Exercitiul3()
        {
            Console.WriteLine("3. Write a program that reads from the console the radius of a circle and prints its perimeter and area.");
            Console.Write("Enter radius r : ");
            int r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter is {0} and area is {1}", 2 * Math.PI * r, Math.PI * r * r);
        }

        public static void Exercitiul4()
        {
            Console.WriteLine("4. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5. such that the remainder of their division by 5 is 0."); 
            int counter = 0;

            Console.Write("Enter first number: ");
            int j = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int k = Int32.Parse(Console.ReadLine());

            for (int i = j; i <= k; i++)
            {
                if (i % 5 == 0) counter++;
            }

            Console.WriteLine("{0} numbers found.", counter);
        }

        public static void Exercitiul5a()
        {
            Console.WriteLine("5. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.");
            Console.WriteLine(" a) without using conditional statements");
            Console.Write("Enter first number: ");
            int l = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int m = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} >= {1}", Math.Max(l, m), Math.Min(l, m));
        }

        public static void Exercitiul5b()
        {
            Console.WriteLine("5. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.");
            Console.WriteLine("b) using conditional statements");
            Console.Write("Enter first number: ");
            int l = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int m = Int32.Parse(Console.ReadLine());
            if (l >= m) {
                Console.WriteLine("The greatest number is : ", l);
            }
            else Console.WriteLine("The greatest number is : ", m);
        }
        public static void Exercitiul6()
        {

            Console.WriteLine("6. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number(only once)");
            {
                int sum = 0;

                Console.Write("Enter the first number a = ");
                int a = Int32.Parse(Console.ReadLine());
                sum = sum + a;

                Console.Write("Enter the second number b = ");
                int b = Int32.Parse(Console.ReadLine());
                sum = sum + b;

                Console.Write("Enter the third number c = ");
                int c = Int32.Parse(Console.ReadLine());
                sum = sum + c;

                Console.Write("Enter the fourth number d = ");
                int d = Int32.Parse(Console.ReadLine());
                sum = sum + d;

                Console.Write("Enter the fifth number e = ");
                int e = Int32.Parse(Console.ReadLine());
                sum = sum + e;

                Console.WriteLine("The sum is  : {0} ", a + b + c + d + e);
            }
        }

        public static void Exercitiul7()
        {
            Console.WriteLine("7. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.");

            Console.Write("Enter the number N : ");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The result is : ");

            for (int i = 1; i < length; i++)
                Console.WriteLine(i);

        }

        public static void Exercitiul8()
        {
            Console.WriteLine("8. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.");

            Console.Write("Enter the number N : ");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The result is : ");
            for (int i = 1; i < length; i++)
            {
                if (i % (3 * 7) != 0) Console.WriteLine(i);
            }

        }

        public static void Exercitiul9()
        {
            Console.WriteLine("9. Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them."); 
            int lowest = 0, highest = 0, input;

            Console.Write("Enter the 5 numbers : ");

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Enter number : ");
                input = Int32.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }
            }
            Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);
        }

        public static void Exercitiul10()
        {
            Console.WriteLine("10.  Write program that outputs a triangle made of stars with variable size, depending on an input parameter. Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number. The output is a series of lines printed on the console, forming a triangle of variable size.");

            // Input 2:   
            //  Output:
            // *
            // **
            // *
            Console.WriteLine("Introduceti numarul de * = ");
            int count = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < count; i++)
            {
                Console.Write("* ");
            }

            for (int i = count - 1; i >= 0; i++)
            {
                Console.WriteLine("* ");
            }
        }

        public static void Exercitiul11()
        {
            Console.WriteLine("11. Write a program that converts a given number from decimal to binary notation (numeral system).");
            int n, i;
            int[] a = new int[10];
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
        public static void Exercitiul12()
        {
            Console.WriteLine("12. Write a program that by a given integer N prints the numbers from 1 to N in random order");

            Random rnd = new Random();
            int temp, randomNumber;
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (int i in arr)
            {
                randomNumber = rnd.Next(0, n);
                temp = arr[i];
                arr[i] = arr[randomNumber];
                arr[randomNumber] = temp;
            }

            foreach (int i in arr) Console.WriteLine(arr[i]);

        }
        public static void Exercitiul13()
        {
            Console.WriteLine("13. A program which iterates the integers from 1 to 50 For multiples of three print Fizz instead of the number and for the multiples of five print Buzz. For numbers which are multiples of both three and five print FizzBuzz.");

            //  Output:
            //    fizzbuzz
            //1
            //2
            //fizz
            //4
            //buzz

            for (var numbers = 1; numbers <= 50; numbers++)
            {  //Lists numbers to 50

                //if number is divisible by 5 or 3 prints FizzBuzz
                if (numbers % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                //if number is divisible by 5 prints Buzz
                else if (numbers % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //if number is divisible by 3 prints Fizz
                else if (numbers % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // if neither prints the number
                else
                {
                    Console.WriteLine(numbers);
                }

            }

        }

        public static void Exercitiul14()
        {
            Console.WriteLine("14. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console."); 
            Console.WriteLine("Enter company name: ");
            string compName = Console.ReadLine();
            Console.WriteLine("Enter company address: ");
            string compAddr = Console.ReadLine();
            Console.WriteLine("Enter company phone number: ");
            string compPhone = Console.ReadLine();
            Console.WriteLine("Enter company fax: ");
            string compFax = Console.ReadLine();
            Console.WriteLine("Enter company website: ");
            string compSite = Console.ReadLine();
            Console.WriteLine("Enter company manager: ");
            string compManager = Console.ReadLine();
            Console.WriteLine("Enter manager first name: ");
            string managerFName = Console.ReadLine();
            Console.WriteLine("Enter manager last name: ");
            string managerLName = Console.ReadLine();
            Console.WriteLine("Enter manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2}, Fax - {3}, Website - {4}, Manager - {5}", compName, compAddr, compPhone, compFax, compSite, compManager);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", managerFName, managerLName, managerPhone);

        }


    }
}
