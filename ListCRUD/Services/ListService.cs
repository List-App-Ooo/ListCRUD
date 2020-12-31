using System;
using System.Threading.Tasks;
using ListCRUD.Data;
using ListCRUD.Models;

namespace ListCRUD.Services
{
    public class ListService : IListService
    {
        private readonly IListRepo _repo;

        public ListService(IListRepo repo)
        {
            this._repo = repo;
        }

        public async Task<ListModel<ItemModel>> GetList(Guid id)
        {
            return await _repo.GetList(id);
        }
    }
}