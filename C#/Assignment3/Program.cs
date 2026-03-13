using System;

namespace Assignment3
{
    internal class Patient
    {
        public int PatientId;
        public string PatientName;
        public int Age;
        public string Disease;
    }

    internal class Doctor
    {
        public int doctorId;
        public string doctorName;
        public string specialization;
        public int consultationFee;

    }

    class Hospital
    {
        public static string HospitalName;
        public static string HospitalAddress;

        public string PatientName;
    }

    class Appointment
    {
        public int AppointmentId;
        public string PatientName;
        public string DoctorName;
        public DateTime AppointmentDate;

        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Today;
        }

    }

    class MedicalTest
    {
        public int TestId;
        public string TestName;
        public double TestCost;

        public MedicalTest(int id, string name, double cost)
        {
            TestId = id;
            TestName = name;
            TestCost = cost;
        }
    }

    class Billing
    {
        public string PatientName;
        public double ConsultationFee;
        public double TestCharges;

        public void CalculateTotalBill()
        {
            double total = ConsultationFee + TestCharges;

            Console.WriteLine("Patient Name: " + PatientName);
            Console.WriteLine("Total Bill: " + total);
        }
    }

    class PatientRecord
    {
        public static string HospitalName;

        public int PatientId;
        public string PatientName;
        public int Age;
        public string Disease;

        public PatientRecord(int id, string name, int age, string disease)
        {
            PatientId = id;
            PatientName = name;
            Age = age;
            Disease = disease;
        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Patient Id: " + PatientId);
            Console.WriteLine("Name: " + PatientName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Disease: " + Disease);
            Console.WriteLine();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();

            p.PatientId = 101;
            p.PatientName = "Ravi Kumar";
            p.Age = 45;
            p.Disease = "Diabetes";

            Console.WriteLine("Patient Id: " + p.PatientId);
            Console.WriteLine("Patient Name: " + p.PatientName);
            Console.WriteLine("Age: " + p.Age);
            Console.WriteLine("Disease: " + p.Disease);


            Doctor doctor1 = new Doctor();
            doctor1.doctorId = 101;
            doctor1.doctorName = "Sathya";
            doctor1.specialization = "Ortho";
            doctor1.consultationFee = 100;

            Console.WriteLine($"Doctor Id   {doctor1.doctorId}");
            Console.WriteLine($"Doctor Name   {doctor1.doctorName}");
            Console.WriteLine($"Doctor Specialization   {doctor1.specialization}");
            Console.WriteLine($"Doctor ConsultationFee   {doctor1.consultationFee}");


            Doctor doctor2 = new Doctor();
            doctor2.doctorId = 102;
            doctor2.doctorName = "Shirisha";
            doctor2.specialization = "Dermitology";
            doctor2.consultationFee = 1000;

            Console.WriteLine($"Doctor Id   {doctor2.doctorId}");
            Console.WriteLine($"Doctor Name   {doctor2.doctorName}");
            Console.WriteLine($"Doctor Specialization   {doctor2.specialization}");
            Console.WriteLine($"Doctor ConsultationFee   {doctor2.consultationFee}");

            Hospital.HospitalName = "Apollo Hospital";
            Hospital.HospitalAddress = "Bangalore";

            Hospital p1 = new Hospital();
            Hospital p2 = new Hospital();
            Hospital p3 = new Hospital();

            p1.PatientName = "Ravi";
            p2.PatientName = "Suresh";
            p3.PatientName = "Mahesh";

            Console.WriteLine(Hospital.HospitalName + " - " + Hospital.HospitalAddress);
            Console.WriteLine("Patient: " + p1.PatientName);
            Console.WriteLine("Patient: " + p2.PatientName);
            Console.WriteLine("Patient: " + p3.PatientName);

            Appointment a = new Appointment();

            a.AppointmentId = 1;
            a.PatientName = "Ravi";

            Console.WriteLine("Appointment Id: " + a.AppointmentId);
            Console.WriteLine("Patient Name: " + a.PatientName);
            Console.WriteLine("Doctor Name: " + a.DoctorName);
            Console.WriteLine("Date: " + a.AppointmentDate.ToShortDateString());

            MedicalTest t1 = new MedicalTest(1, "Blood Test", 500);
            MedicalTest t2 = new MedicalTest(2, "X-Ray", 1200);

            Console.WriteLine(t1.TestId + " " + t1.TestName + " " + t1.TestCost);
            Console.WriteLine(t2.TestId + " " + t2.TestName + " " + t2.TestCost);

            Billing b = new Billing();

            b.PatientName = "Ramesh";
            b.ConsultationFee = 500;
            b.TestCharges = 1000;

            b.CalculateTotalBill();

            PatientRecord.HospitalName = "Apollo Hospital";

            PatientRecord p11 = new PatientRecord(101, "Ravi", 40, "Fever");
            PatientRecord p22 = new PatientRecord(102, "Suresh", 35, "Diabetes");
            PatientRecord p33 = new PatientRecord(103, "Mahesh", 50, "BP");

            p11.DisplayPatientRecord();
            p22.DisplayPatientRecord();
            p33.DisplayPatientRecord();



        }
    }
}