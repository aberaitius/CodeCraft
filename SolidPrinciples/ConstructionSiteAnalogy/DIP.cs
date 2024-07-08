// A class representing a bricklayer
public class Bricklayer
{
    public void PerformDuty()
    {
        Console.WriteLine("Building a wall.");
    }
}

// A class representing an electrician
public class Electrician
{
    public void PerformDuty()
    {
        Console.WriteLine("Installing electrical wiring.");
    }
}

// A class representing a plumber
public class Plumber
{
    public void PerformDuty()
    {
        Console.WriteLine("Installing pipes.");
    }
}

// A class representing a decorator
public class Decorator
{
    public void PerformDuty()
    {
        Console.WriteLine("Painting and adding finishing touches.");
    }
}

// A construction site that depends directly on concrete classes
public class ConstructionSite
{
    private readonly Bricklayer _bricklayer;
    private readonly Electrician _electrician;
    private readonly Plumber _plumber;
    private readonly Decorator _decorator;

    public ConstructionSite(Bricklayer bricklayer, Electrician electrician, Plumber plumber, Decorator decorator)
    {
        _bricklayer = bricklayer;
        _electrician = electrician;
        _plumber = plumber;
        _decorator = decorator;
    }

    public void StartWork(string workerType)
    {
        if (workerType == "Bricklayer")
        {
            _bricklayer.PerformDuty();
        }
        else if (workerType == "Electrician")
        {
            _electrician.PerformDuty();
        }
        else if (workerType == "Plumber")
        {
            _plumber.PerformDuty();
        }
        else if (workerType == "Decorator")
        {
            _decorator.PerformDuty();
        }
    }
}
