// Base class representing a construction worker
public abstract class ConstructionWorker
{
    public abstract void PerformDuty();
}

// Bricklayer class responsible only for building walls
public class Bricklayer : ConstructionWorker
{
    public override void PerformDuty()
    {
        Console.WriteLine("Building a wall.");
    }
}

// Electrician class responsible only for electrical work
public class Electrician : ConstructionWorker
{
    public override void PerformDuty()
    {
        Console.WriteLine("Installing electrical wiring.");
    }
}

// Plumber class responsible only for plumbing
public class Plumber : ConstructionWorker
{
    public override void PerformDuty()
    {
        Console.WriteLine("Installing pipes.");
    }
}

// Decorator class responsible only for decorating
public class Decorator : ConstructionWorker
{
    public override void PerformDuty()
    {
        Console.WriteLine("Painting and adding finishing touches.");
    }
}