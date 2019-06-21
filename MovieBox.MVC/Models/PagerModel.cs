#region Includes

// .NET Libraries
using System.Collections.Generic;

#endregion

namespace MovieBox.MVC.Models
{
    public class PagerModel<T>
        where T : class 
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int TotalRows { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}