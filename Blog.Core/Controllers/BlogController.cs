using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Blog.Core.Controllers
{
    /// <summary>
    ///  博客控制器 
    /// </summary>    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogController : Controller
    {
        /// <summary>
        /// 需要授权
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>  
        // [Authorize(Policy = "Admin")] 
        [Authorize]
        [HttpGet]
        public IActionResult Index(string Name)
        {
            var obj = new { code = 200, message = "成功" };
            return Json(obj);
        }



      

      
 

    }
}