namespace Prototype.Entities;

internal class Document: ICloneable
{
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? Author { get; set; }

    public Document(string? title,
        string? content,
        string? author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public object Clone()
    {
        // Shallow copy
        return MemberwiseClone();
    }
}
