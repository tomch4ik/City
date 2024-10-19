using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class City
    {
        private string cityName;            
        private string countryName;         
        private int population;            
        private string phoneCode;           
        private string[] districts;         
        private int districtCount;          

        public City()
        {
            districts = new string[0];
            districtCount = 0;
        }

        public string GetCityName()
        {
            return cityName;
        }
        public void SetCityName(string value)
        {
            cityName = value;
        }
        public string GetCountryName()
        {
            return countryName;
        }
        public void SetCountryName(string value)
        {
            countryName = value;
        }
        public int GetPopulation()
        {
            return population;
        }
        public void SetPopulation(int value)
        {
            population = value;
        }
        public string GetPhoneCode()
        {
            return phoneCode;
        }
        public void SetPhoneCode(string value)
        {
            phoneCode = value;
        }
        public string[] GetDistricts()
        {
            return districts;
        }
        public int GetDistrictCount()
        {
            return districtCount;
        }
        public void Input()
        {
            Console.Write("City name: ");
            SetCityName(Console.ReadLine());

            Console.Write("Country name: ");
            SetCountryName(Console.ReadLine());

            Console.Write("Population: ");
            SetPopulation(int.Parse(Console.ReadLine()));

            Console.Write("Phone Code: ");
            SetPhoneCode(Console.ReadLine());

            Console.Write("number of districts: ");
            int numberOfDistricts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDistricts; i++)
            {
                Console.Write($"Name district: ");
                string district = Console.ReadLine();
                AddDistrict(district);
            }
        }


        public void AddDistrict(string district)
        {       
            string[] newDistricts = new string[districtCount + 1];

            for (int i = 0; i < districtCount; i++)
            {
                newDistricts[i] = districts[i];
            }
            newDistricts[districtCount] = district;
            districts = newDistricts;       
            districtCount++;
        }
        public void Output()
        {
            Console.WriteLine($"\nCity: {GetCityName()}");
            Console.WriteLine($"Country: {GetCountryName()}");
            Console.WriteLine($"Population: {GetPopulation()}");
            Console.WriteLine($"Phone code: {GetPhoneCode()}");
            Console.WriteLine("Districts:");

            for (int i = 0; i < GetDistrictCount(); i++)
            {
                Console.WriteLine($"{districts[i]}");
            }
        }
    }

    internal class Program
    {    
        static void Main(string[] args)
        {        
            City city = new City();         
            city.Input(); 
            city.Output();
        }
    }
}
