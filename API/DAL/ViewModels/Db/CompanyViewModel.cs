using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class CompanyViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
