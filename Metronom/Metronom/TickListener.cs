namespace Metronom
{
    internal class TickListener
    {
        public TickListener(Metronome metronome)
        {
            metronome.Tick += Metronome_Ticked;
        }

        public static void Metronome_Ticked(object? sender, EventArgs e)
        {
            Console.WriteLine("Heard you");
        }
    }
}
