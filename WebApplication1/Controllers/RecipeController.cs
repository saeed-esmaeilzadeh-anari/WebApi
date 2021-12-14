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
      var objRecipeList = _db.RecipeDetails.ToList();
      return View();
    }
  }
}
