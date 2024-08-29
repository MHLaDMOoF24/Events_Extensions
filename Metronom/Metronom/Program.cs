namespace Metronom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metronome metronome = new Metronome();
            TickListener tickListener = new TickListener(metronome);

            for (int i = 0; i < 5; i++)
            {
                metronome.Activate();
                System.Threading.Thread.Sleep(500);
            }
        }

        private static void Metronome_Tick(object? sender, EventArgs e)
        {
            Console.WriteLine();
        }
    }
}
