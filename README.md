<div align="center">

# ZENIT

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![WinForms](https://img.shields.io/badge/WinForms-0078D4?style=for-the-badge&logo=windows&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
[![MS Access](https://img.shields.io/badge/MS%20Access-A4373A?style=for-the-badge&logo=microsoftaccess&logoColor=white)](https://www.microsoft.com/en-us/microsoft-365/access)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)](https://visualstudio.microsoft.com/)

*A desktop project management application — combining a Kanban board, a to-do list, and project tracking — built with C#, WinForms, and MS Access, developed as an academic project for PSI class.*

[![Status](https://img.shields.io/badge/Status-In%20Development-orange?style=for-the-badge)]()

🇺🇸 This project is documented and implemented entirely in English.

</div>

---

> [!WARNING]
> **This project is still under active development.**
> Core features are being built and the application is not yet complete. Expect breaking changes and missing functionality as development progresses.

---

> [!NOTE]
> **Academic context:** Zenit was developed as part of the PSI (Programação e Sistemas de Informação) curriculum. It demonstrates desktop application development with C#, WinForms, and a Microsoft Access database backend.

---

## Table of Contents

- [About](#-about)
- [Features](#-features)
- [Tech Stack](#️-tech-stack)
- [Prerequisites](#-prerequisites)
- [Getting Started](#-getting-started)
- [Project Structure](#-project-structure)
- [Roadmap](#-roadmap)
- [Known Limitations](#️-known-limitations)
- [What I Learned](#-what-i-learned)

---

## 🧩 About

Zenit is a Windows desktop project management tool built with C# and WinForms, using Microsoft Access as its local database. The goal is to provide a clean and functional interface for managing projects through a **Kanban board**, tracking individual tasks via a **to-do list**, and keeping everything organised under a unified project view.

The application targets Windows and runs entirely locally — no server, no internet connection required. All data is stored in an `.accdb` MS Access file, keeping setup simple and dependencies minimal for an academic context.

---

## ✨ Features

| Feature                     | Description                                                                                                      | Status         |
|-----------------------------|------------------------------------------------------------------------------------------------------------------|----------------|
| 📋 **Kanban Board**          | Visual drag-and-drop board with columns (e.g. To Do, In Progress, Done) for tracking task flow across projects. | 🔨 In progress |
| ✅ **To-Do List**             | Create, edit, complete, and delete individual tasks with title, description, and due date.                      | 🔨 In progress |
| 📁 **Project Management**    | Create and manage multiple projects, each with its own board and task list.                                     | 🔨 In progress |
| 🗄️ **MS Access Database**    | All data persisted locally in a Microsoft Access `.accdb` file via OleDb connection.                           | 🔨 In progress |
| 🖥️ **WinForms UI**           | Native Windows desktop interface built with WinForms controls for a familiar and lightweight experience.        | 🔨 In progress |

---

## 🛠️ Tech Stack

| Technology         | Role                                            |
|--------------------|-------------------------------------------------|
| C#                 | Core application language                       |
| .NET (WinForms)    | Desktop UI framework                            |
| MS Access (.accdb) | Local relational database                       |
| OleDb              | ADO.NET provider for MS Access connectivity     |
| Visual Studio 2022 | IDE and build toolchain                         |

---

## 📦 Prerequisites

- Windows 10 or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload installed
- Microsoft Access Database Engine (included with Microsoft 365, or install the [free redistributable](https://www.microsoft.com/en-us/download/details.aspx?id=54920))
- .NET 6.0+ (or whichever version is targeted in `Zenit.csproj`)

---

## 🚀 Getting Started

**1. Clone the repository**

```bash
git clone https://github.com/EduhxH/Zenit.git
cd Zenit
```

**2. Open the solution in Visual Studio**

```
Open WinFormsApp4.sln with Visual Studio 2022
```

**3. Restore and build**

In Visual Studio: `Build → Build Solution` (or press `Ctrl+Shift+B`).

**4. Configure the database path**

Ensure the MS Access `.accdb` file path in the connection string matches your local setup. Update it in the relevant data access class if needed.

**5. Run the application**

Press `F5` or click **Start** in Visual Studio.

---

## 📁 Project Structure

```
Zenit/
├── WinFormsApp4/
│   ├── Zenit.csproj            # C# project file
│   ├── Program.cs              # Application entry point
│   ├── Forms/                  # WinForms UI forms
│   ├── Models/                 # Data models / entities
│   ├── Data/                   # MS Access connection and data access layer
│   └── Resources/              # Icons, images, and embedded assets
├── WinFormsApp4.sln            # Visual Studio solution file
└── .gitignore
```

---

## 🗺️ Roadmap

- [ ] Project creation and management
- [ ] Kanban board with columns (To Do / In Progress / Done)
- [ ] Task creation, editing, and deletion
- [ ] To-do list with completion tracking
- [ ] MS Access database integration via OleDb
- [ ] Due dates and priority levels for tasks
- [ ] Basic filtering and sorting of tasks
- [ ] Polish UI and fix known layout issues

---

## ⚠️ Known Limitations

- **Early development** — the application is not feature-complete; many screens and workflows are still being implemented.
- **Windows only** — WinForms is a Windows-exclusive framework; the application will not run on macOS or Linux.
- **Local database only** — MS Access stores data in a single `.accdb` file on disk; there is no cloud sync or multi-user support.
- **MS Access Engine required** — if Microsoft Office is not installed, the free Access Database Engine redistributable must be installed separately for OleDb to work.
- **No automated tests** — the project is in early development and does not yet include a test suite.

---

## 🧠 What I Learned

- **WinForms application architecture** — structuring a C# desktop application across multiple forms, handling events, and keeping UI logic separated from data access.
- **MS Access with OleDb** — connecting to a local `.accdb` database using `OleDbConnection`, executing parameterised queries, and managing a relational data model in Access.
- **Kanban data modelling** — thinking through how to represent projects, boards, columns, and tasks as relational entities in a database schema.
- **Visual Studio solution structure** — working with `.sln` and `.csproj` files, managing project references, and using the Visual Studio designer for WinForms layouts.
- **Desktop UX considerations** — designing a workflow-oriented interface for task management where usability matters as much as functionality.

---

## 🤝 Contributing

Contributions are welcome. If you find a bug or want to propose a feature, open an issue first so we can discuss it before any code is written. When submitting a pull request, keep the scope focused — one fix or feature per PR.

---

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.

---

<div align="center">
  Made with 💜 by <a href="https://github.com/EduhxH">EduhxH</a>
</div>
