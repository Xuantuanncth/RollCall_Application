# FingerPrinter

## Overview

FingerPrinter is a Windows Forms application designed to manage employee attendance and information. The application allows users to register, log in, and manage employee data, including timesheets and personal information. It also supports exporting data to Excel and connecting to a serial device for real-time data collection.

## Features

- **User Registration and Login**: Secure user registration and login with password hashing.
- **Employee Management**: Add, update, and view employee information, including name, department, and avatar.
- **Timesheet Management**: Record and view employee attendance data.
- **Data Export**: Export timesheet data to Excel.
- **Serial Device Connection**: Connect to a serial device to receive real-time attendance data.
- **Dashboard**: View a summary of employee attendance and other key metrics.

## Project Structure

## Getting Started

### Prerequisites

- .NET Framework
- Visual Studio

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/FingerPrinter.git
    ```
2. Open the solution file `FingerPrinter.sln` in Visual Studio.
3. Build the solution to restore the NuGet packages.

### Running the Application

1. Set the startup project to `FingerPrinter`.
2. Press `F5` to run the application.

## Usage

### Registering a New User

1. Open the application.
2. Click on the "Register" link.
3. Fill in the registration form and click "Register".

### Logging In

1. Open the application.
2. Enter your username and password.
3. Click "Login".

### Managing Employees

1. Navigate to the "Information" section.
2. Add new employee information by filling in the form and clicking "Add".

### Viewing Timesheets

1. Navigate to the "Timesheet" section.
2. View and search for employee attendance records.

### Exporting Data

1. Navigate to the "Timesheet" section.
2. Click "Export" to save the timesheet data to an Excel file.

### Connecting to a Serial Device

1. Navigate to the "Setting" section.
2. Select the appropriate port and baud rate.
3. Click "Connect" to establish a connection.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License.

## Acknowledgements

- [EPPlus](https://github.com/EPPlusSoftware/EPPlus) for Excel file handling.
- [SQLite](https://www.sqlite.org/index.html) for database management.
