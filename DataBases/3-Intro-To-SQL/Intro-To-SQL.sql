USE TelerikAcademy

--Task 1: What is SQL? What is DML? What is DDL? Recite the most important SQL commands.
-------------------------------------------------
--DDL - Data Definition Language; Example: CREATE, DROP, ALTER, GRANT, REVOKE
--DML - Data Manipulation Language; Example: SELECT, INSERT, UPDATE, DELETE
-------------------------------------------------

--Task 2: What is Transact-SQL (T-SQL)?
-------------------------------------------------
--T-SQL: T-SQL (Transact SQL) is an extension to the standard SQL language
--T-SQL is the standard language used in MS SQL Server
--Supports if statements, loops, exceptions
--Constructions used in the high-level procedural programming languages
--T-SQL is used for writing stored procedures, functions, triggers, etc.
-------------------------------------------------

--Task 3: Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.
-------------------------------------------------
--Major Tables in TelerikAcademyDataBase are:
---Employees
---Departments
---Addresses
---Projects
---Towns
-------------------------------------------------

--Task 4: Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
--NOTE: Mark an sql statement, then execute. Only selected line will be executed.
-------------------------------------------------
SELECT * FROM Departments
-------------------------------------------------

--Task 5: Write a SQL query to find all department names.
-------------------------------------------------
SELECT Name FROM Departments
-------------------------------------------------

--Task 6: Write a SQL query to find the salary of each employee.
-------------------------------------------------
SELECT FirstName + ' ' + LastName AS [Employee], Salary FROM Employees
-------------------------------------------------

--Task 7: Write a SQL to find the full name of each employee.
-------------------------------------------------
SELECT FirstName + ' ' + LastName AS [Full Name] FROM Employees
-------------------------------------------------

--Task 8: Write a SQL query to find the email addresses of each employee (by his first and last name).
--Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com".
--The produced column should be named "Full Email Addresses".
-------------------------------------------------
SELECT FirstName + '.' + LastName + '@telerik.com' AS [Full Email Addresses] FROM Employees
-------------------------------------------------

--Task 9: Write a SQL query to find all different employee salaries.
-------------------------------------------------
SELECT DISTINCT Salary FROM Employees
-------------------------------------------------

--Task 10: Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
-------------------------------------------------
SELECT * FROM Employees WHERE [JobTitle] = 'Sales Representative'
-------------------------------------------------

--Task 11: Write a SQL query to find the names of all employees whose first name starts with "SA".
-------------------------------------------------
SELECT FirstName + ' ' + LastName AS [Emploee Name] FROM Employees WHERE FirstName LIKE 'SA%'
-------------------------------------------------

--Task 12: Write a SQL query to find the names of all employees whose last name contains "ei".
-------------------------------------------------
SELECT FirstName + ' ' + LastName AS [Emploee Name] FROM Employees WHERE LastName LIKE '%ei%'
-------------------------------------------------

--Task 13: Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
-------------------------------------------------
SELECT FirstName + ' ' + LastName AS [Emploee Name], Salary FROM Employees WHERE Salary BETWEEN 20000 AND 30000
-------------------------------------------------

--Task 14: Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
-------------------------------------------------
SELECT FirstName + ' ' + LastName AS [Emploee Name], Salary FROM Employees WHERE Salary IN (25000, 14000, 12500, 23600)
-------------------------------------------------

--Task 15: Write a SQL query to find all employees that do not have manager.
-------------------------------------------------
SELECT FirstName + ' ' + LastName AS [Emploee Name] FROM Employees WHERE ManagerID IS NULL
-------------------------------------------------

--Task 16: Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
-------------------------------------------------
SELECT FirstName + ' ' + LastName AS [Emploee Name], Salary FROM Employees WHERE Salary > 50000 ORDER BY Salary DESC
-------------------------------------------------

--Task 17: Write a SQL query to find the top 5 best paid employees.
-------------------------------------------------
SELECT TOP 5 FirstName + ' ' + LastName AS [Emploee Name], Salary FROM Employees ORDER BY Salary DESC
-------------------------------------------------

--Task 18: Write a SQL query to find all employees along with their address. Use inner join with ON clause.
-------------------------------------------------
SELECT e.FirstName + ' ' + e.LastName AS [Emploee Name], a.AddressText FROM Employees AS e JOIN Addresses AS a ON e.AddressID = a.AddressID
-------------------------------------------------

--Task 19: Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
-------------------------------------------------
SELECT e.FirstName + ' ' + e.LastName AS [Emploee Name], a.AddressText FROM Employees AS e, Addresses AS a WHERE e.AddressID = a.AddressID
-------------------------------------------------

--Task 20: Write a SQL query to find all employees along with their manager.
-------------------------------------------------
SELECT e.FIrstName + ' ' + e.LastName AS [Emploee Name], m.FIrstName + ' ' + m.LastName AS [Manager Name] FROM Employees AS e INNER JOIN Employees AS m ON e.ManagerID = m.EmployeeID
-------------------------------------------------

--Task 21: Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
-------------------------------------------------
SELECT e.FIrstName + ' ' + e.LastName AS [Emploee Name], m.FIrstName + ' ' + m.LastName AS [Manager Name], a.AddressText
FROM Employees AS e 
INNER JOIN Employees AS m ON e.ManagerID = m.EmployeeID
INNER JOIN Addresses AS a ON e.AddressID = a.AddressID
-------------------------------------------------

--Task 22: Write a SQL query to find all departments and all town names as a single list. Use UNION.
-------------------------------------------------
SELECT name FROM Departments
UNION 
SELECT name FROM Towns
-------------------------------------------------

--Task 23: Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
-------------------------------------------------
SELECT e.FIrstName + ' ' + e.LastName AS [Emploee Name],
	m.FIrstName + ' ' + m.LastName AS [Manager Name]
FROM Employees AS m
RIGHT OUTER JOIN Employees as e
	ON e.ManagerID = m.EmployeeID

SELECT e.FIrstName + ' ' + e.LastName AS [Emploee Name],
	m.FIrstName + ' ' + m.LastName AS [Manager Name]
FROM Employees AS e
LEFT OUTER JOIN Employees as m
	ON e.ManagerID = m.EmployeeID
-------------------------------------------------

--Task 24: Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
-------------------------------------------------
SELECT e.FIrstName + ' ' + e.LastName AS [Emploee Name], e.HireDate
FROM Employees AS e
INNER JOIN Departments AS d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance') 
	AND YEAR(e.HireDate) BETWEEN 1995 AND 2005
-------------------------------------------------

