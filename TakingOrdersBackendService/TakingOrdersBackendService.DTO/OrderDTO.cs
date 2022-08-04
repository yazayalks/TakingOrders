using System.ComponentModel.DataAnnotations;

namespace TakingOrdersBackendService.DTO;

public class OrderDTO
{
    [Required(ErrorMessage = "Заполните SenderCity")]
    public string SenderCity { get; set; } = null!;
    public string SenderAddress { get; set; } = null!;
    public string RecipientCity { get; set; } = null!;
    public string RecipientAddress { get; set; } = null!;
    public double CargoWeight { get; set; }
    public DateTime PickupDate { get; set; }
}