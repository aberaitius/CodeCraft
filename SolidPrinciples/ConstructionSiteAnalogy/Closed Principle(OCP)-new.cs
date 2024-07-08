public abstract class ConstructionTask
{
    public abstract void PerformTask();
}

// Class representing a wall building task
public class WallBuilding : ConstructionTask
{
    public override void PerformTask()
    {
        Console.WriteLine("Building a wall.");
    }
}

// Class representing an electrical installation task
public class ElectricalInstallation : ConstructionTask
{
    public override void PerformTask()
    {
        Console.WriteLine("Installing electrical wiring.");
    }
}

// Class representing a plumbing installation task
public class PlumbingInstallation : ConstructionTask
{
    public override void PerformTask()
    {
        Console.WriteLine("Installing pipes.");
    }
}

// Class representing a decorating task
public class Decorating : ConstructionTask
{
    public override void PerformTask()
    {
        Console.WriteLine("Painting and adding finishing touches.");
    }
}

// Construction site that can start work with any construction task
public class ConstructionSite
{
    public void StartWork(ConstructionTask task)
    {
        task.PerformTask();
    }
}