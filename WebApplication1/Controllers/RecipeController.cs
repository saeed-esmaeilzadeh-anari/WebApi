using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
  public class RecipeController : Controller
  {
    private readonly RecipeDetailsContext _db;
    public RecipeController(RecipeDetailsContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      IEnumerable<RecipeDetails> objRecipeList = _db.RecipeDetails;
      return View();
    }
  }
}
