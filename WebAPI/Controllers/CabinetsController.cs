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
    public class CabinetsController : ControllerBase
    {
        private ICabinetService _cabinetService;

        public CabinetsController(ICabinetService cabinetService)
        {
            _cabinetService = cabinetService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _cabinetService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("get")]
        public IActionResult GetById(int cabinetId)
        {
            var result = _cabinetService.GetById(cabinetId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Cabinet cabinet)
        {
            var result = _cabinetService.Add(cabinet);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Cabinet cabinet)
        {
            var result = _cabinetService.Update(cabinet);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Cabinet cabinet)
        {
            var result = _cabinetService.Delete(cabinet);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}