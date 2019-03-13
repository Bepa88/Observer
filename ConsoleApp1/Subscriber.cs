using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Subscriber : IObserver
    {
        public string Name { set; get;}

        public Subscriber(string name)
        {
            Name = name;
        }

        public void ReactionToTheEvent()
        {
            Console.WriteLine("Reaction " + Name);
        }
    }
}
