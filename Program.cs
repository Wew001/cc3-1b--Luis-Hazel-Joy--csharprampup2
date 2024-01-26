using System;

namespace CSharpRampUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Ramp Up! :)");
            Console.WriteLine("===============================================================");

            // Part 1
            // Part 1.1: Weight Conversion
            Console.Write("Enter weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilograms = pounds * 0.453592;
            Console.WriteLine($"The weight in kilograms is: {kilograms}");
            Console.WriteLine("===============================================================");

            // Part 1.2: Distance Conversion
            Console.Write("Enter distance in miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine($"The distance in kilometers is: {kilometers}");
            Console.WriteLine("===============================================================");

            // Part 1.3: Temperature Conversion
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5.0 / 9.0;
            Console.WriteLine($"The temperature in Celsius is: {celsius}");
            Console.WriteLine("===============================================================");

            // Part 1.4: Average Age Calculation
            int sumAge = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Age of student " + (i + 1) + ": ");
                int age = Convert.ToInt32(Console.ReadLine());
                sumAge += age;
            }
            double averageAge = sumAge / 10.0;
            Console.WriteLine($"The average age of the students is: {averageAge}");
            Console.WriteLine("===============================================================");

            // Part 1.5: Printing a Fantasy Story
            string characterName1 = "Alucard", characterName2 = "Tigreal", characterName3 = "Harith", characterName4 = "Granger", characterName5 = "Fanny";

            string equipmentName = "Sword", itemName = "Shield", abilityName = "Strength";

            // Using string interpolation to create a fantasy story
            string story = $"Once upon a time, there were five heroes named: {characterName1}, {characterName2}, {characterName3}, {characterName4}, and {characterName5}.
            They have the mission to bring back the light to Moniyan Empire, to save the kingdom, each equipped with a {equipmentName} and a {itemName}.
            {characterName1} had the ability of {abilityName}, which made him a formidable warrior. Together, they faced many challenges fighting against the darkness, but their unity and determination saw them through.";
            Console.WriteLine(story);
            Console.WriteLine("===============================================================");

            // Part 2
            // Part 2.1: Number Pattern 1
            Console.Write("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            // Nested loops to print a number pattern
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===============================================================");

            // Part 2.2: Number Pattern 2
            Console.Write("Enter a positive integer: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int sum = 0;
            // Loop to calculate the sum of numbers up to the given input
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("===============================================================");

            // Part 2.3: Number Pattern 3
            Console.Write("Enter a positive integer: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            // Nested loops to print a reverse number pattern
            for (int i = number; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===============================================================");
        }
    }
}
