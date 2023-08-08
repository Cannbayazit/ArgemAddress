using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArgemAddress.Models
{
    public class AvenueStreet
    {
        public int Id { get; set; }
        public int MahalleId { get; set; }
        public string Name { get; set; }
        public static List<AvenueStreet> streetList = new List<AvenueStreet>{
    new AvenueStreet{Id = 1,MahalleId = 1,Name = "Güneşli Sokak"},
    new AvenueStreet{Id = 2,MahalleId = 1,Name = "Kızılay Sokak"},
    new AvenueStreet{Id = 3,MahalleId = 2,Name = "Muratpaşa Sokak"},
    new AvenueStreet{Id = 4,MahalleId = 2,Name = "Nilüfer Sokak" },
    new AvenueStreet{Id = 5,MahalleId = 3,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 6,MahalleId = 3,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 7,MahalleId = 4,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 8,MahalleId = 4,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 9,MahalleId = 5,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 10,MahalleId = 5,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 11,MahalleId = 6,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 12,MahalleId = 6,Name = "Güneşli Sokak"},
    new AvenueStreet{Id = 13,MahalleId = 7,Name = "Kızılay Sokak"},
    new AvenueStreet{Id = 14,MahalleId = 7,Name = "Muratpaşa Sokak"},
    new AvenueStreet{Id = 15,MahalleId = 8,Name = "Nilüfer Sokak" },
    new AvenueStreet{Id = 16,MahalleId = 8,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 17,MahalleId = 9,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 18,MahalleId = 9,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 19,MahalleId = 10,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 20,MahalleId = 10,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 21,MahalleId = 11,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 22,MahalleId = 11,Name = "Güneşli Sokak"},
    new AvenueStreet{Id = 23,MahalleId = 12,Name = "Kızılay Sokak"},
    new AvenueStreet{Id = 24,MahalleId = 12,Name = "Muratpaşa Sokak"},
    new AvenueStreet{Id = 25,MahalleId = 13,Name = "Nilüfer Sokak" },
    new AvenueStreet{Id = 26,MahalleId = 13,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 27,MahalleId = 14,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 28,MahalleId = 14,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 29,MahalleId = 15,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 30,MahalleId = 15,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 31,MahalleId = 16,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 32,MahalleId = 16,Name = "Güneşli Sokak"},
    new AvenueStreet{Id = 33,MahalleId = 17,Name = "Kızılay Sokak"},
    new AvenueStreet{Id = 34,MahalleId = 17,Name = "Muratpaşa Sokak"},
    new AvenueStreet{Id = 35,MahalleId = 18,Name = "Nilüfer Sokak" },
    new AvenueStreet{Id = 36,MahalleId = 18,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 37,MahalleId = 19,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 38,MahalleId = 19,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 39,MahalleId = 20,Name = "Adana Merkez Sokak"},
    new AvenueStreet{Id = 40,MahalleId = 20,Name = "Adana Merkez Sokak"},
    };

        static public void UpdateName(AvenueStreet streets)
        {
            var result = streetList.FirstOrDefault(e => e.Id == streets.Id);
            result.Name = streets.Name;

        }
        static public void DeleteStreet(AvenueStreet streets)
        {
            streetList.Remove(streets);
        }
        static public void AddNewStreet(AvenueStreet streets)
        {
            if (streetList.Any(p => p.Name == streets.Name) || String.IsNullOrEmpty(streets.Name))
                return;
            var lastItem = streetList.OrderBy(p => p.Id).Last();
            streets.Id = lastItem.Id + 1;
            streetList.Add(streets);
        }
    }
}