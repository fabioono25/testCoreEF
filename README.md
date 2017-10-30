# testCoreEF
Testing EF with .NET Core 2.0

https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/new-db <br>
https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet

<br/>
dotnet new mvc -n "TestCoreEF"<br/>
dotnet run<br/>
dotnet add package Microsoft.EntityFrameworkCore.SqlServer<br/>
dotnet add package Microsoft.EntityFrameworkCore.Tools<br/>
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design<br/>

<br/><br/>

dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet<br/>
dotnet add package Microsoft.EntityFrameworkCore.Design<br/>
dotnet restore<br/>
<br/>


 <ItemGroup>
   <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.0" />
   <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
 </ItemGroup>
 
<br/> 
dotnet ef migrations add InitialCreate: to scaffold a migration to create the initial set of tables for your model. If you receive an error stating 
dotnet ef database update: to apply the new migration to the database. This command creates the database before applying migrations.
<br/>
dotnet aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries 
