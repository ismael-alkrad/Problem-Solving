namespace Bit__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (s[1] == '+')
                    x++;
                else
                    x--;
            }
            Console.WriteLine(x);
        }
    }
}