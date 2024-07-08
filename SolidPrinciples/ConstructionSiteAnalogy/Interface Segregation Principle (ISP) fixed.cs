// Interface for wall-building tasks
public interface IWallBuildingTasks
{
    void BuildWall();
}

// Interface for electrical tasks
public interface IElectricalTasks
{
    void InstallWiring();
}
// Interface for plumbing tasks
public interface IPlumbingTasks
{
    void InstallPipes();
}

// Bricklayer class implementing only wall-building tasks
public class Bricklayer : IWallBuildingTasks
{
    public void BuildWall()
    {
        Console.WriteLine("Building a wall.");
    }
}

// Electrician class implementing only electrical tasks
public class Electrician : IElectricalTasks
{
    public void InstallWiring()
    {
        Console.WriteLine("Installing electrical wiring.");
    }
}

// Plumber class implementing only plumbing tasks
public class Plumber : IPlumbingTasks
{
    public void InstallPipes()
    {
        Console.WriteLine("Installing pipes.");
    }
}
