namespace Memento.Models;

internal class TextMemento
{
    private string _text;

    public string Text { get => _text; }

    public TextMemento(string text) => _text = text;
}
