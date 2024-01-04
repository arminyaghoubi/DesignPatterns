using Visitor.Models;
using Visitor.Visitors;

var contents = new List<IContentElement>
{
    new Article{Title = "Introduction to Design Patterns", Body = "..."},
    new Image{Caption = "Linkedin Image", Url="https://www.linkedin.com/in/arminyaghoubi1/"}
};

IVisitor visitor = new ExportVisitor();

foreach (var content in contents)
{
    content.Visitor(visitor);
}

Console.ReadKey();