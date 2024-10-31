using System;

class Program
{
    static void Main()
    {
        SodaVendingMachine sodaMachine = new SodaVendingMachine("Газировочный автомат", 100m, 10, 10, 10);

        sodaMachine.AcceptCoins(5m);
        sodaMachine.BuySoda1();
        sodaMachine.BuySoda2();

        sodaMachine.Restock(5, 5, 5);
    }
}
