using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArgemAddress.Models
{
    public class Cities
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int TelCode { get; set; }

        public static List<Cities> CityList = new List<Cities>(){
            new Cities{Id=1,Name="Kahramanmaraş",TelCode=344},
            new Cities{Id=2,Name="Adana",TelCode=244},
            new Cities{Id=3,Name="Ankara",TelCode=144},
            new Cities{Id=4,Name="İstanbul",TelCode=444},
            new Cities{Id=5,Name="Bursa",TelCode=544},
        };
        static public void UpdateName(Cities cities)
        {
            var result = CityList.FirstOrDefault(e => e.Id == cities.Id);
            result.Name = cities.Name;

        }
        static public void DeleteCities(Cities cities)
        {
            CityList.Remove(cities);
        }
        static public void AddNewCity(Cities cities)
        {
            if (CityList.Any(p => p.Name == cities.Name) || String.IsNullOrEmpty(cities.Name))
                return;
            var lastItem = CityList.OrderBy(p => p.Id).Last();
            cities.Id = lastItem.Id + 1;
            CityList.Add(cities);
        }
    }


}