using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
  public class RecipeController : Controller
  {
    private readonly RecipeContext _db;
    public RecipeController(RecipeContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      IEnumerable<Recipe> objRecipeList = _db.Recipe;
      return View();
    }
  }
}
