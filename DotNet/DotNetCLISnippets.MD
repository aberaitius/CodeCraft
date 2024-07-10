## .NET CLI Shortcuts and Commands Guide

This guide provides essential .NET CLI shortcuts and commands to streamline your development workflow. Whether you're creating new projects, managing packages, generating code, or setting up advanced templates, these commands will help you get started quickly and efficiently.

| **Task**                                         | **Command**                                                                 |
|--------------------------------------------------|------------------------------------------------------------------------------|
| **Check .NET SDK Version**                       | `dotnet --version`                                                           |
| **Create a New ASP.NET Core Web API Project**    | `dotnet new webapi -n MyWebAPI`                                               |
| **Create a New ASP.NET Core MVC Project**        | `dotnet new mvc -n MyMvcApp`                                                  |
| **Create a New ASP.NET Core Blazor Server App**  | `dotnet new blazorserver -n MyBlazorApp`                                      |
| **Create a New ASP.NET Core Razor Pages App**    | `dotnet new razor -n MyRazorApp`                                              |
| **Install Entity Framework Core Tools**          | `dotnet tool install --global dotnet-ef`                                      |
| **Install ASP.NET Core Scaffolding Tools**       | `dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design`        |
|                                                  | `dotnet add package Microsoft.EntityFrameworkCore.Design`                    |
| **Run the Project**                             | `dotnet run`                                                                 |
| **Add a Package Reference**                      | `dotnet add package <package-name>`                                           |
| **Restore Packages**                            | `dotnet restore`                                                             |
| **List Installed Templates**                    | `dotnet new --list`                                                          |
| **Generate a New Controller with Scaffolding**   | `dotnet aspnet-codegenerator controller -name ProductsController -async -api -m Product -dc ApplicationDbContext -outDir Controllers` |
| **Generate a New Razor Page with Scaffolding**   | `dotnet aspnet-codegenerator razorpage -name Index -dc ApplicationDbContext -outDir Pages` |
| **Generate CRUD Operations Using Scaffolding**   | `dotnet aspnet-codegenerator controller -name ProductsController -async -api -m Product -dc ApplicationDbContext -outDir Controllers` |
| **Install Clean Architecture Template**          | `dotnet new -i Clean.Architecture.Solution.Template`                          |
| **Create a New Project with Clean Architecture** | `dotnet new ca-sln -n MyCleanArchitectureApp`                                 |
| **Install .NET Boxed Templates**                | `dotnet new -i Boxed.Templates`                                               |
| **Install ABP (ASP.NET Boilerplate)**           | `dotnet tool install -g Volo.Abp.Cli`                                         |
|                                                  | `abp new Acme.BookStore -t app-pro`                                           |
| **Display Help for a Command**                  | `dotnet <command> --help`                                                     |
| **Remove a Package**                            | `dotnet remove package <package-name>`                                        |
| **List Global Tools**                           | `dotnet tool list --global`                                                   |
