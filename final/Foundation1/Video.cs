public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment> {};

    public Video(string title, string author, string length)
    {
        this._title = title;
        this._author = author;
        this._length = length;        
    }

    public void AddComment(string authorName, string content)
    {
        Comment comment = new Comment();
        comment.SetComment(authorName, content);
        _comments.Add(comment);

    }

    public int GetCommentNumber()
    {
        int totalComment = 0;
        foreach (Comment comment in _comments)
        {
            totalComment += 1;
        }
        return totalComment;
    }

    public void DisplayComments()
    {
        int sortNumber = 0;
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            sortNumber += 1;
            Console.WriteLine($"  {sortNumber}. {comment.GetComment()}");
        }
        Console.WriteLine();
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine("--------Movie Time----------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");;
    }
}