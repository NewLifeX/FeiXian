using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            if (Name.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Name));
            if (Type.IsNullOrEmpty()) throw new ArgumentNullException(nameof(Type));
        }
        #endregion

        #region 扩展属性
        [DisplayName("物理地址")]
        public String CreateAddress => CreateIP.IPToAddress();
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

        public static IList<Record> GetTop(String type, Int32 count)
        {
            return FindAll(_.Type == type & _.Enable == true, _.Score.Desc(), null, 0, count);
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
        public static Record Add(String name, String type, Int32 score)
        {
            if (name.IsNullOrEmpty()) throw new ArgumentNullException(nameof(name));
            if (type.IsNullOrEmpty()) throw new ArgumentNullException(nameof(type));

            var r = new Record();
            r.Name = name;
            r.Type = type;
            r.Score = score;

            r.Enable = true;
            //r.Insert();

            return r;
        }
        #endregion
    }
}