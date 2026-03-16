using System;

namespace HealthcareSystem
{
    internal class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public Staff(int staffId, string name, double baseSalary)
        {
            StaffId = staffId;
            Name = name;
            BaseSalary = baseSalary;
        }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {StaffId}");
            Console.WriteLine($"Name: {Name}");
        }
    }

    internal class Doctor : Staff
    {
        public double ConsultationFee { get; set; }

        public Doctor(int id, string name, double salary, double consultationFee)
            : base(id, name, salary)
        {
            ConsultationFee = consultationFee;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + ConsultationFee;
        }
    }

    internal class Nurse : Staff
    {
        public double NightShiftAllowance { get; set; }

        public Nurse(int id, string name, double salary, double allowance)
            : base(id, name, salary)
        {
            NightShiftAllowance = allowance;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + NightShiftAllowance;
        }
    }

    internal class LabTechnician : Staff
    {
        public double EquipmentAllowance { get; set; }

        public LabTechnician(int id, string name, double salary, double allowance)
            : base(id, name, salary)
        {
            EquipmentAllowance = allowance;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + EquipmentAllowance;
        }
    }

    internal class HealthCareSystem
    {
        static void Main(string[] args)
        {
            Staff[] staffMembers =
            {
                new Doctor(1,"Dr.Ravi",50000,15000),
                new Nurse(2,"Anita",30000,5000),
                new LabTechnician(3,"Kiran",25000,4000)
            };

            foreach (Staff staff in staffMembers)
            {
                staff.Display();
                Console.WriteLine($"Salary: {staff.CalculateSalary()}");
                Console.WriteLine("----------------------------");
            }
        }
    }
}