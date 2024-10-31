using System;

public class VendingMachine
{
    public VendingMachine(string name, decimal initialCash)
    {
        this.name = name;
        cashBalance = initialCash;
        salesTotal = 0;
    }

    public string name { get; set; }
    public decimal cashBalance { get; private set; }
    public decimal salesTotal { get; private set; }

    public void AcceptCoins(decimal amount)
    {
        if (amount > 0)
        {
            cashBalance += amount;
            Console.WriteLine($"Добавлено {amount:C}. Текущий баланс: {cashBalance:C}");
        }
        else
        {
            Console.WriteLine("Сумма должна быть положительной.");
        }
    }

    public decimal GiveChange(decimal amount)
    {
        if (amount > cashBalance)
        {
            Console.WriteLine("Недостаточно наличных для выдачи сдачи.");
            return 0;
        }

        cashBalance -= amount;
        Console.WriteLine($"Выдана сдача: {amount:C}. Текущий баланс: {cashBalance:C}");
        return amount;
    }

    protected void UpdateSales(decimal amount)
    {
        salesTotal += amount;
        Console.WriteLine($"Общие продажи: {salesTotal:C}");
    }
}
