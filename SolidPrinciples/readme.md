using System;

/*
#################################################################################################################
SOLID Design Principles Example in C#

This C# code demonstrates the implementation of the five SOLID design principles: Single Responsibility Principle (SRP),
Open/Closed Principle (OCP), Liskov Substitution Principle (LSP), Interface Segregation Principle (ISP), and 
Dependency Inversion Principle (DIP). Each section includes a brief definition and an example implementation showcasing
how these principles can be applied to enhance software design and maintainability.

#################################################################################################################
*/

// Single Responsibility Principle (SRP)
// Definition: A class should have only one reason to change, meaning it should have only one job or responsibility.

public class UserAuthenticationService
{
    public void AuthenticateUser(string username, string password)
    {
        // Authentication logic
        Console.WriteLine($"Authenticating user: {username}");
    }
}

public class EmailService
{
    public void SendEmail(string recipient, string subject, string body)
    {
        // Email sending logic
        Console.WriteLine($"Sending email to: {recipient}, Subject: {subject}, Body: {body}");
    }
}

// Open/Closed Principle (OCP)
// Definition: Software entities should be open for extension but closed for modification.

public interface IShape
{
    double Area();
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

// Liskov Substitution Principle (LSP)
// Definition: Objects of a superclass should be replaceable with objects of its subclasses without affecting correctness.

public abstract class Bird
{
    public abstract void Fly();
}

public class Eagle : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Eagle flying high.");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotSupportedException("Penguins cannot fly.");
    }
}

// Interface Segregation Principle (ISP)
// Definition: Clients should not be forced to depend on interfaces they do not use.

public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class Printer : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

public class Scanner : IScanner
{
    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }
}

// Dependency Inversion Principle (DIP)
// Definition: High-level modules should not depend on low-level modules. Both should depend on abstractions.

public interface INotificationSender
{
    void SendNotification(string message);
}

public class EmailSender : INotificationSender
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending email notification: {message}");
    }
}

public class SMSSender : INotificationSender
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending SMS notification: {message}");
    }
}

public class NotificationService
{
    private readonly INotificationSender _notificationSender;

    public NotificationService(INotificationSender notificationSender)
    {
        _notificationSender = notificationSender;
    }

    public void SendNotification(string message)
    {
        _notificationSender.SendNotification(message);
    }
}

// Main method for testing SOLID principles
public class Program
{
    public static void Main()
    {
        var authService = new UserAuthenticationService();
        authService.AuthenticateUser("john.doe", "password");

        var emailService = new EmailService();
        emailService.SendEmail("john.doe@example.com", "Test Subject", "This is a test email.");

        IShape rectangle = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine($"Area of Rectangle: {rectangle.Area()}");

        IShape circle = new Circle { Radius = 7 };
        Console.WriteLine($"Area of Circle: {circle.Area()}");

        Bird eagle = new Eagle();
        eagle.Fly();

        Bird penguin = new Penguin();
        try
        {
            penguin.Fly();
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }

        IPrinter printer = new Printer();
        printer.Print();

        IScanner scanner = new Scanner();
        scanner.Scan();

        INotificationSender emailSender = new EmailSender();
        var notificationService = new NotificationService(emailSender);
        notificationService.SendNotification("Hello, this is a notification via email.");

        INotificationSender smsSender = new SMSSender();
        notificationService = new NotificationService(smsSender);
        notificationService.SendNotification("Hello, this is a notification via SMS.");
    }
}
