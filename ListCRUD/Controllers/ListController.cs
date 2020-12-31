using System;
using System.Threading.Tasks;
using ListCRUD.Models;
using ListCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListCRUD.Controllers
{
    [ApiController]
    [Route("{api/[controller]}")]
    public class ListController : ControllerBase
    {
        private readonly IListService _service;

        public ListController(IListService service)
        {
            this._service = service;
        }

        [HttpGet("{id}")]
        public async Task<ListModel<ItemModel>> GetList(Guid id)
        {
            return await _service.GetList(id);
        }
    }
}