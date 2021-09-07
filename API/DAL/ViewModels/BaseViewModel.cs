using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public abstract class BaseViewModel
    {
        public Guid Guid { get; set; }
        public bool Active { get; set; }
    }
}
