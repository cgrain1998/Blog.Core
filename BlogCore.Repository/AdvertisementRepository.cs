using Blog.Core.IRepository;
using Blog.Core.Model.Models;
using Blog.Core.Repository.Base;
using Blog.Core.Repository.sugar;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Blog.Core.Repository
{


    /// <summary>
    /// 这里简单说下仓储层：
    /// repository就是一个管理数据持久层的
    /// 它负责数据的CRUD(Create, Read, Update, Delete)
    /// IRepository是领域层，
    /// 它常常需要访问repository层。
    /// 有网友这么说：Repository（仓储）：
    /// 协调领域和数据映射层，利用类似与集合的接口来访问领域对象。
    /// Repository 是一个独立的层，介于领域层与数据映射层（数据访问层）之间。
    /// 它的存在让领域层感觉不到数据访问层的存在，
    /// 它提供一个类似集合的接口提供给领域层进行领域对象的访问
    /// Repository 是仓库管理员，领域层需要什么东西只需告诉仓库管理员
    /// 由仓库管理员把东西拿给它，并不需要知道东西实际放在哪。 
    /// 需要被领域层实现
    /// </summary>
    public class AdvertisementRepository : BaseRepository<Advertisement>, IAdvertisementRepository
    {
        ///C# 只能继承一个类,但是可以继承多个接口  封装,继承,多态
        #region  测试方法 计算 两位数相加
        /// <summary>
        /// 计算 测试方法
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public async Task<float> Sum(float one, float two)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1);
            });
            return one + two;
        }
        #endregion


        private DbContext context;
        private SqlSugarClient db;
        private SimpleClient<Advertisement> entityDB;

        internal SqlSugarClient Db
        {
            get { return db; }
            private set { db = value; }
        }
        public DbContext Context
        {
            get { return context; }
            set { context = value; }
        }
        public AdvertisementRepository()
        {
            DbContext.Init(BaseDBConfig.ConnectionString);
            context = DbContext.GetDbContext();
            db = context.Db;
            entityDB = context.GetEntityDB<Advertisement>(db);
        }
        #region  原理一样
        ///// <summary>
        ///// 添加
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public int Add(Advertisement model)
        //{
        //    //返回的i是long类型,这里你可以根据你的业务需要进行处理
        //    var i = db.Insertable(model).ExecuteReturnBigIdentity();
        //    return i.ObjToInt();
        //}

        ///// <summary>
        ///// 删除
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public bool Delete(Advertisement model)
        //{
        //    var i = db.Deleteable(model).ExecuteCommand();
        //    return i > 0;
        //}

        ///// <summary>
        ///// 查询
        ///// </summary>
        ///// <param name="whereExpression"></param>
        ///// <returns></returns>
        //public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        //{
        //    return entityDB.GetList(whereExpression);
        //}

        ///// <summary>
        ///// 更新
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public bool Update(Advertisement model)
        //{
        //    //这种方式会以主键为条件
        //    var i = db.Updateable(model).ExecuteCommand();
        //    return i > 0;
        //}
        #endregion
    }
}
