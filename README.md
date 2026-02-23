# 🎓 Student Management System

## 📌 Overview

The **Student Management System** is a role-based desktop application built using **C# (Windows Forms)** and **SQL Server**. The system is designed to manage student records in a structured academic environment with controlled access for different user roles.

This project demonstrates practical implementation of database-driven desktop development, including **CRUD operations**, **role-based access control**, and structured data management.

---

## ✨ Features

- 🔐 Role-based access control (Administrator, Lecturer, Student)
- 👤 Secure login interface
- ➕ Add, ✏️ update, and ❌ delete student records
- 📊 View student information using a structured data grid
- ✅ Input validation and confirmation prompts
- 🗄️ SQL Server database integration
- 🎯 Event-driven Windows Forms architecture

---

## 🏗️ System Architecture

The application follows a layered architecture approach:

- **Presentation Layer**  
  Windows Forms user interface for interaction.

- **Data Access Layer**  
  ADO.NET handles database connectivity.

- **Database Layer**  
  Microsoft SQL Server stores relational data.

The system uses role-based logic to control feature access and maintain data integrity.

---

## 💾 Database Design

The database is structured to store student-related information such as:

- Student identification details  
- Course enrollment information  
- Contact details  

Primary keys and parameterized SQL queries are used to ensure data consistency and security.

---

## 🛠️ Technologies Used

- C#
- .NET Windows Forms
- SQL Server
- ADO.NET
- Visual Studio

---

## 🚀 How to Run the Application

1. Clone the repository:
   ```bash
   git clone <repository-url>
