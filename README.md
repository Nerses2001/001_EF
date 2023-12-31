# EF
# Project 001_EF

This project showcases sample code demonstrating the usage of Entity Framework in a .NET Core application. The code includes a simple data model 'User' and necessary configurations to work with Entity Framework and a SQL Server database.

## Code Structure

The code is organized into several namespaces and classes:

1. **_001_EF.Data:** Contains the `DbAppContext` class, inherited from `DbContext`, representing the database context for interacting with it.

2. **_001_EF.Models:** Contains the `User` class representing the user entity with properties like Id, FirstName (FName), LastName (LName), and Age.

3. **_001_EF.Migrations:** Contains migrations for database schema changes, including the initial migration `Intional`.

## Usage

1. **Adding a Migration**

    To create a migration, run the following command in the Package Manager Console:

    ```bash
    Add-Migration Initial -Context DbAppContext
    ```

    This command will create a migration named "Initial" describing the initial state of the database.

2. **Updating the Database**

    To apply migrations and update the database, execute:

    ```bash
    Update-Database -Context DbAppContext
    ```

    This command will apply any pending migrations and update the database schema.

3. The application uses SQL Server as the database provider.

## How to Run

To run this code, ensure you have installed the necessary NuGet packages: `Microsoft.EntityFrameworkCore.SqlServer` and `Microsoft.EntityFrameworkCore.Tools`. Then, you can use Package Manager Console commands like `Add-Migration` and `Update-Database` to manage database migrations.

Ensure that the SQL Server connection settings are correctly configured in the `OnConfiguring` method of the `DbAppContext` class to connect to your SQL Server instance.

The code demonstrates a simple usage of Entity Framework in a .NET Core application to manage a user entity and interact with a SQL Server database.
