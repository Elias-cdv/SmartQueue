# SmartQueue Manager

A console-based queue management system built in C# to practice core Computer Science concepts — specifically **FIFO data structures** and **Object-Oriented Programming (OOP)**.

---

## About the Project

SmartQueue Manager simulates a real-world client queue system (like a bank or service counter). Users can register clients, attend them in order, and view the current queue — all from an interactive terminal menu.

This project was built as a hands-on exercise to reinforce:

- Object-Oriented Programming with custom classes
- Generic collections (`Queue<T>`) and FIFO behavior
- Input validation and control flow in C#

---

## Features

- Add clients to the queue with a name and motive
- Attend the next client in line (FIFO order)
- View all pending clients in the queue
- Input validation — handles non-numeric and out-of-range inputs gracefully
- Clean exit via menu option

---

## Concepts Practiced

| Concept                | Implementation                                                  |
| ---------------------- | --------------------------------------------------------------- |
| OOP / Classes          | `Client` class with properties and constructor                  |
| Data Structures        | `Queue<Client>` — generic FIFO collection                       |
| Encapsulation          | Public auto-properties with controlled access                   |
| Control Flow           | `while` loop, `switch` statement, `continue`, `return`          |
| Input Validation       | `int.TryParse` to handle invalid user input                     |
| Separation of Concerns | Model (`Client.cs`) separated from program logic (`Program.cs`) |

---

## Project Structure

```
SmartQueueManager/
├── Client.cs           # Client model (Id, Name, Motive)
├── Program.cs          # Main program — menu, queue logic, user interaction
└── SmartQueueManager.csproj
```

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (LTS version recommended)

### Run the project

```bash
git clone https://github.com/your-username/SmartQueueManager.git
cd SmartQueueManager
dotnet run
```

---

## Usage

```
=== SmartQueue Manager ===
1. Add client
2. Attend next client
3. View queue
0. Exit
Select an option:
```

**Example flow:**

1. Select `1` → enter name and motive → client is added to the queue
2. Select `3` → see all pending clients in order
3. Select `2` → first client in line is attended and removed from the queue

---

## What I Learned

Building this project reinforced how `Queue<T>` enforces FIFO behavior at the data structure level — the first client enqueued is always the first to be dequeued, regardless of any other logic. It also highlighted the value of separating class definitions from program logic, making the codebase easier to read and extend.

---

## Built With

- C# / .NET
- Visual Studio Code

---

## Author

Built by Elias Cabeza de Vaca — Software Development student at BYU-Idaho (BYU-Pathway Worldwide).
