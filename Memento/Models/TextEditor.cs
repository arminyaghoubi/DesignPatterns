namespace Memento.Models;

internal class TextEditor
{
    private string _text = string.Empty;

    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Text changed: '{_text}'");
        }
    }

    public TextMemento CreateMemento() => new TextMemento(_text);

    public void RestoreFromMemento(TextMemento memento)
    {
        _text = memento.Text;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Restore to previous state: '{_text}'");
    }
}
