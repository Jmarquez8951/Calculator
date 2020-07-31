using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Type in quit to end program.");
            do
            {
                Console.WriteLine("Enter the operation (*, /, +, ^2, avg) and then your numbers seperated by commas.");
                var mNums = Console.ReadLine();

                if (mNums.Contains("* "))
                {
                    mNums = mNums.Replace("* ", "");
                    string[] numbers = mNums.Split(",");
                    int product = 1;

                    foreach (var num in numbers)
                    {
                        product *= int.Parse(num);
                    }
                    Console.WriteLine($"Product: {product}");
                } else if (mNums.Contains("^2 "))
                {
                    mNums = mNums.Replace("^2 ", "");
                    string[] numbers = mNums.Split(",");
                    string exponential = "";

                    foreach (var num in numbers)
                    {
                        exponential += int.Parse(num) * int.Parse(num) + ",";
                    }
                    exponential = exponential.TrimEnd(',');
                    Console.WriteLine($"Power of 2: {exponential}");
                } else if (mNums.Contains("+ "))
                {
                    mNums = mNums.Replace("+ ", "");
                    string[] numbers = mNums.Split(",");
                    int sum = 0;

                    foreach (var num in numbers)
                    {
                        sum += int.Parse(num);
                    }
                    Console.WriteLine($"Sum: {sum}");
                } else if (mNums.Contains("avg "))
                {
                    mNums = mNums.Replace("avg ", "");
                    string[] numbers = mNums.Split(",");
                    double sum = 0;
                    int count = numbers.Length;
                    double final = 0;

                    foreach (var num in numbers)
                    {
                        sum += int.Parse(num);
                    }
                    final += (sum / count);
                    Console.WriteLine($"Average: {final}");
                } else if (mNums.Contains("/ "))
                {
                    mNums = mNums.TrimStart('/', ' ');
                    string[] numbers = mNums.Split(",");
                    double quotient = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i == 0)
                        {
                            quotient += int.Parse(numbers[i]);
                        } else
                        {
                            quotient /= int.Parse(numbers[i]);
                        }
                    }
                    Console.WriteLine($"Quotient: {quotient}");
                }

            } while (Console.ReadLine() != "quit");
        }
    }
}
