using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Data
{
  public class Project

    {
        [System.ComponentModel.DataAnnotations.Key]

        public int Id { get; set; }
        [Column("ID_ProjektID")]
        public string ProjektID { get; set; }
        [Column("ID_Projekt")]
        public string ProjektNazov { get; set; }
        [Column("ID_Hala1")]
        public string Hala1 { get; set; }
        [Column("ID_Hala2")]
        public string Hala2 { get; set; }
        [Column("ID_Hala3")]
        public string Hala3 { get; set; }
        [Column("DatPrid")]
        public string Dat { get; set; }

    }
}
