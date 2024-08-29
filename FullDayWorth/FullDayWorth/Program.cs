using ExtensionsLesson;

namespace Events_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic pBL = new ProcessBusinessLogic();
            Piggybank OBGris = new Piggybank();

            Random rnd = new Random();
            int inputRounds = 0;
            int inputAmount = 0;

            pBL.ProcessCompleted += pBL_ProcessCompleted;

            do
            {
                Console.Clear();
                OBGris.Money = 0;
                pBL.ResetPassCount();

                Console.WriteLine("Velkommen til fodboldgrisen!\n");

                Console.Write("Hvor mange gange ligger du penge i den? ");
                int.TryParse(Console.ReadLine(), out inputRounds);
                Console.Write("Hvad ligger du maks i den per gang? ");
                int.TryParse(Console.ReadLine(), out inputAmount);
                Console.WriteLine();

                System.Threading.Thread.Sleep(1000);
                for (int i = 0; i < inputRounds; i++)
                {
                    OBGris.AddMoney(Math.Round(rnd.NextDouble(inputAmount), 2));
                    OBGris.AnnounceMoney();
                    pBL.CheckForThreshhold(OBGris.Money);
                    System.Threading.Thread.Sleep(1000);
                }

                Console.WriteLine($"\nDu endte med {OBGris.Money}.\nTryk Enter for at fortsætte...");
                Console.ReadLine();
            } while (inputRounds != 0);

            pBL.ProcessCompleted -= pBL_ProcessCompleted;
        }

        public static void pBL_ProcessCompleted(object sender, string message)
        {
            Console.WriteLine(message);
        }
    }
}
