using Memento.Models;

namespace Memento.Services;

internal class TextEditorHistory
{
    public Stack<TextMemento> History { get; } = new Stack<TextMemento>();
}