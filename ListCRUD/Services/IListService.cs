using System;
using System.Threading.Tasks;
using ListCRUD.Models;

namespace ListCRUD.Services
{
    public interface IListService
    {
        Task<ListModel> GetList(Guid id);
    }
}