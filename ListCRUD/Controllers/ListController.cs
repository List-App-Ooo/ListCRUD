using System;
using System.Threading.Tasks;
using ListCRUD.Models;
using ListCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListCRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
            return Ok(await _service.GetList(id));
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetLists(Guid userId)
        {
            return Ok(await _service.GetLists(userId));
        }
    }
}