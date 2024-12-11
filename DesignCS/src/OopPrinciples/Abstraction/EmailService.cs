using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignCS.src.OopPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail(){
            Connect("https://www.hotmail.com");
            Authenticate();
            Console.WriteLine("Sending Email...");
            Disconnect();
        }

        private void Connect(string url){
            //Only need to change here if adding a parameter
            Console.WriteLine("Connecting to Email server...");
        }

        private void Authenticate(){
            Console.WriteLine("Authenticating...");
        }

        private void Disconnect(){
            Console.WriteLine("Disconnecting from Server...");
        }
    }
}