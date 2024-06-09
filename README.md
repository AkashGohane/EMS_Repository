Project Overview:

The Employee Management System is a small web application designed to manage employee information within a company. It provides features for user registration, authentication, password recovery, and basic CRUD operations for employee management.

Technologies:

.NET Core MVC
Entity Framework Core (optional)
Bootstrap (for UI design)

Features:

Registration Page:
Allow users to register with their email address and password.
Validate input fields (e.g., email format, password strength).
Store user information securely in a database.

Login Page:
Provide a login form for registered users to sign in.
Authenticate users based on their credentials.
Implement session management to maintain user sessions.

Forgot Password:
Allow users to reset their password if forgotten.
Send a password reset link to the user's email address.
Verify the reset request and update the password accordingly.

Add Employee:
Provide a form to add new employee details (e.g., name, email, department).
Validate input fields and display appropriate error messages.
Save employee information to the database.

List Employee:
Display a list of all employees currently registered in the system.
Include options to view employee details and perform actions (edit, delete).

Delete Employee:
Allow administrators to delete employee records from the system.
Confirm deletion with a prompt to prevent accidental removal.

Modify Employee:
Enable editing of employee details (e.g., name, email, department).
Update the database with the modified employee information.

Weather Information:
Integrate an open-source weather API to display the current weather information of the city where the employee is located. 

Additional Requirements:
Implement proper error handling and validation throughout the application.
Utilize responsive design principles for better usability across different devices.
Use a relational database (e.g., SQL Server, MySQL) to store user and employee data.
Implement proper authentication and authorization mechanisms to ensure security.
Follow the MVC architectural pattern for code organization and separation of concerns.
Provide clear comments for setup, configuration, and usage of the application.
