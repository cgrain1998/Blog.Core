using Blog.Core.IRepository.Base;
using Blog.Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.IRepository
{

    /// <summary>
    /// 　我们定义了IRepository层，提供了所有的操作接口,这里相当于领域层
    /// 　提供所有操作方法
    /// </summary>
    public interface IAdvertisementRepository: IBaseRepository<Advertisement>
    {
        /// <summary>
        ///  测试方法 实现两数相加
        /// </summary>
        /// <param name="one">参数一</param>
        /// <param name="two">参数二</param>
        /// <returns></returns>
         Task<float> Sum(float one, float two);
       
        #region  同理
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
