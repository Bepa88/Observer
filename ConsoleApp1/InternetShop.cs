using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InternetShop : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        public delegate void Notify();
        public event Notify Reaction;

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.ReactionToTheEvent();
            }
        }

        public void ObserversForEvent()
        {
            if (Reaction != null)
            {
                Reaction();
            }
        }
    }
}
