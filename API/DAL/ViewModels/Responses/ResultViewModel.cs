using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    class ResultViewModel<T> where T : class
    {
        public T Model { get; set; }
        public bool IsSuccess { get; set; }
        public string Error { get; set; }
    }
}
