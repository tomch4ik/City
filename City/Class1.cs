using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    internal class Employee
    {
        private string Name;            
        private int YearBirth;            
        private string PhoneNumber;        
        private string Email;          
        private string position;           
        private string jobDescription;    

        public Employee()
        {
            Name = "";
            YearBirth = 0;
            PhoneNumber = "";
            Email = "";
            position = "";
            jobDescription = "";
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string value)
        {
            Name = value;
        }

        public int GetYearBirth()
        {
            return YearBirth;
        }

        public void SetYearBirth(int value)
        {
            YearBirth = value;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public void SetPhoneNumber(string value)
        {
            PhoneNumber = value;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string value)
        {
            Email = value;
        }

        public string GetPosition()
        {
            return position;
        }

        public void SetPosition(string value)
        {
            position = value;
        }

        public string GetJobDescription()
        {
            return jobDescription;
        }

        public void SetJobDescription(string value)
        {
            jobDescription = value;
        }

        public void Input()
        {
            Console.Write("Enter Full Name: ");
            SetName(Console.ReadLine());

            Console.Write("Enter Birth Year: ");
            SetYearBirth(int.Parse(Console.ReadLine()));

            Console.Write("Enter Phone Number: ");
            SetPhoneNumber(Console.ReadLine());

            Console.Write("Enter Email: ");
            SetEmail(Console.ReadLine());

            Console.Write("Enter position: ");
            SetPosition(Console.ReadLine());

            Console.Write("Enter job description: ");
            SetJobDescription(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("\nPersonal Information:");
            Console.WriteLine($"Full Name: {GetName()}");
            Console.WriteLine($"Birth Year: {GetYearBirth()}");
            Console.WriteLine($"Phone number: {GetPhoneNumber()}");
            Console.WriteLine($"Email: {GetEmail()}");
            Console.WriteLine($"Position: {GetPosition()}");
            Console.WriteLine($"Job description: {GetJobDescription()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee();
            p1.Input();
            p1.Output();                 
        }
    }
}
