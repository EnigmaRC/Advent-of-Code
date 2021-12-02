using System;

public class Day2
{
    private static int _x, _y, _aim = 0;
    public static int X
    {
        get => _x; set
        {
            _x = value;
        }
    }
    public static int Y
    {
        get => _y; set
        {
            _y = value;
        }
    }
    public static int Aim
    {
        get => _aim; set
        {
            _aim = value;
        }
    }

    public static void Main(string[] args)
    {
        string path = @"C:\Users\Olivier PC\source\repos\Advent Of Code\2021\Day 2\input.txt";


        try
        {
            var AllLinesText = File.ReadAllLines(path).ToList();

            foreach (var line in AllLinesText)
            {
                string key = line.Split(' ')[0];
                int value = int.Parse(line.Split(' ')[1]);

                switch (key)
                {
                    case "up":
                        Aim = MoveUp(value);
                        Console.WriteLine($"UP: {value} \t\t X: {X}, Y: {Y} \t AIM: {Aim}");
                        break;
                    case "down":
                        Aim = MoveDown(value);
                        Console.WriteLine($"DOWN: {value} \t X: {X}, Y: {Y} \t AIM: {Aim}");
                        break;
                    case "forward":
                        X = MoveForward(value);
                        Y += CalculateDepth(value);
                        Console.WriteLine($"FORWARD: {value} \t X: {X}, Y: {Y} \t AIM: {Aim}");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{X * Y}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("The file could not be read: ");
            Console.WriteLine(ex.Message);
        }
    }

    public static int MoveUp(int deltaY)
    {
        return Aim - deltaY;
    }

    public static int MoveDown(int deltaY)
    {
        return Aim + deltaY;
    }

    public static int MoveForward(int deltaX)
    {
        return X + deltaX;
    }

    public static int CalculateDepth(int DeltaAim)
    {
        return Aim * DeltaAim;
    }
}
