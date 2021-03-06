using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class ListResultViewModel<T> where T : class
    {
        public ListResultViewModel(List<T> sourceModel,int totalCount, SearchViewModel search)
        {
            IsSuccess = true;
            Model = sourceModel;
            Page = search.Page;
            PerPage = search.PerPage;
            TotalNumberOfRecords = totalCount;
        }
        public ListResultViewModel(Exception ex)
        {
            IsSuccess = false;
            Error = ex.Message;
        }
        public List<T> Model { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
        public int TotalNumberOfRecords { get; set; }
        public bool IsSuccess { get; set; }
        public string Error { get; set; }


    }
}
