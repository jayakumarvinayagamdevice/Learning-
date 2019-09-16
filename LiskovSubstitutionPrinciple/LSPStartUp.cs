using System;

namespace LiskovSubstitutionPrinciple
{
    public class LSPStartUp
    {
        public void Start()
        {
            Fruit fruit = new Apple();
            System.Console.WriteLine(fruit.GetColor());
            fruit = new Orange();
            System.Console.WriteLine(fruit.GetColor());
            fruit = new Kiwi();
            System.Console.WriteLine(fruit.GetColor());
        }

        public void StartAdvanced()
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            SumCalculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Sum()}");
            OddNumberSummation oddSum = new OddNumberSummation(numbers);
            Console.WriteLine($"The sum of all the Odd numbers: {oddSum.Sum()}");
            EvenNumberSummation evenSum = new EvenNumberSummation(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Sum()}");
            Console.WriteLine();
            
            // Solution
            SumCalculator sum1 = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum1.Sum()}");            
            SumCalculator oddSum1 = new OddNumberSummation(numbers);
            Console.WriteLine($"The sum of all the Odd numbers: {oddSum1.Sum()}");
            SumCalculator evenSum1 = new EvenNumberSummation(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum1.Sum()}");

            // 
            Calculator calculator = new SumAllNumbers(numbers);
            Console.WriteLine($"The sum of all the numbers: {calculator.Sum()}");
            calculator = new SummAllOddNumbers(numbers);
            Console.WriteLine($"The sum of all the Odd numbers: {calculator.Sum()}");
            calculator = new SummAllEvenNumbers(numbers);
            Console.WriteLine($"The sum of all the Even numbers: {calculator.Sum()}");

        }

    }
}
