namespace PostOffice;

public class Letter : PostItem
{
    private const decimal Cost = 1.99m; //m: deciMal d: Double

    public Letter(string address, DateTime date) : base(address, date)
    {
    }

    public override decimal PriceCalculation()
    {
        return Cost;
    }
}