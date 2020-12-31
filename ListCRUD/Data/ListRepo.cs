using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListCRUD.Models;

namespace ListCRUD.Data
{
    public class ListRepo : IListRepo
    {
        private readonly ListContext _listContext;

        public ListRepo(ListContext listContext)
        {
            this._listContext = listContext;
        }

        public Task<ListModel<ItemModel>> GetList(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListModel<ItemModel>>> GetLists()
        {
            throw new NotImplementedException();
        }
    }
}