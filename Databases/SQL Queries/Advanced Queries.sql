-- Write a SQL query to find the names and salaries
-- of the employees that take the minimal salary
-- in the company. Use a nested SELECT statement.

SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary = 
	(SELECT MAX(Salary) FROM Employees)

--Write a SQL query to find the names and salaries
--of the employees that have a salary that is up
--to 10% higher than the minimal salary for the company.

SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE e.Salary <= (SELECT MIN(Salary) FROM Employees) * 1.1
ORDER BY e.Salary

-- Write a SQL query to find the full name, salary and
-- department of the employees that take the minimal salary
-- in their department. Use a nested SELECT statement.

SELECT e.FirstName + ' ' + e.LastName AS FullName, e.Salary, d.Name
FROM Employees e INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = (SELECT MIN(Salary) FROM Employees)

-- Write a SQL query to find the average salary in
-- the department #1.

SELECT AVG(Salary) [Average Salary]
FROM Employees e
WHERE e.DepartmentID = 1

-- Write a SQL query to find the average salary
-- in the "Sales" department.

SELECT Avg(Salary) [Average Salary]
FROM Employees e INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- Write a SQL query to find the number of
-- employees in the "Sales" department.

SELECT COUNT(*)
FROM Employees e INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- Write a SQL query to find the number of all
-- employees that have manager.

SELECT COUNT(*)
FROM Employees e
WHERE ManagerID IS NOT NULL

-- Write a SQL query to find the number of all
-- employees that have no manager.

SELECT COUNT(*)
FROM Employees e
WHERE ManagerID IS NULL

-- Write a SQL query to find all departments and
-- the average salary for each of them.

SELECT e.DepartmentID, AVG(Salary) AS [Average Salary]
FROM Employees e
GROUP BY DepartmentID

-- Write a SQL query to find the count of all
-- employees in each department and for each town.

SELECT e.DepartmentID, t.TownID, Count(*) AS [Number of employees]
FROM Employees e JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON a.TownID = t.TownID
GROUP BY e.DepartmentID, t.TownID
ORDER BY e.DepartmentID

-- Write a SQL query to find all managers that have
-- exactly 5 employees. Display their first name
-- and last name.

SELECT m.FirstName, m.LastName
FROM Employees m
WHERE
(
	SELECT COUNT(*)
	FROM Employees e
	WHERE e.ManagerID = m.EmployeeID
) = 5

-- Write a SQL query to find all employees along
-- with their managers. For employees that do not
-- have manager display the value "(no manager)".

SELECT e.FirstName, e.LastName, ISNULL(m.FirstName + ' ' + m.LastName, '(no manager)') AS ManagerFullName
FROM Employees e LEFT JOIN Employees m
ON e.ManagerID = m.EmployeeID

-- Write a SQL query to find the names of all
-- employees whose last name is exactly 5 characters
-- long. Use the built-in LEN(str) function.

SELECT FirstName, LastName
FROM Employees e
WHERE 5 = LEN(LastName)

-- Write a SQL query to display the current
-- date and time in the following format
-- "day.month.year hour:minutes:seconds:milliseconds".
-- Search in  Google to find how to format dates in
-- SQL Server.

SELECT CONVERT(varchar, GETDATE(), 113)

-- Write a SQL statement to create a table Users.
--Users should have username, password, full name
--and last login time. Choose appropriate data types
--for the table fields. Define a primary key column
--with a primary key constraint. Define the primary
--key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames.
--Define a check constraint to ensure the password is
--at least 5 characters long.

CREATE TABLE Users (
	UsersID int IDENTITY,
	Username nvarchar(50) NOT NULL,
	[Password] nvarchar(20) NOT NULL CHECK(LEN([Password]) >= 5),
	FullName nvarchar(100) NOT NULL,
	LastLoginTime datetime,
	CONSTRAINT PK_Users PRIMARY KEY(UsersID)
)

-- Write a SQL statement to create a view that displays
-- the users from the Users table that have been in the
-- system today. Test if the view works correctly.

