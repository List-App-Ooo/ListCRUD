using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ListCRUD.Models;

namespace ListCRUD.Services
{
    public interface IListService
    {
        Task<ListModel> GetList(Guid id);
        Task<IEnumerable<ListModel>> GetLists(Guid id);
    }
}