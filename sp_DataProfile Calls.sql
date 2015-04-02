
-- Generated Database
EXEC sp_dataprofile 'People', 0, @DatabaseName = 'EFTest.EFTestContext', @ShowIndexes = 1

-- Sales
sp_dataprofile 'Sales.Store', @DatabaseName = 'Adventureworks2012', @ShowIndexes = 1

-- Implicit Conversion
sp_dataprofile 'Titles', 0, @DatabaseName = 'Pubs'

