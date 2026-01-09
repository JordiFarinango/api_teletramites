using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using NuevaAPIteletramite.Data;
using NuevaAPIteletramite.Dtos;
using NuevaAPIteletramite.Models;

namespace NuevaAPIteletramite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

    }
}
