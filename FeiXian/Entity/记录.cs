using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace FeiXian.Entity
{
    /// <summary>记录</summary>
    [Serializable]
    [DataObject]
    [Description("记录")]
    [BindTable("Record", Description = "记录", ConnName = "FeiXian", DbType = DatabaseType.SqlServer)]
    public partial class Record : IRecord
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "名称", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _Type;
        /// <summary>类型</summary>
        [DisplayName("类型")]
        [Description("类型")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Type", "类型", "nvarchar(50)")]
        public String Type { get { return _Type; } set { if (OnPropertyChanging(__.Type, value)) { _Type = value; OnPropertyChanged(__.Type); } } }

        private String _Processor;
        /// <summary>处理器</summary>
        [DisplayName("处理器")]
        [Description("处理器")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Processor", "处理器", "nvarchar(50)")]
        public String Processor { get { return _Processor; } set { if (OnPropertyChanging(__.Processor, value)) { _Processor = value; OnPropertyChanged(__.Processor); } } }

        private Int32 _Frequency;
        /// <summary>频率。单位M</summary>
        [DisplayName("频率")]
        [Description("频率。单位M")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Frequency", "频率。单位M", "int")]
        public Int32 Frequency { get { return _Frequency; } set { if (OnPropertyChanging(__.Frequency, value)) { _Frequency = value; OnPropertyChanged(__.Frequency); } } }

        private Int32 _Memory;
        /// <summary>内存。单位M字节</summary>
        [DisplayName("内存")]
        [Description("内存。单位M字节")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Memory", "内存。单位M字节", "int")]
        public Int32 Memory { get { return _Memory; } set { if (OnPropertyChanging(__.Memory, value)) { _Memory = value; OnPropertyChanged(__.Memory); } } }

        private Int32 _Score;
        /// <summary>分数</summary>
        [DisplayName("分数")]
        [Description("分数")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Score", "分数", "int")]
        public Int32 Score { get { return _Score; } set { if (OnPropertyChanging(__.Score, value)) { _Score = value; OnPropertyChanged(__.Score); } } }

        private Int32 _CreateUserID;
        /// <summary>创建者</summary>
        [DisplayName("创建者")]
        [Description("创建者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreateUserID", "创建者", "int")]
        public Int32 CreateUserID { get { return _CreateUserID; } set { if (OnPropertyChanging(__.CreateUserID, value)) { _CreateUserID = value; OnPropertyChanged(__.CreateUserID); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "datetime")]
        public DateTime CreateTime { get { return _CreateTime; } set { if (OnPropertyChanging(__.CreateTime, value)) { _CreateTime = value; OnPropertyChanged(__.CreateTime); } } }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "nvarchar(50)")]
        public String CreateIP { get { return _CreateIP; } set { if (OnPropertyChanging(__.CreateIP, value)) { _CreateIP = value; OnPropertyChanged(__.CreateIP); } } }

        private Int32 _UpdateUserID;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateUserID", "更新者", "int")]
        public Int32 UpdateUserID { get { return _UpdateUserID; } set { if (OnPropertyChanging(__.UpdateUserID, value)) { _UpdateUserID = value; OnPropertyChanged(__.UpdateUserID); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "datetime")]
        public DateTime UpdateTime { get { return _UpdateTime; } set { if (OnPropertyChanging(__.UpdateTime, value)) { _UpdateTime = value; OnPropertyChanged(__.UpdateTime); } } }

        private String _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "nvarchar(50)")]
        public String UpdateIP { get { return _UpdateIP; } set { if (OnPropertyChanging(__.UpdateIP, value)) { _UpdateIP = value; OnPropertyChanged(__.UpdateIP); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.Name : return _Name;
                    case __.Type : return _Type;
                    case __.Processor : return _Processor;
                    case __.Frequency : return _Frequency;
                    case __.Memory : return _Memory;
                    case __.Score : return _Score;
                    case __.CreateUserID : return _CreateUserID;
                    case __.CreateTime : return _CreateTime;
                    case __.CreateIP : return _CreateIP;
                    case __.UpdateUserID : return _UpdateUserID;
                    case __.UpdateTime : return _UpdateTime;
                    case __.UpdateIP : return _UpdateIP;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Type : _Type = Convert.ToString(value); break;
                    case __.Processor : _Processor = Convert.ToString(value); break;
                    case __.Frequency : _Frequency = Convert.ToInt32(value); break;
                    case __.Memory : _Memory = Convert.ToInt32(value); break;
                    case __.Score : _Score = Convert.ToInt32(value); break;
                    case __.CreateUserID : _CreateUserID = Convert.ToInt32(value); break;
                    case __.CreateTime : _CreateTime = Convert.ToDateTime(value); break;
                    case __.CreateIP : _CreateIP = Convert.ToString(value); break;
                    case __.UpdateUserID : _UpdateUserID = Convert.ToInt32(value); break;
                    case __.UpdateTime : _UpdateTime = Convert.ToDateTime(value); break;
                    case __.UpdateIP : _UpdateIP = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得记录字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>类型</summary>
            public static readonly Field Type = FindByName(__.Type);

            /// <summary>处理器</summary>
            public static readonly Field Processor = FindByName(__.Processor);

            /// <summary>频率。单位M</summary>
            public static readonly Field Frequency = FindByName(__.Frequency);

            /// <summary>内存。单位M字节</summary>
            public static readonly Field Memory = FindByName(__.Memory);

            /// <summary>分数</summary>
            public static readonly Field Score = FindByName(__.Score);

            /// <summary>创建者</summary>
            public static readonly Field CreateUserID = FindByName(__.CreateUserID);

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName(__.CreateIP);

            /// <summary>更新者</summary>
            public static readonly Field UpdateUserID = FindByName(__.UpdateUserID);

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            /// <summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName(__.UpdateIP);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得记录字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>名称</summary>
            public const String Name = "Name";

            /// <summary>类型</summary>
            public const String Type = "Type";

            /// <summary>处理器</summary>
            public const String Processor = "Processor";

            /// <summary>频率。单位M</summary>
            public const String Frequency = "Frequency";

            /// <summary>内存。单位M字节</summary>
            public const String Memory = "Memory";

            /// <summary>分数</summary>
            public const String Score = "Score";

            /// <summary>创建者</summary>
            public const String CreateUserID = "CreateUserID";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            /// <summary>更新者</summary>
            public const String UpdateUserID = "UpdateUserID";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>更新地址</summary>
            public const String UpdateIP = "UpdateIP";
        }
        #endregion
    }

    /// <summary>记录接口</summary>
    public partial interface IRecord
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>名称</summary>
        String Name { get; set; }

        /// <summary>类型</summary>
        String Type { get; set; }

        /// <summary>处理器</summary>
        String Processor { get; set; }

        /// <summary>频率。单位M</summary>
        Int32 Frequency { get; set; }

        /// <summary>内存。单位M字节</summary>
        Int32 Memory { get; set; }

        /// <summary>分数</summary>
        Int32 Score { get; set; }

        /// <summary>创建者</summary>
        Int32 CreateUserID { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }

        /// <summary>创建地址</summary>
        String CreateIP { get; set; }

        /// <summary>更新者</summary>
        Int32 UpdateUserID { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }

        /// <summary>更新地址</summary>
        String UpdateIP { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}