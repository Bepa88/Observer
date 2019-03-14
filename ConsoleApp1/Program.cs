using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            InternetShop Rozetka = new InternetShop();
            Subscriber client1 = new Subscriber("Вiра");
            Subscriber client2 = new Subscriber("Вiктор");
            
            Rozetka.AddObserver(client1);
            Rozetka.AddObserver(client2);
            Rozetka.NotifyObservers();
            // Використання events
            Rozetka.Reaction += client1.ReactionToTheEvent;
            Rozetka.Reaction += client2.ReactionToTheEvent;
            Rozetka.ObserversForEvent();
            Console.ReadKey();
        }
    }
}