CREATE VIEW DisplayUsersFromToday AS
SELECT u.FullName, u.LastLoginTime
FROM Users u
WHERE CONVERT(VARCHAR(10),u.LastLoginTime,110) = CONVERT(VARCHAR(10),GETDATE(),110)

-- Write a SQL statement to create a table Groups.
-- Groups should have unique name (use unique constraint).
-- Define primary key and identity column.

CREATE TABLE Groups (
	GroupID int IDENTITY PRIMARY KEY,
	Name nvarchar(50) NOT NULL UNIQUE
)

-- Write a SQL statement to add a column GroupID
-- to the table Users. Fill some data in this new
-- column and as well in the Groups table. Write a
-- SQL statement to add a foreign key constraint
-- between tables Users and Groups tables.

ALTER TABLE Users
ADD GroupID int
CONSTRAINT FK_Users_Groups FOREIGN KEY(GroupID)
	REFERENCES Groups(GroupID)

-- Write SQL statements to insert several records
-- in the Users and Groups tables.

INSERT INTO Groups
Values('Dudes'),
	('Haters'),
	('Buddies')

INSERT INTO Users
VALUES('Pesho', '12345', 'Pesho Peshov', DEFAULT, 5),
	('Misho', '12345', 'Misho Mishov', DEFAULT, 6),
	('Gosho', '12345', 'Gosho Goshov', DEFAULT, 7),
	('Paul', '12345', 'Paul Paul', DEFAULT, 5),
	('Bob', '12345', 'Bob Bob', DEFAULT, 6)
	
 --Write SQL statements to delete some of the records
 --from the Users and Groups tables.

DELETE FROM Users
WHERE Username = 'Paul' OR Username = 'Bob'

-- Write SQL statements to insert in the Users table the
-- names of all employees from the Employees table.
-- Combine the first and last names as a full name.
-- For username use the first letter of the first name + the last name
-- (in lowercase). Use the same for the password, and NULL
-- for last login time.

INSERT INTO Users(Username, [Password], FullName, LastLoginTime, GroupID)
SELECT SUBSTRING(FirstName, 1, 1) + SUBSTRING(LastName, 1, 1) AS UserName,
		SUBSTRING(FirstName, 1, 1) + SUBSTRING(LastName, 1, 1) + '123' AS [Password],
		FirstName + ' ' + LastName AS FullName, NULL AS LastLoginTime, NULL AS GroupID
FROM Employees

-- Write a SQL statement that changes the password to NULL
-- for all users that have not been in the system since 10.03.2010.

UPDATE Users
SET [Password] = NULL
FROM Users u
WHERE u.LastLoginTime <= CONVERT(datetime, '10-03-2010')

-- Write a SQL statement that deletes all users without
-- passwords (NULL password).

DELETE FROM Users
WHERE Users.[Password] IS NULL

-- Write a SQL query to display the average employee salary
-- by department and job title.

SELECT d.Name AS DepartmentName, e.JobTitle, AVG(e.Salary) AS AverageSalary
FROM Employees e JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle

-- Write a SQL query to display the minimal employee salary
-- by department and job title along with the name of some
-- of the employees that take it.

SELECT e.FirstName + ' ' + e.LastName AS FullName, d.Name, e.JobTitle, MIN(e.Salary) AS MinimalSalary
FROM Employees e JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY e.FirstName + ' ' + e.LastName, d.Name, e.JobTitle

-- Write a SQL query to display the town where maximal number of employees work.

SELECT TOP 1 g.Name, MAX(NumberOfEmployeesInTowns) AS NumberOfEmployeesInTowns
FROM(
	SELECT t.Name, COUNT(*) AS NumberOfEmployeesInTowns
	FROM Employees e
		JOIN Addresses a ON e.AddressID = a.AddressID
		JOIN Towns t ON a.TownID = t.TownID
	GROUP BY t.Name
) g
GROUP BY g.Name
ORDER BY NumberOfEmployeesInTowns DESC

-- Write a SQL query to display the number of managers from each town.

