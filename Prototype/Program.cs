using Prototype.Entities;

Document document = new("Prototype", "Creational Design Pattern", "ArminYaghoubi");


var document1= (Document)document.Clone();

var document2= (Document)document.Clone();

Console.WriteLine("-------Document1");
Console.WriteLine($"{document1.Title}({document1.Author})\n{document1.Content}");

Console.WriteLine("-------Document2");
Console.WriteLine($"{document2.Title}({document2.Author})\n{document2.Content}");