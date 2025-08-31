# Csharp-Library-System

A comprehensive, object-oriented Library Management System written in C#, featuring a graphical user interface (GUI) for controlling a collection of books. This system is designed for educational purposes, small institutions, or as a foundation for more advanced library systems.

---

## Table of Contents

- [Features](#features)
- [System Overview](#system-overview)
- [Architecture and Object-Oriented Design](#architecture-and-object-oriented-design)
- [Modules and Main Classes](#modules-and-main-classes)
- [How the System Works](#how-the-system-works)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Contributing](#contributing)
- [License](#license)

---

## Features

- **Book registration, search, and display**
- **Borrowing and returning books with real-time status updates**
- **Graphical interface with multiple forms for different operations**
- **Centralized data sharing between different windows (forms)**
- **Extensible object-oriented codebase**

---

## System Overview

The Library System is a desktop application built using C# and WinForms. It allows users to:

- Register new books (code, title, author)
- View all registered books
- Borrow books (mark as unavailable)
- Return books (mark as available)
- See book details in a user-friendly interface

All these operations are handled through different forms (windows), which share the same list of books to maintain data consistency.

---

## Architecture and Object-Oriented Design

The system is organized around strong object-oriented principles:

- **Encapsulation:** Book data and logic are encapsulated in the `Livro` (Book) class.
- **Separation of Concerns:** Each form (window) handles a specific operation, such as registration, borrowing, or returning books.
- **Extensibility:** The modular structure makes it easy to add new features or entities (e.g., members, reservations).

---

## Modules and Main Classes

### 1. `Livro` (Book) Class

Located in: `app/app/Class_Livro.cs`

Encapsulates all attributes and operations related to a book.

**Attributes:**
- `CodigoPublico` (public code)
- `_titulo` (title)
- `_autor` (author)
- `_disponivel` (availability)
- `condicao_disponibilidade` (status as string)

**Key Methods:**
- `Emprestar()`: Handles borrowing logic, marks book as unavailable.
- `Devolver()`: Handles return logic, marks book as available.
- `AtualizarStatus(bool disponivel)`: Updates the availability status.
- `MostrarInformacoesListBox()`: Returns a formatted string for display in lists.
- `MostrarInformacoesMessageBox()`: Returns detailed info for pop-up messages.

### 2. User Interface Forms

Each operation is handled by a dedicated form:

- `Tela_Livro_Principal`: Main window, shows list of books and navigation to other operations.
- `Tela_Livro_Cadastro`: Handles book registration.
- `Tela_Livro_Emprestar`: Handles borrowing process.
- `Tela_Livro_Devolver`: Handles returning process.

**Data Sharing:**  
All forms share a single list of `Livro` objects, ensuring changes in one window are reflected across the application.

---

## How the System Works

### 1. Application Startup

- The entry point (`Program.cs`) launches `Tela_Livro_Principal`, the main window.

### 2. Book Registration

- In `Tela_Livro_Cadastro`, users input the book's code, title, and author.
- On confirmation, a new `Livro` object is created and added to the shared list.
- The main list in `Tela_Livro_Principal` is updated to reflect the addition.

### 3. Borrowing Books

- In `Tela_Livro_Emprestar`, users can search for available books.
- Selecting a book and confirming the action sets its `_disponivel` flag to `false` via the `Emprestar()` method.
- The status is updated throughout the system.

### 4. Returning Books

- In `Tela_Livro_Devolver`, users select a borrowed book to return.
- The `Devolver()` method sets the book as available again.

### 5. Data Consistency

- The list of books is passed by reference between forms, so all data changes are immediately visible across the application.
- UI elements like listboxes and message boxes display up-to-date information using the formatting methods in `Livro`.

---

## Project Structure

```
Csharp-Library-System/
└── app/
    └── app/
        ├── Class_Livro.cs              # Book class (core logic and data)
        ├── Tela_Livro_Principal.cs     # Main window
        ├── Tela_Livro_Cadastro.cs      # Book registration window
        ├── Tela_Livro_Emprestar.cs     # Borrowing window
        ├── Tela_Livro_Devolver.cs      # Returning window
        ├── Program.cs                  # Application entry point
        └── ... (other WinForms files and resources)
```

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) 6.0 or later
- Windows OS (required for WinForms)

### Build and Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/L1K3D/Csharp-Library-System.git
   cd Csharp-Library-System/app/app
   ```

2. **Build the project:**
   ```bash
   dotnet build
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

---

## Contributing

- Fork this repository and create a new branch for your feature or bugfix.
- Submit pull requests with clear descriptions and screenshots if UI changes are involved.
- Issues and suggestions are welcome!

---

## License

This project is provided for educational purposes and is open-source. Please see `LICENSE` for details if available.

---

## Acknowledgements

- Inspired by classic library management system projects.
- Developed as part of academic coursework at Faculdade Engenheiro Salvador Arena.

---

*Feel free to extend this system with new features such as user management, overdue tracking, or a more advanced database backend!*
