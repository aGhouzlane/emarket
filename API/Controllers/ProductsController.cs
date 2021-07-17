using System.Linq;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {

    private readonly StoreContext _context;
    public ProductsController(StoreContext context)
    {
      _context = context;
    }

    [HttpGet]
    public ActionResult GetProducts()
    {
      var products = _context.Products.ToList();
      return Ok(products);
    }

    [HttpGet("{id}")]
    public string GetProduct(int id)
    {
      return "single product";
    }
  }
}