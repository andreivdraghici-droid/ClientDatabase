# ClientDatabase
This project consists of a table view for clients, made in a C# Windows Forms App project reading from an SQL Database, it was worked on with Visual Studio 2022 and Microsoft SQL Server Management Studio 19 (19.0.2). It displays clients, has a search function, which if searched with empty field can read all existing data from the database of clients, or can search any name or characters contained within names, email, addresses or cities of the clients and lastly, it can also add new clients to the database, with a register button.

Initially I wanted to connect it to a SQL Cloud Server or with a remote connection, but because this is new I've left it towards it functioning locally, making it work with a database export ready for use.

There's a few steps to make it work.
For Visual Studio only requires the Data storage and processing package from Visual Studio Installer. With that the project will populate its references from said package.
For SSMS, it comes with an Export of the database made through Data-tier Application export named "clienti-win-forms-db.bacpac". This has to be imported in the local SQL server's databases, first step placing it in the "(User)\Documents\SQL Server Management Studio\DAC Packages" directory, second step in "Specify settings for the new database", making sure that the database name stays "clienti-win-forms-db" and then finish.

When the import is done there's one last thing to make it work which is in Visual Studio. I left the default localhost server name, "localhost\SQLEXPRESS", this should normally work but if this doesn't then it needs a little modification "App.config". At line 7 the Connection String is located (DatabaseConnectionString) and the part to change is at char 72 which should look like this, "Data Source=localhost\SQLEXPRESS;", change the Data Source value with the correct SQL server name or address. The build should work after this.
