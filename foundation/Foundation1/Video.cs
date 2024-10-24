using System;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comment;

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comment.Count;
    }

    public List<Comment> GetComments()
    {
        return _comment;
    }
}