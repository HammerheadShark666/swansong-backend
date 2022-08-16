using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwanSong.Domain;
using SwanSong.Service.Interfaces;

namespace SwanSong.Api.Controllers
{
    [Controller]
    public class BaseController<D> : Controller
    {
        public Account LoggedInAccount => (Account)HttpContext.Items["Account"];

        protected readonly IHttpContextAccessor _httpContextAccessor; 

        public BaseController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
  
        [NonAction]
        public ActionResult<D> ActionResponse(D dto) 
        {
            return dto == null ? NotFound() : Ok(dto);            
        }  
    }
}
