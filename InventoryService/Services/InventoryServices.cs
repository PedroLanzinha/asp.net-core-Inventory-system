using InventoryService.Controllers;
using System.Collections.Generic;
using InventoryService.Services;

namespace InventoryService.Services
{
    public class InventoryServices : IInventoryServices
    {
        private readonly Dictionary<string, InventoryItems> _inventoryItems;

        public InventoryServices()
        {
            _inventoryItems = new Dictionary<string, InventoryItems>();
        }

        public InventoryItems AddInventoryItems(InventoryItems items)
        {
            _inventoryItems.Add(items.ItemName, items);

            return items; //not good practice but it will do for this
        }

        public Dictionary<string, InventoryItems> GetInventoryItems()
        {
            return _inventoryItems;
        }
    }
}
