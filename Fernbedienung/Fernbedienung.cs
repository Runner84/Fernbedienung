using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernseher
{
    class Fernbedienung
    {
        public bool isOn = false;

        public void operation()
        {
            do

            {
                string userInput = "";
                do
                {
                    Console.WriteLine("Drücken Sie folgende Tasten:");
                    Console.WriteLine("[n] für den nächsten Kanal");
                    Console.WriteLine("[p] für den vorherigen Kanal");
                    Console.WriteLine("[+] um den Fernseher lauter zu schalten");
                    Console.WriteLine("[-] um den Fernseher leiser zu schalten");
                    Console.WriteLine("[o] um den Fernseher auszuschalten");
                    userInput = Console.ReadLine();

                }
                while (!(userInput == "x" || userInput == "n" || userInput == "p" || userInput == "+" || userInput == "-" || userInput == "o"));

                if (userInput == "x")
                {
                    isOn = true;
                }
                else if (userInput == "o")
                {
                    isOn = false;
                }
                else if (userInput == "+")
                {
                    //volumneUp();
                }
                else if (userInput == "-")
                {
                    //volumneDown();
                }
                else if (userInput == "n")
                {
                    //nextChannel();
                }
                else
                {
                    //previousChannel();
                }
            }
            while (isOn = true);
        }
    }
}
