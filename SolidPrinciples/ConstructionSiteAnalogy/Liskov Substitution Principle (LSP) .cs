public abstract class ConstructionWorker
{
    public abstract void PerformDuty();
}

// Specific worker classes
public class Bricklayer : ConstructionWorker
{
    public override void PerformDuty() => Console.WriteLine("Building a wall.");
}

public class Electrician : ConstructionWorker
{
    public override void PerformDuty() => Console.WriteLine("Installing electrical wiring.");
}

// Oops! The Inspector class doesn't fit in with the rest of the workers.
public class Inspector : ConstructionWorker
{
    public override void PerformDuty() => throw new NotImplementedException(); // Violates LSP
}
