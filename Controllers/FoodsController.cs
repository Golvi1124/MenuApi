using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MenuApi.Model;

namespace MenuApi.Controllers
{
    [Route("api/menu")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FoodsController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Foods (Create a new food item)
        [HttpPost]
        public async Task<IActionResult> AddFood([FromBody] Foods food)
        {
            if (food == null)
                return BadRequest("Invalid food item");

            _context.Foods.Add(food);
            await _context.SaveChangesAsync();
            return Ok(food);
        }

        // GET: api/Foods (Get all food items)
        [HttpGet]
        public async Task<IActionResult> GetFoods()
        {
            var foods = await _context.Foods.ToListAsync();
            return Ok(foods);
        }
    }
}
// This is the controller class for the Foods entity. It has two methods: AddFood and GetFoods.
// AddFood is a POST method that creates a new food item in the database. It takes a Foods object as a parameter and adds it to the Foods DbSet in the database context. 
// It then saves the changes to the database and returns the newly created food item.
// GetFoods is a GET method that retrieves all food items from the database. It uses the ToListAsync method to asynchronously retrieve all food items from the Foods DbSet and returns them as a list.
// The controller class is annotated with the [Route("api/[controller]")] attribute, which specifies the base route for all the methods in the controller.