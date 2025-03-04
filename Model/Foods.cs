using System.ComponentModel.DataAnnotations;

namespace MenuApi.Model;

public class Foods
{
    [Key] // This is the primary key
    public int ID { get; set; }
    public Guid guid { get; set; } = Guid.NewGuid(); // Unique ID of the dish
    public string? Name { get; set; } // Name of the dish
    public string? Type { get; set; } // breakfast, dinner, lunch, etc.

    
    public string IngredientsJson { get; set; } = "[]"; // Ingredients stored as a JSON string in SQLite
}
