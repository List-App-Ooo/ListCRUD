using System;
using System.Collections.Generic;

namespace ListCRUD.Models
{
    public class ListModel<T>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int TotalItems { get; set; }
        public T Type { get; set; }
    }
}