namespace PostOffice;

public abstract class Box : PostItem
{
    //protected useable in inherited classed
    protected double Weight { get; }
    
    //double weight = 0 -> default value
    protected Box(string address, DateTime date, double weight = 0) : base(address, date)
    {
        Weight = weight;
    }
    
    //pricecalc not added because it's an abstract class too
}