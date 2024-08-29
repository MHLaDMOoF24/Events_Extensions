namespace ExtensionsLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("tesT stRIng".Capitalize());

            Random rnd = new Random();

            Console.WriteLine(rnd.NextDouble(10));
            Console.WriteLine(rnd.NextDouble(10));
            Console.WriteLine(rnd.NextDouble(10));
            Console.WriteLine(rnd.NextDouble(10));
            Console.WriteLine(rnd.NextDouble(10));

            Console.WriteLine(rnd.CoinFlip());
            Console.WriteLine(rnd.CoinFlip());
            Console.WriteLine(rnd.CoinFlip());
            Console.WriteLine(rnd.CoinFlip());
            Console.WriteLine(rnd.CoinFlip());
            Console.WriteLine(rnd.CoinFlip(0));
            Console.WriteLine(rnd.CoinFlip(0.2));
            Console.WriteLine(rnd.CoinFlip(0.4));
            Console.WriteLine(rnd.CoinFlip(0.6));
            Console.WriteLine(rnd.CoinFlip(0.8));
            Console.WriteLine(rnd.CoinFlip(1));

            string[] str = ["One", "Two", "Three", "Four"];
            Console.WriteLine(rnd.NextString(str));
            Console.WriteLine(rnd.NextString(str));
            Console.WriteLine(rnd.NextString(str));
            Console.WriteLine(rnd.NextString(str));
            Console.WriteLine(rnd.NextString(str));
        }
    }
}
