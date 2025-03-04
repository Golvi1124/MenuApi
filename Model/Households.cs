using System;

namespace MenuApi.Model;

public class Households
{
    public int ID { get; set; }
    public Guid guid { get; set; } = Guid.NewGuid(); // Unique ID of the household
    public string? Family { get; set; } // Name of the household
    public string? Address { get; set; } // Address of the household
    public List<string>? Members { get; set; } // Members of the household

    public int IncrementID()
    {
        return ID++;
    }

}
