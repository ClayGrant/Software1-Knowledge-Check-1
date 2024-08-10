using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    var addNumber1 = Console.ReadLine();
                    var addNumber2 = Console.ReadLine();

                    if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
                    {
                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }

                    /*int[] addNums = new int[2];
                    addNums = getNums();

                    Console.Write($"{addNums[0]} + {addNums[1]} = ");
                    Console.Write(calculator.Add(addNums[0], addNums[1]));*/

                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    var subtractNumber1 = Console.ReadLine();
                    var subtractNumber2 = Console.ReadLine();

                    if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
                    {
                        Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }

                    /*int[] subNums = getNums();

                    Console.Write($"{subNums[0]} - {subNums[1]} = ");
                    Console.Write(calculator.Subtract(subNums[0], subNums[1]));*/


                    break;

                case "3":
                    // Add code here

                    Console.WriteLine("Enter 2 integers to multiply");
                    var multNumber1 = Console.ReadLine();
                    var multNumber2 = Console.ReadLine();

                    if (int.TryParse(multNumber1, out int multNumOne) && int.TryParse(multNumber2, out int multNumTwo))
                    {
                        Console.Write($"{multNumber1} / {multNumber2} = ");
                        Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }

                    /*int[] multNums = getNums();

                    Console.Write($"{multNums[0]} * {multNums[1]} = ");
                    Console.Write(calculator.Multiply(multNums[0], multNums[1]));*/

                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    var divideNumber1 = Console.ReadLine();
                    var divideNumber2 = Console.ReadLine();

                    if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                    /*int[] divNums = getNums();

                    double divNumOne = (double)divNums[0];
                    double divNumTwo = (double)divNums[1];

                    Console.Write($"{divNums[0]} / {divNums[1]} = ");
                    Console.Write(calculator.Divide(divNumOne, divNumTwo));*/

                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }

        }

        public static int[] getNums()
        {
            int[] nums = new int[2];

            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            if (int.TryParse(num1, out int numOne) && int.TryParse(num2, out int numTwo))
            {
                return nums;
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
                return null;
            }

            //return nums;
        }
    }
}