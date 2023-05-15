class Program
{
    static void Main(string[] args)
    {
        Console.Write("Water tank capacity: ");
        double Vmax = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("The average volume of water that participants drank during each break: ");
        double VdrinkAvg = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Volume of water that can be added in each water filling cycle: ");
        double Vfill = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("The interval between breaks: ");
        double tdaytdrink = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Interval between filling cycles: ");
        double tdaytfill = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("The total duration of the event from start to finish of the day: ");
        double totalTime = Convert.ToDouble(Console.ReadLine());
        double fillAmount = (totalTime - (tdaytdrink + tdaytfill)) * Vfill;  
        double drinkAmount = tdaytdrink * VdrinkAvg; 
        double remainingWater = Vmax - (fillAmount + drinkAmount);

        if (remainingWater >= 0)
        {
            Console.WriteLine($"Enough Water, {remainingWater} left");
        }
        else if (fillAmount > Vmax)
        {
            Console.WriteLine("Overflow Water");
        }
        else
        {
            Console.WriteLine("Not Enough Water");
        }
    }
}
class Final
{
    static void Main(string[] args)
    {
        // รับค่าเบ็ดเตล็ดจากผู้ใช้
        Console.WriteLine("Please input balance");
        double B1 = ReadPositiveNumber("Balance 1: ");
        double B2 = ReadPositiveNumber("Balance 2: ");
        double B3 = ReadPositiveNumber("Balance 3: ");

        double L = 0; // ยอดที่ไม่สามารถเบิกจ่ายได้

        // รับค่ายอดชำระในใบเสร็จหรือใบสำคัญรับเงินแต่ละใบ
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

        // แสดงผลลัพธ์
        Console.WriteLine($"Balance 1: {B1}");
        Console.WriteLine($"Balance 2: {B2}");
        Console.WriteLine($"Balance 3: {B3}");
        Console.WriteLine($"Left: {L}");
    }

    // ฟังก์ชันสำหรับอ่านจำนวนจริงที่มากกว่าหรือเท่ากับศูนย์
    static double ReadNonNegativeNumber(string message)
    {
        double number;
        do
        {
            Console.Write(message);
        } while (!double.TryParse(Console.ReadLine(), out number) || number < 0);

        return number;
    }

    // ฟังก์ชันสำหรับอ่านจำนวนจริงที่มากกว่าศูนย์
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