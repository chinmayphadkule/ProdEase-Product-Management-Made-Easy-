# ProdEase – (Product Management Made Easy)

This is a simple Windows Forms application built using C# and .NET that allows users to manage products stored in a SQL Server database. It provides functionality to add, update, delete, and search for products.

## Features
- Load product data from SQL Server
- Display products in a DataGridView
- Search for a product by ID
- Add a new product
- Update an existing product
- Delete a product
- Save changes to the database

## Technologies Used
- C#
- Windows Forms
- SQL Server
- ADO.NET

## Screenshot
![Product](https://github.com/user-attachments/assets/f9faf62b-99bc-4dbf-8f16-d2ddc98b147f)


## Setup and Installation
### Prerequisites
- .NET Framework or .NET Core installed
- SQL Server with a database named `armstrong`
- Visual Studio (recommended for development)

### Database Setup
1. Create a database named `armstrong` in SQL Server.
2. Create a table using the following SQL command:

```sql
CREATE TABLE Product (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100),
    Price DECIMAL(10,2),
    Descrption VARCHAR(100),
);
```

### Running the Project
1. Clone the repository:
   ```sh
   git clone https://github.com/chinmayphadkule/ProdEase-Product-Management-Made-Easy-.git
   ```
2. Open the project in Visual Studio.
3. Update the connection string in `Form1.cs` if necessary.
4. Run the project and start managing products!

## Usage
1. Click "Load Data" to retrieve product details.
2. Use the search box to find a product by ID.
3. Add a new product using the provided text fields.
4. Update an existing product after retrieving details.
5. Delete a product by entering its ID.
6. Click "Save Changes" to update the database.

## Contributing
Feel free to fork the repository and submit pull requests with improvements or bug fixes.

