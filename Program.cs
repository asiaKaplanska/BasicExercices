using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace BasicExercises
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ***** Basic ***** //
            /*  BasicEx1();
              BasisEx2(3, 5);
              BasicEx3(6, 2);
              BasicEx3(6, 0);
              BasicEx4();
              BasicEx5(5, 6);*/
            // BasicEx6();
            /* BasicEx7();
             BasicEx8();
             BasicEx9();
             BasicEx10();
             BasicEx11();
             BasicEx12();
             BasicEx13();
             BasicEx14();
             BasicEx15();*/
            //BasicEx16();
            //BasicEx17();
            //BasicEx18();
            //BasicEx19();
            //BasicEx20();
            //BasicEx21();
            //
            //BasicEx23();
            //BasicEx24();
            /*BasicEx25();
            BasicEx26();
            BasicEx27();
            BasicEx28();
            BasicEx29();*/
            //BasicEx30();
            //BasicEx31();
            //BasicEx32();
            //BasicEx33();
            //BasicEx34();
            //BasicEx35();
            //BasicEx36();
            //BasicEx37();
            //BasicEx38();
            //BasicEx39();
            //BasicEx40();
            BasicEx41();

            Console.ReadLine();
        }
        private static void BasicEx1()
        {
            // Write a C# Sharp program to print Hello and your name in a separate line.
            Console.WriteLine("Hello\n"
                              + "Joanna Kapłańska");
        }

        private static void BasisEx2(int a, int b)
        {
            //Write a C# Sharp program to print the sum of two numbers.
            Console.WriteLine(a+b);
        }

        private static void BasicEx3(int a, int b)
        {
            // Write a C# Sharp program to print the result of dividing two numbers. 
            if (b != 0)
            {
                Console.WriteLine(a/b);
            }
            else
            {
                Console.WriteLine("You can't divide by 0!!!");
            }
        }

        private static void BasicEx4()
        {
            //Write a C# Sharp program to print the result of the specified operations.
            /*-1 + 4 * 6
            ( 35+ 5 ) % 7
            14 + -4 * 6 / 11
            2 + 15 / 6 * 1 - 7 % 2*/
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine( ( 35+ 5 ) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        private static void BasicEx5(int a, int b)
        {
            //Write a C# Sharp program to swap two numbers.
            Console.WriteLine($"Before swap: {a}, {b}");
            int temporary = a;
            a = b;
            b = temporary;
            Console.WriteLine($"After swap: {a}, {b}");
        }

        private static void BasicEx6()
        {
            // Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
            Console.WriteLine("Enter 3 numbers to multiply:");
            Console.Write("a = ");
            var a      = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b      = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c      = int.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {a * b * c}");
        }

        private static void BasicEx7()
        {
            // Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 
            Console.WriteLine("Insert 2 variable to add, subctract, multiply and divide:");
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = int.Parse(Console.ReadLine());

            Console.Write($"Result of adding is: {a + b}, subtracting: {a - b}, multiplying: {a * b},");

            if (b != 0)
            {
                Console.WriteLine(
                    $" dividing:{a / b}, modulo: {a % b}");
            }
            else
            {
                Console.WriteLine("You can't divide by 0!!!"); 
            }
        }

        private static void BasicEx8()
        {
            // Write a C# Sharp program that takes a number as input and print its multiplication table. 
            Console.WriteLine("Insert number to print its multiplication table:");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication table for {input}:");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{input} * {i} = {input*i}");
            }
        }

        private static void BasicEx9()
        {
            // Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
            Console.WriteLine("Insert 4 variable to calculate the average:");
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            var d = double.Parse(Console.ReadLine());
            Console.WriteLine($"Average = {(a+b+c+d)/4}");
        }

        private static void BasicEx10()
        {
            // Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y)*z and x*y + y*z.
            Console.WriteLine("Insert 3 variable to calculate:");
            Console.Write("x = ");
            var x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            var y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            var z = int.Parse(Console.ReadLine());
            Console.WriteLine($"(x+y)*z = {(x+y)*z}\n"
                              + $"x*y+y*z = {(x*y)+(y*z)}\n");
        }

        private static void BasicEx11()
        {
            // Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". 
            Console.WriteLine("Insert your age:");
            var age = Console.ReadLine();
            Console.WriteLine($"You look older than {age}");
        }

        private static void BasicEx12()
        {
            // Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
            Console.Write("Enter a digit: ");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine("Result:\n"
                              + $"{input} {input} {input} {input}\n"
                              + $"{input}{input}{input}{input}");
            Console.WriteLine("{0} {0} {0} {0}", input);
            Console.WriteLine("{0}{0}{0}{0}", input);
        }

        private static void BasicEx13()
        { //Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
            Console.Write("Enter a number: ");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", input);
            Console.WriteLine("{0} {0}", input);
            Console.WriteLine("{0} {0}", input);
            Console.WriteLine("{0} {0}", input);
            Console.WriteLine("{0}{0}{0}", input);
        }

        private static void BasicEx14()
        {
            // Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
            Console.Write("Enter the amount of Celsius: ");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Kelvin: {input+273}\n"
                              + $"Fahrenheit: {(input*18/10)+32}");
        }

        private static void BasicEx15()
        {
            // Write a C# program remove specified a character from a non-empty string using index of a character. 
            var inputString = "w3resource";
            Console.WriteLine(inputString.Remove(1,1));
            Console.WriteLine(inputString.Remove(9,1));
            Console.WriteLine(inputString.Remove(0,1));

        }

        private static void BasicEx16()
        {
            // Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            var string1 = "w3resource";
            var string2 = "Python";

            Console.WriteLine(string1);
            var change1 = string1.Replace("w3", "e3").Replace("ce", "cw");
            Console.WriteLine(change1);

            Console.WriteLine(string2);
            var change2 = string2.Replace("Py", "ny").Replace("on", "oP");
            Console.WriteLine(change2);

            Console.WriteLine("Try on your own text, insert it below: ");
            var input = Console.ReadLine();

            if (input.Length>=1)
            {
                var firstChar = input.Substring(0, 1);
                var lastChar  = input.Substring(input.Length - 1, 1);
                Console.WriteLine($"Result: {lastChar + input.Substring(1, input.Length - 2) + firstChar}");
            }
            else
            {
                Console.WriteLine("Invalid input!!!");
            }
        }

        private static void BasicEx17()
        {
            // Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
            Console.WriteLine("Insert some text (length 1 or more): ");
            var input = Console.ReadLine();

            if (input.Length >= 1)
            {
                var firstChar = input.Substring(0, 1);
                Console.WriteLine(firstChar+input+firstChar);
            }
            else
            {
                Console.WriteLine("Invalid input!!!");
            }
        }

        private static void BasicEx18()
        {
            //Write a C# program to check two given integers and return true if one is negative and one is positive. 
            Console.WriteLine("Check if one is negative and one is positive.");
            Console.Write("Insert first integer: ");
            var firstInput  = int.Parse(Console.ReadLine());
            Console.Write("Insert second integer: ");
            var secondInput = int.Parse(Console.ReadLine());

            Console.WriteLine((firstInput >= 0 && secondInput < 0) || (firstInput < 0 && secondInput >= 0));
        }

        private static void BasicEx19()
        {
            // Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
            Console.WriteLine("Insert 2 integers to compute their sum, if they are equal you will get triple of their sum.");
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = int.Parse(Console.ReadLine());

            if (a!=b)
            {
                Console.WriteLine($"Sum = {a+b}");
            }
            else
            {
                Console.WriteLine($"TripleSum = {3*(a+b)}");
            }
        }

        private static void BasicEx20()
        {
            // Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.
            Console.WriteLine("Insert two integers. If the first number is greater than second number, \n"
                              + "you will get double the absolute value of the difference.");
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b     = int.Parse(Console.ReadLine());
            var input = Math.Abs(a - b);

            if (a > b)
            {
                Console.WriteLine(2*input);
            }
            else
            {
                Console.WriteLine("a <= b");
            }
        }

        private static void BasicEx21()
        {
            // Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20. 
            Console.WriteLine("Insert two integers.\n"
                              + "Check if one of the integer is 20 or if their sum is 20.");
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine((a + b) == 20 || a == 20 || b == 20);
        }
        
        private static void FunctionWrapper(Action<string> functionToInvoke)
        {
            var input = Console.ReadLine();
            if (input.Length >= 1)
            {
                functionToInvoke(input);
            }
            else
            {
                Console.WriteLine("Invalid input!!!");
            }
        }

        public static void BasicEx23()
        {
            // Write a C# program to convert a given string into lowercase.
            Console.WriteLine("Insert text (at least 1 character):");
            FunctionWrapper((input) =>
                {
                    Console.WriteLine($"Result: {input.ToLower()}");
                });
        }

        public static void BasicEx24()
        {
            Console.WriteLine("Insert text, at least 1 character: ");
            FunctionWrapper((input) =>
                {
                    var words = input.Split(' ');
                    var query = from word in words orderby word.Length descending select word;

                    Console.WriteLine($"The longest word: {query.First()}");
                });
        }

        public static void BasicEx25()
        {
           // Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
           Console.WriteLine("Printing the odd numbers from 1 to 99.");

           for (int i = 0; i < 100; i++)
           {
               if ((i % 2) != 0)
               {
                   Console.WriteLine(i);
               }
           }
           
        }

        public static void BasicEx26()
        {
            // Write a C# program to compute the sum of the first 500 prime numbers.
            Console.WriteLine("Computing the sum of the first 500 prime numbers.");

            int iteration = 1;
            int number = 3;
            int sum = 2;
            
            while (iteration < 500)
            {
                bool prime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    iteration++;
                    sum += number;
                }
                
                number++;
            }

            Console.WriteLine($"Sum: {sum}");
        }

        public static void BasicEx27()
        {
            // Write a C# program and compute the sum of the digits of an integer.
            Console.Write("Insert number >= 0: ");
            var input    = Console.ReadLine();
            
            if (input.Length == 1 && !input.Contains("-"))
            {
                var numInput = int.Parse(input);
                Console.WriteLine($"The sum of the digits of an integer is equal: {numInput}");
            }
            else if (input.Length > 1 && !input.Contains("-"))
            {
                var sum = 0;

                foreach (var inputChar in input)
                {
                    var numValue = (int)char.GetNumericValue(inputChar);
                    sum += numValue;
                }

                Console.WriteLine($"The sum of the digits of an integer is equal: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input!!!");
            }
        }

        public static void BasicEx28()
        {
            // Write a C# program to reverse the words of a sentence.
            Console.WriteLine("Insert sentence:");
            FunctionWrapper((input) =>
                {
                    var words        = input.Split(' ');
                    var reverseWords = words.Reverse().ToArray();

                    foreach (var reverseWord in reverseWords)
                    {
                        Console.Write(reverseWord + " ");
                    }
                });
        }

        public static void BasicEx29()
        {
           // Write a C# program to find the size of a specified file in bytes.
           Console.WriteLine("Size of each file in specified directory in bytes.");
           
           DirectoryInfo directoryInfo = new DirectoryInfo("E:\\Dev\\Asia\\ConsoleApplication1");
           FileInfo[]    fileInfos     = directoryInfo.GetFiles();
           
           Console.WriteLine($"The directory {directoryInfo.Name} contains the following files:");

           foreach (var fInfo in fileInfos)
           {
               Console.WriteLine($"The size of {fInfo.Name} is {fInfo.Length} bytes.");
           }
        }

        public static void BasicEx30()
        {
            // Write a C# program to convert a hexadecimal number to decimal number. 
            Console.WriteLine("Insert number to convert from HEXADECIMAL to DECIMAL:");
            var input      = Console.ReadLine();
            var decimalNum = Int32.Parse(input, NumberStyles.HexNumber);
            Console.WriteLine(decimalNum);
        }

        public static void BasicEx31()
        {
            // Write a C# program to multiply corresponding elements of two arrays of integers.
            // Array1: [1, 3, -5, 4]
            // Array2: [1, 4, -5, -2]
            Console.WriteLine("Multiplying corresponding elements of two arrays of integers.");
            int[] firstArray  = { 1, 3, -5, 4 };
            int[] secondArray = { 1, 4, -5, -2 };

            Console.WriteLine("First array: [ 1, 3, -5, 4 ]");
            Console.WriteLine("Second array: [1, 4, -5, -2 ]");

            Console.WriteLine("Result:");
            for (int i = 0; i < 4; i++)
            {
                var result = firstArray[i] * secondArray[i];
                Console.Write(result + " ");
            }
        }

        public static void BasicEx32()
        {
            // Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one.
            Console.WriteLine("Insert sentence below (at least 1 character): ");
            FunctionWrapper(input =>
                {
                    if (input.Length >= 4)
                    {
                        var lastFourCharacters = input.Substring(input.Length - 4, 4);
                        var newStringOfFour = lastFourCharacters + lastFourCharacters + lastFourCharacters + lastFourCharacters;
                        Console.WriteLine(newStringOfFour);
                    }
                    else
                    {
                        Console.WriteLine(input);
                    }
                });
        }

        public static void BasicEx33()
        {
            // Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7
            Console.Write("Insert number: ");
            FunctionWrapper(input =>
            {
                var userInput = int.Parse(input);

                if (userInput >= 0)
                {
                    if (userInput % 3 == 0 && userInput % 7 == 0)
                    {
                        Console.WriteLine("Your number is a multiple of 3 and 7");
                    }
                    else if (userInput % 3 == 0)
                    {
                        Console.WriteLine("Your number is a multiple of 3");
                    }
                    else if (userInput % 7 == 0)
                    {
                        Console.WriteLine("Your number is a multiple of 7");
                    }
                    else
                    {
                        Console.WriteLine("Your number isn't a multiple of 3 or 7");
                    }
                }
                else
                {
                    Console.WriteLine("Insert number is negative!!!");
                }

            });
        }

        public static void BasicEx34()
        {
            // Write a C# program to check if a string starts with a specified word.
            // Note: Suppose the sentence starts with "Hello"
            // Sample Data: string1 = "Hello how are you?"

            var string1 = "Hello how are you?";
            Console.WriteLine(string1);
            var string2 = "Hello";
            var word = string1.Split(' ');
            Console.WriteLine(word[0] == string2);
        }

        public static void BasicEx35()
        {
            Console.WriteLine("Insert two numbers: ");

            Console.Write("Input a first number(<100): ");
            var firstInput = int.Parse(Console.ReadLine());
            Console.Write("Input a second number(>100): ");
            var secondInput = int.Parse(Console.ReadLine());

            Console.WriteLine((firstInput < 100) && (secondInput > 100));
        }

        public static void BasicEx36()
        {
            // Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
            Console.WriteLine("Insert two numbers: ");

            Console.Write("Input a first number: ");
            var firstInput = int.Parse(Console.ReadLine());
            Console.Write("Input a second number: ");
            var secondtInput = int.Parse(Console.ReadLine());

            Console.WriteLine((firstInput > -10 && firstInput < 10) || (secondtInput > -10 && secondtInput < 10));
        }

        public static void BasicEx37()
        {
            // Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP". 
            // Test Data: PHP Tutorial
            var testData = "PHP Tutorial";
            Console.WriteLine(testData);

            if (testData.Substring(1, 2) == "HP")
            {
                var returnString = testData.Remove(1, 2);
                Console.WriteLine(returnString);
            }
        }

        public static void BasicEx38()
        {
            // Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH". 
            //Test Data: PHP
            var testData = "PHP";
            Console.WriteLine(testData);

            Console.WriteLine(testData.First() + testData.Substring(1, 1));
        }

        public static void BasicEx39()
        {
            // Write a C# program to find the largest and lowest values from three integer values.
            Console.WriteLine("Insert three integers:");
            Console.Write("Input first integer: ");
            var firstInput = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            var secondInput = int.Parse(Console.ReadLine());
            Console.Write("Input third integer: ");
            var trirdInput = int.Parse(Console.ReadLine());

            int[] inputs = {firstInput, secondInput, trirdInput};
            var maxInput = inputs.Max(x => x);
            Console.WriteLine($"Largest of three: {maxInput}");

            var minInput = inputs.Min(x => x);
            Console.WriteLine($"Lowest of three: {minInput}");
        }

        public static void BasicEx40()
        {
            // Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
            Console.Write("Insert first number: ");
            var firstInput = int.Parse(Console.ReadLine());
            Console.Write("Insert second number: ");
            var secondInput = int.Parse(Console.ReadLine());
            var target = 20;

            int[] input = {firstInput, secondInput};

            var nearestValue = input.OrderBy(x => Math.Abs(x - target)).First();
            Console.WriteLine($"Nearest value is {nearestValue}");

            if (firstInput==secondInput)
            {
                Console.WriteLine("0");
            } 
        }
    
         public static void BasicEx41()
        {
            // Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
            Console.WriteLine("Insert sentence: ");
            var input = Console.ReadLine();

            var wCount = input.Count(x => x == 'w');
            var query = wCount >= 1 && wCount <= 3;
            
            Console.WriteLine(query);
        }
    
    
    
    
    
    }
}