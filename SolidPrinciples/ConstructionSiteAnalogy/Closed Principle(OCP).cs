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