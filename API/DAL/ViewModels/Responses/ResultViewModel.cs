using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class ResultViewModel<T> where T : class
    {
       

        public ResultViewModel(T sourceModel)
        {
            IsSuccess = true;
            Model = sourceModel;
        }
        public ResultViewModel(Exception ex)
        {
            IsSuccess = false;
            Error = ex.Message;
        }

        public T Model { get; set; }
        public bool IsSuccess { get; set; }
        public string Error { get; set; }
    }
}
