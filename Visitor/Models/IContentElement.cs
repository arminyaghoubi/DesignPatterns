using Visitor.Visitors;

namespace Visitor.Models;

internal interface IContentElement
{
    void Visitor(IVisitor visitor);
}