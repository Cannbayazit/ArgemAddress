using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArgemAddress.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public int StreetId { get; set; }
        public string Name { get; set; }
        public static List<Apartment> ApartmentList = new List<Apartment>(){
        new Apartment{Id=1,StreetId=1,Name="Gülnaz Apt"},
        new Apartment{Id=2,StreetId=1,Name="Şemsi Bey APt"},
        new Apartment{Id=3,StreetId=1,Name="hasmi Bey APt"},
        new Apartment{Id=4,StreetId=1,Name="lütfi Bey APt"},
        new Apartment{Id=5,StreetId=2,Name="kadriye hanım APt"},
        new Apartment{Id=6,StreetId=2,Name="a APt"},
        new Apartment{Id=7,StreetId=2,Name="b APt"},
        new Apartment{Id=8,StreetId=2,Name="c APt"},
        new Apartment{Id=9,StreetId=3,Name="d APt"},
        new Apartment{Id=10,StreetId=3,Name="f APt"},
        new Apartment{Id=11,StreetId=3,Name="leyla  APt"},
        new Apartment{Id=12,StreetId=3,Name="faruk APt"},
        new Apartment{Id=13,StreetId=4,Name="göksü APt"},
        new Apartment{Id=14,StreetId=4,Name="şemsi APt"},
        new Apartment{Id=15,StreetId=4,Name="12 APt"},
        new Apartment{Id=16,StreetId=3,Name="34 APt"},
        new Apartment{Id=17,StreetId=5,Name="kemal APt"},
        new Apartment{Id=18,StreetId=5,Name="necmi APt"},
        new Apartment{Id=19,StreetId=5,Name="ziya APt"},
        new Apartment{Id=20,StreetId=4,Name="neriman sitesi"},
        new Apartment{Id=21,StreetId=6,Name="nane sitesi"},
        new Apartment{Id=22,StreetId=6,Name="perihan sitesi"},
        new Apartment{Id=23,StreetId=6,Name="erdem apt"},
        new Apartment{Id=24,StreetId=6,Name="necmiye apt"},
        new Apartment{Id=25,StreetId=7,Name="Gülnaz Apt"},
        new Apartment{Id=26,StreetId=7,Name="Gülnaz Apt"},
        new Apartment{Id=27,StreetId=7,Name="Gülnaz Apt"},
        new Apartment{Id=28,StreetId=7,Name="Gülnaz Apt"},
        new Apartment{Id=29,StreetId=8,Name="Gülnaz Apt"},
        new Apartment{Id=30,StreetId=8,Name="Gülnaz Apt"},
        new Apartment{Id=31,StreetId=8,Name="Gülnaz Apt"},
        new Apartment{Id=32,StreetId=8,Name="Gülnaz Apt"},
        new Apartment{Id=33,StreetId=9,Name="Gülnaz Apt"},
        new Apartment{Id=34,StreetId=9,Name="Gülnaz Apt"},
        new Apartment{Id=35,StreetId=9,Name="Gülnaz Apt"},
        new Apartment{Id=36,StreetId=9,Name="Gülnaz Apt"},
        new Apartment{Id=37,StreetId=10,Name="Gülnaz Apt"},
        new Apartment{Id=38,StreetId=10,Name="Gülnaz Apt"},
        new Apartment{Id=39,StreetId=10,Name="Gülnaz Apt"},
        new Apartment{Id=40,StreetId=10,Name="Gülnaz Apt"},
        new Apartment{Id=41,StreetId=11,Name="Gülnaz Apt"},
        new Apartment{Id=42,StreetId=11,Name="Gülnaz Apt"},
        new Apartment{Id=43,StreetId=11,Name="Gülnaz Apt"},
        new Apartment{Id=44,StreetId=11,Name="Gülnaz Apt"},
        new Apartment{Id=45,StreetId=12,Name="Gülnaz Apt"},
        new Apartment{Id=46,StreetId=12,Name="Gülnaz Apt"},
        new Apartment{Id=47,StreetId=12,Name="Gülnaz Apt"},
        new Apartment{Id=48,StreetId=12,Name="Gülnaz Apt"},
        new Apartment{Id=49,StreetId=13,Name="Gülnaz Apt"},
        new Apartment{Id=50,StreetId=13,Name="Gülnaz Apt"},
        new Apartment{Id=51,StreetId=13,Name="Gülnaz Apt"},
        new Apartment{Id=52,StreetId=13,Name="Gülnaz Apt"},
        new Apartment{Id=53,StreetId=14,Name="Gülnaz Apt"},
        new Apartment{Id=54,StreetId=14,Name="Gülnaz Apt"},
        new Apartment{Id=55,StreetId=14,Name="Gülnaz Apt"},
        new Apartment{Id=56,StreetId=14,Name="Gülnaz Apt"},
        new Apartment{Id=57,StreetId=15,Name="Gülnaz Apt"},
        new Apartment{Id=58,StreetId=15,Name="Gülnaz Apt"},
        new Apartment{Id=59,StreetId=15,Name="Gülnaz Apt"},
        new Apartment{Id=60,StreetId=15,Name="Gülnaz Apt"},
        new Apartment{Id=61,StreetId=16,Name="Gülnaz Apt"},
        new Apartment{Id=62,StreetId=16,Name="Gülnaz Apt"},
        new Apartment{Id=63,StreetId=16,Name="Gülnaz Apt"},
        new Apartment{Id=64,StreetId=16,Name="Gülnaz Apt"},
        new Apartment{Id=65,StreetId=17,Name="Gülnaz Apt"},
        new Apartment{Id=66,StreetId=17,Name="Gülnaz Apt"},
        new Apartment{Id=67,StreetId=17,Name="Gülnaz Apt"},
        new Apartment{Id=68,StreetId=17,Name="Gülnaz Apt"},
        new Apartment{Id=69,StreetId=18,Name="Gülnaz Apt"},
        new Apartment{Id=70,StreetId=18,Name="Gülnaz Apt"},
        new Apartment{Id=71,StreetId=18,Name="Gülnaz Apt"},
        new Apartment{Id=72,StreetId=18,Name="Gülnaz Apt"},
        new Apartment{Id=73,StreetId=19,Name="Gülnaz Apt"},
        new Apartment{Id=74,StreetId=19,Name="Gülnaz Apt"},
        new Apartment{Id=75,StreetId=19,Name="Gülnaz Apt"},
        new Apartment{Id=76,StreetId=19,Name="Gülnaz Apt"},
        new Apartment{Id=77,StreetId=20,Name="Gülnaz Apt"},
        new Apartment{Id=78,StreetId=20,Name="Gülnaz Apt"},
        new Apartment{Id=79,StreetId=20,Name="Gülnaz Apt"},
        new Apartment{Id=80,StreetId=20,Name="Gülnaz Apt"},
         };
        static public void UpdateName(Apartment apartment)
        {
            var result = ApartmentList.FirstOrDefault(e => e.Id == apartment.Id);
            result.Name = apartment.Name;
        }
        static public void DeleteStreet(Apartment apartment)
        {
            ApartmentList.Remove(apartment);
        }
        static public void AddNewStreet(Apartment apartment)
        {
            if (ApartmentList.Any(p => p.Name == apartment.Name) || String.IsNullOrEmpty(apartment.Name))
                return;
            var lastItem = ApartmentList.OrderBy(p => p.Id).Last();
            apartment.Id = lastItem.Id + 1;
            ApartmentList.Add(apartment);
        }
    }

}