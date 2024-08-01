namespace SpendSmart.Models;

public class Expense
{
    public int Id { get; set; }
    public decimal Value { get; set; }
    public string? Description { get; set; }
    
    // The date will be read only after a DateOnly object is created
    public DateOnly CreationDate { get; }

    public Expense(DateOnly creationDate)
    {
        this.CreationDate = CreationDate;
    }
}