using Visitor.Models;

namespace Visitor.Visitors;

internal class ExportVisitor : IVisitor
{
    public void Visit(Article article)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Exporting article: {article.Title}");
    }

    public void Visit(Image image)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Exporting image: {image.Caption}");
    }
}