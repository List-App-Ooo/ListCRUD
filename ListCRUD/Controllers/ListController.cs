using System;
using System.Threading.Tasks;
using ListCRUD.Models;
using ListCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListCRUD.Controllers
{
    [ApiController]
    [Route("api/list")]
    public class ListController : ControllerBase
    {
        private readonly IListService _service;

        public ListController(IListService service)
        {
            this._service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetList(Guid id)
        {
            var result = await _service.GetList(id);
            return Ok(result);
        }
    }
}