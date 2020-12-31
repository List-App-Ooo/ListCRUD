using System;
using System.Collections.Generic;
using System.Linq;
using ListCRUD.Models;

namespace ListCRUD.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ListContext context)
        {
            context.Database.EnsureCreated();

            if (context.Lists.Any())
            {
                return;
            }

            var list = new ListModel();
            list.Id = new Guid();
            list.Title = "Todo List #1";
            list.TotalItems = 3;

            context.Lists.AddRange(list);
            context.SaveChanges();
        }
    }
}