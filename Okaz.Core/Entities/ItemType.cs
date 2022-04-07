using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Core.Entities
{
    public class ItemType
    {
        [StringLength(15)]
        public string ID { get; set; }
        [Required]
        [StringLength(100)]
        public string NameAr { get; set; }
        public string Notes { get; set; }
    }
}
