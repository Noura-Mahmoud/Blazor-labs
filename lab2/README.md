## Task 1

## Requirements

- Countinue on yesterday assignment of your WebAssembly Blazor App, which manages Trainees and thier Tracks:
	- Apply DataAnnotations on your classes
	- Create Asp.Net Core API that will have and manage TraineeDB
	- Implement All CRUD operations over this API
	- Consume this API in your WebAssembly Blazor App "using HttpClientFactory",
	and render application UI using data comes from API database
	- Use validation and visulaize errors

- Track shoud have the following properties:
    - ID
    - Name
    - Description

- Trainee shoud have the following properties:
    - ID
    - Name
    - Gender
    - email
    - MobileNo
    - Birthdate
    - IsGraduated


## Steps
1. Strat *Blazor assembly webApp* in visual studio
2. Add *ClassLibirary* project and add needed classes
3. Add project reference of class libirary in the blazor project 
4. Add needed razor pages 
5. Create new *ASP.NET core web API* project
6. Add the class library project as a reference project to API project too
7. Add your context class, and install required packages from Nuget Package manager. 
    - Register the DbCintext Service
    - Then add migrations
8. Allow Cors
9. Add needed API controllers
10. Add services folder in blazor project, then add the interfaces and calsses
    - Install *Microsoft.Extensions.Http* package
    - Register the *HttpClient* services in the program.cs file of Client folder in blazor project

11. Edit the blazor pages to get the data from sevices instead of static data

