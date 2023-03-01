namespace PostOffice;

public class BigBox : Box
{
    private const decimal BaseCost = 10.29m; //m: deciMal d: Double
    private const decimal WeightCost = 0.29m; 
    
    public BigBox(string address, DateTime date, double weight) : base(address, date, weight)
    {
    }

    public override decimal PriceCalculation()
    {
        return BaseCost + (decimal) Weight * WeightCost;
    }
}