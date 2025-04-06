public class Comment
{
    public string _commenter;
    public string _comment;

    public void Display()
    {
        Console.WriteLine($"{_commenter}: {_comment}");
    }
    
}