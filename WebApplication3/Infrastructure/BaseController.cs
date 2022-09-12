using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Infrastructure
{
    public class BaseController : Controller
    {
        protected string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}