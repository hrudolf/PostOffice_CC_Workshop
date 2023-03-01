namespace PostOfficeTest;
using PostOffice;

public class Tests
{
    private PostOffice _postOffice; 
    
    [SetUp]
    public void Setup()
    {
        _postOffice = new PostOffice();
        _postOffice.AddPostItem(new Letter("Home", DateTime.Now));
        _postOffice.AddPostItem(new SmallBox("Home", DateTime.Now));
        _postOffice.AddPostItem(new BigBox("CodeCool", DateTime.Now.AddDays(-1), 1500));
    }

    [Test]
    public void TestPostCount()
    {
        var postedItems = _postOffice.GetPostItems();
        Assert.That(postedItems.Count(), Is.EqualTo(3));
    }
    
    [Test]
    public void TestPostedToday()
    {
        var postedItems = _postOffice.GetPostItemsForDate(DateTime.Today);
        Assert.That(postedItems.Count(), Is.EqualTo(2));
    }
    
    [Test]
    public void CalculatePriceForBigBox()
    {
        var bigBoxIncome = _postOffice.CalculateIncomeForType(typeof(BigBox));
        var diff = bigBoxIncome - 445.29m;
        Assert.That(diff, Is.LessThan(0.0000001));
    }
}