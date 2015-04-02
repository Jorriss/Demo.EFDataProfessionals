# Demo.EFDataProfessionals
This project are the demos to the Entity Framework for Data Professionals. For more information on the presentation go to http://www.jorriss.net/blog/efdataprofessionals.

Please note: These demos are to show some issues with Entity Framework not best practices in console applications. I'm just sayin'.

##Solutions
There are four solutions in this repo

* AdventureWorksEF - This uses AdventureWorks2012 database. Demonstrates the n + 1 problem and how EF could kill indexes.
* EF Test - This is used to demonstrate what happens when you generate a database from a project with one class that has four properties. 
* Pubs - Uses the Pubs database. Used to demonstrate that you can get implicit conversion issues with Entity Framework.
* StackOverflow - Uses the StackOverflow data dump. Used to show how LIKE performance can be improved by using Full-Text Search.

## Databases
* AdventureWorks2012 - You can grab it at https://msftdbprodsamples.codeplex.com/releases/view/55330. Once you've installed it you probably should run the `AdventureWorks Index.sql` script
* StackOverflow - You have to download the data dump at https://archive.org/details/stackexchange. You can write a tool to import the data yourself or you could use the SODDI tool (StackOverflow Data Dump Importer) Jeremiah Peschka has been maintaing a version of SODDI at https://github.com/peschkaj/soddi. Once installed you can run the `StackOverflow FullText.sql` script which will install a Full-Text index on the StackOverflow database.
