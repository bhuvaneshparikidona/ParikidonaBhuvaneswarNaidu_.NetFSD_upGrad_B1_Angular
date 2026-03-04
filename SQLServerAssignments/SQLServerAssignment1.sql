create database Assignments
use  Assignments

CREATE TABLE Worker (
	WORKER_ID INT PRIMARY KEY IDENTITY(1,1),
	FIRST_NAME VARCHAR(25),
	LAST_NAME VARCHAR(25),
	SALARY INT,
	JOINING_DATE DATETIME,
	DEPARTMENT CHAR(25)
);


CREATE TABLE Bonus (
	WORKER_REF_ID INT,
	BONUS_AMOUNT INT,
	BONUS_DATE DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);


CREATE TABLE Title (
	WORKER_REF_ID INT,
	WORKER_TITLE CHAR(25),
	AFFECTED_FROM DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

INSERT INTO Worker (FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT)
VALUES 
('Monika', 'Arora', 100000, '2014-02-20 09:00:00', 'HR'),
('Niharika', 'Verma', 80000, '2014-06-11 09:00:00', 'Admin'),
('Vishal', 'Singhal', 300000, '2014-02-20 09:00:00', 'HR'),
('Amitabh', 'Singh', 500000, '2014-02-20 09:00:00', 'Admin'),
('Vivek', 'Bhati', 500000, '2014-06-11 09:00:00', 'Admin'),
('Vipul', 'Diwan', 200000, '2014-06-11 09:00:00', 'Account'),
('Satish', 'Kumar', 75000, '2014-01-20 09:00:00', 'Account'),
('Geetika', 'Chauhan', 90000, '2014-04-11 09:00:00', 'Admin');


INSERT INTO Bonus (WORKER_REF_ID, BONUS_AMOUNT, BONUS_DATE)
VALUES
(1, 5000, '2016-02-20 00:00:00'),
(2, 3000, '2016-06-11 00:00:00'),
(3, 4000, '2016-02-20 00:00:00'),
(1, 4500, '2016-02-20 00:00:00'),
(2, 3500, '2016-06-11 00:00:00');



INSERT INTO Title (WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM)
VALUES
(1, 'Manager', '2016-02-20 00:00:00'),
(2, 'Executive', '2016-06-11 00:00:00'),
(8, 'Executive', '2016-06-11 00:00:00'),
(5, 'Manager', '2016-06-11 00:00:00'),
(4, 'Asst. Manager', '2016-06-11 00:00:00'),
(7, 'Executive', '2016-06-11 00:00:00'),
(6, 'Lead', '2016-06-11 00:00:00'),
(3, 'Lead', '2016-06-11 00:00:00');



SELECT * FROM Worker;
SELECT * FROM Bonus;
SELECT * FROM Title;

--	1. Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>.

select first_name as Worker_Name from Worker 

--	2. Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.

select upper(first_name) as "First Name" from Worker

--	3. Write an SQL query to fetch unique values of DEPARTMENT from Worker table.

select department from Worker group by DEPARTMENT

--	4. Write an SQL query to print the first three characters of  FIRST_NAME from Worker table.
select SUBSTRING(first_name,1,3) from Worker

--	5. Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.
SELECT CHARINDEX('a', FIRST_NAME) FROM Worker WHERE FIRST_NAME = 'Amitabh';

--	6. Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.
select RTRIM(first_name) from Worker

--	7. Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.
select LTRIM(department) from Worker

--	8. Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.
select distinct department, len(department) from worker

--	9. Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘A’.
select REPLACE(first_name,'a','A') from Worker

--	10. Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them.
select CONCAT(first_name,' ', last_name) from Worker as "Complete  Name"

--	11. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending.
SELECT * FROM Worker ORDER BY FIRST_NAME ASC;

--	12. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.
select * from worker
SELECT * FROM Worker ORDER BY FIRST_NAME ASC, DEPARTMENT DESC;

--	13. Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table.
SELECT * FROM Worker WHERE FIRST_NAME IN ('Vipul','Satish');

--	14. Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.
SELECT * FROM Worker WHERE FIRST_NAME NOT IN ('Vipul','Satish');

--	15. Write an SQL query to print details of Workers with DEPARTMENT name as “Admin”.
select * from Worker where DEPARTMENT = 'Admin'

--	16. Write an SQL query to print details of the Workers whose FIRST_NAME contains ‘a’.
select * from Worker where FIRST_NAME like '%a%'

--	17. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘a’.
select * from Worker where FIRST_NAME like '%a'

--	18. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets.
select * from Worker where FIRST_NAME like '_____h'

--	19. Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.
select * from Worker where SALARY between 100000 and 500000

--	20. Write an SQL query to print details of the Workers who have joined in Feb’2014.
select * from Worker where YEAR(JOINING_DATE) = 2014 and MONTH(JOINING_DATE) = 2

--	21. Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000.
select FIRST_NAME, LAST_NAME from Worker where SALARY >= 50000 and SALARY<= 100000

--	22. Write an SQL query to fetch the no. of workers for each department in the descending order.
select department, count(*) from Worker group by DEPARTMENT order by COUNT(*) desc

--	23. Write an SQL query to print details of the Workers who are also Managers


--	24.Write an SQL query to show the current date and time.
SELECT GETDATE();

--	.Write an SQL query to show the top n (say 10) records of a table.
SELECT top 10 * from Worker


