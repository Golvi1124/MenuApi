using System;
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

/* wft is this?

[NotMapped] // This property is ignored by EF Core
        public List<string> Ingredients
        {
            get => JsonSerializer.Deserialize<List<string>>(IngredientsJson) ?? new List<string>();
            set => IngredientsJson = JsonSerializer.Serialize(value);
        }
 */


    /* public List<string>? Ingredients { get; set; } // Ingredients of the dish */

}
