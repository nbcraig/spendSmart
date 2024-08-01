namespace SpendSmart.Models;

public class Expense
{
    public int Id { get; set; }
    public decimal Value { get; set; }
    public string? Description { get; set; }
    
    // The date will be read only after a DateTime object is created
    public DateTime CreationDate { get; }
}