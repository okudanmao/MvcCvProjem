using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Deneyim
    {
        [Key]
        public int DeneyimId { get; set; }
        public string SirketAdi { get; set; }
        public string SirketPozisyon { get; set; }
        public string Aciklama { get; set; }

        public string CalismaSuresi { get; set; }

    }
}
