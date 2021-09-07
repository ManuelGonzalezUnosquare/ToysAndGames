using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbModels
{
    public class Product : BaseModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Range(0,100)]
        public int AgeRestriction { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        [Required]
        [Range(1, 1000)]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Price { get; set; }

        public string Pic { get; set; }
        public string PicThumbnail { get; set; }
    }
}
