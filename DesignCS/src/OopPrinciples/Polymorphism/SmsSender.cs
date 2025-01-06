using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignCS.src.OopPrinciples.Coupling;

namespace DesignCS.src.OopPrinciples.Polymorphism
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine("Sms Message: " + message);
        }
    }
}