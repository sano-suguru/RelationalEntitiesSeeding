using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelationalEntitiesSeeding.Data;
using RelationalEntitiesSeeding.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace RelationalEntitiesSeeding.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class AuthorsController : ControllerBase {
    private readonly MyDbContext context;

    public AuthorsController(MyDbContext context) {
      this.context = context;
    }

    [HttpGet]
    public async Task<ActionResult> Get() =>
      Ok(await context.Authors
        .Include(a => a.Books)
        .ToListAsync()
      );
  }
}
