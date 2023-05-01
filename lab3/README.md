## Lab 3

- Create Server-side Blazor Apps:
 
	- Create a Razor Class Library, it should contain 2 "Non-routable" custom component of your choice
		, use them in your application

	- Implement JSInterop in your application, (Call java function from C#, and visa versa)

	- Implement Identity in your blazor application, Show/Hide application parts based on
		user state  -  Don't allow anonymouse users to access pages via url


 

## Steps
- Convert from webAssembly to serverSide Blazor
	1. Create *Blazor Server App* in visual studio  
	2. Add your *API* and *Shared Libirary* projects
	3. Add your pages

- To implement JSInterop
	1. Add a razor page and your js file
	2. Add the source of js file to the _Host file

- To add custom component
	1. visit https://mudblazor.com/ 
	2. Create *Razor Class libirary* project
	3. Add reference from it to the server blazor project 
	4. Import it and use made components as tags

- To implement Identity
	1. Right click on the blazor project-> add scaffolded item *Identity*
	2. Add-Migration and update datebase
	- When trying to register you must press on *confirm email*
	3. Add authorization and authentication to *navBar* and *app.razor* files	
	4. Add *@attribute [Authorize]* in pages

