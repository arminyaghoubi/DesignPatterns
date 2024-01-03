namespace TemplateMethod.Models;

internal class OnlineCourse : Course
{
    public OnlineCourse(string title, float duration) : base(title, duration)
    {
    }

    protected override void Register()
    {
        Console.WriteLine("\tStudents register for the online course.");
    }

    protected override void ProduceContent()
    {
        Console.WriteLine("\tCreate online course content.");
    }

    protected override void UploadContent()
    {
        Console.WriteLine("\tUpload online course content.");
    }

    protected override void Publish()
    {
        Console.WriteLine("\tPublish the online course.");
    }
}
