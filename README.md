# The Garden Group Project 2022
This repository contains the source code for a NoSQL ticketing application developed for managing service tickets within an organization. The application is designed to streamline the process of handling and resolving device-related issues reported by employees.
**Program made with c# and the program uses mongodb**

## Functions
- Login and registration system: Users can create an account and log in to access personalized features.
- Add an incident (create a ticket)
- View their own tickets
- View a dashboard with the current status of tickets (% open, % resolved, % closed without resolve)
- Searching through incident/service tickets
- Filtering a preloaded list of tickets
- Forget Password functionality
- Escalate/close tickets
- Sorting a ticket list based on priority level
- Transfer a ticket to another person
- Archiving the entire database

## My contributions
In this project I assisted my team members with any problems they had, particularly with issues like the connection to the database and BSON serialization, making it easier for their objects to be sent to the database.
- BaseDAO. A Base DAO used by every DAO to provide a simple and OOP way to reliably connect to the MongoDB collections. It provides all CRUD operations with optional sort definitions for reading operations. An archive operation is also added to add the current state of a collection to an archive database.
- EmployeeDAO. A DAO that inherits from the BaseDAO to provide CRUD operations for the employees.
- EmployeeService. A service layer to connect the EmployeeDAO with the different controllers.
- Employee. BSON serializable model which is used in the MongoDB Employees collection.
- TGG-MongoModel. Base model for objects that are used in the MongoDB collections.
- TGGCollections. An enum used to list the different MongoDB collections.
- TGGEncryption. Used to hash password with salt.
- TGGErrorLogger. Used to log all unexpected errors to errorLogs.txt
- TGGException. Mostly used for expected exceptions which require no logging.
- AddEmployee Form. A WinForm used to easily add an employee by providing all the fields needed for the employee.
- Employees Form. A WinForm to show all the current employees.
