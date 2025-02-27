# TechJobPortal

## Project Overview
TechJobPortal is an ASP.NET Core MVC application designed to display job listings. It follows the MVC architecture and includes key functionalities like listing jobs, viewing job details, and responsive UI design.

## Features
- **ASP.NET Core MVC Structure**
- **Job Listings Management** (List and View Jobs)
- **Bootstrap Navigation Menu**
- **Responsive Design**
- **Partial Views for Header and Footer**
- **Dropdown for Job Type Selection**
- **Proper Routing Implementation**

## Technologies Used
- ASP.NET Core MVC
- C#
- Bootstrap for UI Styling
- HTML/CSS

## Setup Instructions

### 1. Clone the Repository
```sh
git clone <repository_url>
cd TechJobPortal
```

### 2. Open the Project
- Open `TechJobPortal.sln` in Visual Studio.

### 3. Run the Application
- Press `Ctrl + F5` or run the project from Visual Studio.
- Ensure the application runs without errors.

## Project Structure
```
TechJobPortal/
├── Controllers/
│   ├── JobController.cs
├── Models/
│   ├── JobListing.cs
├── Views/
│   ├── Job/
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _Header.cshtml
│   │   ├── _Footer.cshtml
├── wwwroot/
│   ├── css/
│   ├── js/
└── Startup.cs
```

## Future Enhancements
- Implement a database using Entity Framework Core.
- Add user authentication and job posting functionality.
- Enhance UI/UX with additional styling.

## License
This project is open-source and available under the MIT License.


