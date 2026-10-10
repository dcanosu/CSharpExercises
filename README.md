# C# Fundamentals & OOP Exercises (.NET 8)

A robust console application built in C# (.NET 8) containing 15 fundamental programming and Object-Oriented Programming (OOP) exercises. This project demonstrates clean architecture, separation of concerns, polymorphism, and defensive user input validation.

---

## 🚀 Features & Architecture

* **Object-Oriented Design (OOP):** Strictly implements the **Single Responsibility Principle (SRP)**. Each exercise is encapsulated in its own independent class.
* **Polymorphism via Interfaces:** Uses a shared `IExercise` contract, allowing the main menu to execute any exercise dynamically through a unified method (`Execute()`).
* **Dependency Injection (Constructors):** Data is captured and validated in the UI layer (`Program.cs`) and safely injected into the exercise classes through constructors. No hardcoded console inputs inside the business logic.
* **Defensive Programming & Input Validation:** Includes robust helper methods to prevent application crashes caused by invalid data types (letters instead of numbers), empty strings, or division by zero.

---

## 🛠️ Project Structure

```text
CSharpExercises/
│
├── Exercises/               # Isolated classes for each problem
│   ├── PositivePower.cs
│   ├── DoubleOrTriple.cs
│   ├── RootOrSquare.cs
│   ├── CirclePerimeter.cs
│   ├── MidweekDay.cs
│   ├── TaxCalculator.cs
│   ├── RemainderFinder.cs
│   ├── SumOfEvens.cs
│   ├── FractionDifference.cs
│   ├── StringLength.cs
│   ├── AverageOfFour.cs
│   ├── SmallestOfFive.cs
│   ├── VowelCounter.cs
│   ├── FactorialFinder.cs
│   └── InRangeValidator.cs
│
├── Interface/
│   ├── IExercise.cs         # Polymorphic interface contract
├── Program.cs               # Interactive CLI menu & input validation helpers
├── CSharpExercises.csproj   # .NET project configuration
└── Dockerfile & DevContainer # Development container configuration
```

---

## 📋 List of Exercises

1. **Positive Power:** Squares a number only if it is positive.
2. **Double or Triple:** Compares two numbers; returns the double of the first if greater, or triple of the second otherwise.
3. **Root or Square:** Returns the square root if positive, or the square if negative/zero.
4. **Circle Perimeter:** Calculates the perimeter of a circle given its radius.
5. **Midweek Day:** Maps a number (1-5) to a valid work week day.
6. **Tax Calculator:** Calculates a 15% tax on annual salaries exceeding 12,000.
7. **Remainder Finder:** Computes the remainder of a division between two integers (with zero-division protection).
8. **Sum of Evens:** Calculates the sum of all even numbers between 1 and 50.
9. **Fraction Difference:** Computes and simplifies the exact fractional difference between two fractions.
10. **String Length:** Returns the character length of a given word.
11. **Average of Four:** Computes the average of four input numbers.
12. **Smallest of Five:** Finds the minimum value out of five input numbers.
13. **Vowel Counter:** Counts the total number of vowels in a given string.
14. **Factorial Finder:** Computes the factorial of a positive integer.
15. **InRange Validator:** Checks if a number falls inclusively between 10 and 20.

---

## ⚙️ How to Run

### Option 1: Using VS Code Dev Containers (Recommended)
1. Open this repository in **Visual Studio Code**.
2. Make sure you have the **Dev Containers** extension installed.
3. Run the command: `Dev Containers: Rebuild and Reopen in Container`.
4. Once inside the container, open a terminal and run:
   ```bash
   dotnet run
   ```

### Option 2: Local CLI (.NET 8 SDK Required)
1. Open your terminal in the project directory.
2. Run the application:
   ```bash
   dotnet run
