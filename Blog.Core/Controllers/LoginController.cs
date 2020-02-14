using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller 
    {

        /// <summary>
        /// 获取令牌
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="name">账号</param>
        /// <returns></returns>
        //[HttpPost]
        //public string GetJwt(int ID, string name)
        //{
        
        //}
    }

}