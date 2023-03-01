namespace PostOffice;

public class PostOffice
{
    private List<PostItem> _postItems;

    public PostOffice()
    {
        _postItems = new();
    }

    public List<PostItem> GetPostItems()
    {
        return new List<PostItem>(_postItems);
    }

    public List<PostItem> GetPostItemsForDate(DateTime date)
    {
        return _postItems.Where(postItem => postItem.Date.ToShortDateString() == date.ToShortDateString()).ToList();
        return _postItems.Where(postItem => postItem.Date.Year == date.Year &&
                                            postItem.Date.Month == date.Month &&
                                            postItem.Date.Day == date.Day).ToList();
    }

    public void AddPostItem(PostItem postItem)
    {
        _postItems.Add(postItem);
    }

    public decimal CalculateIncomeForType(Type type)
    {
        return _postItems.Where(postItem => postItem.GetType() == type)
            .Sum(postItem => postItem.PriceCalculation());
    }
}