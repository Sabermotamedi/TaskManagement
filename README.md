#  Real-Time Task Management Application with SignalR

This application was developed during the interview process for the United Young Generation Company
## Technologies

* [ASP.NET Core 7](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
* [Entity Framework Core 7](https://docs.microsoft.com/en-us/ef/core/)
* [Angular 15](https://angular.io/)
* [MediatR](https://github.com/jbogard/MediatR)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://fluentvalidation.net/)
* [XUnit](https://xunit.net/), [FluentAssertions](https://fluentassertions.com/)
  
## Getting Started

1. Install the latest [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
2. Install the Angular: 15.1.6 [Angular](https://angular.io/)
3. Install the Node: 18.14.1 [Node.js](https://nodejs.org/en/)

4. Run `dotnet build ` to build the backend side.
5. Run `npm i build ` to build the front-end side.
6. Run `dotnet run ` to run the backend side. 
7. Ensure the base URL address from the backend side and set it to the enviroment.ts > baseApiUrl variable.
8. Run `npm start` to run the front-end side.
9. Open a browser and go to the localhost:4200.

### Database Configuration

The template is configured to use an in-memory database by default. This ensures that all users will be able to run the solution without needing to set up additional infrastructure (e.g. SQL Server).

If you would like to use SQL Server, you will need to update **WebUI/appsettings.json** as follows:

```json
  "UseInMemoryDatabase": false,
```

Verify that the **DefaultConnection** connection string within **appsettings.json** points to a valid SQL Server instance. 

When you run the application the database will be automatically created (if necessary) and the latest migrations will be applied.


## Overview
