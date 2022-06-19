using Okaz.Core.Entities._Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Core.Entities
{
    public class ItemCategory : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string ImagePath { get; set; }
        
    }
}
