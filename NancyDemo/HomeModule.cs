using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyDemo
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.html"];
        }
    }
}