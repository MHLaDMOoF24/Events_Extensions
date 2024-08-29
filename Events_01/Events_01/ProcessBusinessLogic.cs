using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_01
{
    public class ProcessBusinessLogic
    {
        public event EventHandler<string> ProcessCompleted;

        int seasonPass = 0, seasonPassPrice = 399;
        int premiumPass = 0, premiumPassPrice = 799;

        public void CheckForThreshhold(double money)
        {
            if ((int)(money / seasonPassPrice) > seasonPass)
            {
                seasonPass = (int)(money / seasonPassPrice);
                OnProcessCompleted($"Tillykke - du har nu penge nok til at købe {seasonPass} sæsonkort til OBs kampe.");
            }
            if ((int)(money / premiumPassPrice) > premiumPass)
            {
                premiumPass = (int)(money / premiumPassPrice);
                OnProcessCompleted($"Tillykke - du har nu penge nok til at købe {premiumPass} premium sæsonkort til OBs kampe.");
            }

        }

        protected virtual void OnProcessCompleted(string message)
        {
            // Intrinsic for "if ProcessCompleted != null then Invoke"
            ProcessCompleted?.Invoke(this, message);
        }
        
    }
}
