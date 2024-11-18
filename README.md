Read Me
Overview
This application is a municipal services application meant to promote community engagement and improve service delivery from the government. On the application, the users will be able to perform actions such as report Issues, access information about local events, and track the progress on their service requests.
Prerequisites
Must ensure that the following is installed on your system: 
•	Microsoft Visual Studio Community 2022 
•	.NET Framework 4.8
•	Windows Operating System
How to Clone From GitHub
GitHub Repository: https://github.com/SameerRajie/MunicipalServiceApplication.git
•	Go to the GitHub repository through the link.
•	Click on the “Code” dropdown on the top right of the code section.
•	Choose Open in Visual Studio
Compiling and running the application:
•	If the correct software is installed, the project should be opened in Microsoft Visual Studio, then click clone.
•	On the solution explorer, right-click on the solution and click “Restore NuGet Packages to ensure that any missing dependencies are installed.
•	Using file explorer in your bin -> debug folder, ensure that there is a ‘.mdf’ file present as that represents the database, if not, then it should be copyable from the base project directory.
•	Go to the ‘Build’ section in the menu bar and ‘Build Solution’ to ensure that the project can compile without errors and is ready for your device.
Running the application
For running the application, click start at the top of the screen and a new window will open.
How to Use
•	After the application is running, the Login page will be opened.	
•	For testing purposes, you may log in to a created demo account.
o	Username: User1
o	Password: Password1!
•	If not, then you may create your own account using the link button present beneath the login button, that will redirect you to the sign up page.
•	There you have the fields to input a username and password. After clicking the signup button, the inputs are validated and an account is created if valid.
•	You will once again be prompted to log in and may now enter your login details.
•	The main menu window is then shown.
•	There are three options for the user to choose from.
•	On all pages from this point forward, there is also a collapsable side navigation panel that can be opened by clicking a button on the top left of the screen.
•	The options will include:
o	The Home page
o	The three options that are available on the home page.
o	As well as a button to log out of the application.

•	The report issues page has inputs for adding details.
•	One of the inputs is a button labelled ‘Attach File’
•	All details must be added to the inputs to save the issue.

•	The Events and Announcements page displays data and has three fields to filter the list of events.
•	The announcements are organised from the one that was last published onwards.
•	The Events are sorted from the nearest date to the latest date, and only with days after the current date.
•	There is a search feature to search for specific events. This allows you to search through the events’ titles and/or descriptions.
•	Events can then be filtered further by choosing dates or categories, the list will automatically be updated when a selection is made.
•	Can reset the filters and show the original list by clicking the button labelled reset.
•	Recommendations will be saved for the current session in the application based on the categories that the user filters by the most.

•	The Request Status page provides a comprehensive list of the requests that the user has made to the council.
•	These requests are represented by the Issues that the user has reported. As of now, for testing, the application will be loaded with requests.
•	The list shall not only show the request’s details, but it will also show the status of the request (Pending, In progress, Completed) represented by red, orange and green respectively, it also shows the priority assigned to the request, with the lower the number, representing the higher the priority.
•	The user is able to search the list with a text box present at the top of the page. The search will search through the location, category and description of the requests, displaying only the requests where at least one field meets the criteria.
•	The user can also change the way that the list is sorted via a combo box beneath the search text box. The default sorting is by the requests’ priority with the lowest number first. The other sorting option is by progress, which will arrange the list to show the in-progress requests first, the completed requests last, and the pending requests in between.
 
References
Troelsen, A. & Japikse, P., 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Minneapolis, West Chester: Apress.


