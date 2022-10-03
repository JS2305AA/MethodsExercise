using System.ComponentModel;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("How old are you?");
            //string userAge = Console.ReadLine();

            //Console.WriteLine("What is your dog's name?");
            //string userDogName = Console.ReadLine();

            //Console.WriteLine("What color is your dog?");
            //string userDogColor = Console.ReadLine();

            //Console.WriteLine($"There was a lady named {userName}, she was {userAge} years old.");
            //Console.WriteLine($"He had a {userDogColor} dog named {userDogName}.");
            //Console.WriteLine($"{userName} loved his dog, but he did not love being {userAge} year's old.");


            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");


            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

        }
        public static int Sum(int num1, int num2)

        { //Can use return sum; or
          //return sum = (num1 +num2)

            return num1 + num2;


            }
        public static int Sum(params int[] list)
        {
            for (int i = 0; i < list.Legnth; i++)
            { 
                Sum = Sum + list{ i};

            } 
                    return Sum;
                

        {
            return x * y;
        }
                
                
                
    }
    
}