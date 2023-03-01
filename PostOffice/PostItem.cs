namespace PostOffice;

public abstract class PostItem
{
    public string Address { get; }
    public DateTime Date { get; }

    public PostItem(string address, DateTime date)
    {
        Address = address;
        Date = date;
    }

    public abstract decimal PriceCalculation();
}