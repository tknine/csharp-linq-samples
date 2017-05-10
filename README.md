# C# LINQ Samples

This repository is based on the [LINQ - Sample Queries](https://code.msdn.microsoft.com/LINQ-Sample-Queries-13a42a54?SRC=VSIDE) project on MSDN.

### Changes from original
This version includes the following changes:

* Added **101 Linq Lambda Samples** that mirror the **101 Linq Query Samples**.  These use the extension method syntax for all changed samples. Some of he query based examples were not changed due to them already being in the extension method format where there was not a query based way to extract the desired data. 

* Added **Northwind.sql** script so that the database can be created for the LINQ to SQL examples can be run.  This script can be run in SQL Management Studio against LocalDB, SQL Express, or SQL Server.  The connection string will have to be updated accordingly.

* The connection string is now provided as a user setting on the file menu.


### Todo List
Changes that are yet to be made:

* Add LinqToSql lambda samples.
* Add LinqToXml lambda samples.
* Add ability to export all samples to LinqPad files.