using Blog.Core.IServices.Base;
using Blog.Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.IServices
{

    /// <summary>
    /// 类似IBLL 层    , 控制器访问该层
    /// </summary>
    public interface IAdvertisementServices:IBaseServices<Advertisement>
    {
        /// <summary>
        /// 计算sum
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        Task<float> Sum(float one, float two);

        #region  这里为什么不这样写了? --> 由于我们都加了一个base类继承, 泛型仓储
        ///// <summary>
        ///// 添加
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //int Add(Advertisement model);
        ///// <summary>
        ///// 删除
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //bool Delete(Advertisement model);
        ///// <summary>
        ///// 修改
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //bool Update(Advertisement model);
        //List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression);

        #endregion
    }
}
