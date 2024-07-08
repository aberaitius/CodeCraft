using System;

//#################################################################################################################
// Single Responsibility Principle (SRP)
// Definition: A class should have only one reason to change, meaning it should have only one job or responsibility.

// User Authentication Service with a single responsibility for user authentication
public class UserAuthenticationService
{
    public void AuthenticateUser(string username, string password)
    {
        // Authentication logic
        Console.WriteLine($"Authenticating user: {username}");
    }
}

// Email Service with a single responsibility for sending emails
public class EmailService
{
    public void SendEmail(string recipient, string subject, string body)
    {
        // Email sending logic
        Console.WriteLine($"Sending email to: {recipient}, Subject: {subject}, Body: {body}");
    }
}

//#################################################################################################################
// Open/Closed Principle (OCP)
// Definition: Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. 
// This allows new functionality to be added without altering existing code.

// Shape interface that is open for extension (new shapes can be added)
public interface IShape
{
    double Area(); // Calculating area of the shape
}

// Rectangle class extending Shape and closed for modification
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height; // Area calculation specific to Rectangle
    }
}

// Circle class extending Shape and closed for modification
public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius; // Area calculation specific to Circle
    }
}

//#################################################################################################################
// Liskov Substitution Principle (LSP)
// Definition: Objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program.

// Bird superclass with a common method Fly() that should be usable by all subclasses
public abstract class Bird
{
    public abstract void Fly(); // Common behavior for all birds
}

// Eagle subclass that can fly
public class Eagle : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Eagle flying high.");
    }
}

// Penguin subclass that cannot fly (LSP violation example)
public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotSupportedException("Penguins cannot fly.");
    }
}

//#################################################################################################################
// Interface Segregation Principle (ISP)
// Definition: Clients should not be forced to depend on interfaces they do not use. 
// Instead of one large interface, many smaller interfaces should be preferred.

// IPrinter interface for printing functionality
public interface IPrinter
{
    void Print(); // Print method
}

// IScanner interface for scanning functionality
public interface IScanner
{
    void Scan(); // Scan method
}

// Printer class implementing IPrinter interface
public class Printer : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing..."); // Printer implementation of Print()
    }
}

// Scanner class implementing IScanner interface
public class Scanner : IScanner
{
    public void Scan()
    {
        Console.WriteLine("Scanning..."); // Scanner implementation of Scan()
    }
}

//#################################################################################################################
// Dependency Inversion Principle (DIP)
// Definition: High-level modules should not depend on low-level modules. Both should depend on abstractions (e.g., interfaces). 
// Abstractions should not depend on details; details should depend on abstractions.

// INotificationSender interface defining SendNotification method
public interface INotificationSender
{
    void SendNotification(string message); // Method to send notifications
}

// EmailSender implementing INotificationSender for sending email notifications
public class EmailSender : INotificationSender
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending email notification: {message}"); // Email sending logic
    }
}

// SMSSender implementing INotificationSender for sending SMS notifications
public class SMSSender : INotificationSender
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending SMS notification: {message}"); // SMS sending logic
    }
}

// NotificationService using INotificationSender for sending notifications
public class NotificationService
{
    private readonly INotificationSender _notificationSender;

    public NotificationService(INotificationSender notificationSender)
    {
        _notificationSender = notificationSender; // Dependency injection
    }

    public void SendNotification(string message)
    {
        _notificationSender.SendNotification(message); // Sending notification using injected sender
    }
}

//######################################################################################################
// Main method for testing SOLID principles
public class Program
{
    public static void Main()
    {
        // Test Single Responsibility Principle (SRP)
        var authService = new UserAuthenticationService();
        authService.AuthenticateUser("john.doe", "password");

        var emailService = new EmailService();
        emailService.SendEmail("john.doe@example.com", "Test Subject", "This is a test email.");

        // Test Open/Closed Principle (OCP)
        IShape rectangle = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine($"Area of Rectangle: {rectangle.Area()}");

        IShape circle = new Circle { Radius = 7 };
        Console.WriteLine($"Area of Circle: {circle.Area()}");

        // Test Liskov Substitution Principle (LSP)
        Bird eagle = new Eagle();
        eagle.Fly(); // Eagle can fly

        Bird penguin = new Penguin();
        penguin.Fly(); // Penguin cannot fly (LSP violation)

        // Test Interface Segregation Principle (ISP)
        IPrinter printer = new Printer();
        printer.Print(); // Printing functionality

        IScanner scanner = new Scanner();
        scanner.Scan(); // Scanning functionality

        // Test Dependency Inversion Principle (DIP)
        INotificationSender emailSender = new EmailSender();
        var notificationService = new NotificationService(emailSender);
        notificationService.SendNotification("Hello, this is a notification via email.");

        INotificationSender smsSender = new SMSSender();
        notificationService = new NotificationService(smsSender);
        notificationService.SendNotification("Hello, this is a notification via SMS.");
    }
}
