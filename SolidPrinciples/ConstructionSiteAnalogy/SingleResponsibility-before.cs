// A single class doing multiple tasks, which is not efficient
public class ConstructionWorker
{
    public void BuildWall()
    {
        Console.WriteLine("Building a wall.");
    }

    public void InstallWiring()
    {
        Console.WriteLine("Installing electrical wiring.");
    }

    public void InstallPipes()
    {
        Console.WriteLine("Installing pipes.");
    }

    public void Paint()
    {
        Console.WriteLine("Painting and adding finishing touches.");
    }
}