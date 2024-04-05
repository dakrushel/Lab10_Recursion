namespace Lab10_Recursion
{
    internal class Program
    {
        //Calculate the sum of all numbers from n to m (inclusive) recursively
        public static int SumNumBtwn(int a, int b)
        {
            int highest = Math.Max(a, b);
            int lowest = Math.Min(a, b);
            //base case or condition to break the loop (when highest == lowest)
            if (highest == lowest)
            {
                //Console.WriteLine($"{lowest}");
                return lowest;
            }
            //recursive case (the loop; still not sure how it increments or decrements though)
            else
            {
                //Console.WriteLine(highest);
                return highest + SumNumBtwn(highest - 1, lowest);
            }

        }

        //Determine how many times a number can be divided by two, recursively
        public static int HowManyTwos(int c)
        {
            //Base case (when a cannot be divided by 2)
            if (c%2 != 0)
            {
                return 0;
            }
            //
            else
            {
                return 1 + HowManyTwos(c / 2);
            }
        }

        static void Main(string[] args)
        {
            //Addition
            Console.WriteLine("Addition\n\nEnter number a:\n");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter number b:\n");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"\n{SumNumBtwn(a, b)}\n");

            //Division
            Console.WriteLine("Division\n\nEnter number c:\n");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"\nTotal number of divisions: {HowManyTwos(c)}");
        }
    }
}
