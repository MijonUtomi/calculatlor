using System;

namespace calculatlor
{
    class Program
    {
        static void Main(string[] args)
        {
            string askForNumber = "Hello please give me a number.";
            string askForNumber2 = "Please give me a second Number";

            TalkToUser(askForNumber);

            string userInput = GetUserData();

            int num1 = int.Parse(userInput);

            TalkToUser(askForNumber);

            userInput = GetUserData();

            int num2 = int.Parse(userInput);

            int answer = Add(num1, num2);

            Console.WriteLine($"The sum of thesse 2 numbers = {answer}");
            Console.ReadLine();
            Console.WriteLine("Subtraction");
            Console.WriteLine($"{num1} minus {num2} equals: {Subtract(num1 , num2)}");

            Console.WriteLine("Multiplication");
            Console.WriteLine($"{num1} times {num2} equals: {Multiply(num1, num2)}");

             Console.WriteLine("Division");
            Console.WriteLine($"{num1} divided by {num2} equals: {Divide(num1, num2)}");


        }

        public static void TalkToUser(string dialogue)
        {

            Console.WriteLine(dialogue);
        }
        public static string GetUserData()
        {
            return Console.ReadLine();
        }
    
        public static int Add(int firstNumber, int secondNumber)
        {

            int answer = firstNumber + secondNumber;

            return answer;
        }
        public static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
           
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;

        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2; 
        }

    }

}
