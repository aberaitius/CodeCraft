public abstract class ConstructionWorker
{
    public abstract void PerformDuty();
}

// Let's give inspectors their own space
public interface IInspector
{
    void PerformInspection();
}

// Specific worker classes doing what they're supposed to
public class Bricklayer : ConstructionWorker
{
    public override void PerformDuty() => Console.WriteLine("Building a wall.");
}

public class Electrician : ConstructionWorker
{
    public override void PerformDuty() => Console.WriteLine("Installing electrical wiring.");
}

// Inspector now has its own role and responsibilities
public class Inspector : IInspector
{
    public void PerformInspection() => Console.WriteLine("Inspecting the construction work.");
}
