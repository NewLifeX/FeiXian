using System;
using System.Collections.Generic;
using FeiXian.Entity;
using NewLife.Cube;
using NewLife.Web;

namespace FeiXian.Web.Controllers
{
    public class RecordController : EntityController<Record>
    {

        /// <summary>列表页视图。子控制器可重载，以传递更多信息给视图，比如修改要显示的列</summary>
        /// <param name="p"></param>
        /// <returns></returns>
        protected override IEnumerable<Record> Search(Pager p)
        {
            Boolean? flag = null;
            if (!p["enable"].IsNullOrEmpty()) flag = p["enable"].ToBoolean();

            return Record.Search(p["type"], flag, p["dtStart"].ToDateTime(), p["dtEnd"].ToDateTime(), p["Q"], p);
        }
    }
}