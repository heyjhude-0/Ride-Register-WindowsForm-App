# Ride&Register 
---

## Project Description and Purpose

Ride&Register is a C# Windows Form Application  designed to manage Tricycle Operators and Drivers' Association (TODA) systems. It streamlined the operation of a TODA system when it comes to member profiling, and managing tricycles, franchises and routes. It incorporates features such as member’s membership and tracking, vehicle registration, and route assignment. The proposed project will be beneficial to real life TODA of tricycle drivers. This addresses the problem of the lack of management and access of TODAs on their organization operations. Through CRUD functionality, the administrator can oversee TODA processes and systems, including faster retrieval and modification of member information, monitoring active or expired memberships, checking tricycle availability for driver linking, and reviewing routes lacking assigned tricycles for transportation efficiency. The proposed system helps in ensuring a comprehensive and cohesive management on tricycle association through a windows form application. 

---

## UML Diagram



---

## Features and Functionalities of the System

List the main features of your system.
| **Feature** | **Description** |
| ----------- | ----------- |
| Login Functionality | Securing access through a login authentication, ensuring only the admin can access TODA information, protecting member data. |
| Dashboard Overview | An overview of the TODA system including total number of members, registered tricycles, and memberships supervision. |
| Member Management | Register new members, update member information, track membership status |
| Tricycle Management | Add tricycle information, link tricycle to available specific members |
| Route Management | Define route start point and end point, link route to tricycle |

---

## Explanation of how the program works

Ride&Register is a C# Windows Forms application for a Tricycle Operators and Drivers' Association (TODA) that manages the operation of a TODA. Member profiling, registration of tricycles and route assignment are all consolidated on a single organized desktop application for the TODA administrator.

System login is secured with a Login Form as the starting point to the application. Only the admin can login with valid logins in the database. Once logged in, user is forwarded to the Main Dashboard.

The Dashboard offers a snapshot of the TODA system which includes:
  - The total count of members that have registered.The total number of registered members.
  - Total registered tricycles
  - Membership monitoring

  The admin can click on any of the following tabs or buttons to get to the three main modules from the dashboard:

  **1. Member Management**

  This module lets the admin:
  - Recruit new TODA members
  - Update member details (Name, Age, Gender, Birthdate, Role)
  - Keep track on membership status (active/expired)
  - Search and filter member records using the DataGrid View

  All member information is in the database tables Members and Memberships.

  **2. Tricycle Management**

  The admin can use this module to:
  - Record the information about the tricycle (model, plate number).
  - Attach a tricycle to a particular member/driver
  - Display list of all Registered tricycles in a DataGrid View

  This will ensure each tricycle has an owner/driver assigned.

  **3. Route Management**

  With this module, the admin can:
  - Identify starting and end points for routes
  - Use tricycles for routes
  - View the assignment and availability of routes

  This assists the TODA to track what routes are given a tricycle and which ones are still being driven.

---

## Instructions on how to run the application

**Step 1 – Set Up the Database**
- Start SQL Server Management Studio.
- You need to make a new database (such as RideRegisterDB).
- Run the provided SQL script from the project repository to create the tables:
  - Members
  - Tricycles
  - Routes
  - Admin/Login table

**Step 2 – Open the Project**
- Create a new project.
- Start Microsoft Visual Studio.
- Select “Open a project or solution.”
- Click on the Ride&Register project folder or .slnx file.

**Step 3 – Run the Program**
- Press Start or F5 in the Visual Studio.
- The Login Form will be displayed.
- Type in the admin username and password found in the database.
- Once you have successfully logged in, the Dashboard will appear.

**Step 4 - Test the Functionalities**
You can now test:
- Adding and editing members.
- Registration of tricycles and connecting to members
- Making routes and assigning tricycles
- Viewing records in DataGridViews with search and filter

---

## Names of the developers or team members
- Dagle, Jhude Dominic
- Hernandez, Nhealeen Fae D.

---
