using Visitor.Models;

namespace Visitor.Visitors;

internal interface IVisitor
{
    void Visit(Article article);
    void Visit(Image image);
}