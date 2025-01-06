using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignCS.src.OopPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine("Sending Email: " + message );
        }
    }
}