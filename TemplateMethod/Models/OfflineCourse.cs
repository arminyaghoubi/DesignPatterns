namespace TemplateMethod.Models;

internal class OfflineCourse : Course
{
    public OfflineCourse(string title, float duration) : base(title, duration)
    {
    }

    protected override void Register()
    {
        Console.WriteLine("\tStudents register for the offline course.");
    }

    protected override void ProduceContent()
    {
        Console.WriteLine("\tCreate offline course content.");
    }

    protected override void UploadContent()
    {
        Console.WriteLine("\tUpload offline course content.");
    }

    protected override void Publish()
    {
        Console.WriteLine("\tPublish the offline course.");
    }
}