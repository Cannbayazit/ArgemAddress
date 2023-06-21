using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArgemAddress.Models
{
    public class Neighbourhoods
    {
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }


        public static List<Neighbourhoods> NeighbourhoodsList = new List<Neighbourhoods>(){
            new Neighbourhoods{IlId=1,IlceId=1,Id=1,Name="Mimar Sinan Mahallesi"},
            new Neighbourhoods{IlId=1,IlceId=1,Id=2,Name="Mağralı"},
            new Neighbourhoods{IlId=1,IlceId=2,Id=3,Name="Aslanbey"},
            new Neighbourhoods{IlId=1,IlceId=2,Id=4,Name="Bağlarbaşı"},
            new Neighbourhoods{IlId=2,IlceId=3,Id=5,Name="2000 EVLER MAHALLESİ"},
            new Neighbourhoods{IlId=2,IlceId=3,Id=6,Name="AHMET REMZİ YÜREĞİR MAHALLESİ"},
            new Neighbourhoods{IlId=2,IlceId=4,Id=7,Name="Adatepe Mahallesi"},
            new Neighbourhoods{IlId=2,IlceId=4,Id=8,Name="Altıocak Mahallesi"},
            new Neighbourhoods{IlId=3,IlceId=5,Id=9,Name="Akpınar"},
            new Neighbourhoods{IlId=3,IlceId=5,Id=10,Name="Anıttepe"},
            new Neighbourhoods{IlId=3,IlceId=6,Id=11,Name="Cumhuriyet"},
            new Neighbourhoods{IlId=3,IlceId=6,Id=12,Name="Meşrutiyet"},
            new Neighbourhoods{IlId=4,IlceId=7,Id=13,Name="Ambarlı"},
            new Neighbourhoods{IlId=4,IlceId=7,Id=14,Name="Cihangir"},
            new Neighbourhoods{IlId=4,IlceId=8,Id=15,Name="100. YIL MAHALLESİ"},
            new Neighbourhoods{IlId=4,IlceId=8,Id=16,Name="15 TEMMUZ MAHALLESİ"},
            new Neighbourhoods{IlId=5,IlceId=9,Id=17,Name="ADALET MAHALLESİ"},
            new Neighbourhoods{IlId=5,IlceId=9,Id=18,Name="Ahmet bey MAHALLESİ"},
            new Neighbourhoods{IlId=5,IlceId=10,Id=19,Name="19 MAYIS MAHALLESİ"},
            new Neighbourhoods{IlId=5,IlceId=10,Id=20,Name="23 NİSAN MAHALLESİ"},
        };
        static public void UpdateName(Neighbourhoods neighbourhoods)
        {
            var result = NeighbourhoodsList.FirstOrDefault(e => e.Id == neighbourhoods.Id);
            result.Name = neighbourhoods.Name;

        }
        static public void DeleteNeighbour(Neighbourhoods neighbourhoods)
        {
            NeighbourhoodsList.Remove(neighbourhoods);
        }
    }
}