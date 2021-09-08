using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbModels
{
    public class Company : BaseModel
    {
        [MaxLength(50)]
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
