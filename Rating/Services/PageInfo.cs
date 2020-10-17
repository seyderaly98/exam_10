using System;
using System.Collections.Generic;
using Rating.Models;

namespace Rating.Services
{
    public class PageInfo
    {
        public int PageNumber { get; set; } // номер текущей страницы
        public int PageSize { get; set; } // кол-во объектов на странице
        public int TotalItems { get; set; } // всего объектов
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / PageSize); // всего страниц
    }
    public class IndexViewModel
    {
        public IEnumerable<Institution> Institutions { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}