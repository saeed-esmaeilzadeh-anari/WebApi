using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeDetailController : ControllerBase
    {
        private readonly RecipeDetailsContext _context;

        public RecipeDetailController(RecipeDetailsContext context)
        {
            _context = context;
        }

        // GET: api/RecipeDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeDetails>>> GetRecipeDetails()
        {
            return await _context.RecipeDetails.ToListAsync();
        }

        // GET: api/RecipeDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeDetails>> GetRecipeDetails(int id)
        {
            var recipeDetails = await _context.RecipeDetails.FindAsync(id);

            if (recipeDetails == null)
            {
                return NotFound();
            }

            return recipeDetails;
        }

        // PUT: api/RecipeDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecipeDetails(int id, RecipeDetails recipeDetails)
        {
            if (id != recipeDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(recipeDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RecipeDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RecipeDetails>> PostRecipeDetails(RecipeDetails recipeDetails)
        {
            _context.RecipeDetails.Add(recipeDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecipeDetails", new { id = recipeDetails.Id }, recipeDetails);
        }

        // DELETE: api/RecipeDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipeDetails(int id)
        {
            var recipeDetails = await _context.RecipeDetails.FindAsync(id);
            if (recipeDetails == null)
            {
                return NotFound();
            }

            _context.RecipeDetails.Remove(recipeDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecipeDetailsExists(int id)
        {
            return _context.RecipeDetails.Any(e => e.Id == id);
        }
    }
}
