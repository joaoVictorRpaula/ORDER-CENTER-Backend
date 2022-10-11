using Microsoft.AspNetCore.Mvc;
using ORDER_CENTER_API.Models;
using ORDER_CENTER_API.Services;
using System.Collections.Generic;

namespace ORDER_CENTER_API.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class FoodsController : Controller
    {
        private readonly FoodsService _service;

        public FoodsController(FoodsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllFoods()
        {
            List<Foods> foods = _service.GetAllFoods();

            if(foods == null)
            {
                return NotFound();
            }
            return Ok(foods);
        }
    }
}
