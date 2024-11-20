# Project => SIMS (Incident Management System)

0. ## Table of Contents

1. [Overview](#overview)
2. [Features](#features)
3. [System Requirements](#system-requirements)
4. [Installation](#installation)
5. [Usage](#usage)
6. [Roadmap](#roadmap)
7. [Contributors](#contributors)
8. [License](#license)
9. [ER Diagram](#er-diagram)
10. [Class Diagram](#class-diagram)
11. [Project Structure](#project-structure)
12. [Git Repository](#git-repository)

-----------------------------------------------------------------------------------------------------------------------------------------
1. ## Overview

**SIMS (Simple Incident Management System)** is a web-based application designed for managing incidents. Users can create, search, and manage incidents, including adding specific details like date, title, description, and type of incident. Admins can also close incidents to indicate their resolution. The application aims to provide a streamlined and efficient way of tracking and managing incidents.

The project utilizes **Blazor** for the front-end UI and **ASP.NET** for the backend, with a REST API handling requests and responses. Entity Framework (EF) is used for mapping data between the system and the **Docker**-hosted database.

2. ## Features

- **Incident Creation**: Users can create new incidents by specifying details such as date, title, description, and type of incident.
- **Incident Search**: Search for incidents by different incident types, allowing for easy filtering and management.
- **Incident Clousing**: Admins have the ability to mark incidents as closed, ensuring that resolved issues are properly tracked.
- **User Roles and Login**: The system features role-based access where admins can close incidents, while supporters can create and search for incidents.

### Additional Functionality

- **Logging and Error Handling**: Errors are logged to help identify and resolve issues efficiently.
- **User Interface**: The web UI is created using Blazor, providing a modern and interactive experience for managing incidents.

3. ## System Requirements

- **Operating System**: Windows 10, Linux, macOS
- **.NET Runtime**: Version 8.0 or higher  (dotnet --version)
- **Docker**: Docker Desktop for initializing the Docker Compose files
- **RAM**: Minimum 4 GB
- **Storage**: Minimum 2 GB free disk space

4. ## Installation

4.1. ## Clone the repository:
   ```bash
   git clone https://github.com/is231316/sims
   ```
2. Install the required dependencies: 
   ```bash
   dotnet restore
   ```
3. Build the project:
   ```bash
   dotnet build
   ```
4. Start Docker: Make sure Docker Desktop is running, and initialize the Docker Compose files as needed. 

5. Create the database and run the first migration:
   ```bash
   dotnet ef database update
   ```

5. ## Usage

Run the application with the following command:

```bash
dotnet run
```

After launching, navigate to the main menu where you can access all features such as creating, searching, and managing incidents.

6. ## Roadmap

- **v1.0**: Initial release with core features:
  - Creating a Blazor UI
  - Creating the REST API with ASP.NET
  - Testing DB connection
  - Testing data persistence
  - Whole testing of the application
  - Adding roles and login feature
  - Adding search functionality

7. ## Contributors

- **is231316**: [GitHub Profile](https://github.com/is231316)
- **Eisenbahno**: Assisted with architecture and tech stack.

8. ## License

This project is licensed under the MIT License. See the LICENSE file for more details.
-------------------- wo ist dieses licence file und wie heist es?

9. ## ER Diagram

**Incident**
| Field           | Description            |
|-----------------|------------------------|
| Id              | Primary Key            |
| incident_date   | Date of Incident       |
| title           | Incident Title         |
| description     | Incident Description   |
| incident_type   | Type of Incident       |
| is_closed       | Incident Status        |
| created_at      | Creation Timestamp     |
| updated_at      | Last Updated Timestamp |

**Redis**
| Key     | Value    |
|---------|----------|
| monika  | password |
| role    | admin    |



10. ## Class Diagram

The following diagram shows the classes and their relationships:
Class-Diagram.png in the same directory


11. ## Project Structure (for Incident Management Application)

# Main Project Directory
project_name/
├── GitHub Actions/            # (Optional) CI/CD configuration files
├── Projektmappenelemente/     # Project elements (e.g., Visual Studio project files)
├── Shared/                    # Shared components used across projects
│   ├── Controllers/           # Controllers for handling requests
│   │   └── IncidentsController.cs
│   ├── DbContextFolder/       # Database context for Entity Framework
│   │   ├── IncidentDbContext.cs
│   ├── Migrations/            # Migrations for database versioning
│   │   ├── 20241115204557_InitialCreate.cs
│   ├── Model/                 # Data models used in the system
│   │   └── Incident.cs
│   ├── UserUtils/             # User utilities (e.g., password management)
│   │   └── PasswordManagement.cs
│   ├── appsettings.json       # Application settings
│   ├── docker-compose.yml     # Docker compose configuration
│   ├── Program.cs             # Main entry point for the shared components
│   └── Shared.http            # HTTP client requests (optional)

# Blazor Front-End
SimsUI/
├── wwwroot/                   # Static files for Blazor (CSS, JS, images)
├── Components/                # Blazor components for UI structure
│   ├── Layout/
│   │   ├── MainLayout.razor   # Main layout for the application
│   │   ├── NavMenu.razor      # Navigation menu component
├── Pages/                     # Blazor pages for individual UI views
│   ├── Error.razor            # Error handling page
│   ├── Home.razor             # Homepage
│   ├── Incident.razor         # Incident management page
│   ├── Search.razor           # Search functionality page
│   ├── _Imports.razor         # Common imports for all pages
│   ├── App.razor              # Main application component
│   ├── Routes.razor           # Application routing configuration
├── appsettings.json           # Application settings for the front-end
├── Program.cs                 # Main entry point for the Blazor application

12. ## Git Repository

Find the complete source code on GitHub: [Git Repository](https://github.com/is231316/sims)

git init - Initializes a new Git repository.
git clone [URL] - Clones a repository from a remote server to your local machine.
git add [file] - Adds changes in a file to the staging area (or use git add . to add all changes).
git commit -m "message" - Commits the staged changes to the repository with a descriptive commit message.
git status - Shows the status of changes in the working directory and staging area.
git branch - Lists, creates, or deletes branches.
git merge [branch-name] - Merges changes from a specified branch into the current branch.
git pull - Fetches changes from a remote repository and merges them into your local branch.
git push - Pushes committed changes from your local repository to a remote repository.

