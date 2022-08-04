namespace TakingOrdersBackendService.DataAccess.Models;

public class Order
{
    public int Id { get; set; }
    public string SenderCity { get; set; } = null!;
    public string SenderAddress { get; set; } = null!;
    public string RecipientCity { get; set; } = null!;
    public string RecipientAddress { get; set; } = null!;
    public double CargoWeight { get; set; }
    public DateTime PickupDate { get; set; }
}