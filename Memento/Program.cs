using Memento.Models;
using Memento.Services;

Console.Title = "Text Editor";

TextEditorHistory editorHistory = new();

TextEditor editor = new();

string change = string.Empty;
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Please enter your text: ");
    editor.Text = Console.ReadLine();



    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Do you want to change the text[Y,N]? ");
    change = Console.ReadLine().ToUpper();

    if (change == "Y")
    {
        var memento = editor.CreateMemento();
        editorHistory.History.Push(memento);
    }
} while (change == "Y");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Now you can have restores!");

while (editorHistory.History.Count > 0)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Do you want restore to previous state[Y,N]? ");
    string restore = Console.ReadLine().ToUpper();

    if (restore == "N")
    {
        break;
    }

    var memento = editorHistory.History.Pop();
    editor.RestoreFromMemento(memento);
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("End");

Console.ReadKey();
