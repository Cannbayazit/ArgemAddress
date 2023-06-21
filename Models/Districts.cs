using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArgemAddress.Models
{
    public class Districts
    {
        public int IlId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<Districts> DistrictList = new List<Districts>(){
            new Districts{IlId=1,Id=1,Name="Onikişubat"},
            new Districts{IlId=1,Id=2,Name="Dulkadiroğlu"},
            new Districts { IlId = 2, Id = 3, Name = "Seyhan" },
            new Districts { IlId = 2, Id = 4, Name = "Ceyhan" },
            new Districts { IlId = 3, Id = 5, Name = "Çankaya" },
            new Districts { IlId = 3, Id = 6, Name = "Kızılay" },
            new Districts { IlId = 4, Id = 7, Name = "Avcılar" },
            new Districts { IlId = 4, Id = 8, Name = "Bağcılar" },
            new Districts { IlId = 5, Id = 9, Name = "Osmangazi" },
            new Districts { IlId = 5, Id = 10, Name = "Nilüfer" },
        };
    }
}