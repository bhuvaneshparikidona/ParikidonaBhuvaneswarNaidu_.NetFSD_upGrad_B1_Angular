--	EduDomain Assignment 6

SELECT DepartmentID, COUNT(*) AS StudentCount
FROM Students
GROUP BY DepartmentID;

SELECT ExamID, AVG(MarksObtained)
FROM Marks
GROUP BY ExamID;

SELECT CourseID, COUNT(StudentID)
FROM Enrollments
GROUP BY CourseID;

SELECT ExamID, MAX(MarksObtained)
FROM Marks
GROUP BY ExamID;

SELECT CourseID, MIN(MarksObtained)
FROM Marks m
JOIN Exams e
ON m.ExamID = e.ExamID
GROUP BY CourseID;

SELECT DepartmentID, COUNT(*)
FROM Students
GROUP BY DepartmentID
HAVING COUNT(*) > 5;