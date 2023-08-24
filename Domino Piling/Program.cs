using System.ComponentModel;

namespace Domino_Piling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PRICES = 2;
            string[] M = Console.ReadLine().Split(' ');
            int count = 0;
            int MaxNum = 0;
            int Result = int.Parse(M[0]) * int.Parse(M[1]);

            if (int.Parse(M[0]) >= 1 && int.Parse(M[1]) <= 16)
            {
                if (Result % PRICES == 0)
                {
                    for (int i = 1; i <= Result; i++)
                    {
                        MaxNum = i;
                        count += PRICES;

                        if (count == Result)
                        {
                            goto print;
                        }

                    }
                print:
                    Console.WriteLine(MaxNum);
                }
                else
                {
                    for (int i = 1; i < Result; i++)
                    {
                        MaxNum = i;
                        count += PRICES;

                        if (count == Result - 1)
                        {
                            goto print;
                        }
                    }

                print:
                    Console.WriteLine(MaxNum);
                }
            }
            else
            {
                Console.WriteLine("Some Thing Error Please Appllay The Conditions");
            }
        }
    }
}