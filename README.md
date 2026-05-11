## 🎯 Project Title

**Ride & Register** - A Windows Forms Desktop Application for TODA Management

---
## Project Description and Purpose

Ride&Register is a C# Windows Form Application  designed to manage Tricycle Operators and Drivers' Association (TODA) systems. It streamlined the operation of a TODA system when it comes to member profiling, and managing tricycles, franchises and routes. It incorporates features such as member’s membership and tracking, vehicle registration, and route assignment. The proposed project will be beneficial to real life TODA of tricycle drivers. This addresses the problem of the lack of management and access of TODAs on their organization operations. Through CRUD functionality, the administrator can oversee TODA processes and systems, including faster retrieval and modification of member information, monitoring active or expired memberships, checking tricycle availability for driver linking, and reviewing routes lacking assigned tricycles for transportation efficiency. The proposed system helps in ensuring a comprehensive and cohesive management on tricycle association through a windows form application. 

---
## UML Diagram

![image_alt](https://github.com/heyjhude-0/Ride-Register-WindowsForm-App/blob/43ea36c654b5071c9469ae08d0b9d924e8bf4948/Ride%26Register-UML.drawio.png)

## ✨ Features and Functionalities

### 1. **User Authentication & Authorization**
- ✅ Secure login system with username and password
- ✅ Role-based access control (Admin / Member)
- ✅ Session management using SessionManager
- ✅ Automatic dashboard routing based on user role

### 2. **Member Management**
- ✅ Add new members (Owners, Drivers, Operators)
- ✅ View all members with detailed information
- ✅ Update member information (Name, Contact, Address)
- ✅ Delete member records
- ✅ Membership renewal functionality
- ✅ Track membership status (Active/Expired)
- ✅ Account status tracking (Has Account/No Account)

### 3. **Tricycle Management**
- ✅ Add tricycles with plate number and model
- ✅ Assign tricycles to owners, drivers, and routes
- ✅ View all tricycles with owner and driver information
- ✅ Update tricycle details
- ✅ Delete tricycle records
- ✅ **Search by plate number** - Real-time search functionality
- ✅ **Filter by owner** - Filter tricycles by vehicle owner
- ✅ **Filter by driver** - Filter tricycles by assigned driver
- ✅ **Filter by route** - Filter tricycles by assigned route
- ✅ Combined filtering - Multiple filters work simultaneously

### 4. **Route Management**
- ✅ Create new routes with start/end points and fare
- ✅ View all routes with tricycle count
- ✅ Update route information
- ✅ Delete routes
- ✅ Track tricycle assignments per route

### 5. **Dashboard & Reporting**
- ✅ Admin dashboard with key metrics
- ✅ Total members count
- ✅ Total tricycles count
- ✅ Total routes count
- ✅ Quick navigation to all modules

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
   - Update member details (Name, Birthdate, Address, Role)
   - Keep track on membership status (active/expired)
   - Search and filter member records using the DataGridView

  All member information is in the database tables Members and Memberships.

  **2. Tricycle Management**

  The admin can use this module to:
   - Record the information about the tricycle (model, plate number).
   - Attach a tricycle to a particular member/driver
   - Display list of all Registered tricycles in a DataGridView

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
  - Memberships
  - Tricycles
  - Routes
  - Users

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


## 🛠️ Technology Stack

### **Frontend**
- **Windows Forms (WinForms)** - Desktop UI framework
- **Guna.UI2** (v2.0.4.7) - Modern UI control library for enhanced UI/UX
- **C# 7.3+** - Programming language

### **Backend**
- **C#** - Business logic implementation
- **.NET Framework 4.7.2** - Runtime environment

### **Database**
- **SQL Server** (Express 2019 or later) - Relational database
- **SQL Server Management Studio (SSMS)** - Database management tool

### **Development Tools**
- **Visual Studio Community 2022** - IDE
- **Git** - Version control
- **NuGet** - Package manager

### **Libraries & Dependencies**
- **Guna.UI2.WinForms** - Modern UI controls
- **System.Data.SqlClient** - SQL Server connectivity
- **System.Windows.Forms** - WinForms framework
- 
## **Team Members**

| Name | Role | Responsibilities |
|------|------|------------------|
| Dagle, Jhude Dominic | Lead Developer | Project architecture, authentication, core features |
| Hernandez, Nhealeen Fae | Frontend Developer | UI Design, navigations |
| Tarcelo, Mark Nino | Developer |  |


**Happy Coding! 🚀**
