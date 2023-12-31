using Observer.Interfaces;

Subject subject = new();

IObserver observer1 = new Observer.Subscribers.Observer("Observer1");
IObserver observer2 = new Observer.Subscribers.Observer("Observer2");
IObserver observer3 = new Observer.Subscribers.Observer("Observer3");

subject.Attach(observer1);
subject.Attach(observer2);
subject.Attach(observer3);

subject.Message = "Hello my observers";

subject.Notify();

Console.ReadKey();