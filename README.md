# 🍽️ Restaurant Review System

A multi-language **Restaurant Feedback/Review System** developed for **CS103 – Computer Programming 2**.

This project demonstrates how the same application logic can be implemented across **C++**, **C#**, and **Python**. It is a console-based system that allows users to submit reviews, view feedback, and compute average ratings.

---

## 📌 Introduction

Customer feedback is essential in the restaurant industry. This project simulates a simple review system where users can:

- Submit feedback about a restaurant
- Rate their experience (1–5 scale)
- View all reviews
- See the overall average rating

The goal of this project is to:
- Practice core programming concepts
- Compare implementation across multiple languages
- Build a functional, user-friendly console application

---

## 🚀 Features

- 📝 Add a new review (Name, Feedback, Rating)
- 📋 Display all reviews
- ⭐ Compute average rating
- ⚠️ Input validation for ratings and menu choices
- 💻 Menu-driven interface
- 🔁 Implemented in:
  - C++
  - C#
  - Python

---

## 🛠️ Technologies Used

| Language | Tools / Concepts |
|--------|----------------|
| C++ | iostream, vector, string, limits |
| C# | .NET, List, Classes |
| Python | Classes, Lists, Exception Handling |

---

## 📂 Project Structure

```
restaurant-review-system/
│
├── cpp/
│   └── main.cpp
│
├── csharp/
│   └── Program.cs
│
├── python/
│   └── main.py
│
└── README.md
```

---

# ⚙️ Installation & Deployment Guide

Follow the steps below depending on which language you want to run.

---

## 🧩 Option 1: Run the C++ Version

### ✅ Requirements
- C++ Compiler (MinGW / g++ / Visual Studio)
- Terminal / Command Prompt

### 📥 Steps

```bash
git clone https://github.com/your-username/restaurant-review-system.git
cd restaurant-review-system/cpp
g++ main.cpp -o review_system
./review_system
```

---

## 🧩 Option 2: Run the C# Version

### ✅ Requirements
- .NET SDK installed  
https://dotnet.microsoft.com/download

### 📥 Steps

```bash
git clone https://github.com/your-username/restaurant-review-system.git
cd restaurant-review-system/csharp
dotnet run
```

---

## 🧩 Option 3: Run the Python Version

### ✅ Requirements
- Python 3.x installed

### 📥 Steps

```bash
git clone https://github.com/your-username/restaurant-review-system.git
cd restaurant-review-system/python
python main.py
```

---

# ▶️ How to Use the Program

When you run the program, you will see a menu like this:

```
1. Add Review
2. Display Reviews
3. Exit
```

### 📌 Usage Flow

1. Select **Add Review**
2. Enter:
   - Your Name
   - Your Feedback
   - Rating (1–5 only)
3. Choose **Display Reviews** to view:
   - All submitted reviews
   - Average rating

---

## 🧠 Key Concepts Demonstrated

- Object-Oriented Programming (OOP)
- Data Structures (Lists / Vectors)
- Input Validation
- Functions & Modular Programming
- Cross-language implementation

---

## 📈 Future Improvements

- 💾 Save reviews to a file or database
- 🗑️ Edit/Delete reviews
- 🔍 Search functionality
- 🖥️ GUI version (Windows Forms / Tkinter)
- 🌐 Web-based version

---

## 👤 Author

**Cedrik Julianne M. Ocampo**  
CS103 – Computer Programming 2 Final Project

---

## 📄 License

This project is for educational purposes.
