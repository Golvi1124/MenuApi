using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MenuApi.Model;

namespace MenuApi.Controllers
{
    [Route("api/households")]
    [ApiController]
    public class HouseholdsController : ControllerBase
    {
        private readonly AppDbContext _context; // why private?

        private List<Households> _households;

        public HouseholdsController(AppDbContext context)
        {
            _context = context;
            _households = new List<Households>
            {
                new Households { ID = 1, Family = "Smith", Address = "1234 Elm St", Members = new List<string> { "John", "Jane", "Jimmy" } },
                new Households { ID = 2, Family = "Doe", Address = "5678 Oak St", Members = new List<string> { "Jack", "Jill" } },
            };
        }
    }
}

/*     public int ID { get; set; }
    public Guid guid { get; set; } = Guid.NewGuid(); // Unique ID of the household
    public string? Family { get; set; } // Name of the household
    public string? Address { get; set; } // Address of the household
    public List<string>? Members { get; set; } // Members of the household */