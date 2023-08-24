namespace Team
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += int.Parse(s[j]);

                }
                if (sum >= 2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}