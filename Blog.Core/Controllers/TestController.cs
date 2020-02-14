using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace Blog.Core.Controllers
{
    /// <summary>
    /// 这是测试接口专用的 
    /// </summary>
    [Route("api/[controller]/[action]/")]
    [ApiController]
    public class TestController : Controller
    {
        /// <summary>
        /// 测试方法,不需要认证
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        [HttpGet]
        public  async Task<float> Test(float one, float two)
        {
              //定义仓储，首先需要定义IRepository接口（1）
              //然后再Repository中实现（2）
              //接着在IService层中引用这些接口，同时也可以自定义扩展业务逻辑接口（3）
              //最后在Service层中去实现（4），这就是四层。

            IAdvertisementServices advertisementServices = new AdvertisementServices();
            
            return  await advertisementServices.Sum(one, two);
        }
         /// <summary>
         /// 
         /// </summary>
         /// <param name="id"></param>
         /// <returns></returns>
        [HttpGet]
        public  async Task<List<Advertisement>> GetAdvertisement(string id)
        {
            IAdvertisementServices advertisementServices = new AdvertisementServices();

            return await advertisementServices.Query(d => d.Title.Contains(id));
        }

    }
}