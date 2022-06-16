using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Egitim
    {
        [Key]
        public int EgitimId { get; set; }
        public string OkulAdi { get; set; }
        public string BölümAdi { get; set; }
        public string OkulGirisTRH { get; set; }
        public string OkulCikisTRH { get; set; }
        public string BitirmePuani { get; set; }
    }
}
