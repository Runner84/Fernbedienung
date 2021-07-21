using System;
using System.Linq;

namespace Fernseher
{
    class Program
    {
        static void Main(string[] args)
        {
            Fernbedienung fernbedienung = new Fernbedienung();

            var channelList = Enumerable.Range(1, 10).ToList();

            do
            {
                Console.WriteLine($"Der Fernseher ist aus, drücken Sie [x] um den Fernseher einzuschalten");
            }
            while (fernbedienung.isOn = false);
            if(fernbedienung.isOn = true)
            {
                fernbedienung.operation();

            }


        }
    }
}
