using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int NumberOfComments()
    {
        return _comments.Count;
    }

     public void Display()
     {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {NumberOfComments()}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
        
     }


}