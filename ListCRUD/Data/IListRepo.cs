using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ListCRUD.Models;

namespace ListCRUD.Data
{
    public interface IListRepo
    {
        Task<List<ListModel>> GetLists(Guid userId);
        Task<ListModel> GetList(Guid id);
    }
}