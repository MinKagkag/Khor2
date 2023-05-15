using System;

class Final
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input balance");
        double B1 = ReadPositiveNumber("Balance 1: ");
        double B2 = ReadPositiveNumber("Balance 2: ");
        double B3 = ReadPositiveNumber("Balance 3: ");

        double L = 0; 

        double payment;
        do
        {
            payment = ReadNonNegativeNumber("Payment recipt (press 0 for cancle): ");
            if (payment > 0)
            {
                if (payment <= B1)
                {
                    B1 -= payment;
                }
                else if (payment <= B2)
                {
                    B2 -= payment;
                }
                else if (payment <= B3)
                {
                    B3 -= payment;
                }
                else
                {
                    L += payment;
                }
            }
        } while (payment > 0);


        Console.WriteLine($"Balance 1: {B1}");
        Console.WriteLine($"Balance 2: {B2}");
        Console.WriteLine($"Balance 3: {B3}");
        Console.WriteLine($"Left: {L}");
    }

 
    static double ReadNonNegativeNumber(string message)
    {
        double number;
        do
        {
            Console.Write(message);
        } while (!double.TryParse(Console.ReadLine(), out number) || number < 0);

        return number;
    }

    static double ReadPositiveNumber(string message)
    {
        double number;
        do
        {
            Console.Write(message);
        } while (!double.TryParse(Console.ReadLine(), out number) || number <= 0);

        return number;
    }
}
