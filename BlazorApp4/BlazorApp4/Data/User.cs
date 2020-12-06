using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Data
{
    public class User
    {
        
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Zaradenie { get; set; }
        public string Email { get; set; }
        public string Heslo { get; set; }
        public string Hala { get; set; }
        public string Dat { get; set; }
    }
}
