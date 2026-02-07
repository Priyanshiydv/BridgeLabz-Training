-- =====================================
-- STEP 1: CREATE DATABASE (DDL)
-- =====================================
CREATE DATABASE StudentDB;

-- =====================================
-- STEP 2: USE DATABASE
-- =====================================
USE StudentDB;

-- =====================================
-- DDL(Data Definition Language)
-- STEP 3: CREATE TABLE
-- =====================================
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Age INT CHECK (Age >= 17),
    Course VARCHAR(50)
);

-- =====================================
-- STEP 4A: ADD COLUMN
-- =====================================
ALTER TABLE Students
ADD Email VARCHAR(100);


-- =====================================
-- STEP 4B: DROP COLUMN
-- =====================================
ALTER TABLE Students
DROP COLUMN Email;


-- =====================================
-- STEP 5: TRUNCATE TABLE 
-- Removes all records from the table
-- =====================================
TRUNCATE TABLE Students;

-- =====================================
-- DML (Data Manipulation Language)
-- STEP 5: INSERT DATA
-- =====================================
INSERT INTO Students VALUES (1, 'Priyanshi', 20, 'BCA');
INSERT INTO Students VALUES (2, 'Suruchi', 21, 'BTech');
INSERT INTO Students VALUES (3, 'Ritu', 19, 'BSc');


-- =====================================
-- STEP 6: UPDATE DATA
-- =====================================
UPDATE Students
SET Course = 'MCA'
WHERE StudentID = 1;

-- =====================================
-- STEP 7: DELETE DATA
-- =====================================
DELETE FROM Students WHERE StudentID = 3;


-- =====================================
-- DQL(Data Query Language)
-- STEP 8: SELECT DATA
-- =====================================
SELECT * FROM Students;

-- =====================================
-- STEP 9: SELECT WITH WHERE
-- =====================================
SELECT * FROM Students WHERE Age > 20;


-- =====================================
-- STEP 10: TCL (TRANSACTIONS Control Language)
-- =====================================
BEGIN TRANSACTION;

INSERT INTO Students VALUES (4, 'Riya', 22, 'MBA');

ROLLBACK;  -- Undo change
-- COMMIT;  -- Use this to save change


-- =====================================
-- STEP 11: DCL (SECURITY)
-- =====================================
CREATE LOGIN TestUser WITH PASSWORD = 'Test@123';
CREATE USER TestUser FOR LOGIN TestUser;

GRANT SELECT ON Students TO TestUser;


-- =====================================
-- STEP 12: TRUNCATE TABLE
-- =====================================
TRUNCATE TABLE Students;

-- =====================================
-- STEP 13: DROP TABLE
-- =====================================
DROP TABLE Students;


-- =====================================
-- STEP 14: DROP DATABASE
-- =====================================
USE master;
DROP DATABASE StudentDB;


-- JOINS
-- =====================================
-- CREATE DEPARTMENTS TABLE
-- =====================================
CREATE TABLE Departments (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

-- =====================================
-- ADD DeptID COLUMN TO STUDENTS
-- =====================================
ALTER TABLE Students
ADD DeptID INT;

-- Add foreign key relationship
ALTER TABLE Students
ADD CONSTRAINT FK_Student_Department
FOREIGN KEY (DeptID) REFERENCES Departments(DeptID);

-- Departments
INSERT INTO Departments VALUES (1, 'Computer Science');
INSERT INTO Departments VALUES (2, 'Electronics');
INSERT INTO Departments VALUES (3, 'Mechanical');

-- Students
INSERT INTO Students VALUES (3, 'Priya', 19, 'BSc', 1);
INSERT INTO Students VALUES (4, 'Neha', 22, 'BBA', NULL);

SELECT * FROM Departments;

-- =====================================
-- INNER JOIN shows only matching records
-- =====================================
SELECT Students.Name, Departments.DeptName
FROM Students
INNER JOIN Departments
ON Students.DeptID = Departments.DeptID;

-- =====================================
-- LEFT JOIN -All students, even if no department.
-- =====================================
SELECT Students.Name, Departments.DeptName
FROM Students
LEFT JOIN Departments
ON Students.DeptID = Departments.DeptID;


-- =====================================
-- RIGHT JOIN
-- =====================================
SELECT Students.Name, Departments.DeptName
FROM Students
RIGHT JOIN Departments
ON Students.DeptID = Departments.DeptID;


-- =====================================
-- FULL JOIN
-- =====================================
SELECT Students.Name, Departments.DeptName
FROM Students
FULL OUTER JOIN Departments
ON Students.DeptID = Departments.DeptID;


-- =====================================
-- CROSS JOIN
-- =====================================
SELECT Students.Name, Departments.DeptName
FROM Students
CROSS JOIN Departments;

--SELF JOIN
-- Example: students of same course
SELECT A.Name, B.Name AS Classmate
FROM Students A
JOIN Students B
ON A.Course = B.Course AND A.StudentID <> B.StudentID;


-- =====================================
-- RESET DATA BEFORE AGGREGATE PRACTICE
-- =====================================
DELETE FROM Students;
DELETE FROM Departments;


-- Departments
INSERT INTO Departments VALUES (1, 'Computer Science');
INSERT INTO Departments VALUES (2, 'Electronics');
INSERT INTO Departments VALUES (3, 'Mechanical');

-- Students
INSERT INTO Students VALUES (1, 'Rahul', 20, 'BCA', 1);
INSERT INTO Students VALUES (2, 'Ankit', 21, 'BTech', 2);
INSERT INTO Students VALUES (3, 'Priya', 19, 'BSc', 1);
INSERT INTO Students VALUES (4, 'Neha', 22, 'BBA', 2);
INSERT INTO Students VALUES (5, 'Riya', 23, 'MBA', 3);


--AGGREGATE FUNCTIONS
--COUNT()
-- Total students
SELECT COUNT(*) AS TotalStudents FROM Students;

--SUM()
ALTER TABLE Students ADD Marks INT;

UPDATE Students SET Marks = 80 WHERE StudentID = 1;
UPDATE Students SET Marks = 75 WHERE StudentID = 2;
UPDATE Students SET Marks = 90 WHERE StudentID = 3;
UPDATE Students SET Marks = 85 WHERE StudentID = 4;
UPDATE Students SET Marks = 70 WHERE StudentID = 5;

SELECT SUM(Marks) AS TotalMarks FROM Students;

--AVG()
SELECT AVG(Marks) AS AverageMarks FROM Students;

--MAX()
SELECT MAX(Marks) AS HighestMarks FROM Students;

--MIN()
SELECT MIN(Marks) AS LowestMarks FROM Students;

--GROUP BY
-- Average marks department wise
SELECT D.DeptName, AVG(S.Marks) AS AvgMarks
FROM Students S
JOIN Departments D ON S.DeptID = D.DeptID
GROUP BY D.DeptName;


--HAVING
-- Departments with average marks > 75
SELECT D.DeptName, AVG(S.Marks) AS AvgMarks
FROM Students S
JOIN Departments D ON S.DeptID = D.DeptID
GROUP BY D.DeptName
HAVING AVG(S.Marks) > 75;
