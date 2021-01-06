using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ListCRUD.Models;

namespace ListCRUD.Data
{
    public interface IListRepo
    {
        Task<List<ListModel<TypeModel>>> GetLists();
        Task<ListModel<TypeModel>> GetList(Guid id);
    }
}