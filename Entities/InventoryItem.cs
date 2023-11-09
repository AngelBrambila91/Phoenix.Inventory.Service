using System;
using System.Security.Principal;
using Phoenix.Common;

namespace Phoenix.Inventory.Service.Entities;
public class InventoryItem : IEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid CatalogGodId { get; set; }
    public int Quantity { get; set; }
    public DateTimeOffset AcquiredDate { get; set; }
}