# Game Project

This is a **full-stack web application** built with **Angular 20** on the frontend and **ASP.NET Core 9 Web API** on the backend, using **SQL Server** with **Code First approach** for the database. The application allows users to manage games with features like create, read, update, and delete (CRUD).

---

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Backend Setup (.NET Core API)](#backend-setup-net-core-api)
  - [Frontend Setup (Angular 20)](#frontend-setup-angular-20)
- [Database](#database)
- [CORS and HTTP Configuration](#cors-and-http-configuration)
- [Running the Project](#running-the-project)
- [Project Structure](#project-structure)
- [License](#license)

---

## Features

- Full CRUD operations for games:
  - Create new games
  - Read game list or details
  - Update existing games
  - Delete games
- Search, filter, and tag management
- Date handling (launch date, added/modified timestamps)
- Responsive UI with **Bootstrap 5**
- Modular Angular 20 structure (feature modules, lazy loading)
- RESTful API architecture

---

## Technologies Used

**Frontend:**
- Angular 20 (module-based architecture)
- Bootstrap 5
- RxJS
- Angular Forms (Reactive Forms)

**Backend:**
- ASP.NET Core 9 Web API
- Entity Framework Core 9 (Code First)
- SQL Server

**Other:**
- Git / GitHub or Bitbucket for version control
- CORS enabled for Angular development

---

## Getting Started

### Prerequisites

- [Node.js](https://nodejs.org/) (v18+ recommended)
- [Angular CLI](https://angular.io/cli)
- [.NET SDK 9](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or SQL Server Express
- Git (for version control)

---

### Backend Setup (.NET Core API)

1. Navigate to the API project folder:

```bash
cd Game.Api
