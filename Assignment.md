# Databases May 2017
## Practical Teamwork Project

## Assignement

Create a project of your choice and implement it using Code First approach with Entity Framework. You must use SQL Server 2016 as your database. Part of the data in SQL Server must be provided via external files (Excel, XML, JSON, zip, etc.) of your choice. You should use PostgreSQL and SQLite to store some of the data for your application. You should create PDF reports based on your application logic. They should consists of meaningful data. 

 * Project examples:

    - Sports ranking
    - Online store 
    - Movie ranking
    - Book store


## General Requirements

- Use Code First approach
- Use Entity Framework
- Use SQL Server 2016
- At least five tables in the SQL Server database
- Provide all type of relations in the database and use both attributes and the Fluent API (Model builder) for configuration
- Put some of the data of your application in SQLite and PostgreSQL (at least two tables)
- Load some of the data from external files (Excel, XML, JSON, zip, etc.) of your choice
- The user should be able to manipulate the database through the client (basic CRUD. No need to provide roles for the users)
- Provide some usable user interface for the client (could be the console, WPF, Windows Forms, ASP.NET Web application, etc.)
- Generate PDF reports based on your application

![project](http://i.imgur.com/gftm1XJ.png)

## Additional Requirements

*	For the PDF export use a non-commercial third party framework
*	The XML files should be read / written through the standard .NET parsers (of your choice)
*	For JSON serializations use a non-commercial library / framework of your choice

## Optional Requirements (Bonus points)

* Unit test the application (think about how and use the techniques from the previous courses in Telerik Academy and the [Design Patterns course](http://telerikacademy.com/Courses/Courses/Details/431))
* You could use Repository pattern or Services of your choice or use pure Entity Framework and DbContext (research the options and choose your preferable way to do it)
* Completely finished and working project is not a requirement but it will be considered a plus