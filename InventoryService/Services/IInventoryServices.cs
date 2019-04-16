using InventoryService.Controllers;
using System.Collections.Generic;

namespace InventoryService.Services
{
    interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);

        Dictionary<string, InventoryItems> GetInventoryItems();
    }
}
