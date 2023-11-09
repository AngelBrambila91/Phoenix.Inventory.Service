using System.Diagnostics.Contracts;
using Phoenix.Inventory.Service.Entities;
using Phoenix.Inventory.Service.Dtos;

namespace Phoenix.Inventory.Service;
public static class Extensions
{
    public static InventoryItemDto AsDto(this InventoryItem item)
    {
        return new InventoryItemDto(item.CatalogGodId, item.Quantity, item.AcquiredDate);
    }
}