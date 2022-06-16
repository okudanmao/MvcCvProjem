using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string IsimSoyisim { get; set; }
        public string Adres { get; set; }
        public string TelefonNumarasi { get; set; }
        public string MailAdres { get; set; }
        public string KısaAciklama { get; set; }
        public string Adres2 { get; set; }

    }
}
