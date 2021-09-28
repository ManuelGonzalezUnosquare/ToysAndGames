using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AgeRestriction { get; set; }
        public CompanyViewModel Company { get; set; }
        public Guid CompanyGuid { get; set; }
        public decimal Price { get; set; }
        public string Pic { get; set; }
        public string PicThumbnail { get; set; }
    }
}
