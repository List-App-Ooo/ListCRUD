using System;
using System.Linq;
using ListCRUD.Models;

namespace ListCRUD.Data
{
    public static class DbInitializer
    {public static void Initialize(ListContext context)
        {
            context.Database.EnsureCreated();

            if (context.Lists.Any())
            {
                return;
            }

            ListModel<ItemModel> list = new ListModel<ItemModel>();
            list.Id = new Guid();
            list.Title = "Todo List #1";

            context.Lists.Add(list);
            context.SaveChanges();
        }        
    }
}