using System;

namespace GovtRulesSimple
{
    interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double GratuityAmount(float serviceCompleted, double basicSalary);
    }

    // TCS Class
    class TCS : GovtRules
    {
        int empId;
        string name;
        string dept;
        string desg;
        double basicSalary;

        // Constructor
        public TCS(int empId, string name, string dept, string desg, double basicSalary)
        {
            this.empId = empId;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        // Method for PF
        public double EmployeePF(double basicSalary)
        {
            double empPF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.0833;
            double pension = basicSalary * 0.0367;

            double total = empPF + employerPF + pension;
            return total;
        }

        // Method for Leave
        public string LeaveDetails()
        {
            return "Casual Leave: 1 per month\nSick Leave: 12 per year\nPrivilege Leave: 10 per year";
        }

        // Method for Gratuity
        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
                return 3 * basicSalary;
            else if (serviceCompleted > 10)
                return 2 * basicSalary;
            else if (serviceCompleted > 5)
                return basicSalary;
            else
                return 0;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("TCS Employee");
            Console.WriteLine("ID: " + empId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Dept: " + dept);
            Console.WriteLine("Designation: " + desg);
            Console.WriteLine("Salary: " + basicSalary);
        }
    }

    // Accenture Class
    class Accenture : GovtRules
    {
        int empId;
        string name;
        string dept;
        string desg;
        double basicSalary;

        public Accenture(int empId, string name, string dept, string desg, double basicSalary)
        {
            this.empId = empId;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            double empPF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.12;

            return empPF + employerPF;
        }

        public string LeaveDetails()
        {
            return "Casual Leave: 2 per month\nSick Leave: 5 per year\nPrivilege Leave: 5 per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0; // not applicable
        }

        public void Display()
        {
            Console.WriteLine("Accenture Employee");
            Console.WriteLine("ID: " + empId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Dept: " + dept);
            Console.WriteLine("Designation: " + desg);
            Console.WriteLine("Salary: " + basicSalary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // TCS Object
            TCS tcs = new TCS(1, "Bhuvan", "IT", "Developer", 50000);
            tcs.Display();
            Console.WriteLine("PF: " + tcs.EmployeePF(50000));
            Console.WriteLine("Leave Details:\n" + tcs.LeaveDetails());
            Console.WriteLine("Gratuity: " + tcs.GratuityAmount(6, 50000));

            Console.WriteLine();

            // Accenture Object
            Accenture acc = new Accenture(2, "Naidu", "HR", "Manager", 60000);
            acc.Display();
            Console.WriteLine("PF: " + acc.EmployeePF(60000));
            Console.WriteLine("Leave Details:\n" + acc.LeaveDetails());
            Console.WriteLine("Gratuity: " + acc.GratuityAmount(6, 60000));
        }
    }
}