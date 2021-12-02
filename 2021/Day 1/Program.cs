using System;
using System.Text;

class Day1
{
    public static void Main()
    {
        string path = @"C:\Users\Olivier PC\source\repos\Advent Of Code\2021\Day 1\Day_1_input.txt";

        try
        {
            var list = File.ReadLines(path).Select(line => int.Parse(line)).ToList();
            int singleCounter = 0;
            int sumCounter = 0;
            int previousSum = 0;

            for (int i = 0; i < list.Count - 1; i++) // reduced for-loop length by -1 because we look one index ahead for the calculation
            {
                if (HasDepthIncreased(list[i], list[i + 1]))
                {
                    singleCounter++;
                }
            }

            for (int i = 0; i < list.Count - 2; i++)
            {
                int currentSum = ThreeMeasurementSum(list[i], list[i + 1], list[i + 2]);
                if (HasDepthIncreased(previousSum, currentSum))
                {
                    sumCounter++;
                }
                previousSum = currentSum;
            }
            Console.WriteLine($"Amount of single increases: {singleCounter}");
            Console.WriteLine($"Amount of three sum increases: {sumCounter}");

        }
        catch (Exception ex)
        {
            Console.WriteLine("The file could not be read: ");
            Console.WriteLine(ex.Message);
        }
    }

    private static bool HasDepthIncreased(int previousMeasurement, int currentMeasurement)
    {
        if (previousMeasurement != 0)
        {
            return previousMeasurement < currentMeasurement;
        }
        else
        {
            return false;
        }
    }

    private static int ThreeMeasurementSum(int firstMeasurement, int secondMeasurement, int thirdMeasurement)
    {
        return firstMeasurement + secondMeasurement + thirdMeasurement;
    }

}