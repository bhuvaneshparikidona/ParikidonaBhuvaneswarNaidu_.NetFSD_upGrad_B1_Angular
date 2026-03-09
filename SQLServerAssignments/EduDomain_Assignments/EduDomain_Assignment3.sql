use Assignments

ALTER TABLE Students
ADD PhoneNumber VARCHAR(15);

ALTER TABLE Teachers
ADD Salary INT;

ALTER TABLE Teachers
ALTER COLUMN Salary DECIMAL(10,2);

ALTER TABLE Teachers
ADD CONSTRAINT chk_salary
CHECK (Salary > 20000);

ALTER TABLE Students
DROP COLUMN PhoneNumber;

EXEC sp_rename 'Teachers.TeacherName', 'FullName', 'COLUMN';

