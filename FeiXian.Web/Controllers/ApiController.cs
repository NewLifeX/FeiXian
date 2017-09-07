using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeiXian.Entity;
using NewLife.Web;

namespace FeiXian.Web.Controllers
{
    public class ApiController : Controller
    {
        //public ActionResult Add(String name, String type, Int32 score, String os = null, String processor = null, Int32 frequency = 0, Int32 memory = 0, String config = null)
        //{
        //    if (name.IsNullOrEmpty()) throw new ArgumentNullException(nameof(name));
        //    if (type.IsNullOrEmpty()) throw new ArgumentNullException(nameof(type));

        //    if (!type.EndsWithIgnoreCase("_Insert")) throw new InvalidOperationException("非法操作");

        //    //var ip = WebHelper.UserHost;
        //    var r = Record.Add(name, type, score);
        //    r.OS = os;
        //    r.Processor = processor;
        //    r.Frequency
        //    r.Memory = memory;
        //    r.Config = config;

        //    r.Insert();

        //    return Content("OK");
        //}

        public ActionResult Add(Record model)
        {
            if (!Request.UserAgent.Contains("FeiXian.Client")) throw new InvalidOperationException("非法请求");
            if (!model.Type.EndsWithIgnoreCase("_Insert")) throw new InvalidOperationException("非法操作");

            model.Enable = true;
            model.Insert();

            return Content("OK");
        }
    }
}