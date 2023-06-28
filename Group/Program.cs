using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
         
           double num1, num2, results;
           Console.WriteLine("C# Calculator");

           Console.WriteLine("enter first number:");
           num1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Enter operator (+, -, *, /):");
           string op = Console.ReadLine();

           Console.WriteLine("Enter Second number:");
           num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case "+":
                results = num1 + num2;
                Console.WriteLine($"Your results: {num1 + num2} =" + results);
                break;
            case "-":
                results = num1 - num2;
                Console.WriteLine($"Your results: {num1 - num2} =" + results);
                break;
            case "*":
                results = num1 * num2;
                Console.WriteLine($"Your results: {num1 * num2} =" + results);
                break;
            case "/":
                results = num1 / num2;
                Console.WriteLine($"Your results: {num1 / num2} =" + results);
                break;
            default:
                Console.WriteLine("that was not a valid option");
                break;



                Console.WriteLine("Would you like to continue? (Y=yes, N=no :");
        } while (Console.ReadLine().ToUpper() == "Y");
              Console.WriteLine("BYE!");







           





        




    }
}