# Yurt Giriş Sistemi

A Windows desktop application (C# / WinForms) for managing a student dormitory: student records, department assignments, payments, check-in/check-out tracking and basic statistics, backed by a MySQL database.

## Features

- **Student management** — register students and keep their records up to date
- **Department/section management** — organize students by department
- **Payments** — track dormitory payment records
- **Statistics** — summary views over students and payments
- **Admin operations** — separate forms for administrative tasks

## Tech stack

- C# (.NET Framework) with Windows Forms
- MySQL via `MySql.Data` / Entity Framework

## Running

1. Open `yurtdenemeicin.sln` in Visual Studio.
2. Update the MySQL connection string in `App.config` to point at your database.
3. Build and run (F5).

> Educational/portfolio project — built to practice desktop CRUD application development with WinForms and MySQL.
