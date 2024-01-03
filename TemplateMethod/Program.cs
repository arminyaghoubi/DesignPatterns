using TemplateMethod.Models;

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Creating an online course...");
Console.ForegroundColor = ConsoleColor.DarkGreen;

Course onlineCourse = new OnlineCourse("Design Patterns", 20);

onlineCourse.CreateCourse();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n-------------------\n");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Creating an offline course...");
Console.ForegroundColor = ConsoleColor.DarkRed;

Course offlineCourse = new OfflineCourse("C# Fundamentals", 15);

offlineCourse.CreateCourse();

Console.ReadKey();