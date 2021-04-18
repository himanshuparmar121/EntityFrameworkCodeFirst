# EntityFrameworkCodeFirst

1). dotnet new webApp -o EntityFrameworkCodeFirst: 
This command will create a webApp with name EntityFrameworkCodeFirst.

2). Added Nuget packages:
i) Microsoft.EntityFrameworkCore.Tools
ii) Microsoft.EntityFrameworkCore.SqlServer

3). Added Connection String in appsettings.json

4). dotnet ef migrations add EFCodeFirst: 
This will create migration script based on the models used in the WebApp i.e, database name used in connection string.
The advantage of using this is that it will create a new database by default even if that is not present in Sql Server.

5). dotnet ef database update
    Database can be updated i.e created by this command.

6). Added validation for Employee and Address then udated migration script and database.
