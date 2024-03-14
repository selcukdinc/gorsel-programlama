namespace Donusum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"a = {a = a ^ b ^ (b = a)}, b = {b}");
            Console.ReadKey();
        }
    }
}
