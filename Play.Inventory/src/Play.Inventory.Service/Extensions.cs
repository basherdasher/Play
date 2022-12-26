using Play.Inventory.Service.Dtos;
using Play.Inventory.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Inventory.Service
{
    public static class Extensions
    {
        public static InventoryItemDto AsDto(this InventoryItem item)
        {
            return new InventoryItemDto(
                item.CatalogItemId,
                item.Quantity,
                item.AcquiredDate
                );
        }
    }
}
