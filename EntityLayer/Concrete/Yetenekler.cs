using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yetenekler
    {
        [Key]
        public int YetenekId { get; set; }
        public string Yetenekisim { get; set; }

    }
}
