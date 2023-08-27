using System;

namespace Codetolive.Csharp.Examples{

    public class CsharpExamples
    {    
        public static void Main(string[] args){
            //SimpleRecursion(5);
            
            var powerResult = Power(2, 5);
            Console.WriteLine(powerResult);


            // var factorialResult = Factorial(5);
            // Console.WriteLine(factorialResult);
        }

        /**
        Recursion method to calculate the input power of the number
        **/
        public static int Power(int number, int power){

            if(power == 0){
                return 1;
            }

            return number * Power(number, power - 1);
            
        }

        /**
        Recursion method to calculate the factorial of the input number
        **/
        public static int Factorial(int number){

            if(number == 0){
                return 1;
            }

            return number * Factorial(number - 1);
            
        }

        /**
        Simple recursion to demonstrate the recursion.
        The method iterates the input number decrement until it reaches zero
        **/
        public static void SimpleRecursion(int number){

            if(number == 0){
                return;
            }

            SimpleRecursion(number-1);
            Console.WriteLine(number);
        }
    }
}