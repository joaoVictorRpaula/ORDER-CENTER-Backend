using Microsoft.AspNetCore.Mvc;
using ORDER_CENTER_API.Models;
using ORDER_CENTER_API.Services;
using System.Collections.Generic;

namespace ORDER_CENTER_API.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class TempOrdersController : Controller
    {
        private readonly TempOrdersService _service;

        public TempOrdersController(TempOrdersService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult AddTempOrders([FromBody] List<TempOrders> tempOrders)
        {
            List<TempOrders> newTempOrders = _service.AddTempOrders(tempOrders);
            if(newTempOrders == null)
            {
                return NotFound();
            }
            return Ok(newTempOrders);
        }

        [HttpGet]
        public IActionResult GetAllTempOrders()
        {
            List<TempOrders> tempOrders = _service.GetAllTempOrders();

            if(tempOrders == null)
            {
                return NotFound();
            }


            return Ok(tempOrders);
        }

        [HttpDelete("{tempOrderId}")]
        public IActionResult RemoveTempOrder(int tempOrderId)
        {
             TempOrders tempOrder = _service.RemoveTempOrder(tempOrderId);

            if(tempOrder == null)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
