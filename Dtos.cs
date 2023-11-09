namespace Phoenix.Inventory.Service.Dtos;

public record GrantItemsDto(Guid UserId, Guid CatalogGodId, int Quantity);
public record InventoryItemDto(Guid CatalogItemId, int Quantity, DateTimeOffset AcquiredDate);