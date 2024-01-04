using Visitor.Visitors;

namespace Visitor.Models;

internal class Image : IContentElement
{
    public string Caption { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    public void Visitor(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}