using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Models
{
    public class Inventory
    {
        public int Id { get; set; }

        public String ItemName { get; set; }

        public double Price { get; set; }
    }
}
