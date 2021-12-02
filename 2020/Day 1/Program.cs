using System;
using System.Text;

class Day1
{
    public static void Main()
    {
        string path = @"C:\Users\Olivier PC\source\repos\Advent Of Code\2020\Day 1\input.txt";

        try
        {
            var list = File.ReadLines(path).Select(line => int.Parse(line)).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count - 1; j++)
                {
                    for (int k = 2; k < list.Count - 2; k++)
                    {
                        if (list[i] + list[j] + list[k] == 2020)
                        {
                            Console.WriteLine(list[i] * list[j] * list[k]);
                            return;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("The file could not be read: ");
            Console.WriteLine(ex.Message);
        }
    }
}