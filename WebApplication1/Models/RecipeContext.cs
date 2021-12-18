using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
  public class RecipeContext : DbContext
  {
    public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
    {
      
    }
    public  DbSet<Recipe> Recipe { get; set; }
  }
}
