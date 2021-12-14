using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
  public class RecipeDetailsContext : DbContext
  {
    public RecipeDetailsContext(DbContextOptions<RecipeDetailsContext> options) : base(options)
    {
      
    }
    public  DbSet<RecipeDetails> RecipeDetails { get; set; }
  }
}
