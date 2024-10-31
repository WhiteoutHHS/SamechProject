using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class SodaVendingMachine : VendingMachine
{
    private int sodaStock1;
    private int sodaStock2;
    private int sodaStock3;

    public SodaVendingMachine(string name, decimal initialCash, int initialSoda1, int initialSoda2, int initialSoda3)
        : base(name, initialCash)
    {
        sodaStock1 = initialSoda1;
        sodaStock2 = initialSoda2;
        sodaStock3 = initialSoda3;
    }

    public void BuySoda1()
    {
        if (sodaStock1 < 1)
        {
            Console.WriteLine("Сода 1 закончилась.");
            return;
        }

        sodaStock1--;
        UpdateSales(1.50m); // цена за Соду 1
        Console.WriteLine("Куплена Сода 1.");
    }

    public void BuySoda2()
    {
        if (sodaStock2 < 1)
        {
            Console.WriteLine("Сода 2 закончилась.");
            return;
        }

        sodaStock2--;
        UpdateSales(1.75m); // цена за Соду 2
        Console.WriteLine("Куплена Сода 2.");
    }

    public void BuySoda3()
    {
        if (sodaStock3 < 1)
        {
            Console.WriteLine("Сода 3 закончилась.");
            return;
        }

        sodaStock3--;
        UpdateSales(2.00m); // цена за Соду 3
        Console.WriteLine("Куплена Сода 3.");
    }

    public void Restock(int soda1, int soda2, int soda3)
    {
        sodaStock1 += soda1;
        sodaStock2 += soda2;
        sodaStock3 += soda3;

        Console.WriteLine("Запасы газировки обновлены.");
    }
}
