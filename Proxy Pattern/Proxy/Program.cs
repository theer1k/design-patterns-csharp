using System;
using Proxy.Entities;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            string machineName = "Seatle";
            int machineNumber = 112;

            Console.WriteLine("GumballMachine {0} {1}", machineName, machineNumber);  

            GumballMachine gumballMachine = new GumballMachine(machineName, machineNumber);

            GumballMonitor monitor = new GumballMonitor(gumballMachine);


            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            monitor.Report();

            Console.ReadLine();
        }
    }
}
