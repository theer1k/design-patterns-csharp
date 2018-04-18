using System;
using State.Entities;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(2);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.Refill(5);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            Console.ReadLine();
        }
    }
}
