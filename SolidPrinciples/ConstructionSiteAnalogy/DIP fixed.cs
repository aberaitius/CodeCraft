public interface IConstructionWorker
{
    void PerformDuty();
}

// Concrete classes representing different workers
public class Bricklayer : IConstructionWorker
{
    public void PerformDuty()
    {
        Console.WriteLine("Building a wall.");
    }
}

public class Electrician : IConstructionWorker
{
    public void PerformDuty()
    {
        Console.WriteLine("Installing electrical wiring.");
    }
}

public class Plumber : IConstructionWorker
{
    public void PerformDuty()
    {
        Console.WriteLine("Installing pipes.");
    }
}

public class Decorator : IConstructionWorker
{
    public void PerformDuty()
    {
        Console.WriteLine("Painting and adding finishing touches.");
    }
}

// A construction site that depends on the IConstructionWorker abstraction
public class ConstructionSite
{
    private readonly IConstructionWorker _worker;

    public ConstructionSite(IConstructionWorker worker)
    {
        _worker = worker;
    }

    public void StartWork()
    {
        _worker.PerformDuty();
    }
}
