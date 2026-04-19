# Global Telecom Prefix & Operator Locator

A high-performance C# Desktop application built with .NET and WPF for bi-directional lookup of international telecommunication numbering plans, prefixes, and carrier information.

## 🚀 Overview

This project serves as a desktop-based alternative to tools like `numberplans.com`. It allows users to instantly identify the country, region, and operator type (Mobile/Landline) based on a dialing prefix, or find prefixes associated with specific regions.

---

## 🛠 Tech Stack

* **Language:** C# (.NET Framework 4.6+)
* **UI Framework:** WPF (Windows Presentation Foundation) with XAML
* **Architecture:** MVVM (Model-View-ViewModel)
* **Data Access:** Entity Framework 6 / ADO.NET
* **Database:** Microsoft SQL Server
* **Concurrecy:** Async/Await (Task Parallel Library)

---  

## ✨ Key Features

* **Bi-directional Search:** Search by numeric prefix (e.g., `447`) to find the country/operator, or by string (e.g., `UK Mobile`) to find prefixes.
* **Real-time Filtering:** Optimized "Search-as-you-type" functionality using debouncing logic to minimize database load.
* **High Performance:** Leverages Asynchronous LINQ queries to ensure the UI remains responsive during large data lookups.
* **Data Persistence:** Robust SQL Server backend with Entity Framework for structured numbering plan management.
* **Regex Validation:** Built-in input sanitization to ensure data integrity during search.

---

## 🏗 Architecture

The application follows the **MVVM pattern** to ensure a clean separation of concerns:

1.  **Model:** Represents the `TelecomPlan` entity (Prefix, Country, Region, Type).
2.  **View (XAML):** A modern UI with a data-bound `DataGrid` and stylized search bars.
3.  **ViewModel:** Handles the presentation logic, command binding, and triggers asynchronous data fetching.

---
   ![Architecture](/Assets/Telecom-Prefix-Locator-2.png)

---   

## 📈 Performance Optimizations

* **LINQ Optimization:** Used `.AsNoTracking()` for read-only search queries to reduce memory overhead.
* **Async/Await:** All I/O operations are offloaded from the UI thread to prevent application freezing.
* **Indexing:** SQL database columns `Prefix` and `Country` are indexed for sub-millisecond search results.

---  

## 📝 How to Use

1. Clone the repository (https://github.com/github-saba/Telecom-Prefix-Locator.git)
2. Update the `App.config` connection string to point to your local SQL Server instance.
3. Run the "Initial Migration" to set up the database schema.
4. Launch the application and start typing a prefix in the search bar.

---   
