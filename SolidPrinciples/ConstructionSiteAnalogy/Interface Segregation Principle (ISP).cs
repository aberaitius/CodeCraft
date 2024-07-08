public interface IConstructionTasks
{
    void BuildWall();
    void InstallWiring();
    void InstallPipes();
  
}
public class Bricklayer : IConstructionTasks
{
    public void BuildWall()
    {
        Console.WriteLine("Building a wall.");
    }

    public void InstallWiring()
    {
        throw new NotImplementedException();
    }

    public void InstallPipes()
    {
        throw new NotImplementedException();
    }
}