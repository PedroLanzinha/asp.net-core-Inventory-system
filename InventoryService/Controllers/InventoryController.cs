using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controllers
{
    [Route("v1/]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        public ActionResult<InventoryItems> AddInventoryItems()
        {
            var inventoryItems = _service.AddInventoryItems(InventoryItems items);

            if (inventoryItems == null)
            {
                return NotFound();
            }

            return Ok();

        }
    }
}