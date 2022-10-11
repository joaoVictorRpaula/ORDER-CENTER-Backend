using Microsoft.AspNetCore.Mvc;
using ORDER_CENTER_API.Models;
using ORDER_CENTER_API.Services;

namespace ORDER_CENTER_API.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class OrdersController : Controller
    {
        private readonly OrdersService _service;

        public OrdersController(OrdersService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult AddNewOrder([FromBody] Orders order)
        {
            Orders newOrder = _service.AddNewOrder(order);
            if (newOrder == null)
            {
                return BadRequest();
            }
            return Ok(newOrder);
        }
    }
}
