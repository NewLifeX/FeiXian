using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeiXian.Entity;

namespace FeiXian.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ns = Record.FindAllTypeName().Keys.ToArray();
            var dic = new Dictionary<String, IList<Record>>();
            foreach (var item in ns)
            {
                var list = Record.GetTop(item, 10);
                if (list.Count > 0) dic.Add(item, list);
            }

            return View(dic);
        }
    }
}