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
            
            var noteList = new ListModel();
            noteList.Id = new Guid("ef6a7925-80a6-44bc-9e03-89bc7ca3586e");
            noteList.Title = "Note List #1";
            noteList.TotalItems = 3;
            
            var todoList = new ListModel();
            todoList.Id = new Guid("ef6a7925-80a6-44bc-9e03-89bc7ca3586f");
            todoList.Title = "Todo List #1";
            todoList.TotalItems = 3;

            context.Lists.AddRange(noteList);
            context.Lists.AddRange(todoList);
            context.SaveChanges();
        }
    }
}