namespace backend.DTOs;

public class CartResponse
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public List<CartItemResponse> Items { get; set; } = [];
    public int TotalItems => Items.Sum(i => i.Quantity);
    public decimal Subtotal => Items.Sum(i => i.LineTotal);
    public decimal Total => Subtotal;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
