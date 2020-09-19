using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelfsController : ControllerBase
    {
        private readonly IShelfService _shelfService;

        public ShelfsController(IShelfService shelfService)
        {
            _shelfService = shelfService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _shelfService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("get")]
        public IActionResult GetById(int shelfId)
        {
            var result = _shelfService.GetById(shelfId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Shelf shelf)
        {
            var result = _shelfService.Add(shelf);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Shelf shelf)
        {
            var result = _shelfService.Update(shelf);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Shelf shelf)
        {
            var result = _shelfService.Delete(shelf);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}