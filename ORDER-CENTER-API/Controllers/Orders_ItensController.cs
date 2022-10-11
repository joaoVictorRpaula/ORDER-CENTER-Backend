using Microsoft.AspNetCore.Mvc;
using ORDER_CENTER_API.Models;
using ORDER_CENTER_API.Services;
using System.Collections.Generic;

namespace ORDER_CENTER_API.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class Orders_ItensController : Controller
    {
        private readonly Orders_ItensService _service;

        public Orders_ItensController(Orders_ItensService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetOrders_Itens()
        {
            List<Orders_Itens> ordersItens = _service.GetOrders_Itens();

            if(ordersItens == null)
            {
                return NotFound();
            }

            return Ok(ordersItens);
        }

        [HttpGet("Order/{orderId}")]
        public IActionResult GetOrders_ItensByOrderId(int orderId)
        {
            List<Orders_Itens> ordersItens = _service.GetOrders_ItensByOrderId(orderId);

            if (ordersItens == null)
            {
                return NotFound();
            }

            return Ok(ordersItens);
        }


        [HttpPost]
        public IActionResult AddOrders_Itens([FromBody] List<Orders_Itens> ordersItens)
        {
            List<Orders_Itens> newOrdersItens = _service.AddOrders_Itens(ordersItens);

            if(newOrdersItens == null)
            {
                return BadRequest();
            }

            return Ok(ordersItens);
        }

    }
}
