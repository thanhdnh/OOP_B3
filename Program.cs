public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Calculator cal = new Calculator();
        Console.WriteLine("5+4="+cal.Tinh(5f, 4f));
        Console.WriteLine("5-4="+cal.Tinh(5f, 4f,0f));

        Console.WriteLine("1+2="+cal.TinhN(1f, 2f));
        Console.WriteLine("1+2+3="+cal.TinhN(1f, 2f, 3f));

        Console.WriteLine($"counter={Calculator.counter}");

        Console.ReadLine();
    }
}