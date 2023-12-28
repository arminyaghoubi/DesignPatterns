namespace Iterator.Iterators;

internal interface IIterator<T>
{
    bool HasNext();
    T? Next();
}
