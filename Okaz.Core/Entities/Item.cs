using Okaz.Core.Entities._Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Core.Entities
{
    public class Item : BaseEntity
    {
        [StringLength(25)]
        public string BarCode { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [ForeignKey("ItemCategory")]
        public int CategoryID { get; set; }
        [StringLength(250)]
        public string TagIDs { get; set; }

        [ForeignKey("ItemType")]
        public string TypeID { get; set; }

        public decimal Price1 { get; set; }
        public decimal Price2 { get; set; }
        public decimal Price3 { get; set; }

        public int ReorderLevel { get; set; }
        public bool IsAddedFromExcel { get; set; }
        public bool IsEnabled { get; set; }

        public bool IsTaxedItem { get; set; }

        [ForeignKey("Tax")]
        public int? TaxID { get; set; }

        [ForeignKey("ItemColor")]
        public int? ColorID { get; set; }
        [ForeignKey("ItemSize")]
        public int? SizeID { get; set; }

        public string Description { get; set; }
        public string StorageLocation { get; set; }
        public string ImagePath { get; set; }

        public ItemCategory ItemCategory { get; set; }
        public ItemType ItemType { get; set; }

    }
}
