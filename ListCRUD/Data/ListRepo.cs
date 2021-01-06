using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ListCRUD.Data
{
    public class ListRepo : IListRepo
    {
        private readonly ListContext _context;

        public ListRepo(ListContext context)
        {
            this._context = context;
        }

        public async Task<ListModel<TypeModel>> GetList(Guid id)
        {
            return await _context.Lists.FirstOrDefaultAsync(m => m.Id == id);
        }

        public Task<List<ListModel<TypeModel>>> GetLists()
        {
            throw new NotImplementedException();
        }
    }
}