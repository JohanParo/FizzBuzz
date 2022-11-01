namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input digits");
            //input is [x x x] with x being a digit
            string input = Console.ReadLine();
            int[] inputs = new int[5];

            for (int i = 0; i <= input.Length-1; i=i+2)
            {
                inputs[i] = Int32.Parse(input.Substring(i, 1));
            }

            for (int i = 1; i <= inputs[4]; i++)
            {
                if (i % inputs[0] == 0 && i % inputs[2] == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    
                }
                else
                {
                    if (i % inputs[0] == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % inputs[2] == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);

                    }
                }
            }
        }
    }
}