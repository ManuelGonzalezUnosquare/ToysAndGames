using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class SearchViewModel
    {
       
        public Guid? Guid { get; set; }
        public bool? Active { get; set; } = true;
        public int Page { get; set; } = 1;
        public int PerPage { get; set; } = 15;
    }
}
