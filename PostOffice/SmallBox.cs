namespace PostOffice;

public class SmallBox : Box
{
    private const decimal Cost = 7.99m; //m: deciMal d: Double
    
    public SmallBox(string address, DateTime date, double weight = 0) : base(address, date, weight)
    {
    }

    public override decimal PriceCalculation()
    {
        return Cost;
    }
}