# ManagementSystem

## Description
This project consists of a desktop application for a book store, helping the owners with sales registration, stock tracking, client management, and generating useful reports.

## Features
- **User Authentication:** Sign Up and Sign In functionality.
- **Sales Management:** Register and manage book sales.
- **Stock Management:** Track and update book inventory.
- **Client Management:** Manage client information.
- **Reporting:** Generate various reports.

## Technologies
- **Programming Language:** C#
- **Framework:** .NET
- **Database:** MySQL

### NuGet Packages used
- **BCrypt.Net:** For password hashing.
- **ClosedXML:** For generating Excel reports.
- **MySql.Data:** For MySQL database connectivity.

## Getting Started

### Prerequisites
- **Programming Language:** C#
- **Framework:** .NET
- **Database:** MySQL

### Installation

1. **Clone the repository:**
    ```bash
    git clone https://github.com/VitorVieira20/Management-System-Desktop-App.git
    ```

2. **Install NuGet Packages:**
    - BCrypt.Net
    - ClosedXML
    - MySql.Data

3. **Add Configuration File:**
    - In the root of the `ManagementSystem` project, create a `Configuration.cs` file to configure variables used throughout the project. Currently, you only need to set up the `ConnectionString` to connect your project to your MySQL database.

    ```csharp
    public static class Configuration
    {
        public static string ConnectionString { get; } = "Server=localhost;Database=YOUR_DATABASE;User ID=YOUR_USER;Password=YOUR_PASSWORD;";
    }
    ```

4. **Create Database Tables:**
    - Use the following SQL scripts to create the necessary tables in your MySQL database:

    ```sql
    CREATE TABLE books (
        id INT AUTO_INCREMENT PRIMARY KEY,
        title VARCHAR(255),
        author VARCHAR(255),
        genre VARCHAR(100),
        publish_date DATE,
        price DECIMAL(10, 2),
        description MEDIUMTEXT
    );

    CREATE TABLE clients (
        id INT AUTO_INCREMENT PRIMARY KEY,
        name VARCHAR(45),
        email VARCHAR(45),
        nif VARCHAR(45),
        phone VARCHAR(45),
        address VARCHAR(150),
        creation_date DATE
    );

    CREATE TABLE sales (
        id INT AUTO_INCREMENT PRIMARY KEY,
        date DATE,
        client_id INT,
        total_amount DECIMAL(10, 2)
    );

    CREATE TABLE sales_items (
        id INT AUTO_INCREMENT PRIMARY KEY,
        sales_id INT,
        book_id INT,
        quantity INT
    );

    CREATE TABLE stock (
        id INT AUTO_INCREMENT PRIMARY KEY,
        book_id INT,
        quantity INT,
        last_updated TIMESTAMP
    );

    CREATE TABLE users (
        id INT AUTO_INCREMENT PRIMARY KEY,
        username VARCHAR(45),
        password VARCHAR(100)
    );
    ```

### Running the Application
1. Open the solution in your preferred IDE (e.g., Visual Studio).
2. Build the solution to restore the NuGet packages.
3. Run the application.

### Usage
- **Sign Up and Sign In:** Create a new user or log in with existing credentials.
- **Manage Sales:** Add, edit, or delete sales records.
- **Track Stock:** Monitor and update book inventory levels.
- **Client Management:** Add, edit, or delete client records.
- **Generate Reports:** Create and export reports in Excel format.

### Troubleshooting
- Ensure that your MySQL server is running and accessible.
- Verify that the `ConnectionString` in the `Configuration.cs` file is correct.
- Check for any missing NuGet packages and restore them if necessary.

### License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for more details.