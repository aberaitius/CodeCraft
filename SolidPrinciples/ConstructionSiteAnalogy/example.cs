```csharp
// Single Responsibility Principle (SRP) - Before Implementation

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

// Single Responsibility Principle (SRP) - After Implementation

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

// Open/Closed Principle (OCP) - Before Implementation

// Class with hardcoded logic for different tasks
public class ConstructionSite
{
    public void PerformTask(string task)
    {
        if (task == "WallBuilding")
        {
            Console.WriteLine("Building a wall.");
        }
        else if (task == "ElectricalInstallation")
        {
            Console.WriteLine("Installing electrical wiring.");
        }
        else if (task == "PlumbingInstallation")
        {
            Console.WriteLine("Installing pipes.");
        }
        else if (task == "Decorating")
        {
            Console.WriteLine("Painting and adding finishing touches.");
        }
    }
}

// Open/Closed Principle (OCP) - After Implementation

// Base class representing a construction task
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

// Liskov Substitution Principle (LSP) - Before Implementation

// A class that cannot perform the same duty as other construction workers
public class Decorator : ConstructionWorker
{
    public override void PerformDuty()
    {
        throw new NotImplementedException(); // Decorator cannot perform duty
    }
}

// Liskov Substitution Principle (LSP) - After Implementation

// Base class representing a construction worker
public abstract class ConstructionWorker
{
    public abstract void PerformDuty();
}

// Bricklayer class
public class Bricklayer : ConstructionWorker
{
    public override void PerformDuty()
    {
        Console.WriteLine("Building a wall.");
    }
}

// Electrician class
public class Electrician : ConstructionWorker
{
    public override void PerformDuty()
    {
        Console.WriteLine("Installing electrical wiring.");
    }
}

// Plumber class
public class Plumber : ConstructionWorker
{
    public override void PerformDuty()
    {
        Console.WriteLine("Installing pipes.");
    }
}

// Decorator class
public class Decorator : ConstructionWorker
{
    public override void PerformDuty()
    {
        Console.WriteLine("Painting and adding finishing touches.");
    }
}

// Construction site that can start work with any construction worker
public class ConstructionSite
{
    public void StartWork(ConstructionWorker worker)
    {
        worker.PerformDuty();
    }
}

// Interface Segregation Principle (ISP) - Before Implementation

// Interface with multiple unrelated methods
public interface IConstructionTasks
{
    void BuildWall();
    void InstallWiring();
    void InstallPipes();
    void Paint();
}

// Class implementing the interface but not all methods are needed
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

    public void Paint()
    {
        throw new NotImplementedException();
    }
}

// Interface Segregation Principle (ISP) - After Implementation

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

// Interface for decorating tasks
public interface IDecoratingTasks
{
    void Paint();
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

// Decorator class implementing only decorating tasks
public class Decorator : IDecoratingTasks
{
    public void Paint()
    {
        Console.WriteLine("Painting and adding finishing touches.");
    }
}

// Dependency Inversion Principle (DIP) - Before Implementation

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

// Dependency Inversion Principle (DIP) - After Implementation

// An interface for performing duties
public interface IConstructionWorker
{
    void PerformDuty();
}

// A class representing a bricklayer, implementing the IConstructionWorker interface
public class Bricklayer : IConstructionWorker
{
    public void PerformDuty()
    {
        Console.WriteLine("Building a wall.");
    }
}

// A class representing an electrician, implementing the IConstructionWorker interface
public class Electrician : IConstructionWorker
{
    public void PerformDuty()
    {
        Console.WriteLine("Installing electrical wiring.");
    }
}

// A class representing a plumber, implementing the IConstructionWorker interface
public class Plumber : IConstructionWorker
{
    public void PerformDuty()
    {
        Console.WriteLine("Installing pipes.");
    }
}

// A class representing a decorator, implementing the IConstructionWorker interface
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
```