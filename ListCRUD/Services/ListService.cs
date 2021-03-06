using System;
using System.Collections.Generic;
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

        public async Task<ListModel> GetList(Guid id)
        {
            return await _repo.GetList(id);
        }

        public async Task<IEnumerable<ListModel>> GetLists(Guid id)
        {
            return await _repo.GetLists(id);
        }
    }
}