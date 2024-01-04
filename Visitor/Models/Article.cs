using Visitor.Visitors;

namespace Visitor.Models;

internal class Article : IContentElement
{
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;

    public void Visitor(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
