# 🎓 Student and Staff Management System

Welcome to the **Student and Staff Management System**! This console application is designed to manage students 🎒, teachers 👩‍🏫👨‍🏫, and administrative staff 🏢 within a school.  📚✨


## 📋 Table of Contents
- [Introduction](#introduction) 📖
- [How It Works](#how-it-works) ⚙️
- [Code Overview](#code-overview) 🖥️
- [Usage](#usage) 🚀


## 📖 Introduction
In this project, you'll find a simple menu-driven console application that allows users to add 🆕 and display information about students 🎓, teachers 👩‍🏫, and administrative staff 🧑‍💼. Each entity can be managed efficiently through a clear and user-friendly interface. Let's explore the code! ✨🚀

## 💻 How It Works
The application provides a menu where users can choose to:
1. Add a student 🎓
2. Add a teacher 👨‍🏫
3. Add an administrative staff member 🏢
4. Display all users 👀
5. Exit the application ❌

Each choice corresponds to a function that prompts the user for the necessary information. This keeps our program interactive and easy to use! 💡🤖

## 🔍 Code Overview

### Program.cs
The `Program.cs` file is the heart ❤️ of the application, containing the main menu and the logic to handle user inputs.
- Initialization: Initializes lists to store students, teachers, and administrative staff. 📝
- Menu Loop: Continuously displays options until the user decides to exit. 🔄
- Switch Statement: Handles the user's choice and calls appropriate functions to add or display users.
```csharp
namespace Skole_Objekt_programmering_opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize lists to hold our data
            List<Studerende> lstStudents = new List<Studerende>();
            List<Underviser> lstUnderviser = new List<Underviser>();
            List<AdminPersonale> lstadminPersonales = new List<AdminPersonale>();

            // Menu loop
            bool KeepRuning = true;
            while (KeepRuning)
            {
                Console.WriteLine("1: Tilføj Studerende");
                Console.WriteLine("2: Tilføj Underviser");
                Console.WriteLine("3: Tilføj Admin Personale");
                Console.WriteLine("4: Vis alle bruger");
                Console.WriteLine("5: Afslut");
                Console.Write("Pick a Option: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char userInput = keyInfo.KeyChar;

                // Switch statement to handle user choices
                switch (userInput)
                {
                    case '1':
                        // Add a student
                        AddStudent(lstStudents);
                        break;
                    case '2':
                        // Add a teacher
                        AddTeacher(lstUnderviser);
                        break;
                    case '3':
                        // Add administrative staff
                        AddAdmin(lstadminPersonales);
                        break;
                    case '4':
                        // Display all users
                        Person.VisInfoallePersoner(lstStudents, lstUnderviser, lstadminPersonales);
                        break;
                    case '5':
                        Console.WriteLine("Afslutter program");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong input: enter 1,2,3,4,5");
                        break;
                }
            }
        }
    }
}
```
## 🎓 Adding a Student
- Functionality: Prompts for a student's name and validates input. If valid, it adds the student to the list. 🎉
```csharp
private static void AddStudent(List<Studerende> lstStudents)
{
    Console.Write(" Navn: ");
    string Navn = Console.ReadLine();
    // ... Additional code for getting data and adding the student
}

```
## 👩‍🏫 Adding a Teacher
- Functionality: Similar to adding a student but collects data specific to teachers. 📖
 ```csharp
private static void AddTeacher(List<Underviser> lstUnderviser)
{
    Console.Write(" Navn: ");
    string NavnUnderviser = Console.ReadLine();
    // ... Additional code for getting data and adding the teacher
}
```
## 🧑‍💼 Adding Administrative Staff
- Functionality: Gathers details for administrative staff and adds them to the list. 🏢
 ```csharp
private static void AddAdmin(List<AdminPersonale> lstadminPersonales)
{
    Console.Write(" Navn: ");
    string NavnAdminPersonale = Console.ReadLine();
    // ... Additional code for getting data and adding admin staff
}
```
## 🧑‍🎓🗂️ Displaying Information
- Functionality: Loops through the lists and prints details for each user, including their age. 🧑‍🎓🗂️
```csharp
public static void VisInfoallePersoner(List<Studerende> listStudents, List<Underviser> listUnderviser, List<AdminPersonale> listadmin)
{
    foreach (var student in listStudents)
    {
        Console.WriteLine($" Student: Navn: {student.Navn} :Skolenavn: {student.SchoolName}");
        BeregnAlder(student.Fødselsdato, DateTime.Now);
    }
    // ... Additional code to display other types of users
}
```
### Thank you for reading!

I hope you found this project helpful. If you're interested in checking out more of my work, you can find my other projects [here](https://github.com/PlutoGamerpro?tab=stars).

  
