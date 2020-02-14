using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Repository;
using Blog.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    /// <summary>
    /// Service层只负责将Repository仓储层的数据进行调用，
    /// 至于如何是与数据库交互的，
    /// 它不去管，这样就可以达到一定程度上的解耦，假如以后数据库要换，
    /// 比如MySql，那Service层就完全不需要修改即可，至于真正意义的解耦，还是得靠依赖注入，这下一节我们会讲到。
    /// 继承IBLL
    /// </summary>
   public class AdvertisementServices : BaseServices<Advertisement>, IAdvertisementServices
    {
        /// <summary>
        /// 实例化
        /// </summary>
        IAdvertisementRepository Dal = new AdvertisementRepository();


        public async Task<float> Sum(float one, float two)
        {
            return await Dal.Sum(one, two);
        }
        #region  这里为什么不这样写了? --> 由于我们都加了一个base类继承, 泛型仓储 所以我们只写一个基类就可以了
        //public int Add(Advertisement model)
        //{
        //    return Dal.Add(model);
        //}

        //public bool Delete(Advertisement model)
        //{
        //    return Dal.Delete(model);
        //}

        //public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        //{
        //    return Dal.Query(whereExpression);
        //}


        //public bool Update(Advertisement model)
        //{
        //    return Dal.Update(model);
        //}
        #endregion
    }
}
