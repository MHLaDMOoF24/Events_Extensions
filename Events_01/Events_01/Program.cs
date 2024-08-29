namespace Events_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic pBL = new ProcessBusinessLogic();

            Piggybank OBGris = new Piggybank();
            double latest = 0;

            pBL.ProcessCompleted += pBL_ProcessCompleted;
            Console.WriteLine("Velkommen til fodboldgrisen!\n");
            do
            {
                Console.Write("Indsæt et beløb: ");
                if (double.TryParse(Console.ReadLine(), out latest))
                {
                    OBGris.AddMoney(Math.Round(latest, 2));
                    OBGris.AnnounceMoney();
                    pBL.CheckForThreshhold(OBGris.Money);
                }

            } while (latest != 0);
            pBL.ProcessCompleted -= pBL_ProcessCompleted;
        }

        public static void pBL_ProcessCompleted(object sender, string message)
        {
            Console.WriteLine(message);
        }
    }
}
