namespace TemplateMethod.Models;

internal abstract class Course
{
    private string _title;

    public string Title
    {
        get { return _title; }
    }

    private float _duration;

    public float Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public Course(string title, float duration)
    {
        _title = title;
        _duration = duration;
    }

    public void CreateCourse()
    {
        Console.WriteLine($"Course: {_title}({_duration}H)");
        Register();
        ProduceContent();
        UploadContent();
        Publish();
    }

    protected abstract void Register();
    protected abstract void ProduceContent();
    protected abstract void UploadContent();
    protected abstract void Publish();
}