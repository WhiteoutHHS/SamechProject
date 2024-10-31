public abstract class VendingMachine
{
    protected const decimal DEFAULT_CASH = 0m;
    protected const decimal SODA1_PRICE = 1.50m;
    protected const decimal SODA2_PRICE = 1.75m;
    protected const decimal SODA3_PRICE = 2.00m;

    public VendingMachine(string name, decimal initialCash)
    {
        this.Name = name;
        CashBalance = initialCash;
        SalesTotal = 0;
    }

    public string Name { get; set; }
    public decimal CashBalance { get; private set; }
    public decimal SalesTotal { get; private set; }

    public void AcceptCoins(decimal amount)
    {
        if (amount > 0)
        {
            CashBalance += amount;
            Console.WriteLine($"Добавлено {amount:C}. Текущий баланс: {CashBalance:C}");
        }
        else
        {
            Console.WriteLine("Сумма должна быть положительной.");
        }
    }




    public decimal GiveChange(decimal amount)
    {
        if (amount > CashBalance)
        {
            Console.WriteLine("Недостаточно наличных для выдачи сдачи.");
            return 0;
        }

        CashBalance -= amount;
        Console.WriteLine($"Выдана сдача: {amount:C}. Текущий баланс: {CashBalance:C}");
        return amount;
    }

    protected void UpdateSales(decimal amount)
    {
        SalesTotal += amount;
        Console.WriteLine($"Общие продажи: {SalesTotal:C}");
    }

    public abstract void BuyProduct();

    public override bool Equals(object obj)
    {
        if (obj is VendingMachine machine)
        {
            return Name == machine.Name && CashBalance == machine.CashBalance && SalesTotal == machine.SalesTotal;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, CashBalance, SalesTotal);
    }
}
