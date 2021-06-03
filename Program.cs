using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int hW1, hW2, midterm, final, x;

        hW1 = (int)readValue();
        hW2 = (int)readValue();
        midterm = (int)readValue();
        final = (int)readValue();
        x = hW1 + hW2 + midterm + final;
        Console.WriteLine(x);
        if (x > 79)
        {
            Console.WriteLine(" Grade A ");
        }
        else
        {
            if (x > 69)
            {
                Console.WriteLine(" Grade B ");
            }
            else
            {
                if (x > 59)
                {
                    Console.WriteLine(" Grade C ");
                }
                else
                {
                    if (x > 49)
                    {
                        Console.WriteLine(" Grade D ");
                    }
                    else
                    {
                        if (x < 49)
                        {
                            Console.WriteLine(" Grade F ");
                        }
                    }
                }
            }
        }
    }
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
