using System;

namespace Strategy
{
    public class Client
    {
        public IStrategy Strategy { get; set; }

        public void CallAlgorithm()
        {
            Console.WriteLine(Strategy.Algorithm());
        }
    }
}