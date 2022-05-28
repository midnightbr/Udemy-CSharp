namespace Generics;

public class PrintService<X>
{
    private X[] _values = new X[10];
    private int _count = 0;

    public void AddValue(X value)
    {
        if (_count >= 10)
        {
            throw new InvalidOperationException("PrintService is full");
        }
        _values[_count] = value;
        _count++;
    }

    public X First()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("PrintService is empty");
        }
        return _values[0];
    }

    public void Print()
    {
        Console.Write("[");
        for (int i = 0; i < _count - 1; i++)
        {
            Console.Write(_values[i] + ", ");
        }

        if (_count > 0)
        {
            Console.Write(_values[_count - 1]);
        }

        Console.WriteLine("]");
    }
}