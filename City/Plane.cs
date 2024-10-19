using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    internal class Plane
    {
        private string planeName;           
        private string manufacturerName;    
        private int year;      
        private string planeType;          

        public Plane()
        {
            planeName = "";
            manufacturerName = "";
            year = 0;
            planeType = "";
        }

        public Plane(string plane, string manufacturer, int years, string type)
        {
            planeName = plane;
            manufacturerName = manufacturer;
            year = years;
            planeType = type;
        }

        public string GetPlaneName()
        {
            return planeName;
        }
        public void SetPlaneName(string value)
        {
            planeName = value;
        }

        public string GetManufacturerName()
        {
            return manufacturerName;
        }

        public void SetManufacturerName(string value)
        {
            manufacturerName = value;
        }

        public int Getyear()
        {
            return year;
        }

        public void Setyear(int value)
        {
            year = value;
        }

        public string GetPlaneType()
        {
            return planeType;
        }

        public void SetPlaneType(string value)
        {
            planeType = value;
        }

        public void Input()
        {
            Console.Write("Enter plane Name: ");
            SetPlaneName(Console.ReadLine());

            Console.Write("Enter name manufacture: ");
            SetManufacturerName(Console.ReadLine());

            Console.Write("Enter year: ");
            Setyear(int.Parse(Console.ReadLine()));

            Console.Write("Enter type plane: ");
            SetPlaneType(Console.ReadLine());
        }

        public void Input(string planeName, string manufacturerName, int year, string planeType)
        {
            SetPlaneName(planeName);
            SetManufacturerName(manufacturerName);
            Setyear(year);
            SetPlaneType(planeType);
        }

        public void Output()
        {
            Console.WriteLine("\nИнформация о самолёте:");
            Console.WriteLine($"Название: {GetPlaneName()}");
            Console.WriteLine($"Производитель: {GetManufacturerName()}");
            Console.WriteLine($"Год выпуска: {Getyear()}");
            Console.WriteLine($"Тип: {GetPlaneType()}");
        }

        public void Output(bool includeHeader)
        {
            if (includeHeader)
            {
                Console.WriteLine("\nPlane Information");
            }

            Output(); 
        }
    }

    internal class Program1
    {
        static void Main(string[] args)
        {
            Plane plane1 = new Plane();
            plane1.Input();     
            plane1.Output();    

            Plane plane2 = new Plane("Boeing 747", "Boeing", 2007, "Passenger");
            plane2.Output(true); 
        }
    }
}
