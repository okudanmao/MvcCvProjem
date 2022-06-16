using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class IlgiAlanlari
    {
        [Key]
        public int ilgiAlanlarıId { get; set; }

        public string ilgiAlanAdi { get; set; }

    }
}
