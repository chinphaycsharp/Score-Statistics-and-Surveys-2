using PhoDiem_TLU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.Commons
{
    public class Pager
    {
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public long number { get; set; }
        public int TotalItems { get; set; }
        public int PageSize { get; set; }
        public bool sort { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public List<UserViewModel> content { get; set; }

        public Pager()
        {

        }

        public Pager(int totalItems, int page, int pageSize = 10)
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
            int currentPage = page;
            int startPage = currentPage - 5;
            int endPage = currentPage + 4;

            if(startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }

            if(endPage > totalPages)
            {
                endPage = totalPages;
                if(endPage > 10)
                {
                    startPage = endPage - 9;
                }
            }

            TotalItems = totalItems;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;
        }
    }
}