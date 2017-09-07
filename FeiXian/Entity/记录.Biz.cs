using System;
using System.Collections.Generic;
using System.Linq;
using NewLife.Data;
using XCode;
using XCode.Cache;
using XCode.Membership;

namespace FeiXian.Entity
{
    /// <summary>记录</summary>
    public partial class Record : Entity<Record>
    {
        #region 对象操作
        static Record()
        {
            // 累加字段
            //Meta.Factory.AdditionalFields.Add(__.Logins);

            // 过滤器 UserModule、TimeModule、IPModule
            Meta.Modules.Add<UserModule>();
            Meta.Modules.Add<TimeModule>();
            Meta.Modules.Add<IPModule>();
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 在新插入数据或者修改了指定字段时进行修正
            // 处理当前已登录用户信息，可以由UserModule过滤器代劳
            /*var user = ManageProvider.User;
            if (user != null)
            {
                if (isNew && !Dirtys[nameof(CreateUserID)) nameof(CreateUserID) = user.ID;
                if (!Dirtys[nameof(UpdateUserID)]) nameof(UpdateUserID) = user.ID;
            }*/
            //if (isNew && !Dirtys[nameof(CreateTime)]) nameof(CreateTime) = DateTime.Now;
            //if (!Dirtys[nameof(UpdateTime)]) nameof(UpdateTime) = DateTime.Now;
            //if (isNew && !Dirtys[nameof(CreateIP)]) nameof(CreateIP) = WebHelper.UserHost;
            //if (!Dirtys[nameof(UpdateIP)]) nameof(UpdateIP) = WebHelper.UserHost;
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化Record[记录]数据……");

        //    var entity = new Record();
        //    entity.ID = 0;
        //    entity.Name = "abc";
        //    entity.CPU = "abc";
        //    entity.Frequency = 0;
        //    entity.Memory = 0;
        //    entity.CreateUserID = 0;
        //    entity.CreateTime = DateTime.Now;
        //    entity.CreateIP = "abc";
        //    entity.UpdateUserID = 0;
        //    entity.UpdateTime = DateTime.Now;
        //    entity.UpdateIP = "abc";
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化Record[记录]数据！"
        //}

        ///// <summary>已重载。基类先调用Valid(true)验证数据，然后在事务保护内调用OnInsert</summary>
        ///// <returns></returns>
        //public override Int32 Insert()
        //{
        //    return base.Insert();
        //}

        ///// <summary>已重载。在事务保护范围内处理业务，位于Valid之后</summary>
        ///// <returns></returns>
        //protected override Int32 OnDelete()
        //{
        //    return base.OnDelete();
        //}
        #endregion

        #region 扩展属性
        #endregion

        #region 扩展查询
        /// <summary>根据编号查找</summary>
        /// <param name="id">编号</param>
        /// <returns>实体对象</returns>
        public static Record FindByID(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Count < 1000) return Meta.Cache.Entities.FirstOrDefault(e => e.ID == id);

            // 单对象缓存
            //return Meta.SingleCache[id];

            return Find(_.ID == id);
        }
        #endregion

        #region 高级查询
        public static IList<Record> Search(String type, Boolean? enable, DateTime start, DateTime end, String key, PageParameter p)
        {
            var exp = SearchWhereByKeys(key);
            if (!type.IsNullOrEmpty()) exp &= _.Type == type;
            exp &= _.CreateTime.Between(start, end);

            return FindAll(exp, p);
        }

        /// <summary>类别名实体缓存，异步，缓存10分钟</summary>
        static FieldCache<Record> TypeCache = new FieldCache<Record>(_.Type);

        /// <summary>获取所有类别名称</summary>
        /// <returns></returns>
        public static IDictionary<String, String> FindAllTypeName()
        {
            return TypeCache.FindAllName();
        }
        #endregion

        #region 业务操作
        #endregion
    }
}