SELECT g.TownName, COUNT(*) AS NumberOfManagers
FROM (
	SELECT m.EmployeeID, m.FirstName + ' ' + m.LastName AS ManagerFullName, t.Name AS TownName
	FROM Employees e
		JOIN Employees m
		ON e.ManagerID = m.EmployeeID
		JOIN Addresses a ON e.AddressID = a.AddressID
		JOIN Towns t ON a.TownID = t.TownID
) g
GROUP BY g.TownName

-- Write a SQL to create table WorkHours to store work reports for each employee
-- (employee id, date, task, hours, comments). Don't forget to define  identity,
-- primary key and appropriate foreign key. 
-- Issue few SQL statements to insert, update and delete of some data in the table.

CREATE TABLE WorkHours (
	WorkHoursID int IDENTITY PRIMARY KEY,
	[Date] datetime NOT NULL,
	Task nvarchar(50) NOT NULL,
	[Hours] int NOT NULL,
	Comments nvarchar(300),
	EmployeeID int NOT NULL,
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeID)
		REFERENCES Employees(EmployeeID)
)

--INSERT INTO WorkHours([Date], Task, [Hours], Comments, EmployeeID)
--VALUES(GETDATE(), 'Do some work', 3, 'Doing some work', 109),
--		(GETDATE(), 'Do some hard work', 6, 'Doing hard work', 291),
--		(GETDATE(), 'Do some hard work', 6, 'Doing hard work', 292)

UPDATE WorkHours
SET Task = 'Do another work'
WHERE EmployeeID = 109

DELETE FROM WorkHours
WHERE EmployeeID = 292

-- Define a table WorkHoursLogs to track all changes in
-- the WorkHours table with triggers. For each change keep
-- the old record data, the new record data and the command
-- (insert / update / delete).

CREATE TABLE WorkHoursLogs (
	LogID int IDENTITY PRIMARY KEY,
	OldRecordData nvarchar(100),
	NewRecordData nvarchar(100),
	Command nvarchar(30) NOT NULL
)

GO

CREATE TRIGGER TR_WorkHoursInsert
ON WorkHours
FOR INSERT
AS
	INSERT INTO WorkHoursLogs(OldRecordData, NewRecordData, Command)
	VALUES(NULL, NULL, 'INSERT')

GO

CREATE TRIGGER TR_WorkHoursUpdate
ON WorkHours
FOR UPDATE
AS
	INSERT INTO WorkHoursLogs(OldRecordData, NewRecordData, Command)
	VALUES(NULL, NULL, 'UPDATE')

GO

CREATE TRIGGER TR_WorkHoursDelete
ON WorkHours
FOR DELETE
AS
	INSERT INTO WorkHoursLogs(OldRecordData, NewRecordData, Command)
	VALUES(NULL, NULL, 'DELETE')

GO

-- Start a database transaction, delete all employees
-- from the 'Sales' department along with all dependent
-- records from the pother tables. At the end rollback the transaction.

ALTER TABLE Departments
ADD CONSTRAINT FK_CASCADE_1 FOREIGN KEY (ManagerID)
	REFERENCES Employees (EmployeeID)
	ON DELETE CASCADE

ALTER TABLE EmployeesProjects
ADD CONSTRAINT FK_CASCADE_2 FOREIGN KEY (EmployeeID)
	REFERENCES Employees (EmployeeID)
	ON DELETE CASCADE

BEGIN TRAN

DELETE FROM Employees
WHERE DepartmentID = (
	SELECT d.DepartmentID
	FROM Departments d
	WHERE d.Name = 'Sales'
)

ROLLBACK TRAN

-- Start a database transaction and drop the table EmployeesProjects.

BEGIN TRAN
DROP TABLE EmployeesProjects
ROLLBACK TRAN

 Find how to use temporary tables in SQL Server. Using temporary
 tables backup all records from EmployeesProjects and restore them
 back after dropping and re-creating the table.

SELECT *
INTO #EmployeesProjectsRecordsBackup
FROM EmployeesProjects;

DROP TABLE EmployeesProjects

SELECT *
INTO EmployeesProjects
FROM #EmployeesProjectsRecordsBackup