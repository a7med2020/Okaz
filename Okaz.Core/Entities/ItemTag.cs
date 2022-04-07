using Okaz.Core.Entities._Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Core.Entities
{
    public class ItemTag : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
