/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        _queue.Insert(Length, person);
    }

    public Person Dequeue()
    {
        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        bool YesNo;
        if (Length == 0)
        {
            YesNo = true;
        }
        else
        {
            YesNo = false;
        }    
        return YesNo;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}