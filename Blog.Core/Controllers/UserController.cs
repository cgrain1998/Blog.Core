using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Controllers
{
    /// <summary>
    /// 用户控制器
    /// </summary>
    [Route("api/[controller]")] 
    public class UserController : Controller
    {
        /// <summary>
        /// 默认请求方法
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index(string Name)
        {
            var obj = new { code = 200, message = "成功" };
            return Json(obj);
        }


    }
}