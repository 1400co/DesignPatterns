using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Strategy = new ConcreteStrategyA();
            client.CallAlgorithm();

            client.Strategy = new ConcreteStrategyB();
            client.CallAlgorithm();

            Console.ReadKey();
        }
    }
}
