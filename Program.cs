using System;

class Calculator
{
    public double Add(params int[] numbers) =>
        numbers.Select(
        (v, i) =>
        Math.Pow(10, i) * v).Sum();
}

class Program
{
    static void Main()
    {
        Calculator calc = new();
        var sum = calc.Add( 3, 2, 1);
        Console.WriteLine(sum);
    }

}