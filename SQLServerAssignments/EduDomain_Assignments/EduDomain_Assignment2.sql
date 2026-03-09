-- Assignment 2 Constraints

ALTER TABLE Students
ADD CONSTRAINT chk_gender
CHECK (Gender IN ('M','F'));

ALTER TABLE Courses
ADD CONSTRAINT chk_credits
CHECK (Credits BETWEEN 1 AND 5);

ALTER TABLE Marks
ADD CONSTRAINT chk_marks
CHECK (MarksObtained BETWEEN 0 AND 100);

ALTER TABLE Enrollments
ADD CONSTRAINT df_enrollmentdate
DEFAULT GETDATE() FOR EnrollmentDate;

ALTER TABLE Teachers
ADD CONSTRAINT uq_teacher_email
UNIQUE (Email);